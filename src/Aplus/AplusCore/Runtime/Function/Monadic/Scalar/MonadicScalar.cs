﻿using System;
using System.Collections.Generic;
using System.Reflection;

using AplusCore.Types;

namespace AplusCore.Runtime.Function.Monadic.Scalar
{
    abstract class MonadicScalar : AbstractMonadicFunction
    {
        #region Variables

        private ATypes defaultResultType;
        private HashSet<ATypes> allowedTypes;

        #endregion

        #region Constructor

        public MonadicScalar()
        {
            this.allowedTypes = new HashSet<ATypes>();
            Type currentType = this.GetType();

            DefaultResultAttribute attribute = currentType.GetSingleAttribute<DefaultResultAttribute>();
            this.defaultResultType = (attribute != null) ? attribute.DefaultType : ATypes.AType;

            MethodInfo[] methods = currentType.GetMethods(
                BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public
            );

            foreach (MethodInfo method in methods)
            {
                if (!method.IsVirtual)
                {
                    continue;
                }

                ParameterInfo[] parameterInfo = method.GetParameters();

                this.allowedTypes.Add(Utils.GetATypesFromType(parameterInfo[0].ParameterType));
            }
        }

        #endregion

        #region Entry Point from DLR

        public override AType Execute(AType argument, Aplus environment = null)
        {
            ATypes currentType = argument.Type;

            if (argument.Length == 0)
            {
                if (currentType == ATypes.AFunc)
                {
                    if (!this.allowedTypes.Contains(currentType))
                    {
                        throw new Error.NonData(DomainErrorText);
                    }

                    return ExecutePrimitive((AFunc)argument.Data, environment);
                }

                return AArray.Create(this.defaultResultType != ATypes.AType ? this.defaultResultType : argument.Type);
            }
            // Check if we have a rule for the specific input type
            else if (!this.allowedTypes.Contains(currentType))
            {
                // Rule not found

                // reset to the general case
                currentType = ATypes.AType;

                // Check if we have default case
                if (!this.allowedTypes.Contains(currentType))
                {
                    // throw a type error
                    throw new Error.Type(this.TypeErrorText);
                }
            }

            return ExecuteRecursion(argument, currentType, environment);
        }

        #endregion

        #region Recursion

        private AType ExecuteRecursion(AType argument, ATypes currentType, Aplus environment)
        {
            AType result;
            if (argument.IsArray)
            {
                uint floatTypeCounter = 0;
                AType currentItem;

                result = AArray.Create(ATypes.AArray);

                for (int i = 0; i < argument.Length; i++)
                {
                    currentItem = ExecuteRecursion(argument[i], currentType, environment);
                    floatTypeCounter += (uint)((currentItem.Type == ATypes.AFloat) ? 1 : 0);

                    result.AddWithNoUpdate(currentItem);
                }

                result.UpdateInfo();

                if ((floatTypeCounter != result.Length) && (floatTypeCounter != 0))
                {
                    result.ConvertToFloat();
                }
            }
            else
            {
                switch (currentType)
                {
                    case ATypes.AInteger:
                        result = ExecutePrimitive((AInteger)argument.Data, environment);
                        break;
                    case ATypes.AFloat:
                        result = ExecutePrimitive((AFloat)argument.Data, environment);
                        break;
                    case ATypes.AChar:
                        result = ExecutePrimitive((AChar)argument.Data, environment);
                        break;
                    case ATypes.ASymbol:
                        result = ExecutePrimitive((ASymbol)argument.Data, environment);
                        break;
                    case ATypes.ABox:
                        result = ExecutePrimitive((ABox)argument.Data, environment);
                        break;
                    case ATypes.AType:
                        result = ExecuteDefault((AType)argument.Data, environment);
                        break;
                    default:
                        throw new Error.Invalid("Something really went wrong...");
                }
            }

            return result;
        }

        #endregion

        #region Type specific executes

        public virtual AType ExecuteDefault(AType argument, Aplus environment = null)
        {
            throw new NotImplementedException("Invalid use-case");
        }

        public virtual AType ExecutePrimitive(AInteger argument, Aplus environment = null)
        {
            throw new NotImplementedException("Invalid use-case");
        }

        public virtual AType ExecutePrimitive(AFloat argument, Aplus environment = null)
        {
            throw new NotImplementedException("Invalid use-case");
        }

        public virtual AType ExecutePrimitive(AChar argument, Aplus environment = null)
        {
            throw new NotImplementedException("Invalid use-case");
        }

        public virtual AType ExecutePrimitive(ASymbol argument, Aplus environment = null)
        {
            throw new NotImplementedException("Invalid use-case");
        }

        public virtual AType ExecutePrimitive(ABox argument, Aplus environment = null)
        {
            throw new NotImplementedException("Invalid use-case");
        }

        public virtual AType ExecutePrimitive(AFunc argument, Aplus environment = null)
        {
            throw new NotImplementedException("Invalid use-case");
        }

        #endregion
    }
}
