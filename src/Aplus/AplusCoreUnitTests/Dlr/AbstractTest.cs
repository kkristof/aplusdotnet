using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Scripting.Hosting;
using System.Threading;
using System.Globalization;

namespace AplusCoreUnitTests.Dlr
{

    [TestClass]
    public abstract class AbstractTest
    {
        protected ScriptEngine engine;
        protected ScriptEngine engineUni;
        protected ScriptEngine engineApl;

        [TestInitialize]
        public void Setup()
        {
            ScriptRuntimeSetup setup = new ScriptRuntimeSetup();
            setup.LanguageSetups.Add(AplusCore.Runtime.AplusLanguageContext.LanguageSetup);

            ScriptRuntime dlrRuntime = new ScriptRuntime(setup);
            this.engine = dlrRuntime.GetEngine("A+");

            ScriptRuntimeSetup setupUni = new ScriptRuntimeSetup();
            setupUni.LanguageSetups.Add(AplusCore.Runtime.AplusLanguageContext.LanguageSetup);
            setupUni.Options.Add("LexerMode", AplusCore.Compiler.LexerMode.UNI);

            ScriptRuntime dlrRuntimeUni = new ScriptRuntime(setupUni);
            this.engineUni = dlrRuntimeUni.GetEngine("A+");

            ScriptRuntimeSetup setupApl = new ScriptRuntimeSetup();
            setupApl.LanguageSetups.Add(AplusCore.Runtime.AplusLanguageContext.LanguageSetup);
            setupApl.Options.Add("LexerMode", AplusCore.Compiler.LexerMode.APL);

            ScriptRuntime dlrRuntimeApl = new ScriptRuntime(setupApl);
            this.engineApl = dlrRuntimeApl.GetEngine("A+");
        }
    }
}
