using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AplusCore.Types;
using AplusCore.Runtime;

namespace AplusCoreUnitTests.Dlr.Operator.Monadic.Bitwise
{
    [TestClass]
    public class BitwiseOr : AbstractTest
    {
        [TestCategory("DLR"), TestCategory("Monadic"), TestCategory("Bitwise Or"), TestMethod]
        public void BitwiseOrVector()
        {
            AType expected = AArray.Create(ATypes.AInteger,
                AInteger.Create(11), AInteger.Create(100), AInteger.Create(101)
            );

            AType result = this.engine.Execute<AType>("10 100 100 bwor 3 4 5");

            Assert.AreEqual(expected, result);
            Assert.AreEqual(InfoResult.OK, result.CompareInfos(expected));

            AType resultUni = this.engineUni.Execute<AType>("10 100 100 B.| 3 4 5");

            Assert.AreEqual(expected, resultUni);
            Assert.AreEqual(InfoResult.OK, resultUni.CompareInfos(expected));

            AType resultApl = this.engineApl.Execute<AType>("10 100 100 \u00A9\u00AE 3 4 5");

            Assert.AreEqual(expected, resultApl);
            Assert.AreEqual(InfoResult.OK, resultApl.CompareInfos(expected));
        }

        [TestCategory("DLR"), TestCategory("Monadic"), TestCategory("Bitwise Or"), TestMethod]
        [ExpectedException(typeof(Error.Type))]
        public void Error()
        {
            this.engine.Execute<AType>("10 100 1000 bwor 3 4 5.0");
        }
    }
}
