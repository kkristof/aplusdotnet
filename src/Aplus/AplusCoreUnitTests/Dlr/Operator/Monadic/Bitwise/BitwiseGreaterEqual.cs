﻿using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AplusCore.Types;
using AplusCore.Runtime;

namespace AplusCoreUnitTests.Dlr.Operator.Monadic.Bitwise
{
    [TestClass]
    public class BitwiseGreaterEqual : AbstractTest
    {
        [TestCategory("DLR"), TestCategory("Monadic"), TestCategory("Bitwise Greater Equal"), TestMethod]
        public void BitwiseGreaterEqualVector()
        {
            AType expected = AArray.Create(ATypes.AInteger,
                AInteger.Create(-2), AInteger.Create(-1), AInteger.Create(-2)
            );

            AType result = this.engine.Execute<AType>("10 100 100 bwge 3 4 5");

            Assert.AreEqual(expected, result);
            Assert.AreEqual(InfoResult.OK, result.CompareInfos(expected));

            AType resultUni = this.engineUni.Execute<AType>("10 100 100 B.>= 3 4 5");

            Assert.AreEqual(expected, resultUni);
            Assert.AreEqual(InfoResult.OK, resultUni.CompareInfos(expected));
        }

        [TestCategory("DLR"), TestCategory("Monadic"), TestCategory("Bitwise Greater Equal"), TestMethod]
        [ExpectedException(typeof(Error.Type))]
        public void Error()
        {
            this.engine.Execute<AType>("10 100 1000 bwge 3 4 5.0");
        }
    }
}
