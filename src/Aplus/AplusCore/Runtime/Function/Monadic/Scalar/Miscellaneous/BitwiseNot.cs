﻿using AplusCore.Types;

namespace AplusCore.Runtime.Function.Monadic.Scalar.Miscellaneous
{
    /// <summary>
    /// ~(a)
    /// </summary>
    class BitwiseNot : MonadicScalar
    {
        public override AType ExecutePrimitive(AInteger argument, Aplus environment = null)
        {
            return AInteger.Create(~argument.asInteger);
        }

        public override AType ExecutePrimitive(AFloat argument, Aplus environment = null)
        {
            int number;
            if (!argument.ConvertToRestrictedWholeNumber(out number))
            {
                throw new Error.Type("Bitwise not");
            }

            return AInteger.Create(~number);
        }
    }
}
