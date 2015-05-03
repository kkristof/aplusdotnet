using System;
using System.Runtime.Remoting.Messaging;
using AplusCore.Compiler.AST;
using AplusCore.Compiler.Grammar;
using AplusCore.Runtime.Function.ADAP;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using APlusWPF;
using System.Windows.Input;
using AplusCore.Types;
using AplusCoreUnitTests.Dlr;
using Microsoft.Scripting.Hosting;

namespace AplusCoreUnitTests
{
    [TestClass]
    public class MyTests : AbstractTest
    {
        [TestMethod]
        public void CreateDotFileTest()
        {
            DotGenerator.CreateDotFile("1 + if x <7 else 11", "out.dot");

            DotGenerator.CreateDotFile("(i:=20) do { b:=b + i }", "assaign.dot");

            DotGenerator.CreateDotFile("((((+))))*5", "builtInFunc.dot");

            DotGenerator.CreateDotFile("|{-76}", "builtInFunc1.dot");

            DotGenerator.CreateDotFile("(iota 3 4)[1; 1 3]", "builtInFunc2.dot");
        }

        [TestMethod]
        public void TestMethod1()
        {
            var testString = "abc\\n\\7543210\\x12345789";
            var ret = StringProcessor.ProcessEscapes(testString);
        }

        private ADAPException export;

        public void Setup()
        {
            export = new ADAPException(ADAPExceptionType.Export);
        }

        [TestMethod]
        public void ConstructorTests()
        {
            export = new ADAPException(ADAPExceptionType.Export, "Message!");

            export = new ADAPException(ADAPExceptionType.Export, "Message!", new Exception("Inner exception!"));
        }

        [TestMethod]
        public void GetTypeTest()
        {
            Setup();
            Assert.AreEqual(export.Type, ADAPExceptionType.Export);
        }

        [TestMethod]
        public void convertLCAsciiCharToAplCharTest()
        {
            MessageFilter.convertLCAsciiCharToAplChar(Key.Q);
            MessageFilter.convertLCAsciiCharToAplChar(Key.E);
            MessageFilter.convertLCAsciiCharToAplChar(Key.R);
            MessageFilter.convertLCAsciiCharToAplChar(Key.T);
            MessageFilter.convertLCAsciiCharToAplChar(Key.Y);
            MessageFilter.convertLCAsciiCharToAplChar(Key.U);
            MessageFilter.convertLCAsciiCharToAplChar(Key.I);
            MessageFilter.convertLCAsciiCharToAplChar(Key.O);
            MessageFilter.convertLCAsciiCharToAplChar(Key.P);
            MessageFilter.convertLCAsciiCharToAplChar(Key.Oem4);
            MessageFilter.convertLCAsciiCharToAplChar(Key.Oem6);
            MessageFilter.convertLCAsciiCharToAplChar(Key.S);
            MessageFilter.convertLCAsciiCharToAplChar(Key.D);
            MessageFilter.convertLCAsciiCharToAplChar(Key.F);
            MessageFilter.convertLCAsciiCharToAplChar(Key.J);
            MessageFilter.convertLCAsciiCharToAplChar(Key.K);
            MessageFilter.convertLCAsciiCharToAplChar(Key.Z);
            MessageFilter.convertLCAsciiCharToAplChar(Key.X);
            MessageFilter.convertLCAsciiCharToAplChar(Key.V);
            MessageFilter.convertLCAsciiCharToAplChar(Key.B);
            MessageFilter.convertLCAsciiCharToAplChar(Key.N);
            MessageFilter.convertLCAsciiCharToAplChar(Key.M);
            MessageFilter.convertLCAsciiCharToAplChar(Key.Back);
            MessageFilter.convertLCAsciiCharToAplChar(Key.D1);
            MessageFilter.convertLCAsciiCharToAplChar(Key.D2);
            MessageFilter.convertLCAsciiCharToAplChar(Key.D3);
            MessageFilter.convertLCAsciiCharToAplChar(Key.D4);
            MessageFilter.convertLCAsciiCharToAplChar(Key.D5);
            MessageFilter.convertLCAsciiCharToAplChar(Key.D6);
            MessageFilter.convertLCAsciiCharToAplChar(Key.D7);
            MessageFilter.convertLCAsciiCharToAplChar(Key.D8);
            MessageFilter.convertLCAsciiCharToAplChar(Key.D9);
            MessageFilter.convertLCAsciiCharToAplChar(Key.D0);
            MessageFilter.convertLCAsciiCharToAplChar(Key.OemMinus);
            MessageFilter.convertLCAsciiCharToAplChar(Key.OemPlus);
            MessageFilter.convertLCAsciiCharToAplChar(Key.OemSemicolon);
            MessageFilter.convertLCAsciiCharToAplChar(Key.OemQuotes);
        }

