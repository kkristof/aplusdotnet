﻿using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AplusCore.Types;

namespace AplusCoreUnitTests.Dlr.Function.Monadic.Scalar
{
    [TestClass]
    public class Not : AbstractTest
    {
        [TestCategory("DLR"), TestCategory("Monadic"), TestCategory("Not"), TestMethod]
        public void NotRestrictedWholeNumber()
        {
            AType expected = AInteger.Create(1);

            AType result = this.engine.Execute<AType>("~ 0.0000000000000000000000000000000000000001");

            Assert.AreEqual(expected, result);
        }

        [TestCategory("DLR"), TestCategory("Monadic"), TestCategory("Not"), TestMethod]
        public void NotVector()
        {
            AType expected = AArray.Create(
                ATypes.AInteger,
                AInteger.Create(0),
                AInteger.Create(1),
                AInteger.Create(0),
                AInteger.Create(0),
                AInteger.Create(0)
            );

            AType result = this.engine.Execute<AType>("~ -1 0 1 2 3");

            Assert.AreEqual(expected, result);
        }

        [TestCategory("DLR"), TestCategory("Monadic"), TestCategory("Not"), TestMethod]
        public void NotRestrictedWholeVector()
        {
            AType expected = AArray.Create(
                ATypes.AInteger,
                AInteger.Create(0),
                AInteger.Create(0),
                AInteger.Create(1)
            );

            AType result = this.engine.Execute<AType>("~ -3.0000000000000000000001 2.0000000000000003 0");

            Assert.AreEqual(expected, result);
        }
    }
}
