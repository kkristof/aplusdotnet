﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AplusCore.Types;

namespace AplusCore.Runtime.Function.Dyadic.Product
{
    class OPResidue : OuterProduct
    {
        protected override AType Calculate(AType left, AType right, AplusEnvironment env)
        {
            return DyadicFunctionInstance.Residue.Execute(right, left, env);
        }
    }
}
