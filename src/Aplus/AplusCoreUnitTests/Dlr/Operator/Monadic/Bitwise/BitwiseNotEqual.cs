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
    public class BitwiseNotEqual : AbstractTest
    {
        [TestCategory("DLR"), TestCategory("Monadic"), TestCategory("Bitwise Not Equal"), TestMethod]
        public void BitwiseNotEqualVector()
        {
            AType expected = AArray.Create(ATypes.AInteger,
                AInteger.Create(9), AInteger.Create(96), AInteger.Create(1005)
            );

            AType result = this.engine.Execute<AType>("10 100 1000 bwne 3 4 5");

            Assert.AreEqual(expected, result);
            Assert.AreEqual(InfoResult.OK, result.CompareInfos(expected));

            AType resultUni = this.engineUni.Execute<AType>("10 100 1000 B.!= 3 4 5");

            Assert.AreEqual(expected, resultUni);
            Assert.AreEqual(InfoResult.OK, resultUni.CompareInfos(expected));

            AType resultApl = this.engineApl.Execute<AType>("10 100 1000 \u00A8\u00AE 3 4 5");

            Assert.AreEqual(expected, resultApl);
            Assert.AreEqual(InfoResult.OK, resultApl.CompareInfos(expected));
        }

        [TestCategory("DLR"), TestCategory("Monadic"), TestCategory("Bitwise Not Equal"), TestMethod]
        [ExpectedException(typeof(Error.Type))]
        public void BitwiseNotEqualError()
        {
           this.engine.Execute<AType>("10 100 1000 bwne 3 4 5.0");
        }

    }
}
