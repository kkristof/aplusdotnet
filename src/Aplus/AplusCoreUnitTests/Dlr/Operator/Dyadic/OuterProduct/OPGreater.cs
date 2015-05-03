﻿using Microsoft.Scripting.Hosting;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using AplusCore.Types;

namespace AplusCoreUnitTests.Dlr.Operator.Dyadic.OuterProduct
{
    [TestClass]
    public class OPGreater : AbstractTest
    {
        [TestCategory("DLR"), TestCategory("Outer Product"), TestCategory("OP Greater Equal"), TestMethod]
        public void Greater2Arrays()
        {
            AType expected = this.engine.Execute<AType>("3 4 rho 0 0 0 0 1 1 1 0 1 1 1 1");

            ScriptScope scope = this.engine.CreateScope();
            scope.SetVariable(".y", this.engine.Execute<AType>("1 10 100"));
            scope.SetVariable(".x", this.engine.Execute<AType>("1 2 5 10"));

            AType result = this.engine.Execute<AType>("y >. x", scope);

            Assert.AreEqual(InfoResult.OK, result.CompareInfos(expected));
            Assert.AreEqual(expected, result);

            AType resultUni = this.engineUni.Execute<AType>("y O.> x", scope);

            Assert.AreEqual(expected, resultUni);
            Assert.AreEqual(InfoResult.OK, resultUni.CompareInfos(expected));

            AType resultApl = this.engineApl.Execute<AType>("y \u00CA.> x", scope);

            Assert.AreEqual(expected, resultApl);
            Assert.AreEqual(InfoResult.OK, resultApl.CompareInfos(expected));
        }
    }
}