        [TestMethod]
        public void convertUCAsciiCharToAplCharTest()
        {
            MessageFilter.convertUCAsciiCharToAplChar(Key.Oem4);
                MessageFilter.convertUCAsciiCharToAplChar(Key.Oem6);
                MessageFilter.convertUCAsciiCharToAplChar(Key.G);
                MessageFilter.convertUCAsciiCharToAplChar(Key.H);
                MessageFilter.convertUCAsciiCharToAplChar(Key.C);
                MessageFilter.convertUCAsciiCharToAplChar(Key.B);
                MessageFilter.convertUCAsciiCharToAplChar(Key.N);
                MessageFilter.convertUCAsciiCharToAplChar(Key.Back);
                MessageFilter.convertUCAsciiCharToAplChar(Key.D1);
                MessageFilter.convertUCAsciiCharToAplChar(Key.D3);
                MessageFilter.convertUCAsciiCharToAplChar(Key.D4);
                MessageFilter.convertUCAsciiCharToAplChar(Key.D5);
                MessageFilter.convertUCAsciiCharToAplChar(Key.D6);
                MessageFilter.convertUCAsciiCharToAplChar(Key.D8);
                MessageFilter.convertUCAsciiCharToAplChar(Key.D0);
                MessageFilter.convertUCAsciiCharToAplChar(Key.OemMinus);
                MessageFilter.convertUCAsciiCharToAplChar(Key.OemPlus);
                MessageFilter.convertUCAsciiCharToAplChar(Key.OemComma);
                MessageFilter.convertUCAsciiCharToAplChar(Key.OemPeriod);
        }

