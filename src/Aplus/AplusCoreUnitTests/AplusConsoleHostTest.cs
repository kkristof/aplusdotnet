using AplusCore.Hosting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using AplusCore.Compiler;
using Microsoft.Scripting.Hosting.Shell;
using Microsoft.Scripting.Hosting;

namespace AplusCoreUnitTests
{
    
    
    /// <summary>
    ///This is a test class for AplusConsoleHostTest and is intended
    ///to contain all AplusConsoleHostTest Unit Tests
    ///</summary>
    [TestClass()]
    public class AplusConsoleHostTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for CreateCommandLine
        ///</summary>
        [TestMethod()]
        [DeploymentItem("AplusCore.dll")]
        public void CreateCommandLineTest()
        {
            AplusCore.Hosting.AplusConsoleHost console = new AplusCore.Hosting.AplusConsoleHost();
            string[] args = new string[1];
            Object mode;
            args[0] = "-h";
            Assert.AreEqual(console.Run(args), 0);
            args[0] = "--uni";
            Assert.AreEqual(console.Run(args), 1);
            Assert.IsTrue(console.Engine.Setup.Options.TryGetValue("LexerMode", out mode));
            Assert.AreEqual(LexerMode.UNI, (LexerMode)mode);

            args[0] = "--apl";
            Assert.AreEqual(console.Run(args), 1);
            Assert.IsTrue(console.Engine.Setup.Options.TryGetValue("LexerMode", out mode));
            Assert.AreEqual(LexerMode.APL, (LexerMode)mode);

            args[0] = "--ascii";
            Assert.AreEqual(console.Run(args), 1);
            Assert.IsTrue(console.Engine.Setup.Options.TryGetValue("LexerMode", out mode));
            Assert.AreEqual(LexerMode.ASCII, (LexerMode)mode);
        }

        [TestMethod()]
        [DeploymentItem("AplusCore.dll")]
        public void CreateCommandLineTest2()
        {
            AplusCore.Hosting.AplusConsoleHost console = new AplusCore.Hosting.AplusConsoleHost();
            string[] args = new string[2];
            Object mode;

            args[0] = "--mode";
            args[1] = "uni";
            Assert.AreEqual(console.Run(args), 1);
            Assert.IsTrue(console.Engine.Setup.Options.TryGetValue("LexerMode", out mode));
            Assert.AreEqual(LexerMode.UNI, (LexerMode) mode);

            args[0] = "--mode";
            args[1] = "apl";
            Assert.AreEqual(console.Run(args), 1);
            Assert.IsTrue(console.Engine.Setup.Options.TryGetValue("LexerMode", out mode));
            Assert.AreEqual(LexerMode.APL, (LexerMode) mode);

            args[0] = "--mode";
            args[1] = "ascii";
            Assert.AreEqual(console.Run(args), 1);
            Assert.IsTrue(console.Engine.Setup.Options.TryGetValue("LexerMode", out mode));
            Assert.AreEqual(LexerMode.ASCII, (LexerMode) mode);
        }
    }
}
