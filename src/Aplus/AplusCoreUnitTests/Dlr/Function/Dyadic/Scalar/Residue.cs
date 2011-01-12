﻿using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AplusCore.Types;

namespace AplusCoreUnitTests.Dlr.Function.Dyadic.Scalar
{
    [TestClass]
    public class Residue : AbstractTest
    {
        [TestCategory("DLR"), TestCategory("Dyadic"), TestCategory("Residue"), TestMethod]
        public void ResidueInteger2Vector()
        {
            AType expected = AArray.Create(
                ATypes.AInteger,
                AInteger.Create(30),
                AInteger.Create(41),
                AInteger.Create(52),
                AInteger.Create(78)
            );
            AType result = this.engine.Execute<AType>("100 | 1930 1941 1952 1978");
            Assert.AreEqual(expected, result);
            Assert.IsTrue(result.Type == ATypes.AInteger);
        }

        [TestCategory("DLR"), TestCategory("Dyadic"), TestCategory("Residue"), TestMethod]
        public void ResidueVector2Vector1()
        {
            AType expected = AArray.Create( 
                ATypes.AFloat,
                AFloat.Create((3.7 + 1E-12) - 1.4 * Math.Floor((3.7 + 1E-12) / 1.4)),
                AFloat.Create(0)
            );
            // The original test from the A+ language reference: 1.4 100 | 3.7 , 100+ 1e-12  (note the catenate)
            AType result = this.engine.Execute<AType>("1.4 100 | 3.7 100 + 1e-12");
            Assert.AreEqual(expected, result);
            Assert.IsTrue(result.Type == ATypes.AFloat);
        }

        [TestCategory("DLR"), TestCategory("Dyadic"), TestCategory("Residue"), TestMethod]
        public void ResidueVector2Vector2()
        {
            AType expected = AArray.Create(
                ATypes.AFloat,
                AFloat.Create(3),
                AFloat.Create(0),
                AFloat.Create(0),
                AFloat.Create(0)
            );
            // The original test from the A+ language reference: 1.4 100 | 3.7 , 100+ 1e-12  (note the catenate)
            AType result = this.engine.Execute<AType>("0 Inf -Inf 2 | 3 4 9 2.00000000000002");
            Assert.AreEqual(expected, result);
            Assert.IsTrue(result.Type == ATypes.AFloat);
        }
    }
}
