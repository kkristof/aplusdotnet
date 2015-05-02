using Microsoft.Scripting.Hosting;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using AplusCore.Types;

namespace AplusCoreUnitTests.Dlr.Operator.Dyadic.OuterProduct
{
    [TestClass]
    public class OPAdd : AbstractTest
    {
        [TestCategory("DLR"), TestCategory("Outer Product"), TestCategory("OP Add"), TestMethod]
        public void Add2Arrays()
        {
            AType expected = this.engine.Execute<AType>("3 4 rho 2.2 -2 99.2 6 11.2 7 108.2 15 101.2 97 198.2 105");

            ScriptScope scope = this.engine.CreateScope();
            scope.SetVariable(".y", this.engine.Execute<AType>("1 10 100"));
            scope.SetVariable(".x", this.engine.Execute<AType>("1.2 -3 98.2 5"));

            AType result = this.engine.Execute<AType>("y +. x", scope);

            Assert.AreEqual(expected, result);
            Assert.AreEqual(InfoResult.OK, result.CompareInfos(expected));

            AType resultUni = this.engineUni.Execute<AType>("y O.+ x", scope);

            Assert.AreEqual(expected, resultUni);
            Assert.AreEqual(InfoResult.OK, resultUni.CompareInfos(expected));

            AType resultApl = this.engineApl.Execute<AType>("y \u00CA.+ x", scope);

            Assert.AreEqual(expected, resultApl);
            Assert.AreEqual(InfoResult.OK, resultApl.CompareInfos(expected));
        }
    }
}
