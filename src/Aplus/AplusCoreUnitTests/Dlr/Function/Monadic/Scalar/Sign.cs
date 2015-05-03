using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AplusCore.Types;

namespace AplusCoreUnitTests.Dlr.Function.Monadic.Scalar
{
    [TestClass]
    public class Sign : AbstractTest
    {
        [TestCategory("DLR"), TestCategory("Monadic"), TestCategory("Sign"), TestMethod]
        public void SignVector()
        {
            AType expected = AArray.Create(
                ATypes.AInteger,
                AInteger.Create(1),
                AInteger.Create(-1),
                AInteger.Create(0),
                AInteger.Create(1),
                AInteger.Create(-1)
            );

            AType result = this.engine.Execute<AType>("* 100 -2.5 0 5 -Inf");

            Assert.AreEqual(expected, result);
        }

        [TestCategory("DLR"), TestCategory("Monadic"), TestCategory("Sign"), TestMethod]
        public void SignVectorUni()
        {
            AType expected = AArray.Create(
                ATypes.AInteger,
                AInteger.Create(1),
                AInteger.Create(-1),
                AInteger.Create(0),
                AInteger.Create(1),
                AInteger.Create(-1)
            );

            AType result = this.engineUni.Execute<AType>("* 100 -2.5 0 5 -Inf");

            Assert.AreEqual(expected, result);
        }

        [TestCategory("DLR"), TestCategory("Monadic"), TestCategory("Sign"), TestMethod]
        public void SignVectorApl()
        {
            AType expected = AArray.Create(
                ATypes.AInteger,
                AInteger.Create(1),
                AInteger.Create(-1),
                AInteger.Create(0),
                AInteger.Create(1),
                AInteger.Create(-1)
            );

            AType result = this.engineApl.Execute<AType>("\u00AB 100 \u00A22.5 0 5 \u00A2Inf");

            Assert.AreEqual(expected, result);
        }

        [TestCategory("DLR"), TestCategory("Monadic"), TestCategory("Sign"), TestMethod]
        public void SignNull()
        {
            AType result = this.engine.Execute<AType>("* ()");

            Assert.AreEqual<ATypes>(ATypes.AInteger, result.Type, "Incorrect type");
        }

        [TestCategory("DLR"), TestCategory("Monadic"), TestCategory("Sign"), TestMethod]
        public void IntegerArgument()
        {
            AType expected = AArray.Create(
                ATypes.AInteger,
                AInteger.Create(1),
                AInteger.Create(-1),
                AInteger.Create(0),
                AInteger.Create(1),
                AInteger.Create(-1)
            );

            AType result = this.engine.Execute<AType>("* 100 -2 0 5 -1");

            Assert.AreEqual(expected, result);
        }

    }
}
