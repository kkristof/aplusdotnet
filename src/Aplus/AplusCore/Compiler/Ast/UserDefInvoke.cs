﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using AplusCore.Runtime;
using DLR = System.Linq.Expressions;
using AplusCore.Types;
using DYN = System.Dynamic;
using Microsoft.Scripting;
using AplusCore.Runtime.Function.Monadic;

namespace AplusCore.Compiler.AST
{
    public class UserDefInvoke : Node
    {
        #region Variables
        private ExpressionList arguments;
        private Identifier method;
        #endregion

        #region Constructor
        public UserDefInvoke(Identifier method, ExpressionList arguments)
        {
            this.method = method;
            this.arguments = arguments;
        }
        #endregion

        #region DLR Generator

        public override DLR.Expression Generate(AplusScope scope)
        {
            Aplus runtime = scope.GetRuntime();

            // arguments for the dynamic method call
            LinkedList<DLR.Expression> callArguments = new LinkedList<DLR.Expression>();

            if (scope.IsAssignment)
            {
                // Generate the paramters differently for assignment

                // f{...;x} := value  <=> i := f{...; iota rho x}; (,x)[i] := value

                List<Node> items = new List<Node>(this.arguments.Items);
                // 2. Add the parameters in !reverse! order except the last one
                for (int i = 0; i < items.Count - 1; i++)
			    {
                    callArguments.AddFirst(items[i].Generate(scope));
			    }

                Node lastItem = items[items.Count - 1];
                bool isPick = Node.TestDyadicToken(lastItem, Grammar.Tokens.PICK);
                bool isRavel = Node.TestMonadicToken(lastItem, Grammar.Tokens.RAVEL);

                if (!(lastItem is Identifier || isPick || isRavel))
                {
                    throw new ParseException("user-def invoke assign", false);
                }

                DLR.Expression indexList = AST.Assign.BuildIndicesList(scope, lastItem.Generate(scope));

                callArguments.AddFirst(indexList);
            }
            else
            {
                // 2. Add the parameters in !reverse! order
                foreach (Node item in this.arguments.Items)
                {
                    callArguments.AddFirst(item.Generate(scope));
                }
            }

            callArguments.AddFirst(scope.GetAplusEnvironment());

            // 0.5. Convert the method's name to a qualified name
            if (this.method.Type == IdentifierType.UnQualifiedName)
            {
                this.method.Name = this.method.BuildQualifiedName(runtime.CurrentContext);
                this.method.Type = IdentifierType.QualifiedName;
            }
            // 1. Construct the method body
            callArguments.AddFirst(this.method.Generate(scope));

            DLR.Expression result;
            if (scope.IsAssignment)
            {
                // (,x)[f{...;iota rho x}]
                result = AST.Assign.BuildIndexing(
                    scope,
                    this.arguments.Items.Last.Value.Generate(scope),
                    BuildInvoke(runtime, callArguments)
                );
            }
            else
            {
                // 3. Dynamic invoke of method
                // Order of arguments:
                //  (method, Enviroment, argN, ... arg1, arg0)
                result = BuildInvoke(runtime, callArguments);
            }

            return result;
        }

        private static DLR.Expression BuildInvoke(Aplus runtime, LinkedList<DLR.Expression> callArguments)
        {
            DLR.Expression result = DLR.Expression.Convert(
                DLR.Expression.Dynamic(
                    runtime.InvokeBinder(new DYN.CallInfo(callArguments.Count - 1)),
                    typeof(object),
                    callArguments
                ),
                typeof(AType)
            );
            return result;
        }

        #endregion

        #region overrides

        public override string ToString()
        {
            return String.Format("FunctionInvoke({0} {1})", this.method.ToString(), this.arguments.ToString());
        }

        public override bool Equals(object obj)
        {
            if (obj is UserDefInvoke)
            {
                UserDefInvoke other = (UserDefInvoke)obj;
                return (this.method == other.method) && (this.arguments == other.arguments);
            }

            return false;
        }

        public override int GetHashCode()
        {
            return this.method.GetHashCode() ^ this.arguments.GetHashCode();
        }

        #endregion

        #region GraphViz output (Only in DEBUG)
#if DEBUG
        private static int counter = 0;
        internal override string ToDot(string parent, StringBuilder textBuilder)
        {
            string name = String.Format("FunctionInvoke{0}", counter++);

            textBuilder.AppendFormat("  {0} [label=\"Invoke: {1}\"]", name, this.method.Name);

            textBuilder.AppendFormat("  subgraph cluster_{0}_args {{ style=dotted; color=lightgrey; label=\"Arguments\";\n", name);
            string argumentsName = this.arguments.ToDot(name, textBuilder);
            textBuilder.AppendFormat("  }}\n");

            textBuilder.AppendFormat("  {0} -> {1};\n", name, argumentsName);

            return name;
        }
#endif
        #endregion

    }

    #region Construction helper

    public partial class Node
    {

        public static UserDefInvoke UserDefInvoke(Node methodIdentifier, Node arguments)
        {
            Debug.Assert(methodIdentifier is Identifier);
            Debug.Assert(arguments is ExpressionList);
            return new UserDefInvoke((Identifier)methodIdentifier, (ExpressionList)arguments);
        }

    }

    #endregion

}