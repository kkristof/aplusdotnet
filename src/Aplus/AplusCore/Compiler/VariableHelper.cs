﻿using System;
using DLR = System.Linq.Expressions;
using AplusCore.Runtime;
using AplusCore.Types;
using Microsoft.Scripting;

namespace AplusCore.Compiler
{
    class VariableHelper
    {
        #region DLR helpers

        /// <summary>
        /// Constructs a DLR Expression tree representing accessing a variable inside a context
        /// </summary>
        /// <param name="runtime"></param>
        /// <param name="variableContainer">The container where the lookup should be performed</param>
        /// <param name="contextParts">
        /// Contains 2 strings:
        ///  1. The name of the context
        ///  2. The name of the variable inside the context
        /// </param>
        /// <returns>Expression tree</returns>
        internal static DLR.Expression GetVariable(Aplus runtime, DLR.Expression variableContainer, string[] contextParts)
        {
            // Get the context
            DLR.Expression contextAccess = DLR.Expression.Dynamic(
                runtime.GetMemberBinder(contextParts[0]),
                typeof(object),
                variableContainer
            );

            // Get the variable from the context
            DLR.Expression variableAccess = DLR.Expression.Dynamic(
                runtime.GetMemberBinder(contextParts[1]),
                typeof(object),
                contextAccess
            );
            return variableAccess;
        }

        /// <summary>
        /// Constructs a DLR Expression tree representing setting a variable inside a context.
        /// </summary>
        /// <param name="runtime"></param>
        /// <param name="variableContainer">The container where the lookup should be performed</param>
        /// <param name="contextParts">
        /// Contains 2 strings:
        ///  1. The name of the context
        ///  2. The name of the variable inside the context
        /// </param>
        /// <param name="value">Expression containing the value of the variable</param>
        /// <remarks>
        /// The returned DLR Expression tree will try to fetch the context inside the container.
        /// If the context does not exists, this will result an exception.
        /// If the exception occured, the context will be created inside the catch block.
        /// After this the context surely exists.
        /// 
        /// 
        /// 
        /// </remarks>
        /// <returns>Expression tree</returns>
        internal static DLR.Expression SetVariable(Aplus runtime, DLR.Expression variableContainer, string[] contextParts, DLR.Expression value)
        {
            // Get the context
            DLR.Expression getContext =
                DLR.Expression.TryCatch(
                    DLR.Expression.Dynamic(
                        runtime.GetMemberBinder(contextParts[0]),
                        typeof(object),
                        variableContainer
                    ),
                    DLR.Expression.Catch(
                // Context not found, create one!
                        typeof(Error.Value),
                        DLR.Expression.Dynamic(
                            runtime.SetMemberBinder(contextParts[0]),
                            typeof(object),
                            variableContainer,
                            DLR.Expression.Constant(new ScopeStorage())
                        )
                    )
                );

            DLR.Expression setVariable = DLR.Expression.Dynamic(
                runtime.SetMemberBinder(contextParts[1]),
                typeof(object),
                getContext,
                value
            );
            return setVariable;
        }

        #endregion

        #region Variable Access method builder

        /// <summary>
        /// Build a method for accessing a variable in a context.
        /// </summary>
        /// <param name="environment"></param>
        /// <param name="contextParts"></param>
        /// <returns></returns>
        internal static DLR.Expression<Func<AType>> BuildVariableAccessMethod(AplusEnvironment environment, 
            string[] contextParts)
        {
            DLR.Expression<Func<AType>> lambda =
                DLR.Expression.Lambda<Func<AType>>(
                // Convert the variable to an AType
                    DLR.Expression.Dynamic(
                        environment.Runtime.ConvertBinder(typeof(AType)),
                        typeof(AType),
                // Access the variable
                        VariableHelper.GetVariable(
                            environment.Runtime,
                            DLR.Expression.Constant(environment.Context),
                            contextParts
                        )
                    )
            );

            return lambda;
        }


        /// <summary>
        /// Build a method for setting a variable in a context.
        /// </summary>
        /// <param name="environment"></param>
        /// <param name="contextParts"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        internal static DLR.Expression<Func<AType>> BuildVariableAssignMethod(AplusEnvironment environment, 
            string[] contextParts, AType value)
        {
            DLR.Expression<Func<AType>> lambda = DLR.Expression.Lambda<Func<AType>>(
                DLR.Expression.Convert(
                    VariableHelper.SetVariable(
                        environment.Runtime,
                        DLR.Expression.Constant(environment.Context),
                        contextParts,
                        DLR.Expression.Constant(value)
                    ),
                    typeof(AType)
                )
            );
            return lambda;
        }

        /// <summary>
        /// Construct a (context, variablename) string pair,
        /// based on the current context and variablename
        /// </summary>
        /// <param name="context">The current context in the runtime</param>
        /// <param name="varname">This can be either a Qualified or an UnQualified variablename</param>
        /// <returns>(context, variablename) string pair, where variable name is an unqualified name.</returns>
        internal static string[] CreateContextParts(string context, string varname)
        {
            // Construct the context parts: (contextname, variablename)
            string[] contextParts;


            bool isQualified = varname.IndexOf(".") != -1;
            if (isQualified)
            {
                contextParts = varname.Split(new char[] { '.' }, 2);

                // check the variablename part for an other '.'
                if (contextParts[1].IndexOf('.') != -1)
                {
                    // Found an other '.', this is not a qualified name => error
                    throw new Error.Value(varname);
                }
            }
            else
            {
                contextParts = new string[2] { 
                    ((context.Length > 0) ? context : "."),  // Treat the empty context as the '.' (root) context
                    varname };
            }

            return contextParts;
        }

        #endregion
    }
}
