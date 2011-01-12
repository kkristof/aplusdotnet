﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AplusCore.Types;

namespace AplusCore.Runtime.Function.Monadic.NonScalar.Informational
{
    class Shape : AbstractMonadicFunction
    {
        /// <summary>
        /// Returns the shape of the argument
        /// </summary>
        /// <remarks>
        /// The shape of a scalar is Null (scalar does not have axes).
        /// For a nonscalar the i-th element of the result is the i-th dimension of the argument.
        /// </remarks>
        public override AType Execute(AType argument, AplusEnvironment environment = null)
        {
            return AArray.FromIntegerList(argument.Shape);
        }

    }
}
