﻿using System;

using AplusCore.Types;

namespace AplusCore.Runtime.Function.Monadic.Scalar.Elementary
{
    [DefaultResult(ATypes.AFloat)]
    class PiTimes : MonadicScalar
    {
        public override AType ExecutePrimitive(AInteger argument, Aplus environment = null)
        {
            return calculatePi(argument.asFloat);
        }

        public override AType ExecutePrimitive(AFloat argument, Aplus environment = null)
        {
            return calculatePi(argument.asFloat);
        }

        private AType calculatePi(double number)
        {
            return AFloat.Create(number * Math.PI);
        }
    }
}
