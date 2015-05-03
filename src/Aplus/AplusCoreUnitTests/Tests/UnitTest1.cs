using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Runtime.Remoting.Channels;
using Antlr.Runtime;
using AplusCore.Compiler;
using AplusCore.Compiler.Grammar;
using AplusCore.Hosting;
using AplusCore.Runtime;
using AplusCore.Runtime.Function.ADAP;
using AplusCore.Runtime.Function.Tools;
using AplusCore.Types;
using Microsoft.Scripting;
using Microsoft.Scripting.Runtime;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace AplusCoreUnitTests.Tests
{
    [TestClass]
    public class UnitTest1
    {
        
        [TestCategory("Tests"), TestMethod]
        public void TestMethod1()
        {

            AplusCommandLine acl = new AplusCommandLine();
            //private methods
        }

        [TestCategory("Tests"), TestMethod]
        public void TestExtensionMethodsToTypeString()
        {
            AplusCore.ExtensionMethods.ToTypeString(ATypes.AArray);
        }

        [TestCategory("Tests"), TestMethod]
        public void TestAPlusCoreCompiler()
        {
            //VariableHelper Tests
            VariableHelper.BuildValueQualifiedName("str.1", "str2");
            VariableHelper.CreateContextParts("str1", "str2");
            VariableHelper.CreateContextParts("", "str2");

            //FunctionInformation Tests
            FunctionInformation fi = new FunctionInformation("stringContext");
            fi.IsLocalFunction("string2");
            fi.RegisterLocalFunction("string");
            fi.Context = "string";

            //ParseExcemtion Tests
            ParseException pe = new ParseException("string");
            if (pe.CanContinue){}

            
        }

        [TestCategory("Tests"), TestMethod]
        public void AplusCoreRuntimeTest1()
        {
            //Runtime Error Tests
            Error.Interrupt ei = new Error.Interrupt("message");
            Error.Wsfull ew = new Error.Wsfull("message");
            Error.Stack es = new Error.Stack("message");
            Error.Parse ep = new Error.Parse("message");
            Error.MaxItems em = new Error.MaxItems("message");
            Error.Invalid einv = new Error.Invalid("message");

            Error e = new Error(ErrorType.Index, "message");
            string errorToString = e.ToString();

            //StopException
            StopException se1 = new StopException();
            StopException se2 = new StopException("message");
            StopException se3 = new StopException("message", new Exception());
            string tos = se2.ToString();

            //Runtime SystemCommands Tests
            //SystemCommands.PrintContexts();
            //SystemCommands.WriteToFile(new Aplus(new Scope(), new LexerMode()), "string", "fileToWrite.txt");

        }

        [TestCategory("Tests"), TestMethod]
        public void AplusCoreRuntimeTest2()
        {
            //Helpers
            //AType[] at = new AType[10];
            //Helpers.BuildArray(at);

            //SystemVariables
            SystemVariables sv = new SystemVariables();
            sv.Contains("string");

            //DependencyManager
            DependencyManager dm = new DependencyManager();
            //dm.TryGetDependency("string", new DependencyItem("string", new HashSet<string>(), new AReference(new AValue())));
            dm.ValidateDependency("string");

            //AplusLanguageContext
            //ScaledMatrix sm = new ScaledMatrix(new Matrix(), 2.0);
        }

        [TestCategory("Tests"), TestMethod]
        public void AplusCoreRuntimeFunctionAdapTest()
        {
            
        }




    }
}