        [TestMethod]
        public void convertLCAsciiCharToAplCharIDETest()
        {
            AplusIDE.MessageFilter.convertLCAsciiCharToAplChar(Key.Q);
            AplusIDE.MessageFilter.convertLCAsciiCharToAplChar(Key.E);
            AplusIDE.MessageFilter.convertLCAsciiCharToAplChar(Key.R);
            AplusIDE.MessageFilter.convertLCAsciiCharToAplChar(Key.T);
            AplusIDE.MessageFilter.convertLCAsciiCharToAplChar(Key.Y);
            AplusIDE.MessageFilter.convertLCAsciiCharToAplChar(Key.U);
            AplusIDE.MessageFilter.convertLCAsciiCharToAplChar(Key.I);
            AplusIDE.MessageFilter.convertLCAsciiCharToAplChar(Key.O);
            AplusIDE.MessageFilter.convertLCAsciiCharToAplChar(Key.P);
            AplusIDE.MessageFilter.convertLCAsciiCharToAplChar(Key.Oem4);
            AplusIDE.MessageFilter.convertLCAsciiCharToAplChar(Key.Oem6);
            AplusIDE.MessageFilter.convertLCAsciiCharToAplChar(Key.S);
            AplusIDE.MessageFilter.convertLCAsciiCharToAplChar(Key.D);
            AplusIDE.MessageFilter.convertLCAsciiCharToAplChar(Key.F);
            AplusIDE.MessageFilter.convertLCAsciiCharToAplChar(Key.J);
            AplusIDE.MessageFilter.convertLCAsciiCharToAplChar(Key.K);
            AplusIDE.MessageFilter.convertLCAsciiCharToAplChar(Key.Z);
            AplusIDE.MessageFilter.convertLCAsciiCharToAplChar(Key.X);
            AplusIDE.MessageFilter.convertLCAsciiCharToAplChar(Key.V);
            AplusIDE.MessageFilter.convertLCAsciiCharToAplChar(Key.B);
            AplusIDE.MessageFilter.convertLCAsciiCharToAplChar(Key.N);
            AplusIDE.MessageFilter.convertLCAsciiCharToAplChar(Key.M);
            AplusIDE.MessageFilter.convertLCAsciiCharToAplChar(Key.Back);
            AplusIDE.MessageFilter.convertLCAsciiCharToAplChar(Key.D1);
            AplusIDE.MessageFilter.convertLCAsciiCharToAplChar(Key.D2);
            AplusIDE.MessageFilter.convertLCAsciiCharToAplChar(Key.D3);
            AplusIDE.MessageFilter.convertLCAsciiCharToAplChar(Key.D4);
            AplusIDE.MessageFilter.convertLCAsciiCharToAplChar(Key.D5);
            AplusIDE.MessageFilter.convertLCAsciiCharToAplChar(Key.D6);
            AplusIDE.MessageFilter.convertLCAsciiCharToAplChar(Key.D7);
            AplusIDE.MessageFilter.convertLCAsciiCharToAplChar(Key.D8);
            AplusIDE.MessageFilter.convertLCAsciiCharToAplChar(Key.D9);
            AplusIDE.MessageFilter.convertLCAsciiCharToAplChar(Key.D0);
            AplusIDE.MessageFilter.convertLCAsciiCharToAplChar(Key.OemMinus);
            AplusIDE.MessageFilter.convertLCAsciiCharToAplChar(Key.OemPlus);
            AplusIDE.MessageFilter.convertLCAsciiCharToAplChar(Key.OemSemicolon);
            AplusIDE.MessageFilter.convertLCAsciiCharToAplChar(Key.OemQuotes);
        }

        [TestMethod]
        public void convertUCAsciiCharToAplCharTestIDETest()
        {
            AplusIDE.MessageFilter.convertUCAsciiCharToAplChar(Key.Oem4);
            AplusIDE.MessageFilter.convertUCAsciiCharToAplChar(Key.Oem6);
            AplusIDE.MessageFilter.convertUCAsciiCharToAplChar(Key.G);
            AplusIDE.MessageFilter.convertUCAsciiCharToAplChar(Key.H);
            AplusIDE.MessageFilter.convertUCAsciiCharToAplChar(Key.C);
            AplusIDE.MessageFilter.convertUCAsciiCharToAplChar(Key.B);
            AplusIDE.MessageFilter.convertUCAsciiCharToAplChar(Key.N);
            AplusIDE.MessageFilter.convertUCAsciiCharToAplChar(Key.Back);
            AplusIDE.MessageFilter.convertUCAsciiCharToAplChar(Key.D1);
            AplusIDE.MessageFilter.convertUCAsciiCharToAplChar(Key.D3);
            AplusIDE.MessageFilter.convertUCAsciiCharToAplChar(Key.D4);
            AplusIDE.MessageFilter.convertUCAsciiCharToAplChar(Key.D5);
            AplusIDE.MessageFilter.convertUCAsciiCharToAplChar(Key.D6);
            AplusIDE.MessageFilter.convertUCAsciiCharToAplChar(Key.D8);
            AplusIDE.MessageFilter.convertUCAsciiCharToAplChar(Key.D0);
            AplusIDE.MessageFilter.convertUCAsciiCharToAplChar(Key.OemMinus);
            AplusIDE.MessageFilter.convertUCAsciiCharToAplChar(Key.OemPlus);
            AplusIDE.MessageFilter.convertUCAsciiCharToAplChar(Key.OemComma);
            AplusIDE.MessageFilter.convertUCAsciiCharToAplChar(Key.OemPeriod);
        }

        
    }
}
