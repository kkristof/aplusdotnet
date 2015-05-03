// $ANTLR 3.2 Sep 23, 2009 12:02:23 Compiler\\Grammar\\AplusParser.g 2015-05-03 20:17:46

// The variable 'variable' is assigned but its value is never used.
#pragma warning disable 168, 219
// Unreachable code detected.
#pragma warning disable 162


using System.Collections.Generic;


using System;
using Antlr.Runtime;
using IList 		= System.Collections.IList;
using ArrayList 	= System.Collections.ArrayList;
using Stack 		= Antlr.Runtime.Collections.StackList;

using IDictionary	= System.Collections.IDictionary;
using Hashtable 	= System.Collections.Hashtable;
namespace  AplusCore.Compiler.Grammar 
{
public partial class AplusParser : Parser
{
    public static readonly string[] tokenNames = new string[] 
	{
        "<invalid>", 
		"<EOR>", 
		"<DOWN>", 
		"<UP>", 
		"SystemCommand", 
		"SystemCommandArgument", 
		"If", 
		"Else", 
		"Do", 
		"While", 
		"Case", 
		"RAdd", 
		"RAnd", 
		"RMax", 
		"RMin", 
		"RMultiply", 
		"ROr", 
		"SAdd", 
		"SAnd", 
		"SMax", 
		"SMin", 
		"SMultiply", 
		"SOr", 
		"AbsoluteValue", 
		"Ceiling", 
		"Count", 
		"DefaultFormat", 
		"Depth", 
		"Disclose", 
		"Enclose", 
		"Execute", 
		"Exponential", 
		"Floor", 
		"GradeDown", 
		"GradeUp", 
		"Identity", 
		"Interval", 
		"ItemRavel", 
		"MapIn", 
		"MatrixInverse", 
		"NaturalLog", 
		"Negate", 
		"Not", 
		"Null", 
		"Pack", 
		"PartitionCount", 
		"PiTimes", 
		"Print", 
		"Rake", 
		"Ravel", 
		"Raze", 
		"Reciprocal", 
		"Reverse", 
		"Roll", 
		"Right", 
		"SeparateSymbols", 
		"Shape", 
		"Sign", 
		"Signal", 
		"Stop", 
		"Transpose", 
		"Unpack", 
		"Value", 
		"Equal", 
		"Expand", 
		"GTE", 
		"LTE", 
		"NotEqual", 
		"Or", 
		"Replicate", 
		"Result", 
		"IPAddMultiply", 
		"IPMaxAdd", 
		"IPMinAdd", 
		"OPAdd", 
		"OPDivide", 
		"OPEqual", 
		"OPGT", 
		"OPGTE", 
		"OPLT", 
		"OPLTE", 
		"OPMax", 
		"OPMin", 
		"OPMultiply", 
		"OPNotEqual", 
		"OPResidue", 
		"OPSubstract", 
		"OPPower", 
		"BWNot", 
		"BWAnd", 
		"BWOr", 
		"BWLT", 
		"BWLTE", 
		"BWGT", 
		"BWGTE", 
		"BWEqual", 
		"BWNotEqual", 
		"StackReference", 
		"LP", 
		"RP", 
		"LSBracket", 
		"RSBracket", 
		"SemiColon", 
		"Colon", 
		"Each", 
		"Rank", 
		"WhiteSpace", 
		"Blank", 
		"LSB", 
		"RSB", 
		"Comment", 
		"CR", 
		"NewLine", 
		"Digit", 
		"Number", 
		"Int", 
		"Exponent", 
		"Float", 
		"Inf", 
		"SQ", 
		"DQ", 
		"Backslash", 
		"CharachterConstantSQ", 
		"CharachterConstantDQ", 
		"Alphabetic", 
		"Alphanumeric", 
		"SymbolConstant", 
		"UnqualifiedName", 
		"QualifiedName", 
		"SystemName", 
		"SystemCommandName"
    };

    public const int Disclose = 28;
    public const int Enclose = 29;
    public const int SMax = 19;
    public const int LP = 98;
    public const int Inf = 118;
    public const int DQ = 120;
    public const int QualifiedName = 128;
    public const int Replicate = 69;
    public const int EOF = -1;
    public const int SOr = 22;
    public const int Negate = 41;
    public const int Int = 115;
    public const int NewLine = 112;
    public const int Result = 70;
    public const int Rake = 48;
    public const int Signal = 58;
    public const int Transpose = 60;
    public const int Comment = 110;
    public const int OPGT = 77;
    public const int RMax = 13;
    public const int Do = 8;
    public const int Ravel = 49;
    public const int WhiteSpace = 106;
    public const int Sign = 57;
    public const int NaturalLog = 40;
    public const int Null = 43;
    public const int SystemCommand = 4;
    public const int SemiColon = 102;
    public const int SystemCommandArgument = 5;
    public const int RSBracket = 101;
    public const int BWOr = 90;
    public const int Interval = 36;
    public const int Reciprocal = 51;
    public const int RMin = 14;
    public const int RAdd = 11;
    public const int PartitionCount = 45;
    public const int BWGT = 93;
    public const int Stop = 59;
    public const int Colon = 103;
    public const int NotEqual = 67;
    public const int RMultiply = 15;
    public const int IPAddMultiply = 71;
    public const int Equal = 63;
    public const int OPNotEqual = 84;
    public const int GradeDown = 33;
    public const int MapIn = 38;
    public const int Float = 117;
    public const int Right = 54;
    public const int ROr = 16;
    public const int BWNot = 88;
    public const int OPEqual = 76;
    public const int SystemName = 129;
    public const int Ceiling = 24;
    public const int Raze = 50;
    public const int Backslash = 121;
    public const int Roll = 53;
    public const int RAnd = 12;
    public const int Reverse = 52;
    public const int Else = 7;
    public const int OPDivide = 75;
    public const int CharachterConstantDQ = 123;
    public const int SAnd = 18;
    public const int OPGTE = 78;
    public const int Rank = 105;
    public const int Pack = 44;
    public const int RP = 99;
    public const int BWAnd = 89;
    public const int StackReference = 97;
    public const int LSBracket = 100;
    public const int OPLTE = 80;
    public const int GTE = 65;
    public const int Exponent = 116;
    public const int While = 9;
    public const int OPAdd = 74;
    public const int OPLT = 79;
    public const int SMultiply = 21;
    public const int Case = 10;
    public const int LTE = 66;
    public const int Alphanumeric = 125;
    public const int Value = 62;
    public const int Number = 114;
    public const int MatrixInverse = 39;
    public const int RSB = 109;
    public const int Floor = 32;
    public const int Print = 47;
    public const int SystemCommandName = 130;
    public const int OPMax = 81;
    public const int IPMaxAdd = 72;
    public const int IPMinAdd = 73;
    public const int Or = 68;
    public const int Unpack = 61;
    public const int DefaultFormat = 26;
    public const int If = 6;
    public const int OPMin = 82;
    public const int LSB = 108;
    public const int Blank = 107;
    public const int PiTimes = 46;
    public const int Exponential = 31;
    public const int Count = 25;
    public const int Each = 104;
    public const int SAdd = 17;
    public const int SymbolConstant = 126;
    public const int OPResidue = 85;
    public const int UnqualifiedName = 127;
    public const int Depth = 27;
    public const int BWGTE = 94;
    public const int OPPower = 87;
    public const int CharachterConstantSQ = 122;
    public const int Digit = 113;
    public const int BWEqual = 95;
    public const int ItemRavel = 37;
    public const int BWLTE = 92;
    public const int BWLT = 91;
    public const int AbsoluteValue = 23;
    public const int OPSubstract = 86;
    public const int BWNotEqual = 96;
    public const int SMin = 20;
    public const int Not = 42;
    public const int SQ = 119;
    public const int Alphabetic = 124;
    public const int Shape = 56;
    public const int GradeUp = 34;
    public const int SeparateSymbols = 55;
    public const int Identity = 35;
    public const int CR = 111;
    public const int Execute = 30;
    public const int OPMultiply = 83;
    public const int Expand = 64;

    // delegates
    // delegators



        public AplusParser(ITokenStream input)
    		: this(input, new RecognizerSharedState()) {
        }

        public AplusParser(ITokenStream input, RecognizerSharedState state)
    		: base(input, state) {
            InitializeCyclicDFAs();
            this.state.ruleMemo = new Hashtable[173+1];
             
             
        }
        

    override public string[] TokenNames {
		get { return AplusParser.tokenNames; }
    }

    override public string GrammarFileName {
		get { return "Compiler\\Grammar\\AplusParser.g"; }
    }



    // $ANTLR start "script"
    // Compiler\\Grammar\\AplusParser.g:17:1: script : statements EOF ;
    public void script() // throws RecognitionException [1]
    {   
        int script_StartIndex = input.Index();
        AST.ExpressionList statements1 = default(AST.ExpressionList);


        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 1) ) 
    	    {
    	    	return ; 
    	    }
            // Compiler\\Grammar\\AplusParser.g:18:2: ( statements EOF )
            // Compiler\\Grammar\\AplusParser.g:18:4: statements EOF
            {
            	PushFollow(FOLLOW_statements_in_script66);
            	statements1 = statements();
            	state.followingStackPointer--;
            	if (state.failed) return ;
            	Match(input,EOF,FOLLOW_EOF_in_script68); if (state.failed) return ;
            	if ( (state.backtracking==0) )
            	{
            	   this.tree = statements1; 
            	}

            }

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 1, script_StartIndex); 
            }
        }
        return ;
    }
    // $ANTLR end "script"


    // $ANTLR start "statements"
    // Compiler\\Grammar\\AplusParser.g:21:1: statements returns [AST.ExpressionList node] : (items= statement NewLine )* last= statement ;
    public AST.ExpressionList statements() // throws RecognitionException [1]
    {   
        AST.ExpressionList node = default(AST.ExpressionList);
        int statements_StartIndex = input.Index();
        AST.Node items = default(AST.Node);

        AST.Node last = default(AST.Node);


         node = AST.Node.ExpressionList(); 
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 2) ) 
    	    {
    	    	return node; 
    	    }
            // Compiler\\Grammar\\AplusParser.g:23:2: ( (items= statement NewLine )* last= statement )
            // Compiler\\Grammar\\AplusParser.g:23:4: (items= statement NewLine )* last= statement
            {
            	// Compiler\\Grammar\\AplusParser.g:23:4: (items= statement NewLine )*
            	do 
            	{
            	    int alt1 = 2;
            	    alt1 = dfa1.Predict(input);
            	    switch (alt1) 
            		{
            			case 1 :
            			    // Compiler\\Grammar\\AplusParser.g:23:6: items= statement NewLine
            			    {
            			    	PushFollow(FOLLOW_statement_in_statements100);
            			    	items = statement();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return node;
            			    	if ( (state.backtracking==0) )
            			    	{
            			    	   node.AddLast(items); 
            			    	}
            			    	Match(input,NewLine,FOLLOW_NewLine_in_statements112); if (state.failed) return node;

            			    }
            			    break;

            			default:
            			    goto loop1;
            	    }
            	} while (true);

            	loop1:
            		;	// Stops C# compiler whining that label 'loop1' has no statements

            	PushFollow(FOLLOW_statement_in_statements124);
            	last = statement();
            	state.followingStackPointer--;
            	if (state.failed) return node;
            	if ( (state.backtracking==0) )
            	{
            	   node.AddLast(last); 
            	}

            }

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 2, statements_StartIndex); 
            }
        }
        return node;
    }
    // $ANTLR end "statements"


    // $ANTLR start "statement"
    // Compiler\\Grammar\\AplusParser.g:29:1: statement returns [AST.Node node] : ( systemCommand | dependencyDefinition | userDefinedOperator | userDefinedFunction | expressionList );
    public AST.Node statement() // throws RecognitionException [1]
    {   
        AST.Node node = default(AST.Node);
        int statement_StartIndex = input.Index();
        AST.SystemCommand systemCommand2 = default(AST.SystemCommand);

        AplusParser.dependencyDefinition_return dependencyDefinition3 = default(AplusParser.dependencyDefinition_return);

        AplusParser.userDefinedOperator_return userDefinedOperator4 = default(AplusParser.userDefinedOperator_return);

        AplusParser.userDefinedFunction_return userDefinedFunction5 = default(AplusParser.userDefinedFunction_return);

        AST.ExpressionList expressionList6 = default(AST.ExpressionList);


        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 3) ) 
    	    {
    	    	return node; 
    	    }
            // Compiler\\Grammar\\AplusParser.g:30:2: ( systemCommand | dependencyDefinition | userDefinedOperator | userDefinedFunction | expressionList )
            int alt2 = 5;
            alt2 = dfa2.Predict(input);
            switch (alt2) 
            {
                case 1 :
                    // Compiler\\Grammar\\AplusParser.g:30:4: systemCommand
                    {
                    	PushFollow(FOLLOW_systemCommand_in_statement148);
                    	systemCommand2 = systemCommand();
                    	state.followingStackPointer--;
                    	if (state.failed) return node;
                    	if ( (state.backtracking==0) )
                    	{
                    	   node = systemCommand2; 
                    	}

                    }
                    break;
                case 2 :
                    // Compiler\\Grammar\\AplusParser.g:31:4: dependencyDefinition
                    {
                    	PushFollow(FOLLOW_dependencyDefinition_in_statement160);
                    	dependencyDefinition3 = dependencyDefinition();
                    	state.followingStackPointer--;
                    	if (state.failed) return node;
                    	if ( (state.backtracking==0) )
                    	{
                    	   node = ((dependencyDefinition3 != null) ? dependencyDefinition3.node : default(AST.Dependency)); 
                    	}

                    }
                    break;
                case 3 :
                    // Compiler\\Grammar\\AplusParser.g:32:4: userDefinedOperator
                    {
                    	PushFollow(FOLLOW_userDefinedOperator_in_statement170);
                    	userDefinedOperator4 = userDefinedOperator();
                    	state.followingStackPointer--;
                    	if (state.failed) return node;
                    	if ( (state.backtracking==0) )
                    	{
                    	   node = ((userDefinedOperator4 != null) ? userDefinedOperator4.node : default(AST.UserDefOperator)); 
                    	}

                    }
                    break;
                case 4 :
                    // Compiler\\Grammar\\AplusParser.g:33:4: userDefinedFunction
                    {
                    	PushFollow(FOLLOW_userDefinedFunction_in_statement181);
                    	userDefinedFunction5 = userDefinedFunction();
                    	state.followingStackPointer--;
                    	if (state.failed) return node;
                    	if ( (state.backtracking==0) )
                    	{
                    	   node = ((userDefinedFunction5 != null) ? userDefinedFunction5.node : default(AST.UserDefFunction)); 
                    	}

                    }
                    break;
                case 5 :
                    // Compiler\\Grammar\\AplusParser.g:34:4: expressionList
                    {
                    	PushFollow(FOLLOW_expressionList_in_statement192);
                    	expressionList6 = expressionList();
                    	state.followingStackPointer--;
                    	if (state.failed) return node;
                    	if ( (state.backtracking==0) )
                    	{
                    	   node = expressionList6; 
                    	}

                    }
                    break;

            }
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 3, statement_StartIndex); 
            }
        }
        return node;
    }
    // $ANTLR end "statement"


    // $ANTLR start "systemCommand"
    // Compiler\\Grammar\\AplusParser.g:37:1: systemCommand returns [AST.SystemCommand node] : SystemCommand ( SystemCommandArgument )? ;
    public AST.SystemCommand systemCommand() // throws RecognitionException [1]
    {   
        AST.SystemCommand node = default(AST.SystemCommand);
        int systemCommand_StartIndex = input.Index();
        IToken SystemCommand7 = null;
        IToken SystemCommandArgument8 = null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 4) ) 
    	    {
    	    	return node; 
    	    }
            // Compiler\\Grammar\\AplusParser.g:38:2: ( SystemCommand ( SystemCommandArgument )? )
            // Compiler\\Grammar\\AplusParser.g:38:4: SystemCommand ( SystemCommandArgument )?
            {
            	SystemCommand7=(IToken)Match(input,SystemCommand,FOLLOW_SystemCommand_in_systemCommand215); if (state.failed) return node;
            	if ( (state.backtracking==0) )
            	{
            	   node = AST.Node.SystemCommand(SystemCommand7.Text); 
            	}
            	// Compiler\\Grammar\\AplusParser.g:39:3: ( SystemCommandArgument )?
            	int alt3 = 2;
            	int LA3_0 = input.LA(1);

            	if ( (LA3_0 == SystemCommandArgument) )
            	{
            	    alt3 = 1;
            	}
            	switch (alt3) 
            	{
            	    case 1 :
            	        // Compiler\\Grammar\\AplusParser.g:40:4: SystemCommandArgument
            	        {
            	        	SystemCommandArgument8=(IToken)Match(input,SystemCommandArgument,FOLLOW_SystemCommandArgument_in_systemCommand229); if (state.failed) return node;
            	        	if ( (state.backtracking==0) )
            	        	{
            	        	   node.Argument = SystemCommandArgument8.Text; 
            	        	}

            	        }
            	        break;

            	}


            }

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 4, systemCommand_StartIndex); 
            }
        }
        return node;
    }
    // $ANTLR end "systemCommand"

    public class dependencyDefinition_return : ParserRuleReturnScope
    {
        public AST.Dependency node;
    };

    // $ANTLR start "dependencyDefinition"
    // Compiler\\Grammar\\AplusParser.g:44:1: dependencyDefinition returns [AST.Dependency node] : name= variableName ( LSBracket indexer= variableName RSBracket )? Colon functionBody ;
    public AplusParser.dependencyDefinition_return dependencyDefinition() // throws RecognitionException [1]
    {   
        AplusParser.dependencyDefinition_return retval = new AplusParser.dependencyDefinition_return();
        retval.Start = input.LT(1);
        int dependencyDefinition_StartIndex = input.Index();
        AST.Identifier name = default(AST.Identifier);

        AST.Identifier indexer = default(AST.Identifier);

        AST.Node functionBody9 = default(AST.Node);


         this.isdependency = false; SetupUserDefFunction(); 
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 5) ) 
    	    {
    	    	return retval; 
    	    }
            // Compiler\\Grammar\\AplusParser.g:47:2: (name= variableName ( LSBracket indexer= variableName RSBracket )? Colon functionBody )
            // Compiler\\Grammar\\AplusParser.g:47:4: name= variableName ( LSBracket indexer= variableName RSBracket )? Colon functionBody
            {
            	PushFollow(FOLLOW_variableName_in_dependencyDefinition264);
            	name = variableName();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) )
            	{
            	   this.isdependency = true; 
            	}
            	// Compiler\\Grammar\\AplusParser.g:48:3: ( LSBracket indexer= variableName RSBracket )?
            	int alt4 = 2;
            	int LA4_0 = input.LA(1);

            	if ( (LA4_0 == LSBracket) )
            	{
            	    alt4 = 1;
            	}
            	switch (alt4) 
            	{
            	    case 1 :
            	        // Compiler\\Grammar\\AplusParser.g:48:4: LSBracket indexer= variableName RSBracket
            	        {
            	        	Match(input,LSBracket,FOLLOW_LSBracket_in_dependencyDefinition271); if (state.failed) return retval;
            	        	PushFollow(FOLLOW_variableName_in_dependencyDefinition275);
            	        	indexer = variableName();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	Match(input,RSBracket,FOLLOW_RSBracket_in_dependencyDefinition277); if (state.failed) return retval;

            	        }
            	        break;

            	}

            	Match(input,Colon,FOLLOW_Colon_in_dependencyDefinition283); if (state.failed) return retval;
            	PushFollow(FOLLOW_functionBody_in_dependencyDefinition285);
            	functionBody9 = functionBody();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) )
            	{
            	   
            	  			retval.node =  AST.Node.Dependency(name, functionBody9, input.ToString((IToken)retval.Start,input.LT(-1)), this.variables);
            	  			if(indexer != null)
            	  			{
            	  				retval.node.Indexer = indexer;
            	  			}
            	  		
            	}

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {
               this.isdependency = false; TearDownUserDefFunction(); 
            }
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 5, dependencyDefinition_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "dependencyDefinition"

    public class userDefinedOperator_return : ParserRuleReturnScope
    {
        public AST.UserDefOperator node;
    };

    // $ANTLR start "userDefinedOperator"
    // Compiler\\Grammar\\AplusParser.g:59:1: userDefinedOperator returns [AST.UserDefOperator node] : ( LP func= variableName name= variableName RP rhs= variableName Colon functionBody | LP func= variableName name= variableName opcondition= variableName RP rhs= variableName Colon functionBody | lhs= variableName LP func= variableName name= variableName RP rhs= variableName Colon functionBody | lhs= variableName LP func= variableName name= variableName opcondition= variableName RP rhs= variableName Colon functionBody );
    public AplusParser.userDefinedOperator_return userDefinedOperator() // throws RecognitionException [1]
    {   
        AplusParser.userDefinedOperator_return retval = new AplusParser.userDefinedOperator_return();
        retval.Start = input.LT(1);
        int userDefinedOperator_StartIndex = input.Index();
        AST.Identifier func = default(AST.Identifier);

        AST.Identifier name = default(AST.Identifier);

        AST.Identifier rhs = default(AST.Identifier);

        AST.Identifier opcondition = default(AST.Identifier);

        AST.Identifier lhs = default(AST.Identifier);

        AST.Node functionBody10 = default(AST.Node);

        AST.Node functionBody11 = default(AST.Node);

        AST.Node functionBody12 = default(AST.Node);

        AST.Node functionBody13 = default(AST.Node);


         SetupUserDefFunction(); 
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 6) ) 
    	    {
    	    	return retval; 
    	    }
            // Compiler\\Grammar\\AplusParser.g:62:2: ( LP func= variableName name= variableName RP rhs= variableName Colon functionBody | LP func= variableName name= variableName opcondition= variableName RP rhs= variableName Colon functionBody | lhs= variableName LP func= variableName name= variableName RP rhs= variableName Colon functionBody | lhs= variableName LP func= variableName name= variableName opcondition= variableName RP rhs= variableName Colon functionBody )
            int alt5 = 4;
            alt5 = dfa5.Predict(input);
            switch (alt5) 
            {
                case 1 :
                    // Compiler\\Grammar\\AplusParser.g:62:4: LP func= variableName name= variableName RP rhs= variableName Colon functionBody
                    {
                    	Match(input,LP,FOLLOW_LP_in_userDefinedOperator316); if (state.failed) return retval;
                    	PushFollow(FOLLOW_variableName_in_userDefinedOperator320);
                    	func = variableName();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	PushFollow(FOLLOW_variableName_in_userDefinedOperator324);
                    	name = variableName();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	Match(input,RP,FOLLOW_RP_in_userDefinedOperator326); if (state.failed) return retval;
                    	PushFollow(FOLLOW_variableName_in_userDefinedOperator330);
                    	rhs = variableName();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	Match(input,Colon,FOLLOW_Colon_in_userDefinedOperator335); if (state.failed) return retval;
                    	PushFollow(FOLLOW_functionBody_in_userDefinedOperator337);
                    	functionBody10 = functionBody();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) )
                    	{

                    	  			retval.node =  AST.Node.MonadicUserDefOperator(name, func, rhs, functionBody10, input.ToString((IToken)retval.Start,input.LT(-1)));
                    	  		
                    	}

                    }
                    break;
                case 2 :
                    // Compiler\\Grammar\\AplusParser.g:67:4: LP func= variableName name= variableName opcondition= variableName RP rhs= variableName Colon functionBody
                    {
                    	Match(input,LP,FOLLOW_LP_in_userDefinedOperator346); if (state.failed) return retval;
                    	PushFollow(FOLLOW_variableName_in_userDefinedOperator350);
                    	func = variableName();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	PushFollow(FOLLOW_variableName_in_userDefinedOperator354);
                    	name = variableName();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	PushFollow(FOLLOW_variableName_in_userDefinedOperator358);
                    	opcondition = variableName();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	Match(input,RP,FOLLOW_RP_in_userDefinedOperator360); if (state.failed) return retval;
                    	PushFollow(FOLLOW_variableName_in_userDefinedOperator364);
                    	rhs = variableName();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	Match(input,Colon,FOLLOW_Colon_in_userDefinedOperator368); if (state.failed) return retval;
                    	PushFollow(FOLLOW_functionBody_in_userDefinedOperator370);
                    	functionBody11 = functionBody();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) )
                    	{

                    	  			retval.node =  AST.Node.DyadicUserDefOperator(name, func, opcondition, rhs, functionBody11, input.ToString((IToken)retval.Start,input.LT(-1)));
                    	  		
                    	}

                    }
                    break;
                case 3 :
                    // Compiler\\Grammar\\AplusParser.g:72:4: lhs= variableName LP func= variableName name= variableName RP rhs= variableName Colon functionBody
                    {
                    	PushFollow(FOLLOW_variableName_in_userDefinedOperator381);
                    	lhs = variableName();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	Match(input,LP,FOLLOW_LP_in_userDefinedOperator383); if (state.failed) return retval;
                    	PushFollow(FOLLOW_variableName_in_userDefinedOperator387);
                    	func = variableName();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	PushFollow(FOLLOW_variableName_in_userDefinedOperator391);
                    	name = variableName();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	Match(input,RP,FOLLOW_RP_in_userDefinedOperator393); if (state.failed) return retval;
                    	PushFollow(FOLLOW_variableName_in_userDefinedOperator397);
                    	rhs = variableName();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	Match(input,Colon,FOLLOW_Colon_in_userDefinedOperator401); if (state.failed) return retval;
                    	PushFollow(FOLLOW_functionBody_in_userDefinedOperator403);
                    	functionBody12 = functionBody();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) )
                    	{

                    	  			retval.node =  AST.Node.MonadicUserDefOperator(name, func, lhs, rhs, functionBody12, input.ToString((IToken)retval.Start,input.LT(-1)));
                    	  		
                    	}

                    }
                    break;
                case 4 :
                    // Compiler\\Grammar\\AplusParser.g:77:4: lhs= variableName LP func= variableName name= variableName opcondition= variableName RP rhs= variableName Colon functionBody
                    {
                    	PushFollow(FOLLOW_variableName_in_userDefinedOperator414);
                    	lhs = variableName();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	Match(input,LP,FOLLOW_LP_in_userDefinedOperator416); if (state.failed) return retval;
                    	PushFollow(FOLLOW_variableName_in_userDefinedOperator420);
                    	func = variableName();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	PushFollow(FOLLOW_variableName_in_userDefinedOperator424);
                    	name = variableName();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	PushFollow(FOLLOW_variableName_in_userDefinedOperator428);
                    	opcondition = variableName();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	Match(input,RP,FOLLOW_RP_in_userDefinedOperator430); if (state.failed) return retval;
                    	PushFollow(FOLLOW_variableName_in_userDefinedOperator434);
                    	rhs = variableName();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	Match(input,Colon,FOLLOW_Colon_in_userDefinedOperator438); if (state.failed) return retval;
                    	PushFollow(FOLLOW_functionBody_in_userDefinedOperator440);
                    	functionBody13 = functionBody();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) )
                    	{
                    	   
                    	  			retval.node =  AST.Node.DyadicUserDefOperator(name,
                    	  												   func, opcondition,
                    	  												   lhs, rhs,
                    	  												   functionBody13, input.ToString((IToken)retval.Start,input.LT(-1)));
                    	  		
                    	}

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {
               TearDownUserDefFunction(); 
            }
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 6, userDefinedOperator_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "userDefinedOperator"

    public class userDefinedFunction_return : ParserRuleReturnScope
    {
        public AST.UserDefFunction node;
    };

    // $ANTLR start "userDefinedFunction"
    // Compiler\\Grammar\\AplusParser.g:87:1: userDefinedFunction returns [AST.UserDefFunction node] : ( variableName expressionGroup Colon functionBody | arg1= variableName name= variableName arg2= variableName Colon functionBody | name= variableName arg1= variableName Colon functionBody );
    public AplusParser.userDefinedFunction_return userDefinedFunction() // throws RecognitionException [1]
    {   
        AplusParser.userDefinedFunction_return retval = new AplusParser.userDefinedFunction_return();
        retval.Start = input.LT(1);
        int userDefinedFunction_StartIndex = input.Index();
        AST.Identifier arg1 = default(AST.Identifier);

        AST.Identifier name = default(AST.Identifier);

        AST.Identifier arg2 = default(AST.Identifier);

        AST.Identifier variableName14 = default(AST.Identifier);

        AST.ExpressionList expressionGroup15 = default(AST.ExpressionList);

        AST.Node functionBody16 = default(AST.Node);

        AST.Node functionBody17 = default(AST.Node);

        AST.Node functionBody18 = default(AST.Node);


         SetupUserDefFunction(); 
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 7) ) 
    	    {
    	    	return retval; 
    	    }
            // Compiler\\Grammar\\AplusParser.g:90:2: ( variableName expressionGroup Colon functionBody | arg1= variableName name= variableName arg2= variableName Colon functionBody | name= variableName arg1= variableName Colon functionBody )
            int alt6 = 3;
            alt6 = dfa6.Predict(input);
            switch (alt6) 
            {
                case 1 :
                    // Compiler\\Grammar\\AplusParser.g:90:4: variableName expressionGroup Colon functionBody
                    {
                    	PushFollow(FOLLOW_variableName_in_userDefinedFunction472);
                    	variableName14 = variableName();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) )
                    	{
                    	   this.function = variableName14; 
                    	}
                    	PushFollow(FOLLOW_expressionGroup_in_userDefinedFunction487);
                    	expressionGroup15 = expressionGroup();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	Match(input,Colon,FOLLOW_Colon_in_userDefinedFunction489); if (state.failed) return retval;
                    	PushFollow(FOLLOW_functionBody_in_userDefinedFunction491);
                    	functionBody16 = functionBody();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) )
                    	{
                    	   retval.node =  AST.Node.UserDefFunction(variableName14, expressionGroup15, functionBody16, input.ToString((IToken)retval.Start,input.LT(-1))); 
                    	}

                    }
                    break;
                case 2 :
                    // Compiler\\Grammar\\AplusParser.g:93:4: arg1= variableName name= variableName arg2= variableName Colon functionBody
                    {
                    	PushFollow(FOLLOW_variableName_in_userDefinedFunction503);
                    	arg1 = variableName();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	PushFollow(FOLLOW_variableName_in_userDefinedFunction509);
                    	name = variableName();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) )
                    	{
                    	   this.function = name; 
                    	}
                    	PushFollow(FOLLOW_variableName_in_userDefinedFunction526);
                    	arg2 = variableName();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	Match(input,Colon,FOLLOW_Colon_in_userDefinedFunction528); if (state.failed) return retval;
                    	PushFollow(FOLLOW_functionBody_in_userDefinedFunction530);
                    	functionBody17 = functionBody();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) )
                    	{
                    	   retval.node =  AST.Node.UserDefFunction(name, 
                    	  						AST.Node.ExpressionList(arg1, arg2), functionBody17, input.ToString((IToken)retval.Start,input.LT(-1))); 
                    	  			
                    	}

                    }
                    break;
                case 3 :
                    // Compiler\\Grammar\\AplusParser.g:99:4: name= variableName arg1= variableName Colon functionBody
                    {
                    	PushFollow(FOLLOW_variableName_in_userDefinedFunction542);
                    	name = variableName();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) )
                    	{
                    	   this.function = name; 
                    	}
                    	PushFollow(FOLLOW_variableName_in_userDefinedFunction558);
                    	arg1 = variableName();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	Match(input,Colon,FOLLOW_Colon_in_userDefinedFunction560); if (state.failed) return retval;
                    	PushFollow(FOLLOW_functionBody_in_userDefinedFunction562);
                    	functionBody18 = functionBody();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) )
                    	{
                    	   retval.node =  AST.Node.UserDefFunction(name, 
                    	  						AST.Node.ExpressionList(arg1), functionBody18, input.ToString((IToken)retval.Start,input.LT(-1))); 
                    	  			
                    	}

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {
               RegisterUserDefFunction(retval.node); retval.node.Variables = this.variables; TearDownUserDefFunction(); 
            }
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 7, userDefinedFunction_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "userDefinedFunction"


    // $ANTLR start "functionBody"
    // Compiler\\Grammar\\AplusParser.g:106:1: functionBody returns [AST.Node node] : ( expression | NewLine expression );
    public AST.Node functionBody() // throws RecognitionException [1]
    {   
        AST.Node node = default(AST.Node);
        int functionBody_StartIndex = input.Index();
        AST.Node expression19 = default(AST.Node);

        AST.Node expression20 = default(AST.Node);


        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 8) ) 
    	    {
    	    	return node; 
    	    }
            // Compiler\\Grammar\\AplusParser.g:107:2: ( expression | NewLine expression )
            int alt7 = 2;
            int LA7_0 = input.LA(1);

            if ( (LA7_0 == If || (LA7_0 >= Do && LA7_0 <= LP) || LA7_0 == LSB || LA7_0 == Int || (LA7_0 >= Float && LA7_0 <= Inf) || (LA7_0 >= CharachterConstantSQ && LA7_0 <= CharachterConstantDQ) || (LA7_0 >= SymbolConstant && LA7_0 <= SystemName)) )
            {
                alt7 = 1;
            }
            else if ( (LA7_0 == NewLine) )
            {
                alt7 = 2;
            }
            else 
            {
                if ( state.backtracking > 0 ) {state.failed = true; return node;}
                NoViableAltException nvae_d7s0 =
                    new NoViableAltException("", 7, 0, input);

                throw nvae_d7s0;
            }
            switch (alt7) 
            {
                case 1 :
                    // Compiler\\Grammar\\AplusParser.g:107:4: expression
                    {
                    	PushFollow(FOLLOW_expression_in_functionBody582);
                    	expression19 = expression();
                    	state.followingStackPointer--;
                    	if (state.failed) return node;
                    	if ( (state.backtracking==0) )
                    	{
                    	   node = expression19; 
                    	}

                    }
                    break;
                case 2 :
                    // Compiler\\Grammar\\AplusParser.g:108:4: NewLine expression
                    {
                    	Match(input,NewLine,FOLLOW_NewLine_in_functionBody593); if (state.failed) return node;
                    	PushFollow(FOLLOW_expression_in_functionBody595);
                    	expression20 = expression();
                    	state.followingStackPointer--;
                    	if (state.failed) return node;
                    	if ( (state.backtracking==0) )
                    	{
                    	   node = expression20; 
                    	}

                    }
                    break;

            }
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 8, functionBody_StartIndex); 
            }
        }
        return node;
    }
    // $ANTLR end "functionBody"


    // $ANTLR start "expressionList"
    // Compiler\\Grammar\\AplusParser.g:112:1: expressionList returns [AST.ExpressionList node] : fist= topExpressionNull ( SemiColon item= topExpressionNull )* ;
    public AST.ExpressionList expressionList() // throws RecognitionException [1]
    {   
        AST.ExpressionList node = default(AST.ExpressionList);
        int expressionList_StartIndex = input.Index();
        AST.Node fist = default(AST.Node);

        AST.Node item = default(AST.Node);


         AST.ExpressionList list = AST.Node.ExpressionList(); 
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 9) ) 
    	    {
    	    	return node; 
    	    }
            // Compiler\\Grammar\\AplusParser.g:114:2: (fist= topExpressionNull ( SemiColon item= topExpressionNull )* )
            // Compiler\\Grammar\\AplusParser.g:114:4: fist= topExpressionNull ( SemiColon item= topExpressionNull )*
            {
            	PushFollow(FOLLOW_topExpressionNull_in_expressionList625);
            	fist = topExpressionNull();
            	state.followingStackPointer--;
            	if (state.failed) return node;
            	if ( (state.backtracking==0) )
            	{
            	   list.AddLast(fist); 
            	}
            	// Compiler\\Grammar\\AplusParser.g:115:3: ( SemiColon item= topExpressionNull )*
            	do 
            	{
            	    int alt8 = 2;
            	    int LA8_0 = input.LA(1);

            	    if ( (LA8_0 == SemiColon) )
            	    {
            	        alt8 = 1;
            	    }


            	    switch (alt8) 
            		{
            			case 1 :
            			    // Compiler\\Grammar\\AplusParser.g:115:4: SemiColon item= topExpressionNull
            			    {
            			    	Match(input,SemiColon,FOLLOW_SemiColon_in_expressionList633); if (state.failed) return node;
            			    	PushFollow(FOLLOW_topExpressionNull_in_expressionList640);
            			    	item = topExpressionNull();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return node;
            			    	if ( (state.backtracking==0) )
            			    	{
            			    	   list.AddLast(item); 
            			    	}

            			    }
            			    break;

            			default:
            			    goto loop8;
            	    }
            	} while (true);

            	loop8:
            		;	// Stops C# compiler whining that label 'loop8' has no statements

            	if ( (state.backtracking==0) )
            	{
            	   node = list; 
            	}

            }

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 9, expressionList_StartIndex); 
            }
        }
        return node;
    }
    // $ANTLR end "expressionList"


    // $ANTLR start "topExpressionNull"
    // Compiler\\Grammar\\AplusParser.g:121:1: topExpressionNull returns [AST.Node node] : ( expression | operatorSymbol | functionSymbol | );
    public AST.Node topExpressionNull() // throws RecognitionException [1]
    {   
        AST.Node node = default(AST.Node);
        int topExpressionNull_StartIndex = input.Index();
        AST.Node expression21 = default(AST.Node);

        AST.Operator operatorSymbol22 = default(AST.Operator);

        AST.Token functionSymbol23 = default(AST.Token);


        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 10) ) 
    	    {
    	    	return node; 
    	    }
            // Compiler\\Grammar\\AplusParser.g:122:2: ( expression | operatorSymbol | functionSymbol | )
            int alt9 = 4;
            alt9 = dfa9.Predict(input);
            switch (alt9) 
            {
                case 1 :
                    // Compiler\\Grammar\\AplusParser.g:122:4: expression
                    {
                    	PushFollow(FOLLOW_expression_in_topExpressionNull667);
                    	expression21 = expression();
                    	state.followingStackPointer--;
                    	if (state.failed) return node;
                    	if ( (state.backtracking==0) )
                    	{
                    	   node = expression21; 
                    	}

                    }
                    break;
                case 2 :
                    // Compiler\\Grammar\\AplusParser.g:123:4: operatorSymbol
                    {
                    	PushFollow(FOLLOW_operatorSymbol_in_topExpressionNull680);
                    	operatorSymbol22 = operatorSymbol();
                    	state.followingStackPointer--;
                    	if (state.failed) return node;
                    	if ( (state.backtracking==0) )
                    	{
                    	   node = AST.Node.BuiltInOperator(operatorSymbol22); 
                    	}

                    }
                    break;
                case 3 :
                    // Compiler\\Grammar\\AplusParser.g:124:4: functionSymbol
                    {
                    	PushFollow(FOLLOW_functionSymbol_in_topExpressionNull692);
                    	functionSymbol23 = functionSymbol();
                    	state.followingStackPointer--;
                    	if (state.failed) return node;
                    	if ( (state.backtracking==0) )
                    	{
                    	   node = AST.Node.BuiltInFunction(functionSymbol23); 
                    	}

                    }
                    break;
                case 4 :
                    // Compiler\\Grammar\\AplusParser.g:125:21: 
                    {
                    	if ( (state.backtracking==0) )
                    	{
                    	   node = AST.Node.NullConstant(); 
                    	}

                    }
                    break;

            }
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 10, topExpressionNull_StartIndex); 
            }
        }
        return node;
    }
    // $ANTLR end "topExpressionNull"


    // $ANTLR start "expressionGroup"
    // Compiler\\Grammar\\AplusParser.g:128:1: expressionGroup returns [AST.ExpressionList node] : ( LSB RSB | LSB expressionList RSB );
    public AST.ExpressionList expressionGroup() // throws RecognitionException [1]
    {   
        AST.ExpressionList node = default(AST.ExpressionList);
        int expressionGroup_StartIndex = input.Index();
        AST.ExpressionList expressionList24 = default(AST.ExpressionList);


        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 11) ) 
    	    {
    	    	return node; 
    	    }
            // Compiler\\Grammar\\AplusParser.g:129:2: ( LSB RSB | LSB expressionList RSB )
            int alt10 = 2;
            int LA10_0 = input.LA(1);

            if ( (LA10_0 == LSB) )
            {
                int LA10_1 = input.LA(2);

                if ( (LA10_1 == RSB) )
                {
                    int LA10_2 = input.LA(3);

                    if ( (synpred18_AplusParser()) )
                    {
                        alt10 = 1;
                    }
                    else if ( (true) )
                    {
                        alt10 = 2;
                    }
                    else 
                    {
                        if ( state.backtracking > 0 ) {state.failed = true; return node;}
                        NoViableAltException nvae_d10s2 =
                            new NoViableAltException("", 10, 2, input);

                        throw nvae_d10s2;
                    }
                }
                else if ( (LA10_1 == If || (LA10_1 >= Do && LA10_1 <= LP) || LA10_1 == SemiColon || LA10_1 == LSB || LA10_1 == Int || (LA10_1 >= Float && LA10_1 <= Inf) || (LA10_1 >= CharachterConstantSQ && LA10_1 <= CharachterConstantDQ) || (LA10_1 >= SymbolConstant && LA10_1 <= SystemName)) )
                {
                    alt10 = 2;
                }
                else 
                {
                    if ( state.backtracking > 0 ) {state.failed = true; return node;}
                    NoViableAltException nvae_d10s1 =
                        new NoViableAltException("", 10, 1, input);

                    throw nvae_d10s1;
                }
            }
            else 
            {
                if ( state.backtracking > 0 ) {state.failed = true; return node;}
                NoViableAltException nvae_d10s0 =
                    new NoViableAltException("", 10, 0, input);

                throw nvae_d10s0;
            }
            switch (alt10) 
            {
                case 1 :
                    // Compiler\\Grammar\\AplusParser.g:129:4: LSB RSB
                    {
                    	Match(input,LSB,FOLLOW_LSB_in_expressionGroup727); if (state.failed) return node;
                    	Match(input,RSB,FOLLOW_RSB_in_expressionGroup729); if (state.failed) return node;
                    	if ( (state.backtracking==0) )
                    	{
                    	   node = AST.Node.ExpressionList(); 
                    	}

                    }
                    break;
                case 2 :
                    // Compiler\\Grammar\\AplusParser.g:130:4: LSB expressionList RSB
                    {
                    	Match(input,LSB,FOLLOW_LSB_in_expressionGroup743); if (state.failed) return node;
                    	PushFollow(FOLLOW_expressionList_in_expressionGroup745);
                    	expressionList24 = expressionList();
                    	state.followingStackPointer--;
                    	if (state.failed) return node;
                    	Match(input,RSB,FOLLOW_RSB_in_expressionGroup747); if (state.failed) return node;
                    	if ( (state.backtracking==0) )
                    	{
                    	   node = expressionList24; 
                    	}

                    }
                    break;

            }
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 11, expressionGroup_StartIndex); 
            }
        }
        return node;
    }
    // $ANTLR end "expressionGroup"


    // $ANTLR start "expression"
    // Compiler\\Grammar\\AplusParser.g:133:1: expression returns [AST.Node node] : ( controlStatements | lhs= dyadicLeftArg func= dyadicFunctionSelector rhs= expression | func= monadicFunctionSelector arg= expression | simpleExpression );
    public AST.Node expression() // throws RecognitionException [1]
    {   
        AST.Node node = default(AST.Node);
        int expression_StartIndex = input.Index();
        AST.Node lhs = default(AST.Node);

        AST.Node func = default(AST.Node);

        AST.Node rhs = default(AST.Node);

        AST.Node arg = default(AST.Node);

        AST.Node controlStatements25 = default(AST.Node);

        AST.Node simpleExpression26 = default(AST.Node);


        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 12) ) 
    	    {
    	    	return node; 
    	    }
            // Compiler\\Grammar\\AplusParser.g:134:2: ( controlStatements | lhs= dyadicLeftArg func= dyadicFunctionSelector rhs= expression | func= monadicFunctionSelector arg= expression | simpleExpression )
            int alt11 = 4;
            alt11 = dfa11.Predict(input);
            switch (alt11) 
            {
                case 1 :
                    // Compiler\\Grammar\\AplusParser.g:134:4: controlStatements
                    {
                    	PushFollow(FOLLOW_controlStatements_in_expression767);
                    	controlStatements25 = controlStatements();
                    	state.followingStackPointer--;
                    	if (state.failed) return node;
                    	if ( (state.backtracking==0) )
                    	{
                    	   node = controlStatements25; 
                    	}

                    }
                    break;
                case 2 :
                    // Compiler\\Grammar\\AplusParser.g:135:4: lhs= dyadicLeftArg func= dyadicFunctionSelector rhs= expression
                    {
                    	PushFollow(FOLLOW_dyadicLeftArg_in_expression783);
                    	lhs = dyadicLeftArg();
                    	state.followingStackPointer--;
                    	if (state.failed) return node;
                    	PushFollow(FOLLOW_dyadicFunctionSelector_in_expression787);
                    	func = dyadicFunctionSelector();
                    	state.followingStackPointer--;
                    	if (state.failed) return node;
                    	PushFollow(FOLLOW_expression_in_expression791);
                    	rhs = expression();
                    	state.followingStackPointer--;
                    	if (state.failed) return node;
                    	if ( (state.backtracking==0) )
                    	{

                    	  				if(func is AST.Token)
                    	  				{
                    	  					node = BuildDyadic((AST.Token)func, lhs, rhs);
                    	  				}
                    	  				else if(func is AST.Operator)
                    	  				{
                    	  					AST.Operator oper = (AST.Operator)func;
                    	  					oper.RightArgument = rhs;
                    	  					oper.LeftArgument = lhs;
                    	  					node = oper;
                    	  				}
                    	  				else if(func is AST.UserDefInvoke)
                    	  				{
                    	  					AST.UserDefInvoke funcInvoke = (AST.UserDefInvoke)func;
                    	  					funcInvoke.Arguments.AddLast(rhs);
                    	  					funcInvoke.Arguments.AddLast(lhs);
                    	  					node = funcInvoke;
                    	  				}
                    	  				else
                    	  				{
                    	  					throw new ParseException("Should Not reach this point!", false);
                    	  				}
                    	  			
                    	}

                    }
                    break;
                case 3 :
                    // Compiler\\Grammar\\AplusParser.g:160:4: func= monadicFunctionSelector arg= expression
                    {
                    	PushFollow(FOLLOW_monadicFunctionSelector_in_expression803);
                    	func = monadicFunctionSelector();
                    	state.followingStackPointer--;
                    	if (state.failed) return node;
                    	PushFollow(FOLLOW_expression_in_expression807);
                    	arg = expression();
                    	state.followingStackPointer--;
                    	if (state.failed) return node;
                    	if ( (state.backtracking==0) )
                    	{

                    	  				if(func is AST.Token)
                    	  				{
                    	  					node = BuildMonadic((AST.Token)func, arg);
                    	  				}
                    	  				else if(func is AST.Operator)
                    	  				{
                    	  					AST.Operator oper = (AST.Operator)func;
                    	  					if(arg is AST.ExpressionList)
                    	  					{
                    	  						node = AST.Node.BuiltinOpInvoke(oper, (AST.ExpressionList)arg);
                    	  					}
                    	  					else
                    	  					{
                    	  						oper.RightArgument = arg;
                    	  						node = oper;
                    	  					}
                    	  				}
                    	  				else if(func is AST.UserDefInvoke)
                    	  				{
                    	  					node = UpdateUserDefInvoke((AST.UserDefInvoke)func, arg);
                    	  				}
                    	  				else
                    	  				{
                    	  					throw new ParseException("Should Not reach this point!", false);
                    	  				}
                    	  			
                    	}

                    }
                    break;
                case 4 :
                    // Compiler\\Grammar\\AplusParser.g:188:4: simpleExpression
                    {
                    	PushFollow(FOLLOW_simpleExpression_in_expression817);
                    	simpleExpression26 = simpleExpression();
                    	state.followingStackPointer--;
                    	if (state.failed) return node;
                    	if ( (state.backtracking==0) )
                    	{
                    	   node = simpleExpression26; 
                    	}

                    }
                    break;

            }
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 12, expression_StartIndex); 
            }
        }
        return node;
    }
    // $ANTLR end "expression"


    // $ANTLR start "monadicFunctionSelector"
    // Compiler\\Grammar\\AplusParser.g:191:1: monadicFunctionSelector returns [AST.Node node] : ( operatorSymbol | functionSymbol | {...}? variableName );
    public AST.Node monadicFunctionSelector() // throws RecognitionException [1]
    {   
        AST.Node node = default(AST.Node);
        int monadicFunctionSelector_StartIndex = input.Index();
        AST.Operator operatorSymbol27 = default(AST.Operator);

        AST.Token functionSymbol28 = default(AST.Token);

        AST.Identifier variableName29 = default(AST.Identifier);


        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 13) ) 
    	    {
    	    	return node; 
    	    }
            // Compiler\\Grammar\\AplusParser.g:192:2: ( operatorSymbol | functionSymbol | {...}? variableName )
            int alt12 = 3;
            alt12 = dfa12.Predict(input);
            switch (alt12) 
            {
                case 1 :
                    // Compiler\\Grammar\\AplusParser.g:192:4: operatorSymbol
                    {
                    	PushFollow(FOLLOW_operatorSymbol_in_monadicFunctionSelector837);
                    	operatorSymbol27 = operatorSymbol();
                    	state.followingStackPointer--;
                    	if (state.failed) return node;
                    	if ( (state.backtracking==0) )
                    	{
                    	   node = operatorSymbol27; 
                    	}

                    }
                    break;
                case 2 :
                    // Compiler\\Grammar\\AplusParser.g:193:4: functionSymbol
                    {
                    	PushFollow(FOLLOW_functionSymbol_in_monadicFunctionSelector850);
                    	functionSymbol28 = functionSymbol();
                    	state.followingStackPointer--;
                    	if (state.failed) return node;
                    	if ( (state.backtracking==0) )
                    	{
                    	   node = functionSymbol28; 
                    	}

                    }
                    break;
                case 3 :
                    // Compiler\\Grammar\\AplusParser.g:194:4: {...}? variableName
                    {
                    	if ( !((  IsGlobalFunction(input.LT(1)) )) ) 
                    	{
                    	    if ( state.backtracking > 0 ) {state.failed = true; return node;}
                    	    throw new FailedPredicateException(input, "monadicFunctionSelector", "  IsGlobalFunction(input.LT(1)) ");
                    	}
                    	PushFollow(FOLLOW_variableName_in_monadicFunctionSelector865);
                    	variableName29 = variableName();
                    	state.followingStackPointer--;
                    	if (state.failed) return node;
                    	if ( (state.backtracking==0) )
                    	{
                    	   node = AST.Node.UserDefInvoke(variableName29, AST.Node.ExpressionList()); 
                    	}

                    }
                    break;

            }
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 13, monadicFunctionSelector_StartIndex); 
            }
        }
        return node;
    }
    // $ANTLR end "monadicFunctionSelector"


    // $ANTLR start "dyadicFunctionSelector"
    // Compiler\\Grammar\\AplusParser.g:199:1: dyadicFunctionSelector returns [AST.Node node] : ( operatorSymbol | functionSymbol | {...}? variableName );
    public AST.Node dyadicFunctionSelector() // throws RecognitionException [1]
    {   
        AST.Node node = default(AST.Node);
        int dyadicFunctionSelector_StartIndex = input.Index();
        AST.Operator operatorSymbol30 = default(AST.Operator);

        AST.Token functionSymbol31 = default(AST.Token);

        AST.Identifier variableName32 = default(AST.Identifier);


        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 14) ) 
    	    {
    	    	return node; 
    	    }
            // Compiler\\Grammar\\AplusParser.g:200:2: ( operatorSymbol | functionSymbol | {...}? variableName )
            int alt13 = 3;
            alt13 = dfa13.Predict(input);
            switch (alt13) 
            {
                case 1 :
                    // Compiler\\Grammar\\AplusParser.g:200:4: operatorSymbol
                    {
                    	PushFollow(FOLLOW_operatorSymbol_in_dyadicFunctionSelector888);
                    	operatorSymbol30 = operatorSymbol();
                    	state.followingStackPointer--;
                    	if (state.failed) return node;
                    	if ( (state.backtracking==0) )
                    	{
                    	   node = operatorSymbol30; 
                    	}

                    }
                    break;
                case 2 :
                    // Compiler\\Grammar\\AplusParser.g:201:4: functionSymbol
                    {
                    	PushFollow(FOLLOW_functionSymbol_in_dyadicFunctionSelector901);
                    	functionSymbol31 = functionSymbol();
                    	state.followingStackPointer--;
                    	if (state.failed) return node;
                    	if ( (state.backtracking==0) )
                    	{
                    	   node = functionSymbol31; 
                    	}

                    }
                    break;
                case 3 :
                    // Compiler\\Grammar\\AplusParser.g:202:4: {...}? variableName
                    {
                    	if ( !((  IsGlobalFunction(input.LT(1)) )) ) 
                    	{
                    	    if ( state.backtracking > 0 ) {state.failed = true; return node;}
                    	    throw new FailedPredicateException(input, "dyadicFunctionSelector", "  IsGlobalFunction(input.LT(1)) ");
                    	}
                    	PushFollow(FOLLOW_variableName_in_dyadicFunctionSelector916);
                    	variableName32 = variableName();
                    	state.followingStackPointer--;
                    	if (state.failed) return node;
                    	if ( (state.backtracking==0) )
                    	{
                    	   node = AST.Node.UserDefInvoke(variableName32, AST.Node.ExpressionList()); 
                    	}

                    }
                    break;

            }
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 14, dyadicFunctionSelector_StartIndex); 
            }
        }
        return node;
    }
    // $ANTLR end "dyadicFunctionSelector"


    // $ANTLR start "dyadicLeftArg"
    // Compiler\\Grammar\\AplusParser.g:206:1: dyadicLeftArg returns [AST.Node node] : ( operatorSymbol expressionGroup | functionSymbol expressionGroup | simpleExpression );
    public AST.Node dyadicLeftArg() // throws RecognitionException [1]
    {   
        AST.Node node = default(AST.Node);
        int dyadicLeftArg_StartIndex = input.Index();
        AST.Operator operatorSymbol33 = default(AST.Operator);

        AST.ExpressionList expressionGroup34 = default(AST.ExpressionList);

        AST.Token functionSymbol35 = default(AST.Token);

        AST.ExpressionList expressionGroup36 = default(AST.ExpressionList);

        AST.Node simpleExpression37 = default(AST.Node);


        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 15) ) 
    	    {
    	    	return node; 
    	    }
            // Compiler\\Grammar\\AplusParser.g:207:2: ( operatorSymbol expressionGroup | functionSymbol expressionGroup | simpleExpression )
            int alt14 = 3;
            alt14 = dfa14.Predict(input);
            switch (alt14) 
            {
                case 1 :
                    // Compiler\\Grammar\\AplusParser.g:207:4: operatorSymbol expressionGroup
                    {
                    	PushFollow(FOLLOW_operatorSymbol_in_dyadicLeftArg938);
                    	operatorSymbol33 = operatorSymbol();
                    	state.followingStackPointer--;
                    	if (state.failed) return node;
                    	PushFollow(FOLLOW_expressionGroup_in_dyadicLeftArg940);
                    	expressionGroup34 = expressionGroup();
                    	state.followingStackPointer--;
                    	if (state.failed) return node;
                    	if ( (state.backtracking==0) )
                    	{
                    	   node = AST.Node.BuiltinOpInvoke(operatorSymbol33, expressionGroup34); 
                    	}

                    }
                    break;
                case 2 :
                    // Compiler\\Grammar\\AplusParser.g:208:4: functionSymbol expressionGroup
                    {
                    	PushFollow(FOLLOW_functionSymbol_in_dyadicLeftArg949);
                    	functionSymbol35 = functionSymbol();
                    	state.followingStackPointer--;
                    	if (state.failed) return node;
                    	PushFollow(FOLLOW_expressionGroup_in_dyadicLeftArg951);
                    	expressionGroup36 = expressionGroup();
                    	state.followingStackPointer--;
                    	if (state.failed) return node;
                    	if ( (state.backtracking==0) )
                    	{
                    	   node = AST.Node.BuiltinInvoke(functionSymbol35, (AST.ExpressionList)expressionGroup36); 
                    	}

                    }
                    break;
                case 3 :
                    // Compiler\\Grammar\\AplusParser.g:209:4: simpleExpression
                    {
                    	PushFollow(FOLLOW_simpleExpression_in_dyadicLeftArg960);
                    	simpleExpression37 = simpleExpression();
                    	state.followingStackPointer--;
                    	if (state.failed) return node;
                    	if ( (state.backtracking==0) )
                    	{
                    	   node = simpleExpression37; 
                    	}

                    }
                    break;

            }
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 15, dyadicLeftArg_StartIndex); 
            }
        }
        return node;
    }
    // $ANTLR end "dyadicLeftArg"


    // $ANTLR start "operatorSymbol"
    // Compiler\\Grammar\\AplusParser.g:212:1: operatorSymbol returns [AST.Operator node] : ( opArg ( opTail )+ | LP op= operatorSymbol RP );
    public AST.Operator operatorSymbol() // throws RecognitionException [1]
    {   
        AST.Operator node = default(AST.Operator);
        int operatorSymbol_StartIndex = input.Index();
        AST.Operator op = default(AST.Operator);

        AST.Node opArg38 = default(AST.Node);

        AST.Operator opTail39 = default(AST.Operator);


         AST.Node func = null; 
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 16) ) 
    	    {
    	    	return node; 
    	    }
            // Compiler\\Grammar\\AplusParser.g:214:2: ( opArg ( opTail )+ | LP op= operatorSymbol RP )
            int alt16 = 2;
            alt16 = dfa16.Predict(input);
            switch (alt16) 
            {
                case 1 :
                    // Compiler\\Grammar\\AplusParser.g:215:3: opArg ( opTail )+
                    {
                    	PushFollow(FOLLOW_opArg_in_operatorSymbol990);
                    	opArg38 = opArg();
                    	state.followingStackPointer--;
                    	if (state.failed) return node;
                    	if ( (state.backtracking==0) )
                    	{
                    	   func = opArg38; 
                    	}
                    	// Compiler\\Grammar\\AplusParser.g:216:3: ( opTail )+
                    	int cnt15 = 0;
                    	do 
                    	{
                    	    int alt15 = 2;
                    	    switch ( input.LA(1) ) 
                    	    {
                    	    case SystemName:
                    	    	{
                    	        int LA15_2 = input.LA(2);

                    	        if ( (((synpred28_AplusParser() && ( IsMonadicOperator(input.LT(1)) ))|| (synpred28_AplusParser() && ( IsDyadicOperator(input.LT(1)) )))) )
                    	        {
                    	            alt15 = 1;
                    	        }


                    	        }
                    	        break;
                    	    case QualifiedName:
                    	    	{
                    	        int LA15_3 = input.LA(2);

                    	        if ( (((synpred28_AplusParser() && ( IsMonadicOperator(input.LT(1)) ))|| (synpred28_AplusParser() && ( IsDyadicOperator(input.LT(1)) )))) )
                    	        {
                    	            alt15 = 1;
                    	        }


                    	        }
                    	        break;
                    	    case UnqualifiedName:
                    	    	{
                    	        int LA15_4 = input.LA(2);

                    	        if ( (((synpred28_AplusParser() && ( IsMonadicOperator(input.LT(1)) ))|| (synpred28_AplusParser() && ( IsDyadicOperator(input.LT(1)) )))) )
                    	        {
                    	            alt15 = 1;
                    	        }


                    	        }
                    	        break;
                    	    case Each:
                    	    case Rank:
                    	    	{
                    	        alt15 = 1;
                    	        }
                    	        break;

                    	    }

                    	    switch (alt15) 
                    		{
                    			case 1 :
                    			    // Compiler\\Grammar\\AplusParser.g:217:4: opTail
                    			    {
                    			    	PushFollow(FOLLOW_opTail_in_operatorSymbol1005);
                    			    	opTail39 = opTail();
                    			    	state.followingStackPointer--;
                    			    	if (state.failed) return node;
                    			    	if ( (state.backtracking==0) )
                    			    	{
                    			    	   
                    			    	  									if(func is AST.Operator)
                    			    	  									{
                    			    	  										// Found an operator, wrap it as a Built-in operator
                    			    	  										opTail39.Function = AST.Node.BuiltInOperator((AST.Operator)func);
                    			    	  									}
                    			    	  									else
                    			    	  									{
                    			    	  										opTail39.Function = func; 
                    			    	  									}
                    			    	  									node = opTail39;
                    			    	  									func = node;
                    			    	  								
                    			    	}

                    			    }
                    			    break;

                    			default:
                    			    if ( cnt15 >= 1 ) goto loop15;
                    			    if ( state.backtracking > 0 ) {state.failed = true; return node;}
                    		            EarlyExitException eee15 =
                    		                new EarlyExitException(15, input);
                    		            throw eee15;
                    	    }
                    	    cnt15++;
                    	} while (true);

                    	loop15:
                    		;	// Stops C# compiler whining that label 'loop15' has no statements


                    }
                    break;
                case 2 :
                    // Compiler\\Grammar\\AplusParser.g:231:4: LP op= operatorSymbol RP
                    {
                    	Match(input,LP,FOLLOW_LP_in_operatorSymbol1020); if (state.failed) return node;
                    	PushFollow(FOLLOW_operatorSymbol_in_operatorSymbol1024);
                    	op = operatorSymbol();
                    	state.followingStackPointer--;
                    	if (state.failed) return node;
                    	Match(input,RP,FOLLOW_RP_in_operatorSymbol1026); if (state.failed) return node;
                    	if ( (state.backtracking==0) )
                    	{
                    	   node = op; 
                    	}

                    }
                    break;

            }
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 16, operatorSymbol_StartIndex); 
            }
        }
        return node;
    }
    // $ANTLR end "operatorSymbol"


    // $ANTLR start "opArg"
    // Compiler\\Grammar\\AplusParser.g:234:1: opArg returns [AST.Node node] : ( functionSymbol | termExpression );
    public AST.Node opArg() // throws RecognitionException [1]
    {   
        AST.Node node = default(AST.Node);
        int opArg_StartIndex = input.Index();
        AST.Token functionSymbol40 = default(AST.Token);

        AST.Node termExpression41 = default(AST.Node);


        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 17) ) 
    	    {
    	    	return node; 
    	    }
            // Compiler\\Grammar\\AplusParser.g:235:2: ( functionSymbol | termExpression )
            int alt17 = 2;
            alt17 = dfa17.Predict(input);
            switch (alt17) 
            {
                case 1 :
                    // Compiler\\Grammar\\AplusParser.g:235:4: functionSymbol
                    {
                    	PushFollow(FOLLOW_functionSymbol_in_opArg1046);
                    	functionSymbol40 = functionSymbol();
                    	state.followingStackPointer--;
                    	if (state.failed) return node;
                    	if ( (state.backtracking==0) )
                    	{
                    	   node = functionSymbol40; 
                    	}

                    }
                    break;
                case 2 :
                    // Compiler\\Grammar\\AplusParser.g:236:4: termExpression
                    {
                    	PushFollow(FOLLOW_termExpression_in_opArg1058);
                    	termExpression41 = termExpression();
                    	state.followingStackPointer--;
                    	if (state.failed) return node;
                    	if ( (state.backtracking==0) )
                    	{
                    	   node = termExpression41; 
                    	}

                    }
                    break;

            }
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 17, opArg_StartIndex); 
            }
        }
        return node;
    }
    // $ANTLR end "opArg"


    // $ANTLR start "opTail"
    // Compiler\\Grammar\\AplusParser.g:239:1: opTail returns [AST.Operator node] : ( Each | Rank condition | {...}? variableName ( condition | functionSymbol ) | {...}? variableName );
    public AST.Operator opTail() // throws RecognitionException [1]
    {   
        AST.Operator node = default(AST.Operator);
        int opTail_StartIndex = input.Index();
        IToken Each42 = null;
        IToken Rank43 = null;
        AST.Node condition44 = default(AST.Node);

        AST.Identifier variableName45 = default(AST.Identifier);

        AST.Node condition46 = default(AST.Node);

        AST.Token functionSymbol47 = default(AST.Token);

        AST.Identifier variableName48 = default(AST.Identifier);


        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 18) ) 
    	    {
    	    	return node; 
    	    }
            // Compiler\\Grammar\\AplusParser.g:240:2: ( Each | Rank condition | {...}? variableName ( condition | functionSymbol ) | {...}? variableName )
            int alt19 = 4;
            switch ( input.LA(1) ) 
            {
            case Each:
            	{
                alt19 = 1;
                }
                break;
            case Rank:
            	{
                alt19 = 2;
                }
                break;
            case SystemName:
            	{
                int LA19_3 = input.LA(2);

                if ( ((synpred34_AplusParser() && ( IsDyadicOperator(input.LT(1)) ))) )
                {
                    alt19 = 3;
                }
                else if ( (( IsMonadicOperator(input.LT(1)) )) )
                {
                    alt19 = 4;
                }
                else 
                {
                    if ( state.backtracking > 0 ) {state.failed = true; return node;}
                    NoViableAltException nvae_d19s3 =
                        new NoViableAltException("", 19, 3, input);

                    throw nvae_d19s3;
                }
                }
                break;
            case QualifiedName:
            	{
                int LA19_4 = input.LA(2);

                if ( ((synpred34_AplusParser() && ( IsDyadicOperator(input.LT(1)) ))) )
                {
                    alt19 = 3;
                }
                else if ( (( IsMonadicOperator(input.LT(1)) )) )
                {
                    alt19 = 4;
                }
                else 
                {
                    if ( state.backtracking > 0 ) {state.failed = true; return node;}
                    NoViableAltException nvae_d19s4 =
                        new NoViableAltException("", 19, 4, input);

                    throw nvae_d19s4;
                }
                }
                break;
            case UnqualifiedName:
            	{
                int LA19_5 = input.LA(2);

                if ( ((synpred34_AplusParser() && ( IsDyadicOperator(input.LT(1)) ))) )
                {
                    alt19 = 3;
                }
                else if ( (( IsMonadicOperator(input.LT(1)) )) )
                {
                    alt19 = 4;
                }
                else 
                {
                    if ( state.backtracking > 0 ) {state.failed = true; return node;}
                    NoViableAltException nvae_d19s5 =
                        new NoViableAltException("", 19, 5, input);

                    throw nvae_d19s5;
                }
                }
                break;
            	default:
            	    if ( state.backtracking > 0 ) {state.failed = true; return node;}
            	    NoViableAltException nvae_d19s0 =
            	        new NoViableAltException("", 19, 0, input);

            	    throw nvae_d19s0;
            }

            switch (alt19) 
            {
                case 1 :
                    // Compiler\\Grammar\\AplusParser.g:240:4: Each
                    {
                    	Each42=(IToken)Match(input,Each,FOLLOW_Each_in_opTail1080); if (state.failed) return node;
                    	if ( (state.backtracking==0) )
                    	{
                    	   node = AST.Node.EachOperator(new AST.Token(Tokens.EACH, Each42.Text)); 
                    	}

                    }
                    break;
                case 2 :
                    // Compiler\\Grammar\\AplusParser.g:241:4: Rank condition
                    {
                    	Rank43=(IToken)Match(input,Rank,FOLLOW_Rank_in_opTail1094); if (state.failed) return node;
                    	PushFollow(FOLLOW_condition_in_opTail1096);
                    	condition44 = condition();
                    	state.followingStackPointer--;
                    	if (state.failed) return node;
                    	if ( (state.backtracking==0) )
                    	{
                    	   node = AST.Node.RankOperator(new AST.Token(Tokens.RANK, Rank43.Text));
                    	  											  ((AST.RankOperator)node).Condition = condition44; 
                    	}

                    }
                    break;
                case 3 :
                    // Compiler\\Grammar\\AplusParser.g:243:4: {...}? variableName ( condition | functionSymbol )
                    {
                    	if ( !(( IsDyadicOperator(input.LT(1)) )) ) 
                    	{
                    	    if ( state.backtracking > 0 ) {state.failed = true; return node;}
                    	    throw new FailedPredicateException(input, "opTail", " IsDyadicOperator(input.LT(1)) ");
                    	}
                    	PushFollow(FOLLOW_variableName_in_opTail1110);
                    	variableName45 = variableName();
                    	state.followingStackPointer--;
                    	if (state.failed) return node;
                    	// Compiler\\Grammar\\AplusParser.g:243:52: ( condition | functionSymbol )
                    	int alt18 = 2;
                    	alt18 = dfa18.Predict(input);
                    	switch (alt18) 
                    	{
                    	    case 1 :
                    	        // Compiler\\Grammar\\AplusParser.g:243:53: condition
                    	        {
                    	        	PushFollow(FOLLOW_condition_in_opTail1113);
                    	        	condition46 = condition();
                    	        	state.followingStackPointer--;
                    	        	if (state.failed) return node;

                    	        }
                    	        break;
                    	    case 2 :
                    	        // Compiler\\Grammar\\AplusParser.g:243:65: functionSymbol
                    	        {
                    	        	PushFollow(FOLLOW_functionSymbol_in_opTail1117);
                    	        	functionSymbol47 = functionSymbol();
                    	        	state.followingStackPointer--;
                    	        	if (state.failed) return node;

                    	        }
                    	        break;

                    	}

                    	if ( (state.backtracking==0) )
                    	{
                    	   
                    	  			node = AST.Node.UserDefOperatorInvoke(variableName45, condition46 ?? functionSymbol47); 
                    	  		
                    	}

                    }
                    break;
                case 4 :
                    // Compiler\\Grammar\\AplusParser.g:247:4: {...}? variableName
                    {
                    	if ( !(( IsMonadicOperator(input.LT(1)) )) ) 
                    	{
                    	    if ( state.backtracking > 0 ) {state.failed = true; return node;}
                    	    throw new FailedPredicateException(input, "opTail", " IsMonadicOperator(input.LT(1)) ");
                    	}
                    	PushFollow(FOLLOW_variableName_in_opTail1131);
                    	variableName48 = variableName();
                    	state.followingStackPointer--;
                    	if (state.failed) return node;
                    	if ( (state.backtracking==0) )
                    	{
                    	    node = AST.Node.UserDefOperatorInvoke(variableName48, null);  
                    	}

                    }
                    break;

            }
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 18, opTail_StartIndex); 
            }
        }
        return node;
    }
    // $ANTLR end "opTail"


    // $ANTLR start "functionSymbol"
    // Compiler\\Grammar\\AplusParser.g:250:1: functionSymbol returns [AST.Token token] : ( LP sym= functionSymbol RP | t= AbsoluteValue | t= Ceiling | t= Count | t= DefaultFormat | t= Depth | t= Disclose | t= Enclose | t= Execute | t= Exponential | t= Floor | t= GradeDown | t= GradeUp | t= Identity | t= Interval | t= ItemRavel | t= MapIn | t= MatrixInverse | t= NaturalLog | t= Negate | t= Not | t= Null | t= Pack | t= PartitionCount | t= PiTimes | t= Print | t= Rake | t= Raze | t= Ravel | t= Reciprocal | t= Result | t= Reverse | t= Roll | t= Right | t= SeparateSymbols | t= Shape | t= Sign | t= Signal | t= Stop | t= Transpose | t= Unpack | t= Value | t= Or | t= IPAddMultiply | t= IPMaxAdd | t= IPMinAdd | t= OPAdd | t= OPDivide | t= OPEqual | t= OPGT | t= OPGTE | t= OPLT | t= OPLTE | t= OPMax | t= OPMin | t= OPMultiply | t= OPNotEqual | t= OPResidue | t= OPSubstract | t= OPPower | t= RAdd | t= RAnd | t= RMax | t= RMin | t= RMultiply | t= ROr | t= SAdd | t= SAnd | t= SMax | t= SMin | t= SMultiply | t= SOr | t= Equal | t= Expand | t= GTE | t= LTE | t= NotEqual | t= Replicate | t= BWNot | t= BWAnd | t= BWOr | t= BWLT | t= BWLTE | t= BWGT | t= BWGTE | t= BWEqual | t= BWNotEqual | Do );
    public AST.Token functionSymbol() // throws RecognitionException [1]
    {   
        AST.Token token = default(AST.Token);
        int functionSymbol_StartIndex = input.Index();
        IToken t = null;
        AST.Token sym = default(AST.Token);


        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 19) ) 
    	    {
    	    	return token; 
    	    }
            // Compiler\\Grammar\\AplusParser.g:251:2: ( LP sym= functionSymbol RP | t= AbsoluteValue | t= Ceiling | t= Count | t= DefaultFormat | t= Depth | t= Disclose | t= Enclose | t= Execute | t= Exponential | t= Floor | t= GradeDown | t= GradeUp | t= Identity | t= Interval | t= ItemRavel | t= MapIn | t= MatrixInverse | t= NaturalLog | t= Negate | t= Not | t= Null | t= Pack | t= PartitionCount | t= PiTimes | t= Print | t= Rake | t= Raze | t= Ravel | t= Reciprocal | t= Result | t= Reverse | t= Roll | t= Right | t= SeparateSymbols | t= Shape | t= Sign | t= Signal | t= Stop | t= Transpose | t= Unpack | t= Value | t= Or | t= IPAddMultiply | t= IPMaxAdd | t= IPMinAdd | t= OPAdd | t= OPDivide | t= OPEqual | t= OPGT | t= OPGTE | t= OPLT | t= OPLTE | t= OPMax | t= OPMin | t= OPMultiply | t= OPNotEqual | t= OPResidue | t= OPSubstract | t= OPPower | t= RAdd | t= RAnd | t= RMax | t= RMin | t= RMultiply | t= ROr | t= SAdd | t= SAnd | t= SMax | t= SMin | t= SMultiply | t= SOr | t= Equal | t= Expand | t= GTE | t= LTE | t= NotEqual | t= Replicate | t= BWNot | t= BWAnd | t= BWOr | t= BWLT | t= BWLTE | t= BWGT | t= BWGTE | t= BWEqual | t= BWNotEqual | Do )
            int alt20 = 88;
            switch ( input.LA(1) ) 
            {
            case LP:
            	{
                alt20 = 1;
                }
                break;
            case AbsoluteValue:
            	{
                alt20 = 2;
                }
                break;
            case Ceiling:
            	{
                alt20 = 3;
                }
                break;
            case Count:
            	{
                alt20 = 4;
                }
                break;
            case DefaultFormat:
            	{
                alt20 = 5;
                }
                break;
            case Depth:
            	{
                alt20 = 6;
                }
                break;
            case Disclose:
            	{
                alt20 = 7;
                }
                break;
            case Enclose:
            	{
                alt20 = 8;
                }
                break;
            case Execute:
            	{
                alt20 = 9;
                }
                break;
            case Exponential:
            	{
                alt20 = 10;
                }
                break;
            case Floor:
            	{
                alt20 = 11;
                }
                break;
            case GradeDown:
            	{
                alt20 = 12;
                }
                break;
            case GradeUp:
            	{
                alt20 = 13;
                }
                break;
            case Identity:
            	{
                alt20 = 14;
                }
                break;
            case Interval:
            	{
                alt20 = 15;
                }
                break;
            case ItemRavel:
            	{
                alt20 = 16;
                }
                break;
            case MapIn:
            	{
                alt20 = 17;
                }
                break;
            case MatrixInverse:
            	{
                alt20 = 18;
                }
                break;
            case NaturalLog:
            	{
                alt20 = 19;
                }
                break;
            case Negate:
            	{
                alt20 = 20;
                }
                break;
            case Not:
            	{
                alt20 = 21;
                }
                break;
            case Null:
            	{
                alt20 = 22;
                }
                break;
            case Pack:
            	{
                alt20 = 23;
                }
                break;
            case PartitionCount:
            	{
                alt20 = 24;
                }
                break;
            case PiTimes:
            	{
                alt20 = 25;
                }
                break;
            case Print:
            	{
                alt20 = 26;
                }
                break;
            case Rake:
            	{
                alt20 = 27;
                }
                break;
            case Raze:
            	{
                alt20 = 28;
                }
                break;
            case Ravel:
            	{
                alt20 = 29;
                }
                break;
            case Reciprocal:
            	{
                alt20 = 30;
                }
                break;
            case Result:
            	{
                alt20 = 31;
                }
                break;
            case Reverse:
            	{
                alt20 = 32;
                }
                break;
            case Roll:
            	{
                alt20 = 33;
                }
                break;
            case Right:
            	{
                alt20 = 34;
                }
                break;
            case SeparateSymbols:
            	{
                alt20 = 35;
                }
                break;
            case Shape:
            	{
                alt20 = 36;
                }
                break;
            case Sign:
            	{
                alt20 = 37;
                }
                break;
            case Signal:
            	{
                alt20 = 38;
                }
                break;
            case Stop:
            	{
                alt20 = 39;
                }
                break;
            case Transpose:
            	{
                alt20 = 40;
                }
                break;
            case Unpack:
            	{
                alt20 = 41;
                }
                break;
            case Value:
            	{
                alt20 = 42;
                }
                break;
            case Or:
            	{
                alt20 = 43;
                }
                break;
            case IPAddMultiply:
            	{
                alt20 = 44;
                }
                break;
            case IPMaxAdd:
            	{
                alt20 = 45;
                }
                break;
            case IPMinAdd:
            	{
                alt20 = 46;
                }
                break;
            case OPAdd:
            	{
                alt20 = 47;
                }
                break;
            case OPDivide:
            	{
                alt20 = 48;
                }
                break;
            case OPEqual:
            	{
                alt20 = 49;
                }
                break;
            case OPGT:
            	{
                alt20 = 50;
                }
                break;
            case OPGTE:
            	{
                alt20 = 51;
                }
                break;
            case OPLT:
            	{
                alt20 = 52;
                }
                break;
            case OPLTE:
            	{
                alt20 = 53;
                }
                break;
            case OPMax:
            	{
                alt20 = 54;
                }
                break;
            case OPMin:
            	{
                alt20 = 55;
                }
                break;
            case OPMultiply:
            	{
                alt20 = 56;
                }
                break;
            case OPNotEqual:
            	{
                alt20 = 57;
                }
                break;
            case OPResidue:
            	{
                alt20 = 58;
                }
                break;
            case OPSubstract:
            	{
                alt20 = 59;
                }
                break;
            case OPPower:
            	{
                alt20 = 60;
                }
                break;
            case RAdd:
            	{
                alt20 = 61;
                }
                break;
            case RAnd:
            	{
                alt20 = 62;
                }
                break;
            case RMax:
            	{
                alt20 = 63;
                }
                break;
            case RMin:
            	{
                alt20 = 64;
                }
                break;
            case RMultiply:
            	{
                alt20 = 65;
                }
                break;
            case ROr:
            	{
                alt20 = 66;
                }
                break;
            case SAdd:
            	{
                alt20 = 67;
                }
                break;
            case SAnd:
            	{
                alt20 = 68;
                }
                break;
            case SMax:
            	{
                alt20 = 69;
                }
                break;
            case SMin:
            	{
                alt20 = 70;
                }
                break;
            case SMultiply:
            	{
                alt20 = 71;
                }
                break;
            case SOr:
            	{
                alt20 = 72;
                }
                break;
            case Equal:
            	{
                alt20 = 73;
                }
                break;
            case Expand:
            	{
                alt20 = 74;
                }
                break;
            case GTE:
            	{
                alt20 = 75;
                }
                break;
            case LTE:
            	{
                alt20 = 76;
                }
                break;
            case NotEqual:
            	{
                alt20 = 77;
                }
                break;
            case Replicate:
            	{
                alt20 = 78;
                }
                break;
            case BWNot:
            	{
                alt20 = 79;
                }
                break;
            case BWAnd:
            	{
                alt20 = 80;
                }
                break;
            case BWOr:
            	{
                alt20 = 81;
                }
                break;
            case BWLT:
            	{
                alt20 = 82;
                }
                break;
            case BWLTE:
            	{
                alt20 = 83;
                }
                break;
            case BWGT:
            	{
                alt20 = 84;
                }
                break;
            case BWGTE:
            	{
                alt20 = 85;
                }
                break;
            case BWEqual:
            	{
                alt20 = 86;
                }
                break;
            case BWNotEqual:
            	{
                alt20 = 87;
                }
                break;
            case Do:
            	{
                alt20 = 88;
                }
                break;
            	default:
            	    if ( state.backtracking > 0 ) {state.failed = true; return token;}
            	    NoViableAltException nvae_d20s0 =
            	        new NoViableAltException("", 20, 0, input);

            	    throw nvae_d20s0;
            }

            switch (alt20) 
            {
                case 1 :
                    // Compiler\\Grammar\\AplusParser.g:251:4: LP sym= functionSymbol RP
                    {
                    	Match(input,LP,FOLLOW_LP_in_functionSymbol1148); if (state.failed) return token;
                    	PushFollow(FOLLOW_functionSymbol_in_functionSymbol1152);
                    	sym = functionSymbol();
                    	state.followingStackPointer--;
                    	if (state.failed) return token;
                    	Match(input,RP,FOLLOW_RP_in_functionSymbol1154); if (state.failed) return token;
                    	if ( (state.backtracking==0) )
                    	{
                    	   token = sym; 
                    	}

                    }
                    break;
                case 2 :
                    // Compiler\\Grammar\\AplusParser.g:253:4: t= AbsoluteValue
                    {
                    	t=(IToken)Match(input,AbsoluteValue,FOLLOW_AbsoluteValue_in_functionSymbol1167); if (state.failed) return token;
                    	if ( (state.backtracking==0) )
                    	{
                    	   token = new AST.Token(Tokens.ABSOLUTEVALUE, t.Text); 
                    	}

                    }
                    break;
                case 3 :
                    // Compiler\\Grammar\\AplusParser.g:254:4: t= Ceiling
                    {
                    	t=(IToken)Match(input,Ceiling,FOLLOW_Ceiling_in_functionSymbol1181); if (state.failed) return token;
                    	if ( (state.backtracking==0) )
                    	{
                    	   token = new AST.Token(Tokens.CEILING, t.Text); 
                    	}

                    }
                    break;
                case 4 :
                    // Compiler\\Grammar\\AplusParser.g:255:4: t= Count
                    {
                    	t=(IToken)Match(input,Count,FOLLOW_Count_in_functionSymbol1196); if (state.failed) return token;
                    	if ( (state.backtracking==0) )
                    	{
                    	   token = new AST.Token(Tokens.COUNT, t.Text); 
                    	}

                    }
                    break;
                case 5 :
                    // Compiler\\Grammar\\AplusParser.g:256:4: t= DefaultFormat
                    {
                    	t=(IToken)Match(input,DefaultFormat,FOLLOW_DefaultFormat_in_functionSymbol1212); if (state.failed) return token;
                    	if ( (state.backtracking==0) )
                    	{
                    	   token = new AST.Token(Tokens.DEFAULTFORMAT, t.Text); 
                    	}

                    }
                    break;
                case 6 :
                    // Compiler\\Grammar\\AplusParser.g:257:4: t= Depth
                    {
                    	t=(IToken)Match(input,Depth,FOLLOW_Depth_in_functionSymbol1226); if (state.failed) return token;
                    	if ( (state.backtracking==0) )
                    	{
                    	   token = new AST.Token(Tokens.DEPTH, ((t != null) ? t.Text : null)); 
                    	}

                    }
                    break;
                case 7 :
                    // Compiler\\Grammar\\AplusParser.g:258:4: t= Disclose
                    {
                    	t=(IToken)Match(input,Disclose,FOLLOW_Disclose_in_functionSymbol1242); if (state.failed) return token;
                    	if ( (state.backtracking==0) )
                    	{
                    	   token = new AST.Token(Tokens.DISCLOSE, t.Text); 
                    	}

                    }
                    break;
                case 8 :
                    // Compiler\\Grammar\\AplusParser.g:259:4: t= Enclose
                    {
                    	t=(IToken)Match(input,Enclose,FOLLOW_Enclose_in_functionSymbol1257); if (state.failed) return token;
                    	if ( (state.backtracking==0) )
                    	{
                    	   token = new AST.Token(Tokens.ENCLOSE, t.Text); 
                    	}

                    }
                    break;
                case 9 :
                    // Compiler\\Grammar\\AplusParser.g:260:4: t= Execute
                    {
                    	t=(IToken)Match(input,Execute,FOLLOW_Execute_in_functionSymbol1272); if (state.failed) return token;
                    	if ( (state.backtracking==0) )
                    	{
                    	   token = new AST.Token(Tokens.EXECUTE, t.Text); 
                    	}

                    }
                    break;
                case 10 :
                    // Compiler\\Grammar\\AplusParser.g:261:4: t= Exponential
                    {
                    	t=(IToken)Match(input,Exponential,FOLLOW_Exponential_in_functionSymbol1287); if (state.failed) return token;
                    	if ( (state.backtracking==0) )
                    	{
                    	   token = new AST.Token(Tokens.EXPONENTIAL, t.Text); 
                    	}

                    }
                    break;
                case 11 :
                    // Compiler\\Grammar\\AplusParser.g:262:4: t= Floor
                    {
                    	t=(IToken)Match(input,Floor,FOLLOW_Floor_in_functionSymbol1301); if (state.failed) return token;
                    	if ( (state.backtracking==0) )
                    	{
                    	   token = new AST.Token(Tokens.FLOOR, t.Text); 
                    	}

                    }
                    break;
                case 12 :
                    // Compiler\\Grammar\\AplusParser.g:263:4: t= GradeDown
                    {
                    	t=(IToken)Match(input,GradeDown,FOLLOW_GradeDown_in_functionSymbol1317); if (state.failed) return token;
                    	if ( (state.backtracking==0) )
                    	{
                    	   token = new AST.Token(Tokens.GRADEDOWN, t.Text); 
                    	}

                    }
                    break;
                case 13 :
                    // Compiler\\Grammar\\AplusParser.g:264:4: t= GradeUp
                    {
                    	t=(IToken)Match(input,GradeUp,FOLLOW_GradeUp_in_functionSymbol1332); if (state.failed) return token;
                    	if ( (state.backtracking==0) )
                    	{
                    	   token = new AST.Token(Tokens.GRADEUP, t.Text); 
                    	}

                    }
                    break;
                case 14 :
                    // Compiler\\Grammar\\AplusParser.g:265:4: t= Identity
                    {
                    	t=(IToken)Match(input,Identity,FOLLOW_Identity_in_functionSymbol1347); if (state.failed) return token;
                    	if ( (state.backtracking==0) )
                    	{
                    	   token = new AST.Token(Tokens.IDENTITY, t.Text); 
                    	}

                    }
                    break;
                case 15 :
                    // Compiler\\Grammar\\AplusParser.g:266:4: t= Interval
                    {
                    	t=(IToken)Match(input,Interval,FOLLOW_Interval_in_functionSymbol1362); if (state.failed) return token;
                    	if ( (state.backtracking==0) )
                    	{
                    	   token = new AST.Token(Tokens.INTERVAL, t.Text); 
                    	}

                    }
                    break;
                case 16 :
                    // Compiler\\Grammar\\AplusParser.g:267:4: t= ItemRavel
                    {
                    	t=(IToken)Match(input,ItemRavel,FOLLOW_ItemRavel_in_functionSymbol1377); if (state.failed) return token;
                    	if ( (state.backtracking==0) )
                    	{
                    	   token = new AST.Token(Tokens.ITEMRAVEL, t.Text); 
                    	}

                    }
                    break;
                case 17 :
                    // Compiler\\Grammar\\AplusParser.g:268:4: t= MapIn
                    {
                    	t=(IToken)Match(input,MapIn,FOLLOW_MapIn_in_functionSymbol1392); if (state.failed) return token;
                    	if ( (state.backtracking==0) )
                    	{
                    	   token = new AST.Token(Tokens.MAPIN, t.Text); 
                    	}

                    }
                    break;
                case 18 :
                    // Compiler\\Grammar\\AplusParser.g:269:4: t= MatrixInverse
                    {
                    	t=(IToken)Match(input,MatrixInverse,FOLLOW_MatrixInverse_in_functionSymbol1408); if (state.failed) return token;
                    	if ( (state.backtracking==0) )
                    	{
                    	   token = new AST.Token(Tokens.MATRIXINVERSE, t.Text); 
                    	}

                    }
                    break;
                case 19 :
                    // Compiler\\Grammar\\AplusParser.g:270:4: t= NaturalLog
                    {
                    	t=(IToken)Match(input,NaturalLog,FOLLOW_NaturalLog_in_functionSymbol1422); if (state.failed) return token;
                    	if ( (state.backtracking==0) )
                    	{
                    	   token = new AST.Token(Tokens.NATURALLOG, t.Text); 
                    	}

                    }
                    break;
                case 20 :
                    // Compiler\\Grammar\\AplusParser.g:271:4: t= Negate
                    {
                    	t=(IToken)Match(input,Negate,FOLLOW_Negate_in_functionSymbol1436); if (state.failed) return token;
                    	if ( (state.backtracking==0) )
                    	{
                    	   token = new AST.Token(Tokens.NEGATE, t.Text); 
                    	}

                    }
                    break;
                case 21 :
                    // Compiler\\Grammar\\AplusParser.g:272:4: t= Not
                    {
                    	t=(IToken)Match(input,Not,FOLLOW_Not_in_functionSymbol1451); if (state.failed) return token;
                    	if ( (state.backtracking==0) )
                    	{
                    	   token = new AST.Token(Tokens.NOT, t.Text); 
                    	}

                    }
                    break;
                case 22 :
                    // Compiler\\Grammar\\AplusParser.g:273:4: t= Null
                    {
                    	t=(IToken)Match(input,Null,FOLLOW_Null_in_functionSymbol1467); if (state.failed) return token;
                    	if ( (state.backtracking==0) )
                    	{
                    	   token = new AST.Token(Tokens.NULL, t.Text); 
                    	}

                    }
                    break;
                case 23 :
                    // Compiler\\Grammar\\AplusParser.g:274:4: t= Pack
                    {
                    	t=(IToken)Match(input,Pack,FOLLOW_Pack_in_functionSymbol1483); if (state.failed) return token;
                    	if ( (state.backtracking==0) )
                    	{
                    	   token = new AST.Token(Tokens.PACK, t.Text); 
                    	}

                    }
                    break;
                case 24 :
                    // Compiler\\Grammar\\AplusParser.g:275:4: t= PartitionCount
                    {
                    	t=(IToken)Match(input,PartitionCount,FOLLOW_PartitionCount_in_functionSymbol1499); if (state.failed) return token;
                    	if ( (state.backtracking==0) )
                    	{
                    	   token = new AST.Token(Tokens.PARTITIONCOUNT, t.Text); 
                    	}

                    }
                    break;
                case 25 :
                    // Compiler\\Grammar\\AplusParser.g:276:4: t= PiTimes
                    {
                    	t=(IToken)Match(input,PiTimes,FOLLOW_PiTimes_in_functionSymbol1512); if (state.failed) return token;
                    	if ( (state.backtracking==0) )
                    	{
                    	   token = new AST.Token(Tokens.PITIMES, t.Text); 
                    	}

                    }
                    break;
                case 26 :
                    // Compiler\\Grammar\\AplusParser.g:277:4: t= Print
                    {
                    	t=(IToken)Match(input,Print,FOLLOW_Print_in_functionSymbol1527); if (state.failed) return token;
                    	if ( (state.backtracking==0) )
                    	{
                    	   token = new AST.Token(Tokens.PRINT, t.Text); 
                    	}

                    }
                    break;
                case 27 :
                    // Compiler\\Grammar\\AplusParser.g:278:4: t= Rake
                    {
                    	t=(IToken)Match(input,Rake,FOLLOW_Rake_in_functionSymbol1543); if (state.failed) return token;
                    	if ( (state.backtracking==0) )
                    	{
                    	   token = new AST.Token(Tokens.RAKE, t.Text); 
                    	}

                    }
                    break;
                case 28 :
                    // Compiler\\Grammar\\AplusParser.g:279:4: t= Raze
                    {
                    	t=(IToken)Match(input,Raze,FOLLOW_Raze_in_functionSymbol1559); if (state.failed) return token;
                    	if ( (state.backtracking==0) )
                    	{
                    	   token = new AST.Token(Tokens.RAZE, t.Text); 
                    	}

                    }
                    break;
                case 29 :
                    // Compiler\\Grammar\\AplusParser.g:280:4: t= Ravel
                    {
                    	t=(IToken)Match(input,Ravel,FOLLOW_Ravel_in_functionSymbol1598); if (state.failed) return token;
                    	if ( (state.backtracking==0) )
                    	{
                    	   token = new AST.Token(Tokens.RAVEL, t.Text); 
                    	}

                    }
                    break;
                case 30 :
                    // Compiler\\Grammar\\AplusParser.g:281:4: t= Reciprocal
                    {
                    	t=(IToken)Match(input,Reciprocal,FOLLOW_Reciprocal_in_functionSymbol1614); if (state.failed) return token;
                    	if ( (state.backtracking==0) )
                    	{
                    	   token = new AST.Token(Tokens.RECIPROCAL, t.Text); 
                    	}

                    }
                    break;
                case 31 :
                    // Compiler\\Grammar\\AplusParser.g:282:4: t= Result
                    {
                    	t=(IToken)Match(input,Result,FOLLOW_Result_in_functionSymbol1628); if (state.failed) return token;
                    	if ( (state.backtracking==0) )
                    	{
                    	   token = new AST.Token(Tokens.RESULT, t.Text); 
                    	}

                    }
                    break;
                case 32 :
                    // Compiler\\Grammar\\AplusParser.g:283:4: t= Reverse
                    {
                    	t=(IToken)Match(input,Reverse,FOLLOW_Reverse_in_functionSymbol1643); if (state.failed) return token;
                    	if ( (state.backtracking==0) )
                    	{
                    	   token = new AST.Token(Tokens.REVERSE, t.Text); 
                    	}

                    }
                    break;
                case 33 :
                    // Compiler\\Grammar\\AplusParser.g:284:4: t= Roll
                    {
                    	t=(IToken)Match(input,Roll,FOLLOW_Roll_in_functionSymbol1658); if (state.failed) return token;
                    	if ( (state.backtracking==0) )
                    	{
                    	   token = new AST.Token(Tokens.ROLL, t.Text); 
                    	}

                    }
                    break;
                case 34 :
                    // Compiler\\Grammar\\AplusParser.g:285:4: t= Right
                    {
                    	t=(IToken)Match(input,Right,FOLLOW_Right_in_functionSymbol1674); if (state.failed) return token;
                    	if ( (state.backtracking==0) )
                    	{
                    	   token = new AST.Token(Tokens.RIGHT, t.Text); 
                    	}

                    }
                    break;
                case 35 :
                    // Compiler\\Grammar\\AplusParser.g:286:4: t= SeparateSymbols
                    {
                    	t=(IToken)Match(input,SeparateSymbols,FOLLOW_SeparateSymbols_in_functionSymbol1690); if (state.failed) return token;
                    	if ( (state.backtracking==0) )
                    	{
                    	   token = new AST.Token(Tokens.SEPARATESYMBOLS, t.Text); 
                    	}

                    }
                    break;
                case 36 :
                    // Compiler\\Grammar\\AplusParser.g:287:4: t= Shape
                    {
                    	t=(IToken)Match(input,Shape,FOLLOW_Shape_in_functionSymbol1703); if (state.failed) return token;
                    	if ( (state.backtracking==0) )
                    	{
                    	   token = new AST.Token(Tokens.SHAPE, t.Text); 
                    	}

                    }
                    break;
                case 37 :
                    // Compiler\\Grammar\\AplusParser.g:288:4: t= Sign
                    {
                    	t=(IToken)Match(input,Sign,FOLLOW_Sign_in_functionSymbol1719); if (state.failed) return token;
                    	if ( (state.backtracking==0) )
                    	{
                    	   token = new AST.Token(Tokens.SIGN, t.Text); 
                    	}

                    }
                    break;
                case 38 :
                    // Compiler\\Grammar\\AplusParser.g:289:4: t= Signal
                    {
                    	t=(IToken)Match(input,Signal,FOLLOW_Signal_in_functionSymbol1735); if (state.failed) return token;
                    	if ( (state.backtracking==0) )
                    	{
                    	   token = new AST.Token(Tokens.SIGNAL, t.Text); 
                    	}

                    }
                    break;
                case 39 :
                    // Compiler\\Grammar\\AplusParser.g:290:4: t= Stop
                    {
                    	t=(IToken)Match(input,Stop,FOLLOW_Stop_in_functionSymbol1750); if (state.failed) return token;
                    	if ( (state.backtracking==0) )
                    	{
                    	   token = new AST.Token(Tokens.STOP, t.Text); 
                    	}

                    }
                    break;
                case 40 :
                    // Compiler\\Grammar\\AplusParser.g:291:4: t= Transpose
                    {
                    	t=(IToken)Match(input,Transpose,FOLLOW_Transpose_in_functionSymbol1766); if (state.failed) return token;
                    	if ( (state.backtracking==0) )
                    	{
                    	   token = new AST.Token(Tokens.TRANSPOSE, t.Text); 
                    	}

                    }
                    break;
                case 41 :
                    // Compiler\\Grammar\\AplusParser.g:292:4: t= Unpack
                    {
                    	t=(IToken)Match(input,Unpack,FOLLOW_Unpack_in_functionSymbol1781); if (state.failed) return token;
                    	if ( (state.backtracking==0) )
                    	{
                    	   token = new AST.Token(Tokens.UNPACK, t.Text); 
                    	}

                    }
                    break;
                case 42 :
                    // Compiler\\Grammar\\AplusParser.g:293:4: t= Value
                    {
                    	t=(IToken)Match(input,Value,FOLLOW_Value_in_functionSymbol1796); if (state.failed) return token;
                    	if ( (state.backtracking==0) )
                    	{
                    	   token = new AST.Token(Tokens.VALUE, ((t != null) ? t.Text : null)); 
                    	}

                    }
                    break;
                case 43 :
                    // Compiler\\Grammar\\AplusParser.g:295:4: t= Or
                    {
                    	t=(IToken)Match(input,Or,FOLLOW_Or_in_functionSymbol1813); if (state.failed) return token;
                    	if ( (state.backtracking==0) )
                    	{
                    	   token = new AST.Token(Tokens.TYPE, t.Text); 
                    	}

                    }
                    break;
                case 44 :
                    // Compiler\\Grammar\\AplusParser.g:299:4: t= IPAddMultiply
                    {
                    	t=(IToken)Match(input,IPAddMultiply,FOLLOW_IPAddMultiply_in_functionSymbol1834); if (state.failed) return token;
                    	if ( (state.backtracking==0) )
                    	{
                    	   token = new AST.Token(Tokens.IPADDMULTIPLY, t.Text); 
                    	}

                    }
                    break;
                case 45 :
                    // Compiler\\Grammar\\AplusParser.g:300:4: t= IPMaxAdd
                    {
                    	t=(IToken)Match(input,IPMaxAdd,FOLLOW_IPMaxAdd_in_functionSymbol1848); if (state.failed) return token;
                    	if ( (state.backtracking==0) )
                    	{
                    	   token = new AST.Token(Tokens.IPMAXADD, t.Text); 
                    	}

                    }
                    break;
                case 46 :
                    // Compiler\\Grammar\\AplusParser.g:301:4: t= IPMinAdd
                    {
                    	t=(IToken)Match(input,IPMinAdd,FOLLOW_IPMinAdd_in_functionSymbol1863); if (state.failed) return token;
                    	if ( (state.backtracking==0) )
                    	{
                    	   token = new AST.Token(Tokens.IPMINADD, t.Text); 
                    	}

                    }
                    break;
                case 47 :
                    // Compiler\\Grammar\\AplusParser.g:303:4: t= OPAdd
                    {
                    	t=(IToken)Match(input,OPAdd,FOLLOW_OPAdd_in_functionSymbol1880); if (state.failed) return token;
                    	if ( (state.backtracking==0) )
                    	{
                    	   token = new AST.Token(Tokens.OPADD, t.Text); 
                    	}

                    }
                    break;
                case 48 :
                    // Compiler\\Grammar\\AplusParser.g:304:4: t= OPDivide
                    {
                    	t=(IToken)Match(input,OPDivide,FOLLOW_OPDivide_in_functionSymbol1896); if (state.failed) return token;
                    	if ( (state.backtracking==0) )
                    	{
                    	   token = new AST.Token(Tokens.OPDIVIDE, t.Text); 
                    	}

                    }
                    break;
                case 49 :
                    // Compiler\\Grammar\\AplusParser.g:305:4: t= OPEqual
                    {
                    	t=(IToken)Match(input,OPEqual,FOLLOW_OPEqual_in_functionSymbol1911); if (state.failed) return token;
                    	if ( (state.backtracking==0) )
                    	{
                    	   token = new AST.Token(Tokens.OPEQUAL, t.Text); 
                    	}

                    }
                    break;
                case 50 :
                    // Compiler\\Grammar\\AplusParser.g:306:4: t= OPGT
                    {
                    	t=(IToken)Match(input,OPGT,FOLLOW_OPGT_in_functionSymbol1926); if (state.failed) return token;
                    	if ( (state.backtracking==0) )
                    	{
                    	   token = new AST.Token(Tokens.OPGT, t.Text); 
                    	}

                    }
                    break;
                case 51 :
                    // Compiler\\Grammar\\AplusParser.g:307:4: t= OPGTE
                    {
                    	t=(IToken)Match(input,OPGTE,FOLLOW_OPGTE_in_functionSymbol1942); if (state.failed) return token;
                    	if ( (state.backtracking==0) )
                    	{
                    	   token = new AST.Token(Tokens.OPGTE, t.Text); 
                    	}

                    }
                    break;
                case 52 :
                    // Compiler\\Grammar\\AplusParser.g:308:4: t= OPLT
                    {
                    	t=(IToken)Match(input,OPLT,FOLLOW_OPLT_in_functionSymbol1958); if (state.failed) return token;
                    	if ( (state.backtracking==0) )
                    	{
                    	   token = new AST.Token(Tokens.OPLT, t.Text); 
                    	}

                    }
                    break;
                case 53 :
                    // Compiler\\Grammar\\AplusParser.g:309:4: t= OPLTE
                    {
                    	t=(IToken)Match(input,OPLTE,FOLLOW_OPLTE_in_functionSymbol1974); if (state.failed) return token;
                    	if ( (state.backtracking==0) )
                    	{
                    	   token = new AST.Token(Tokens.OPLTE, t.Text); 
                    	}

                    }
                    break;
                case 54 :
                    // Compiler\\Grammar\\AplusParser.g:310:4: t= OPMax
                    {
                    	t=(IToken)Match(input,OPMax,FOLLOW_OPMax_in_functionSymbol1990); if (state.failed) return token;
                    	if ( (state.backtracking==0) )
                    	{
                    	   token = new AST.Token(Tokens.OPMAX, t.Text); 
                    	}

                    }
                    break;
                case 55 :
                    // Compiler\\Grammar\\AplusParser.g:311:4: t= OPMin
                    {
                    	t=(IToken)Match(input,OPMin,FOLLOW_OPMin_in_functionSymbol2006); if (state.failed) return token;
                    	if ( (state.backtracking==0) )
                    	{
                    	   token = new AST.Token(Tokens.OPMIN, t.Text); 
                    	}

                    }
                    break;
                case 56 :
                    // Compiler\\Grammar\\AplusParser.g:312:4: t= OPMultiply
                    {
                    	t=(IToken)Match(input,OPMultiply,FOLLOW_OPMultiply_in_functionSymbol2022); if (state.failed) return token;
                    	if ( (state.backtracking==0) )
                    	{
                    	   token = new AST.Token(Tokens.OPMULTIPLY, t.Text); 
                    	}

                    }
                    break;
                case 57 :
                    // Compiler\\Grammar\\AplusParser.g:313:4: t= OPNotEqual
                    {
                    	t=(IToken)Match(input,OPNotEqual,FOLLOW_OPNotEqual_in_functionSymbol2036); if (state.failed) return token;
                    	if ( (state.backtracking==0) )
                    	{
                    	   token = new AST.Token(Tokens.OPNOTEQUAL, t.Text); 
                    	}

                    }
                    break;
                case 58 :
                    // Compiler\\Grammar\\AplusParser.g:314:4: t= OPResidue
                    {
                    	t=(IToken)Match(input,OPResidue,FOLLOW_OPResidue_in_functionSymbol2050); if (state.failed) return token;
                    	if ( (state.backtracking==0) )
                    	{
                    	   token = new AST.Token(Tokens.OPRESIDUE, t.Text); 
                    	}

                    }
                    break;
                case 59 :
                    // Compiler\\Grammar\\AplusParser.g:315:4: t= OPSubstract
                    {
                    	t=(IToken)Match(input,OPSubstract,FOLLOW_OPSubstract_in_functionSymbol2065); if (state.failed) return token;
                    	if ( (state.backtracking==0) )
                    	{
                    	   token = new AST.Token(Tokens.OPSUBSTRACT, t.Text); 
                    	}

                    }
                    break;
                case 60 :
                    // Compiler\\Grammar\\AplusParser.g:316:4: t= OPPower
                    {
                    	t=(IToken)Match(input,OPPower,FOLLOW_OPPower_in_functionSymbol2079); if (state.failed) return token;
                    	if ( (state.backtracking==0) )
                    	{
                    	   token = new AST.Token(Tokens.OPPOWER, t.Text); 
                    	}

                    }
                    break;
                case 61 :
                    // Compiler\\Grammar\\AplusParser.g:319:4: t= RAdd
                    {
                    	t=(IToken)Match(input,RAdd,FOLLOW_RAdd_in_functionSymbol2097); if (state.failed) return token;
                    	if ( (state.backtracking==0) )
                    	{
                    	   token = new AST.Token(Tokens.RADD, t.Text); 
                    	}

                    }
                    break;
                case 62 :
                    // Compiler\\Grammar\\AplusParser.g:320:4: t= RAnd
                    {
                    	t=(IToken)Match(input,RAnd,FOLLOW_RAnd_in_functionSymbol2113); if (state.failed) return token;
                    	if ( (state.backtracking==0) )
                    	{
                    	   token = new AST.Token(Tokens.RAND, t.Text); 
                    	}

                    }
                    break;
                case 63 :
                    // Compiler\\Grammar\\AplusParser.g:321:4: t= RMax
                    {
                    	t=(IToken)Match(input,RMax,FOLLOW_RMax_in_functionSymbol2129); if (state.failed) return token;
                    	if ( (state.backtracking==0) )
                    	{
                    	   token = new AST.Token(Tokens.RMAX, t.Text); 
                    	}

                    }
                    break;
                case 64 :
                    // Compiler\\Grammar\\AplusParser.g:322:4: t= RMin
                    {
                    	t=(IToken)Match(input,RMin,FOLLOW_RMin_in_functionSymbol2145); if (state.failed) return token;
                    	if ( (state.backtracking==0) )
                    	{
                    	   token = new AST.Token(Tokens.RMIN, t.Text); 
                    	}

                    }
                    break;
                case 65 :
                    // Compiler\\Grammar\\AplusParser.g:323:4: t= RMultiply
                    {
                    	t=(IToken)Match(input,RMultiply,FOLLOW_RMultiply_in_functionSymbol2161); if (state.failed) return token;
                    	if ( (state.backtracking==0) )
                    	{
                    	   token = new AST.Token(Tokens.RMULTIPLY, t.Text); 
                    	}

                    }
                    break;
                case 66 :
                    // Compiler\\Grammar\\AplusParser.g:324:4: t= ROr
                    {
                    	t=(IToken)Match(input,ROr,FOLLOW_ROr_in_functionSymbol2176); if (state.failed) return token;
                    	if ( (state.backtracking==0) )
                    	{
                    	   token = new AST.Token(Tokens.ROR, t.Text); 
                    	}

                    }
                    break;
                case 67 :
                    // Compiler\\Grammar\\AplusParser.g:326:4: t= SAdd
                    {
                    	t=(IToken)Match(input,SAdd,FOLLOW_SAdd_in_functionSymbol2194); if (state.failed) return token;
                    	if ( (state.backtracking==0) )
                    	{
                    	   token = new AST.Token(Tokens.SADD, t.Text); 
                    	}

                    }
                    break;
                case 68 :
                    // Compiler\\Grammar\\AplusParser.g:327:4: t= SAnd
                    {
                    	t=(IToken)Match(input,SAnd,FOLLOW_SAnd_in_functionSymbol2210); if (state.failed) return token;
                    	if ( (state.backtracking==0) )
                    	{
                    	   token = new AST.Token(Tokens.SAND, t.Text); 
                    	}

                    }
                    break;
                case 69 :
                    // Compiler\\Grammar\\AplusParser.g:328:4: t= SMax
                    {
                    	t=(IToken)Match(input,SMax,FOLLOW_SMax_in_functionSymbol2226); if (state.failed) return token;
                    	if ( (state.backtracking==0) )
                    	{
                    	   token = new AST.Token(Tokens.SMAX, t.Text); 
                    	}

                    }
                    break;
                case 70 :
                    // Compiler\\Grammar\\AplusParser.g:329:4: t= SMin
                    {
                    	t=(IToken)Match(input,SMin,FOLLOW_SMin_in_functionSymbol2242); if (state.failed) return token;
                    	if ( (state.backtracking==0) )
                    	{
                    	   token = new AST.Token(Tokens.SMIN, t.Text); 
                    	}

                    }
                    break;
                case 71 :
                    // Compiler\\Grammar\\AplusParser.g:330:4: t= SMultiply
                    {
                    	t=(IToken)Match(input,SMultiply,FOLLOW_SMultiply_in_functionSymbol2258); if (state.failed) return token;
                    	if ( (state.backtracking==0) )
                    	{
                    	   token = new AST.Token(Tokens.SMULTIPLY, t.Text); 
                    	}

                    }
                    break;
                case 72 :
                    // Compiler\\Grammar\\AplusParser.g:331:4: t= SOr
                    {
                    	t=(IToken)Match(input,SOr,FOLLOW_SOr_in_functionSymbol2273); if (state.failed) return token;
                    	if ( (state.backtracking==0) )
                    	{
                    	   token = new AST.Token(Tokens.SOR, t.Text); 
                    	}

                    }
                    break;
                case 73 :
                    // Compiler\\Grammar\\AplusParser.g:334:4: t= Equal
                    {
                    	t=(IToken)Match(input,Equal,FOLLOW_Equal_in_functionSymbol2292); if (state.failed) return token;
                    	if ( (state.backtracking==0) )
                    	{
                    	   token = new AST.Token(Tokens.EQUAL, t.Text); 
                    	}

                    }
                    break;
                case 74 :
                    // Compiler\\Grammar\\AplusParser.g:335:4: t= Expand
                    {
                    	t=(IToken)Match(input,Expand,FOLLOW_Expand_in_functionSymbol2308); if (state.failed) return token;
                    	if ( (state.backtracking==0) )
                    	{
                    	   token = new AST.Token(Tokens.EXPAND, t.Text); 
                    	}

                    }
                    break;
                case 75 :
                    // Compiler\\Grammar\\AplusParser.g:336:4: t= GTE
                    {
                    	t=(IToken)Match(input,GTE,FOLLOW_GTE_in_functionSymbol2323); if (state.failed) return token;
                    	if ( (state.backtracking==0) )
                    	{
                    	   token = new AST.Token(Tokens.GTE, t.Text); 
                    	}

                    }
                    break;
                case 76 :
                    // Compiler\\Grammar\\AplusParser.g:337:4: t= LTE
                    {
                    	t=(IToken)Match(input,LTE,FOLLOW_LTE_in_functionSymbol2339); if (state.failed) return token;
                    	if ( (state.backtracking==0) )
                    	{
                    	   token = new AST.Token(Tokens.LTE, t.Text); 
                    	}

                    }
                    break;
                case 77 :
                    // Compiler\\Grammar\\AplusParser.g:338:4: t= NotEqual
                    {
                    	t=(IToken)Match(input,NotEqual,FOLLOW_NotEqual_in_functionSymbol2355); if (state.failed) return token;
                    	if ( (state.backtracking==0) )
                    	{
                    	   token = new AST.Token(Tokens.NOTEQUAL, t.Text); 
                    	}

                    }
                    break;
                case 78 :
                    // Compiler\\Grammar\\AplusParser.g:339:4: t= Replicate
                    {
                    	t=(IToken)Match(input,Replicate,FOLLOW_Replicate_in_functionSymbol2370); if (state.failed) return token;
                    	if ( (state.backtracking==0) )
                    	{
                    	   token = new AST.Token(Tokens.REPLICATE, t.Text); 
                    	}

                    }
                    break;
                case 79 :
                    // Compiler\\Grammar\\AplusParser.g:342:4: t= BWNot
                    {
                    	t=(IToken)Match(input,BWNot,FOLLOW_BWNot_in_functionSymbol2388); if (state.failed) return token;
                    	if ( (state.backtracking==0) )
                    	{
                    	   token = new AST.Token(Tokens.BWNOT, t.Text); 
                    	}

                    }
                    break;
                case 80 :
                    // Compiler\\Grammar\\AplusParser.g:343:4: t= BWAnd
                    {
                    	t=(IToken)Match(input,BWAnd,FOLLOW_BWAnd_in_functionSymbol2405); if (state.failed) return token;
                    	if ( (state.backtracking==0) )
                    	{
                    	   token = new AST.Token(Tokens.BWAND, t.Text); 
                    	}

                    }
                    break;
                case 81 :
                    // Compiler\\Grammar\\AplusParser.g:344:4: t= BWOr
                    {
                    	t=(IToken)Match(input,BWOr,FOLLOW_BWOr_in_functionSymbol2422); if (state.failed) return token;
                    	if ( (state.backtracking==0) )
                    	{
                    	   token = new AST.Token(Tokens.BWOR, t.Text); 
                    	}

                    }
                    break;
                case 82 :
                    // Compiler\\Grammar\\AplusParser.g:345:4: t= BWLT
                    {
                    	t=(IToken)Match(input,BWLT,FOLLOW_BWLT_in_functionSymbol2439); if (state.failed) return token;
                    	if ( (state.backtracking==0) )
                    	{
                    	   token = new AST.Token(Tokens.BWLESS, t.Text); 
                    	}

                    }
                    break;
                case 83 :
                    // Compiler\\Grammar\\AplusParser.g:346:4: t= BWLTE
                    {
                    	t=(IToken)Match(input,BWLTE,FOLLOW_BWLTE_in_functionSymbol2456); if (state.failed) return token;
                    	if ( (state.backtracking==0) )
                    	{
                    	   token = new AST.Token(Tokens.BWLESSEQUAL, t.Text); 
                    	}

                    }
                    break;
                case 84 :
                    // Compiler\\Grammar\\AplusParser.g:347:4: t= BWGT
                    {
                    	t=(IToken)Match(input,BWGT,FOLLOW_BWGT_in_functionSymbol2473); if (state.failed) return token;
                    	if ( (state.backtracking==0) )
                    	{
                    	   token = new AST.Token(Tokens.BWGREATER, t.Text); 
                    	}

                    }
                    break;
                case 85 :
                    // Compiler\\Grammar\\AplusParser.g:348:4: t= BWGTE
                    {
                    	t=(IToken)Match(input,BWGTE,FOLLOW_BWGTE_in_functionSymbol2490); if (state.failed) return token;
                    	if ( (state.backtracking==0) )
                    	{
                    	   token = new AST.Token(Tokens.BWGREATEREQUAL, t.Text); 
                    	}

                    }
                    break;
                case 86 :
                    // Compiler\\Grammar\\AplusParser.g:349:4: t= BWEqual
                    {
                    	t=(IToken)Match(input,BWEqual,FOLLOW_BWEqual_in_functionSymbol2507); if (state.failed) return token;
                    	if ( (state.backtracking==0) )
                    	{
                    	   token = new AST.Token(Tokens.BWEQUAL, t.Text); 
                    	}

                    }
                    break;
                case 87 :
                    // Compiler\\Grammar\\AplusParser.g:350:4: t= BWNotEqual
                    {
                    	t=(IToken)Match(input,BWNotEqual,FOLLOW_BWNotEqual_in_functionSymbol2523); if (state.failed) return token;
                    	if ( (state.backtracking==0) )
                    	{
                    	   token = new AST.Token(Tokens.BWNOTEQUAL, t.Text); 
                    	}

                    }
                    break;
                case 88 :
                    // Compiler\\Grammar\\AplusParser.g:353:5: Do
                    {
                    	Match(input,Do,FOLLOW_Do_in_functionSymbol2540); if (state.failed) return token;
                    	if ( (state.backtracking==0) )
                    	{
                    	   token = AST.Node.Token(Tokens.DO); 
                    	}

                    }
                    break;

            }
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 19, functionSymbol_StartIndex); 
            }
        }
        return token;
    }
    // $ANTLR end "functionSymbol"


    // $ANTLR start "controlStatements"
    // Compiler\\Grammar\\AplusParser.g:358:1: controlStatements returns [AST.Node node] : ( ifStatement | caseStatement | whileStatement );
    public AST.Node controlStatements() // throws RecognitionException [1]
    {   
        AST.Node node = default(AST.Node);
        int controlStatements_StartIndex = input.Index();
        AST.If ifStatement49 = default(AST.If);

        AST.Case caseStatement50 = default(AST.Case);

        AST.While whileStatement51 = default(AST.While);


        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 20) ) 
    	    {
    	    	return node; 
    	    }
            // Compiler\\Grammar\\AplusParser.g:359:2: ( ifStatement | caseStatement | whileStatement )
            int alt21 = 3;
            switch ( input.LA(1) ) 
            {
            case If:
            	{
                alt21 = 1;
                }
                break;
            case Case:
            	{
                alt21 = 2;
                }
                break;
            case While:
            	{
                alt21 = 3;
                }
                break;
            	default:
            	    if ( state.backtracking > 0 ) {state.failed = true; return node;}
            	    NoViableAltException nvae_d21s0 =
            	        new NoViableAltException("", 21, 0, input);

            	    throw nvae_d21s0;
            }

            switch (alt21) 
            {
                case 1 :
                    // Compiler\\Grammar\\AplusParser.g:359:4: ifStatement
                    {
                    	PushFollow(FOLLOW_ifStatement_in_controlStatements2569);
                    	ifStatement49 = ifStatement();
                    	state.followingStackPointer--;
                    	if (state.failed) return node;
                    	if ( (state.backtracking==0) )
                    	{
                    	   node = ifStatement49; 
                    	}

                    }
                    break;
                case 2 :
                    // Compiler\\Grammar\\AplusParser.g:360:4: caseStatement
                    {
                    	PushFollow(FOLLOW_caseStatement_in_controlStatements2582);
                    	caseStatement50 = caseStatement();
                    	state.followingStackPointer--;
                    	if (state.failed) return node;
                    	if ( (state.backtracking==0) )
                    	{
                    	   node = caseStatement50; 
                    	}

                    }
                    break;
                case 3 :
                    // Compiler\\Grammar\\AplusParser.g:361:4: whileStatement
                    {
                    	PushFollow(FOLLOW_whileStatement_in_controlStatements2594);
                    	whileStatement51 = whileStatement();
                    	state.followingStackPointer--;
                    	if (state.failed) return node;
                    	if ( (state.backtracking==0) )
                    	{
                    	   node = whileStatement51; 
                    	}

                    }
                    break;

            }
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 20, controlStatements_StartIndex); 
            }
        }
        return node;
    }
    // $ANTLR end "controlStatements"


    // $ANTLR start "condition"
    // Compiler\\Grammar\\AplusParser.g:364:1: condition returns [AST.Node node] : termExpression ;
    public AST.Node condition() // throws RecognitionException [1]
    {   
        AST.Node node = default(AST.Node);
        int condition_StartIndex = input.Index();
        AST.Node termExpression52 = default(AST.Node);


        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 21) ) 
    	    {
    	    	return node; 
    	    }
            // Compiler\\Grammar\\AplusParser.g:365:2: ( termExpression )
            // Compiler\\Grammar\\AplusParser.g:365:4: termExpression
            {
            	PushFollow(FOLLOW_termExpression_in_condition2616);
            	termExpression52 = termExpression();
            	state.followingStackPointer--;
            	if (state.failed) return node;
            	if ( (state.backtracking==0) )
            	{
            	   node = termExpression52; 
            	}

            }

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 21, condition_StartIndex); 
            }
        }
        return node;
    }
    // $ANTLR end "condition"


    // $ANTLR start "ifStatement"
    // Compiler\\Grammar\\AplusParser.g:368:1: ifStatement returns [AST.If node] : If condition truecase= topExpressionNull ( Else falsecase= topExpressionNull )? ;
    public AST.If ifStatement() // throws RecognitionException [1]
    {   
        AST.If node = default(AST.If);
        int ifStatement_StartIndex = input.Index();
        AST.Node truecase = default(AST.Node);

        AST.Node falsecase = default(AST.Node);

        AST.Node condition53 = default(AST.Node);


        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 22) ) 
    	    {
    	    	return node; 
    	    }
            // Compiler\\Grammar\\AplusParser.g:369:2: ( If condition truecase= topExpressionNull ( Else falsecase= topExpressionNull )? )
            // Compiler\\Grammar\\AplusParser.g:369:4: If condition truecase= topExpressionNull ( Else falsecase= topExpressionNull )?
            {
            	Match(input,If,FOLLOW_If_in_ifStatement2637); if (state.failed) return node;
            	PushFollow(FOLLOW_condition_in_ifStatement2639);
            	condition53 = condition();
            	state.followingStackPointer--;
            	if (state.failed) return node;
            	PushFollow(FOLLOW_topExpressionNull_in_ifStatement2643);
            	truecase = topExpressionNull();
            	state.followingStackPointer--;
            	if (state.failed) return node;
            	if ( (state.backtracking==0) )
            	{
            	   node = AST.Node.If(condition53, truecase); 
            	}
            	// Compiler\\Grammar\\AplusParser.g:370:3: ( Else falsecase= topExpressionNull )?
            	int alt22 = 2;
            	int LA22_0 = input.LA(1);

            	if ( (LA22_0 == Else) )
            	{
            	    int LA22_1 = input.LA(2);

            	    if ( (synpred124_AplusParser()) )
            	    {
            	        alt22 = 1;
            	    }
            	}
            	switch (alt22) 
            	{
            	    case 1 :
            	        // Compiler\\Grammar\\AplusParser.g:370:4: Else falsecase= topExpressionNull
            	        {
            	        	Match(input,Else,FOLLOW_Else_in_ifStatement2651); if (state.failed) return node;
            	        	PushFollow(FOLLOW_topExpressionNull_in_ifStatement2658);
            	        	falsecase = topExpressionNull();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return node;
            	        	if ( (state.backtracking==0) )
            	        	{
            	        	   node.AddFalseCase(falsecase); 
            	        	}

            	        }
            	        break;

            	}


            }

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 22, ifStatement_StartIndex); 
            }
        }
        return node;
    }
    // $ANTLR end "ifStatement"


    // $ANTLR start "caseStatement"
    // Compiler\\Grammar\\AplusParser.g:375:1: caseStatement returns [AST.Case node] : Case condition expressionGroup ;
    public AST.Case caseStatement() // throws RecognitionException [1]
    {   
        AST.Case node = default(AST.Case);
        int caseStatement_StartIndex = input.Index();
        AST.Node condition54 = default(AST.Node);

        AST.ExpressionList expressionGroup55 = default(AST.ExpressionList);


        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 23) ) 
    	    {
    	    	return node; 
    	    }
            // Compiler\\Grammar\\AplusParser.g:376:2: ( Case condition expressionGroup )
            // Compiler\\Grammar\\AplusParser.g:376:4: Case condition expressionGroup
            {
            	Match(input,Case,FOLLOW_Case_in_caseStatement2684); if (state.failed) return node;
            	PushFollow(FOLLOW_condition_in_caseStatement2686);
            	condition54 = condition();
            	state.followingStackPointer--;
            	if (state.failed) return node;
            	PushFollow(FOLLOW_expressionGroup_in_caseStatement2688);
            	expressionGroup55 = expressionGroup();
            	state.followingStackPointer--;
            	if (state.failed) return node;
            	if ( (state.backtracking==0) )
            	{
            	   node = AST.Node.Case(condition54, expressionGroup55); 
            	}

            }

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 23, caseStatement_StartIndex); 
            }
        }
        return node;
    }
    // $ANTLR end "caseStatement"


    // $ANTLR start "whileStatement"
    // Compiler\\Grammar\\AplusParser.g:379:1: whileStatement returns [AST.While node] : While condition topExpressionNull ;
    public AST.While whileStatement() // throws RecognitionException [1]
    {   
        AST.While node = default(AST.While);
        int whileStatement_StartIndex = input.Index();
        AST.Node condition56 = default(AST.Node);

        AST.Node topExpressionNull57 = default(AST.Node);


        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 24) ) 
    	    {
    	    	return node; 
    	    }
            // Compiler\\Grammar\\AplusParser.g:380:2: ( While condition topExpressionNull )
            // Compiler\\Grammar\\AplusParser.g:380:4: While condition topExpressionNull
            {
            	Match(input,While,FOLLOW_While_in_whileStatement2708); if (state.failed) return node;
            	PushFollow(FOLLOW_condition_in_whileStatement2710);
            	condition56 = condition();
            	state.followingStackPointer--;
            	if (state.failed) return node;
            	PushFollow(FOLLOW_topExpressionNull_in_whileStatement2712);
            	topExpressionNull57 = topExpressionNull();
            	state.followingStackPointer--;
            	if (state.failed) return node;
            	if ( (state.backtracking==0) )
            	{
            	   node = AST.Node.While(condition56, topExpressionNull57); 
            	}

            }

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 24, whileStatement_StartIndex); 
            }
        }
        return node;
    }
    // $ANTLR end "whileStatement"


    // $ANTLR start "simpleExpression"
    // Compiler\\Grammar\\AplusParser.g:383:1: simpleExpression returns [AST.Node node] : ({...}? StackReference expressionGroup | expr= termExpression ( expressionGroup )? );
    public AST.Node simpleExpression() // throws RecognitionException [1]
    {   
        AST.Node node = default(AST.Node);
        int simpleExpression_StartIndex = input.Index();
        AST.Node expr = default(AST.Node);

        AST.ExpressionList expressionGroup58 = default(AST.ExpressionList);

        AST.ExpressionList expressionGroup59 = default(AST.ExpressionList);


        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 25) ) 
    	    {
    	    	return node; 
    	    }
            // Compiler\\Grammar\\AplusParser.g:384:2: ({...}? StackReference expressionGroup | expr= termExpression ( expressionGroup )? )
            int alt24 = 2;
            int LA24_0 = input.LA(1);

            if ( (LA24_0 == StackReference) )
            {
                alt24 = 1;
            }
            else if ( (LA24_0 == LP || LA24_0 == LSB || LA24_0 == Int || (LA24_0 >= Float && LA24_0 <= Inf) || (LA24_0 >= CharachterConstantSQ && LA24_0 <= CharachterConstantDQ) || (LA24_0 >= SymbolConstant && LA24_0 <= SystemName)) )
            {
                alt24 = 2;
            }
            else 
            {
                if ( state.backtracking > 0 ) {state.failed = true; return node;}
                NoViableAltException nvae_d24s0 =
                    new NoViableAltException("", 24, 0, input);

                throw nvae_d24s0;
            }
            switch (alt24) 
            {
                case 1 :
                    // Compiler\\Grammar\\AplusParser.g:384:4: {...}? StackReference expressionGroup
                    {
                    	if ( !(( this.isfunction )) ) 
                    	{
                    	    if ( state.backtracking > 0 ) {state.failed = true; return node;}
                    	    throw new FailedPredicateException(input, "simpleExpression", " this.isfunction ");
                    	}
                    	Match(input,StackReference,FOLLOW_StackReference_in_simpleExpression2732); if (state.failed) return node;
                    	PushFollow(FOLLOW_expressionGroup_in_simpleExpression2734);
                    	expressionGroup58 = expressionGroup();
                    	state.followingStackPointer--;
                    	if (state.failed) return node;
                    	if ( (state.backtracking==0) )
                    	{

                    	  			node = AST.Node.UserDefInvoke(this.function, expressionGroup58);
                    	  		
                    	}

                    }
                    break;
                case 2 :
                    // Compiler\\Grammar\\AplusParser.g:388:4: expr= termExpression ( expressionGroup )?
                    {
                    	PushFollow(FOLLOW_termExpression_in_simpleExpression2745);
                    	expr = termExpression();
                    	state.followingStackPointer--;
                    	if (state.failed) return node;
                    	if ( (state.backtracking==0) )
                    	{
                    	   node = expr; 
                    	}
                    	// Compiler\\Grammar\\AplusParser.g:389:3: ( expressionGroup )?
                    	int alt23 = 2;
                    	alt23 = dfa23.Predict(input);
                    	switch (alt23) 
                    	{
                    	    case 1 :
                    	        // Compiler\\Grammar\\AplusParser.g:390:4: expressionGroup
                    	        {
                    	        	PushFollow(FOLLOW_expressionGroup_in_simpleExpression2759);
                    	        	expressionGroup59 = expressionGroup();
                    	        	state.followingStackPointer--;
                    	        	if (state.failed) return node;
                    	        	if ( (state.backtracking==0) )
                    	        	{

                    	        	  				if( (expr is AST.Identifier) )
                    	        	  				{
                    	        	  					node = AST.Node.UserDefInvoke(expr, expressionGroup59);

                    	        	  				}
                    	        	  				else
                    	        	  				{
                    	        	  					throw new ParseException("non-function", false);
                    	        	  				}
                    	        	  				
                    	        	  			
                    	        	}

                    	        }
                    	        break;

                    	}


                    }
                    break;

            }
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 25, simpleExpression_StartIndex); 
            }
        }
        return node;
    }
    // $ANTLR end "simpleExpression"


    // $ANTLR start "termExpression"
    // Compiler\\Grammar\\AplusParser.g:406:1: termExpression returns [AST.Node node] : term ( LSBracket ( | i= expressionList ) RSBracket )* ;
    public AST.Node termExpression() // throws RecognitionException [1]
    {   
        AST.Node node = default(AST.Node);
        int termExpression_StartIndex = input.Index();
        AST.ExpressionList i = default(AST.ExpressionList);

        AST.Node term60 = default(AST.Node);


        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 26) ) 
    	    {
    	    	return node; 
    	    }
            // Compiler\\Grammar\\AplusParser.g:407:2: ( term ( LSBracket ( | i= expressionList ) RSBracket )* )
            // Compiler\\Grammar\\AplusParser.g:407:4: term ( LSBracket ( | i= expressionList ) RSBracket )*
            {
            	PushFollow(FOLLOW_term_in_termExpression2784);
            	term60 = term();
            	state.followingStackPointer--;
            	if (state.failed) return node;
            	if ( (state.backtracking==0) )
            	{
            	   node = term60; 
            	}
            	// Compiler\\Grammar\\AplusParser.g:408:3: ( LSBracket ( | i= expressionList ) RSBracket )*
            	do 
            	{
            	    int alt26 = 2;
            	    int LA26_0 = input.LA(1);

            	    if ( (LA26_0 == LSBracket) )
            	    {
            	        alt26 = 1;
            	    }


            	    switch (alt26) 
            		{
            			case 1 :
            			    // Compiler\\Grammar\\AplusParser.g:408:4: LSBracket ( | i= expressionList ) RSBracket
            			    {
            			    	Match(input,LSBracket,FOLLOW_LSBracket_in_termExpression2791); if (state.failed) return node;
            			    	// Compiler\\Grammar\\AplusParser.g:408:14: ( | i= expressionList )
            			    	int alt25 = 2;
            			    	int LA25_0 = input.LA(1);

            			    	if ( (LA25_0 == RSBracket) )
            			    	{
            			    	    int LA25_1 = input.LA(2);

            			    	    if ( (synpred127_AplusParser()) )
            			    	    {
            			    	        alt25 = 1;
            			    	    }
            			    	    else if ( (true) )
            			    	    {
            			    	        alt25 = 2;
            			    	    }
            			    	    else 
            			    	    {
            			    	        if ( state.backtracking > 0 ) {state.failed = true; return node;}
            			    	        NoViableAltException nvae_d25s1 =
            			    	            new NoViableAltException("", 25, 1, input);

            			    	        throw nvae_d25s1;
            			    	    }
            			    	}
            			    	else if ( (LA25_0 == If || (LA25_0 >= Do && LA25_0 <= LP) || LA25_0 == SemiColon || LA25_0 == LSB || LA25_0 == Int || (LA25_0 >= Float && LA25_0 <= Inf) || (LA25_0 >= CharachterConstantSQ && LA25_0 <= CharachterConstantDQ) || (LA25_0 >= SymbolConstant && LA25_0 <= SystemName)) )
            			    	{
            			    	    alt25 = 2;
            			    	}
            			    	else 
            			    	{
            			    	    if ( state.backtracking > 0 ) {state.failed = true; return node;}
            			    	    NoViableAltException nvae_d25s0 =
            			    	        new NoViableAltException("", 25, 0, input);

            			    	    throw nvae_d25s0;
            			    	}
            			    	switch (alt25) 
            			    	{
            			    	    case 1 :
            			    	        // Compiler\\Grammar\\AplusParser.g:408:33: 
            			    	        {
            			    	        }
            			    	        break;
            			    	    case 2 :
            			    	        // Compiler\\Grammar\\AplusParser.g:408:35: i= expressionList
            			    	        {
            			    	        	PushFollow(FOLLOW_expressionList_in_termExpression2800);
            			    	        	i = expressionList();
            			    	        	state.followingStackPointer--;
            			    	        	if (state.failed) return node;

            			    	        }
            			    	        break;

            			    	}

            			    	Match(input,RSBracket,FOLLOW_RSBracket_in_termExpression2803); if (state.failed) return node;
            			    	if ( (state.backtracking==0) )
            			    	{
            			    	   node = AST.Node.Indexing(node, i);  
            			    	}

            			    }
            			    break;

            			default:
            			    goto loop26;
            	    }
            	} while (true);

            	loop26:
            		;	// Stops C# compiler whining that label 'loop26' has no statements


            }

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 26, termExpression_StartIndex); 
            }
        }
        return node;
    }
    // $ANTLR end "termExpression"


    // $ANTLR start "term"
    // Compiler\\Grammar\\AplusParser.g:413:1: term returns [AST.Node node] : ( LP expressionList RP | expressionGroup | constant | variableName );
    public AST.Node term() // throws RecognitionException [1]
    {   
        AST.Node node = default(AST.Node);
        int term_StartIndex = input.Index();
        AST.ExpressionList expressionList61 = default(AST.ExpressionList);

        AST.ExpressionList expressionGroup62 = default(AST.ExpressionList);

        AST.Node constant63 = default(AST.Node);

        AST.Identifier variableName64 = default(AST.Identifier);


        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 27) ) 
    	    {
    	    	return node; 
    	    }
            // Compiler\\Grammar\\AplusParser.g:414:2: ( LP expressionList RP | expressionGroup | constant | variableName )
            int alt27 = 4;
            switch ( input.LA(1) ) 
            {
            case LP:
            	{
                alt27 = 1;
                }
                break;
            case LSB:
            	{
                alt27 = 2;
                }
                break;
            case Int:
            case Float:
            case Inf:
            case CharachterConstantSQ:
            case CharachterConstantDQ:
            case SymbolConstant:
            	{
                alt27 = 3;
                }
                break;
            case UnqualifiedName:
            case QualifiedName:
            case SystemName:
            	{
                alt27 = 4;
                }
                break;
            	default:
            	    if ( state.backtracking > 0 ) {state.failed = true; return node;}
            	    NoViableAltException nvae_d27s0 =
            	        new NoViableAltException("", 27, 0, input);

            	    throw nvae_d27s0;
            }

            switch (alt27) 
            {
                case 1 :
                    // Compiler\\Grammar\\AplusParser.g:414:4: LP expressionList RP
                    {
                    	Match(input,LP,FOLLOW_LP_in_term2829); if (state.failed) return node;
                    	PushFollow(FOLLOW_expressionList_in_term2831);
                    	expressionList61 = expressionList();
                    	state.followingStackPointer--;
                    	if (state.failed) return node;
                    	Match(input,RP,FOLLOW_RP_in_term2833); if (state.failed) return node;
                    	if ( (state.backtracking==0) )
                    	{
                    	   
                    	  			switch(expressionList61.Length)
                    	  			{
                    	  				case 0:
                    	  					node = AST.Node.NullConstant();
                    	  					break;
                    	  				case 1:
                    	  					node = expressionList61.Items.First.Value;
                    	  					if(node is AST.Identifier)
                    	  					{
                    	  						((AST.Identifier)node).IsEnclosed = true;
                    	  					}
                    	  					break;
                    	  				
                    	  				default:
                    	  					node = AST.Node.Strand(expressionList61.Items);
                    	  					break;
                    	  			}
                    	  		
                    	}

                    }
                    break;
                case 2 :
                    // Compiler\\Grammar\\AplusParser.g:434:4: expressionGroup
                    {
                    	PushFollow(FOLLOW_expressionGroup_in_term2846);
                    	expressionGroup62 = expressionGroup();
                    	state.followingStackPointer--;
                    	if (state.failed) return node;
                    	if ( (state.backtracking==0) )
                    	{
                    	   node = expressionGroup62; 
                    	}

                    }
                    break;
                case 3 :
                    // Compiler\\Grammar\\AplusParser.g:435:4: constant
                    {
                    	PushFollow(FOLLOW_constant_in_term2858);
                    	constant63 = constant();
                    	state.followingStackPointer--;
                    	if (state.failed) return node;
                    	if ( (state.backtracking==0) )
                    	{
                    	   node = constant63; 
                    	}

                    }
                    break;
                case 4 :
                    // Compiler\\Grammar\\AplusParser.g:436:4: variableName
                    {
                    	PushFollow(FOLLOW_variableName_in_term2871);
                    	variableName64 = variableName();
                    	state.followingStackPointer--;
                    	if (state.failed) return node;
                    	if ( (state.backtracking==0) )
                    	{
                    	   node = variableName64; 
                    	}

                    }
                    break;

            }
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 27, term_StartIndex); 
            }
        }
        return node;
    }
    // $ANTLR end "term"


    // $ANTLR start "constant"
    // Compiler\\Grammar\\AplusParser.g:439:1: constant returns [AST.Node node] : ( numericConstantList | symbolConsantList | characterConstant );
    public AST.Node constant() // throws RecognitionException [1]
    {   
        AST.Node node = default(AST.Node);
        int constant_StartIndex = input.Index();
        AST.Node numericConstantList65 = default(AST.Node);

        AST.Node symbolConsantList66 = default(AST.Node);

        AST.Node characterConstant67 = default(AST.Node);


        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 28) ) 
    	    {
    	    	return node; 
    	    }
            // Compiler\\Grammar\\AplusParser.g:440:2: ( numericConstantList | symbolConsantList | characterConstant )
            int alt28 = 3;
            switch ( input.LA(1) ) 
            {
            case Int:
            case Float:
            case Inf:
            	{
                alt28 = 1;
                }
                break;
            case SymbolConstant:
            	{
                alt28 = 2;
                }
                break;
            case CharachterConstantSQ:
            case CharachterConstantDQ:
            	{
                alt28 = 3;
                }
                break;
            	default:
            	    if ( state.backtracking > 0 ) {state.failed = true; return node;}
            	    NoViableAltException nvae_d28s0 =
            	        new NoViableAltException("", 28, 0, input);

            	    throw nvae_d28s0;
            }

            switch (alt28) 
            {
                case 1 :
                    // Compiler\\Grammar\\AplusParser.g:440:4: numericConstantList
                    {
                    	PushFollow(FOLLOW_numericConstantList_in_constant2893);
                    	numericConstantList65 = numericConstantList();
                    	state.followingStackPointer--;
                    	if (state.failed) return node;
                    	if ( (state.backtracking==0) )
                    	{
                    	   node = numericConstantList65; 
                    	}

                    }
                    break;
                case 2 :
                    // Compiler\\Grammar\\AplusParser.g:441:4: symbolConsantList
                    {
                    	PushFollow(FOLLOW_symbolConsantList_in_constant2909);
                    	symbolConsantList66 = symbolConsantList();
                    	state.followingStackPointer--;
                    	if (state.failed) return node;
                    	if ( (state.backtracking==0) )
                    	{
                    	   node = symbolConsantList66; 
                    	}

                    }
                    break;
                case 3 :
                    // Compiler\\Grammar\\AplusParser.g:442:4: characterConstant
                    {
                    	PushFollow(FOLLOW_characterConstant_in_constant2920);
                    	characterConstant67 = characterConstant();
                    	state.followingStackPointer--;
                    	if (state.failed) return node;
                    	if ( (state.backtracking==0) )
                    	{
                    	   node = characterConstant67; 
                    	}

                    }
                    break;

            }
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 28, constant_StartIndex); 
            }
        }
        return node;
    }
    // $ANTLR end "constant"


    // $ANTLR start "numericConstant"
    // Compiler\\Grammar\\AplusParser.g:446:1: numericConstant returns [AST.Constant number] : ( Int | Float | Inf );
    public AST.Constant numericConstant() // throws RecognitionException [1]
    {   
        AST.Constant number = default(AST.Constant);
        int numericConstant_StartIndex = input.Index();
        IToken Int68 = null;
        IToken Float69 = null;
        IToken Inf70 = null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 29) ) 
    	    {
    	    	return number; 
    	    }
            // Compiler\\Grammar\\AplusParser.g:447:2: ( Int | Float | Inf )
            int alt29 = 3;
            switch ( input.LA(1) ) 
            {
            case Int:
            	{
                alt29 = 1;
                }
                break;
            case Float:
            	{
                alt29 = 2;
                }
                break;
            case Inf:
            	{
                alt29 = 3;
                }
                break;
            	default:
            	    if ( state.backtracking > 0 ) {state.failed = true; return number;}
            	    NoViableAltException nvae_d29s0 =
            	        new NoViableAltException("", 29, 0, input);

            	    throw nvae_d29s0;
            }

            switch (alt29) 
            {
                case 1 :
                    // Compiler\\Grammar\\AplusParser.g:447:4: Int
                    {
                    	Int68=(IToken)Match(input,Int,FOLLOW_Int_in_numericConstant2942); if (state.failed) return number;
                    	if ( (state.backtracking==0) )
                    	{
                    	   number = AST.Node.IntConstant(Int68.Text); 
                    	}

                    }
                    break;
                case 2 :
                    // Compiler\\Grammar\\AplusParser.g:448:4: Float
                    {
                    	Float69=(IToken)Match(input,Float,FOLLOW_Float_in_numericConstant2957); if (state.failed) return number;
                    	if ( (state.backtracking==0) )
                    	{
                    	   number = AST.Node.FloatConstant(Float69.Text); 
                    	}

                    }
                    break;
                case 3 :
                    // Compiler\\Grammar\\AplusParser.g:449:4: Inf
                    {
                    	Inf70=(IToken)Match(input,Inf,FOLLOW_Inf_in_numericConstant2971); if (state.failed) return number;
                    	if ( (state.backtracking==0) )
                    	{
                    	   number = AST.Node.InfConstant(Inf70.Text); 
                    	}

                    }
                    break;

            }
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 29, numericConstant_StartIndex); 
            }
        }
        return number;
    }
    // $ANTLR end "numericConstant"


    // $ANTLR start "numericConstantList"
    // Compiler\\Grammar\\AplusParser.g:452:1: numericConstantList returns [AST.Node node] : ( numericConstant )+ ;
    public AST.Node numericConstantList() // throws RecognitionException [1]
    {   
        AST.Node node = default(AST.Node);
        int numericConstantList_StartIndex = input.Index();
        AST.Constant numericConstant71 = default(AST.Constant);


         AST.ConstantList list = AST.Node.ConstantList(); 
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 30) ) 
    	    {
    	    	return node; 
    	    }
            // Compiler\\Grammar\\AplusParser.g:454:2: ( ( numericConstant )+ )
            // Compiler\\Grammar\\AplusParser.g:454:4: ( numericConstant )+
            {
            	// Compiler\\Grammar\\AplusParser.g:454:4: ( numericConstant )+
            	int cnt30 = 0;
            	do 
            	{
            	    int alt30 = 2;
            	    switch ( input.LA(1) ) 
            	    {
            	    case Int:
            	    	{
            	        int LA30_2 = input.LA(2);

            	        if ( (synpred136_AplusParser()) )
            	        {
            	            alt30 = 1;
            	        }


            	        }
            	        break;
            	    case Float:
            	    	{
            	        int LA30_3 = input.LA(2);

            	        if ( (synpred136_AplusParser()) )
            	        {
            	            alt30 = 1;
            	        }


            	        }
            	        break;
            	    case Inf:
            	    	{
            	        int LA30_4 = input.LA(2);

            	        if ( (synpred136_AplusParser()) )
            	        {
            	            alt30 = 1;
            	        }


            	        }
            	        break;

            	    }

            	    switch (alt30) 
            		{
            			case 1 :
            			    // Compiler\\Grammar\\AplusParser.g:454:5: numericConstant
            			    {
            			    	PushFollow(FOLLOW_numericConstant_in_numericConstantList3004);
            			    	numericConstant71 = numericConstant();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return node;
            			    	if ( (state.backtracking==0) )
            			    	{
            			    	   list.AddLast(numericConstant71); 
            			    	}

            			    }
            			    break;

            			default:
            			    if ( cnt30 >= 1 ) goto loop30;
            			    if ( state.backtracking > 0 ) {state.failed = true; return node;}
            		            EarlyExitException eee30 =
            		                new EarlyExitException(30, input);
            		            throw eee30;
            	    }
            	    cnt30++;
            	} while (true);

            	loop30:
            		;	// Stops C# compiler whining that label 'loop30' has no statements

            	if ( (state.backtracking==0) )
            	{
            	   node = list; 
            	}

            }

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 30, numericConstantList_StartIndex); 
            }
        }
        return node;
    }
    // $ANTLR end "numericConstantList"


    // $ANTLR start "symbolConsantList"
    // Compiler\\Grammar\\AplusParser.g:458:1: symbolConsantList returns [AST.Node node] : ( SymbolConstant )+ ;
    public AST.Node symbolConsantList() // throws RecognitionException [1]
    {   
        AST.Node node = default(AST.Node);
        int symbolConsantList_StartIndex = input.Index();
        IToken SymbolConstant72 = null;

         AST.ConstantList list = AST.Node.ConstantList(); 
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 31) ) 
    	    {
    	    	return node; 
    	    }
            // Compiler\\Grammar\\AplusParser.g:460:2: ( ( SymbolConstant )+ )
            // Compiler\\Grammar\\AplusParser.g:460:4: ( SymbolConstant )+
            {
            	// Compiler\\Grammar\\AplusParser.g:460:4: ( SymbolConstant )+
            	int cnt31 = 0;
            	do 
            	{
            	    int alt31 = 2;
            	    int LA31_0 = input.LA(1);

            	    if ( (LA31_0 == SymbolConstant) )
            	    {
            	        int LA31_2 = input.LA(2);

            	        if ( (synpred137_AplusParser()) )
            	        {
            	            alt31 = 1;
            	        }


            	    }


            	    switch (alt31) 
            		{
            			case 1 :
            			    // Compiler\\Grammar\\AplusParser.g:460:5: SymbolConstant
            			    {
            			    	SymbolConstant72=(IToken)Match(input,SymbolConstant,FOLLOW_SymbolConstant_in_symbolConsantList3036); if (state.failed) return node;
            			    	if ( (state.backtracking==0) )
            			    	{
            			    	   list.AddLast(AST.Node.SymbolConstant(SymbolConstant72.Text)); 
            			    	}

            			    }
            			    break;

            			default:
            			    if ( cnt31 >= 1 ) goto loop31;
            			    if ( state.backtracking > 0 ) {state.failed = true; return node;}
            		            EarlyExitException eee31 =
            		                new EarlyExitException(31, input);
            		            throw eee31;
            	    }
            	    cnt31++;
            	} while (true);

            	loop31:
            		;	// Stops C# compiler whining that label 'loop31' has no statements

            	if ( (state.backtracking==0) )
            	{
            	   node = list; 
            	}

            }

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 31, symbolConsantList_StartIndex); 
            }
        }
        return node;
    }
    // $ANTLR end "symbolConsantList"


    // $ANTLR start "characterConstant"
    // Compiler\\Grammar\\AplusParser.g:464:1: characterConstant returns [AST.Node node] : ( CharachterConstantSQ | CharachterConstantDQ );
    public AST.Node characterConstant() // throws RecognitionException [1]
    {   
        AST.Node node = default(AST.Node);
        int characterConstant_StartIndex = input.Index();
        IToken CharachterConstantSQ73 = null;
        IToken CharachterConstantDQ74 = null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 32) ) 
    	    {
    	    	return node; 
    	    }
            // Compiler\\Grammar\\AplusParser.g:465:2: ( CharachterConstantSQ | CharachterConstantDQ )
            int alt32 = 2;
            int LA32_0 = input.LA(1);

            if ( (LA32_0 == CharachterConstantSQ) )
            {
                alt32 = 1;
            }
            else if ( (LA32_0 == CharachterConstantDQ) )
            {
                alt32 = 2;
            }
            else 
            {
                if ( state.backtracking > 0 ) {state.failed = true; return node;}
                NoViableAltException nvae_d32s0 =
                    new NoViableAltException("", 32, 0, input);

                throw nvae_d32s0;
            }
            switch (alt32) 
            {
                case 1 :
                    // Compiler\\Grammar\\AplusParser.g:465:4: CharachterConstantSQ
                    {
                    	CharachterConstantSQ73=(IToken)Match(input,CharachterConstantSQ,FOLLOW_CharachterConstantSQ_in_characterConstant3060); if (state.failed) return node;
                    	if ( (state.backtracking==0) )
                    	{
                    	   node = AST.Node.SingeQuotedConstant(((CharachterConstantSQ73 != null) ? CharachterConstantSQ73.Text : null)); 
                    	}

                    }
                    break;
                case 2 :
                    // Compiler\\Grammar\\AplusParser.g:466:4: CharachterConstantDQ
                    {
                    	CharachterConstantDQ74=(IToken)Match(input,CharachterConstantDQ,FOLLOW_CharachterConstantDQ_in_characterConstant3070); if (state.failed) return node;
                    	if ( (state.backtracking==0) )
                    	{
                    	   node = AST.Node.DoubleQuotedConstant(((CharachterConstantDQ74 != null) ? CharachterConstantDQ74.Text : null)); 
                    	}

                    }
                    break;

            }
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 32, characterConstant_StartIndex); 
            }
        }
        return node;
    }
    // $ANTLR end "characterConstant"


    // $ANTLR start "variableName"
    // Compiler\\Grammar\\AplusParser.g:469:1: variableName returns [AST.Identifier node] : ( SystemName | QualifiedName | UnqualifiedName );
    public AST.Identifier variableName() // throws RecognitionException [1]
    {   
        AST.Identifier node = default(AST.Identifier);
        int variableName_StartIndex = input.Index();
        IToken SystemName75 = null;
        IToken QualifiedName76 = null;
        IToken UnqualifiedName77 = null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 33) ) 
    	    {
    	    	return node; 
    	    }
            // Compiler\\Grammar\\AplusParser.g:470:3: ( SystemName | QualifiedName | UnqualifiedName )
            int alt33 = 3;
            switch ( input.LA(1) ) 
            {
            case SystemName:
            	{
                alt33 = 1;
                }
                break;
            case QualifiedName:
            	{
                alt33 = 2;
                }
                break;
            case UnqualifiedName:
            	{
                alt33 = 3;
                }
                break;
            	default:
            	    if ( state.backtracking > 0 ) {state.failed = true; return node;}
            	    NoViableAltException nvae_d33s0 =
            	        new NoViableAltException("", 33, 0, input);

            	    throw nvae_d33s0;
            }

            switch (alt33) 
            {
                case 1 :
                    // Compiler\\Grammar\\AplusParser.g:470:5: SystemName
                    {
                    	SystemName75=(IToken)Match(input,SystemName,FOLLOW_SystemName_in_variableName3091); if (state.failed) return node;
                    	if ( (state.backtracking==0) )
                    	{
                    	   node = AST.Node.SystemName(SystemName75.Text); 
                    	}

                    }
                    break;
                case 2 :
                    // Compiler\\Grammar\\AplusParser.g:472:4: QualifiedName
                    {
                    	QualifiedName76=(IToken)Match(input,QualifiedName,FOLLOW_QualifiedName_in_variableName3107); if (state.failed) return node;
                    	if ( (state.backtracking==0) )
                    	{
                    	   
                    	  												node = AST.Node.QualifiedName(QualifiedName76.Text);

                    	  												if(this.isdependency)
                    	  												{
                    	  													this.variables.AddAccess(node);
                    	  												}
                    	  											
                    	}

                    }
                    break;
                case 3 :
                    // Compiler\\Grammar\\AplusParser.g:480:4: UnqualifiedName
                    {
                    	UnqualifiedName77=(IToken)Match(input,UnqualifiedName,FOLLOW_UnqualifiedName_in_variableName3119); if (state.failed) return node;
                    	if ( (state.backtracking==0) )
                    	{
                    	   
                    	  												node = AST.Node.UnQualifiedName(UnqualifiedName77.Text);

                    	  												if(this.isdependency)
                    	  												{
                    	  													this.variables.AddAccess(node);
                    	  												}
                    	  											
                    	}

                    }
                    break;

            }
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 33, variableName_StartIndex); 
            }
        }
        return node;
    }
    // $ANTLR end "variableName"

    // $ANTLR start "synpred1_AplusParser"
    public void synpred1_AplusParser_fragment() {
        AST.Node items = default(AST.Node);


        // Compiler\\Grammar\\AplusParser.g:23:6: (items= statement NewLine )
        // Compiler\\Grammar\\AplusParser.g:23:6: items= statement NewLine
        {
        	PushFollow(FOLLOW_statement_in_synpred1_AplusParser100);
        	items = statement();
        	state.followingStackPointer--;
        	if (state.failed) return ;
        	Match(input,NewLine,FOLLOW_NewLine_in_synpred1_AplusParser112); if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred1_AplusParser"

    // $ANTLR start "synpred3_AplusParser"
    public void synpred3_AplusParser_fragment() {
        // Compiler\\Grammar\\AplusParser.g:31:4: ( dependencyDefinition )
        // Compiler\\Grammar\\AplusParser.g:31:4: dependencyDefinition
        {
        	PushFollow(FOLLOW_dependencyDefinition_in_synpred3_AplusParser160);
        	dependencyDefinition();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred3_AplusParser"

    // $ANTLR start "synpred4_AplusParser"
    public void synpred4_AplusParser_fragment() {
        // Compiler\\Grammar\\AplusParser.g:32:4: ( userDefinedOperator )
        // Compiler\\Grammar\\AplusParser.g:32:4: userDefinedOperator
        {
        	PushFollow(FOLLOW_userDefinedOperator_in_synpred4_AplusParser170);
        	userDefinedOperator();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred4_AplusParser"

    // $ANTLR start "synpred5_AplusParser"
    public void synpred5_AplusParser_fragment() {
        // Compiler\\Grammar\\AplusParser.g:33:4: ( userDefinedFunction )
        // Compiler\\Grammar\\AplusParser.g:33:4: userDefinedFunction
        {
        	PushFollow(FOLLOW_userDefinedFunction_in_synpred5_AplusParser181);
        	userDefinedFunction();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred5_AplusParser"

    // $ANTLR start "synpred15_AplusParser"
    public void synpred15_AplusParser_fragment() {
        // Compiler\\Grammar\\AplusParser.g:122:4: ( expression )
        // Compiler\\Grammar\\AplusParser.g:122:4: expression
        {
        	PushFollow(FOLLOW_expression_in_synpred15_AplusParser667);
        	expression();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred15_AplusParser"

    // $ANTLR start "synpred16_AplusParser"
    public void synpred16_AplusParser_fragment() {
        // Compiler\\Grammar\\AplusParser.g:123:4: ( operatorSymbol )
        // Compiler\\Grammar\\AplusParser.g:123:4: operatorSymbol
        {
        	PushFollow(FOLLOW_operatorSymbol_in_synpred16_AplusParser680);
        	operatorSymbol();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred16_AplusParser"

    // $ANTLR start "synpred17_AplusParser"
    public void synpred17_AplusParser_fragment() {
        // Compiler\\Grammar\\AplusParser.g:124:4: ( functionSymbol )
        // Compiler\\Grammar\\AplusParser.g:124:4: functionSymbol
        {
        	PushFollow(FOLLOW_functionSymbol_in_synpred17_AplusParser692);
        	functionSymbol();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred17_AplusParser"

    // $ANTLR start "synpred18_AplusParser"
    public void synpred18_AplusParser_fragment() {
        // Compiler\\Grammar\\AplusParser.g:129:4: ( LSB RSB )
        // Compiler\\Grammar\\AplusParser.g:129:4: LSB RSB
        {
        	Match(input,LSB,FOLLOW_LSB_in_synpred18_AplusParser727); if (state.failed) return ;
        	Match(input,RSB,FOLLOW_RSB_in_synpred18_AplusParser729); if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred18_AplusParser"

    // $ANTLR start "synpred20_AplusParser"
    public void synpred20_AplusParser_fragment() {
        AST.Node lhs = default(AST.Node);

        AST.Node func = default(AST.Node);

        AST.Node rhs = default(AST.Node);


        // Compiler\\Grammar\\AplusParser.g:135:4: (lhs= dyadicLeftArg func= dyadicFunctionSelector rhs= expression )
        // Compiler\\Grammar\\AplusParser.g:135:4: lhs= dyadicLeftArg func= dyadicFunctionSelector rhs= expression
        {
        	PushFollow(FOLLOW_dyadicLeftArg_in_synpred20_AplusParser783);
        	lhs = dyadicLeftArg();
        	state.followingStackPointer--;
        	if (state.failed) return ;
        	PushFollow(FOLLOW_dyadicFunctionSelector_in_synpred20_AplusParser787);
        	func = dyadicFunctionSelector();
        	state.followingStackPointer--;
        	if (state.failed) return ;
        	PushFollow(FOLLOW_expression_in_synpred20_AplusParser791);
        	rhs = expression();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred20_AplusParser"

    // $ANTLR start "synpred21_AplusParser"
    public void synpred21_AplusParser_fragment() {
        AST.Node func = default(AST.Node);

        AST.Node arg = default(AST.Node);


        // Compiler\\Grammar\\AplusParser.g:160:4: (func= monadicFunctionSelector arg= expression )
        // Compiler\\Grammar\\AplusParser.g:160:4: func= monadicFunctionSelector arg= expression
        {
        	PushFollow(FOLLOW_monadicFunctionSelector_in_synpred21_AplusParser803);
        	func = monadicFunctionSelector();
        	state.followingStackPointer--;
        	if (state.failed) return ;
        	PushFollow(FOLLOW_expression_in_synpred21_AplusParser807);
        	arg = expression();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred21_AplusParser"

    // $ANTLR start "synpred22_AplusParser"
    public void synpred22_AplusParser_fragment() {
        // Compiler\\Grammar\\AplusParser.g:192:4: ( operatorSymbol )
        // Compiler\\Grammar\\AplusParser.g:192:4: operatorSymbol
        {
        	PushFollow(FOLLOW_operatorSymbol_in_synpred22_AplusParser837);
        	operatorSymbol();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred22_AplusParser"

    // $ANTLR start "synpred23_AplusParser"
    public void synpred23_AplusParser_fragment() {
        // Compiler\\Grammar\\AplusParser.g:193:4: ( functionSymbol )
        // Compiler\\Grammar\\AplusParser.g:193:4: functionSymbol
        {
        	PushFollow(FOLLOW_functionSymbol_in_synpred23_AplusParser850);
        	functionSymbol();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred23_AplusParser"

    // $ANTLR start "synpred24_AplusParser"
    public void synpred24_AplusParser_fragment() {
        // Compiler\\Grammar\\AplusParser.g:200:4: ( operatorSymbol )
        // Compiler\\Grammar\\AplusParser.g:200:4: operatorSymbol
        {
        	PushFollow(FOLLOW_operatorSymbol_in_synpred24_AplusParser888);
        	operatorSymbol();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred24_AplusParser"

    // $ANTLR start "synpred25_AplusParser"
    public void synpred25_AplusParser_fragment() {
        // Compiler\\Grammar\\AplusParser.g:201:4: ( functionSymbol )
        // Compiler\\Grammar\\AplusParser.g:201:4: functionSymbol
        {
        	PushFollow(FOLLOW_functionSymbol_in_synpred25_AplusParser901);
        	functionSymbol();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred25_AplusParser"

    // $ANTLR start "synpred26_AplusParser"
    public void synpred26_AplusParser_fragment() {
        // Compiler\\Grammar\\AplusParser.g:207:4: ( operatorSymbol expressionGroup )
        // Compiler\\Grammar\\AplusParser.g:207:4: operatorSymbol expressionGroup
        {
        	PushFollow(FOLLOW_operatorSymbol_in_synpred26_AplusParser938);
        	operatorSymbol();
        	state.followingStackPointer--;
        	if (state.failed) return ;
        	PushFollow(FOLLOW_expressionGroup_in_synpred26_AplusParser940);
        	expressionGroup();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred26_AplusParser"

    // $ANTLR start "synpred27_AplusParser"
    public void synpred27_AplusParser_fragment() {
        // Compiler\\Grammar\\AplusParser.g:208:4: ( functionSymbol expressionGroup )
        // Compiler\\Grammar\\AplusParser.g:208:4: functionSymbol expressionGroup
        {
        	PushFollow(FOLLOW_functionSymbol_in_synpred27_AplusParser949);
        	functionSymbol();
        	state.followingStackPointer--;
        	if (state.failed) return ;
        	PushFollow(FOLLOW_expressionGroup_in_synpred27_AplusParser951);
        	expressionGroup();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred27_AplusParser"

    // $ANTLR start "synpred28_AplusParser"
    public void synpred28_AplusParser_fragment() {
        // Compiler\\Grammar\\AplusParser.g:217:4: ( opTail )
        // Compiler\\Grammar\\AplusParser.g:217:4: opTail
        {
        	PushFollow(FOLLOW_opTail_in_synpred28_AplusParser1005);
        	opTail();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred28_AplusParser"

    // $ANTLR start "synpred29_AplusParser"
    public void synpred29_AplusParser_fragment() {
        // Compiler\\Grammar\\AplusParser.g:215:3: ( opArg ( opTail )+ )
        // Compiler\\Grammar\\AplusParser.g:215:3: opArg ( opTail )+
        {
        	PushFollow(FOLLOW_opArg_in_synpred29_AplusParser990);
        	opArg();
        	state.followingStackPointer--;
        	if (state.failed) return ;
        	// Compiler\\Grammar\\AplusParser.g:216:3: ( opTail )+
        	int cnt34 = 0;
        	do 
        	{
        	    int alt34 = 2;
        	    int LA34_0 = input.LA(1);

        	    if ( ((LA34_0 >= Each && LA34_0 <= Rank) || (LA34_0 >= UnqualifiedName && LA34_0 <= SystemName)) )
        	    {
        	        alt34 = 1;
        	    }


        	    switch (alt34) 
        		{
        			case 1 :
        			    // Compiler\\Grammar\\AplusParser.g:217:4: opTail
        			    {
        			    	PushFollow(FOLLOW_opTail_in_synpred29_AplusParser1005);
        			    	opTail();
        			    	state.followingStackPointer--;
        			    	if (state.failed) return ;

        			    }
        			    break;

        			default:
        			    if ( cnt34 >= 1 ) goto loop34;
        			    if ( state.backtracking > 0 ) {state.failed = true; return ;}
        		            EarlyExitException eee34 =
        		                new EarlyExitException(34, input);
        		            throw eee34;
        	    }
        	    cnt34++;
        	} while (true);

        	loop34:
        		;	// Stops C# compiler whining that label 'loop34' has no statements


        }
    }
    // $ANTLR end "synpred29_AplusParser"

    // $ANTLR start "synpred30_AplusParser"
    public void synpred30_AplusParser_fragment() {
        // Compiler\\Grammar\\AplusParser.g:235:4: ( functionSymbol )
        // Compiler\\Grammar\\AplusParser.g:235:4: functionSymbol
        {
        	PushFollow(FOLLOW_functionSymbol_in_synpred30_AplusParser1046);
        	functionSymbol();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred30_AplusParser"

    // $ANTLR start "synpred33_AplusParser"
    public void synpred33_AplusParser_fragment() {
        // Compiler\\Grammar\\AplusParser.g:243:53: ( condition )
        // Compiler\\Grammar\\AplusParser.g:243:53: condition
        {
        	PushFollow(FOLLOW_condition_in_synpred33_AplusParser1113);
        	condition();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred33_AplusParser"

    // $ANTLR start "synpred34_AplusParser"
    public void synpred34_AplusParser_fragment() {
        // Compiler\\Grammar\\AplusParser.g:243:4: ({...}? variableName ( condition | functionSymbol ) )
        // Compiler\\Grammar\\AplusParser.g:243:4: {...}? variableName ( condition | functionSymbol )
        {
        	if ( !(( IsDyadicOperator(input.LT(1)) )) ) 
        	{
        	    if ( state.backtracking > 0 ) {state.failed = true; return ;}
        	    throw new FailedPredicateException(input, "synpred34_AplusParser", " IsDyadicOperator(input.LT(1)) ");
        	}
        	PushFollow(FOLLOW_variableName_in_synpred34_AplusParser1110);
        	variableName();
        	state.followingStackPointer--;
        	if (state.failed) return ;
        	// Compiler\\Grammar\\AplusParser.g:243:52: ( condition | functionSymbol )
        	int alt35 = 2;
        	alt35 = dfa35.Predict(input);
        	switch (alt35) 
        	{
        	    case 1 :
        	        // Compiler\\Grammar\\AplusParser.g:243:53: condition
        	        {
        	        	PushFollow(FOLLOW_condition_in_synpred34_AplusParser1113);
        	        	condition();
        	        	state.followingStackPointer--;
        	        	if (state.failed) return ;

        	        }
        	        break;
        	    case 2 :
        	        // Compiler\\Grammar\\AplusParser.g:243:65: functionSymbol
        	        {
        	        	PushFollow(FOLLOW_functionSymbol_in_synpred34_AplusParser1117);
        	        	functionSymbol();
        	        	state.followingStackPointer--;
        	        	if (state.failed) return ;

        	        }
        	        break;

        	}


        }
    }
    // $ANTLR end "synpred34_AplusParser"

    // $ANTLR start "synpred124_AplusParser"
    public void synpred124_AplusParser_fragment() {
        AST.Node falsecase = default(AST.Node);


        // Compiler\\Grammar\\AplusParser.g:370:4: ( Else falsecase= topExpressionNull )
        // Compiler\\Grammar\\AplusParser.g:370:4: Else falsecase= topExpressionNull
        {
        	Match(input,Else,FOLLOW_Else_in_synpred124_AplusParser2651); if (state.failed) return ;
        	PushFollow(FOLLOW_topExpressionNull_in_synpred124_AplusParser2658);
        	falsecase = topExpressionNull();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred124_AplusParser"

    // $ANTLR start "synpred126_AplusParser"
    public void synpred126_AplusParser_fragment() {
        // Compiler\\Grammar\\AplusParser.g:390:4: ( expressionGroup )
        // Compiler\\Grammar\\AplusParser.g:390:4: expressionGroup
        {
        	PushFollow(FOLLOW_expressionGroup_in_synpred126_AplusParser2759);
        	expressionGroup();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred126_AplusParser"

    // $ANTLR start "synpred127_AplusParser"
    public void synpred127_AplusParser_fragment() {
        // Compiler\\Grammar\\AplusParser.g:408:33: ()
        // Compiler\\Grammar\\AplusParser.g:408:33: 
        {
        }
    }
    // $ANTLR end "synpred127_AplusParser"

    // $ANTLR start "synpred136_AplusParser"
    public void synpred136_AplusParser_fragment() {
        // Compiler\\Grammar\\AplusParser.g:454:5: ( numericConstant )
        // Compiler\\Grammar\\AplusParser.g:454:5: numericConstant
        {
        	PushFollow(FOLLOW_numericConstant_in_synpred136_AplusParser3004);
        	numericConstant();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred136_AplusParser"

    // $ANTLR start "synpred137_AplusParser"
    public void synpred137_AplusParser_fragment() {
        // Compiler\\Grammar\\AplusParser.g:460:5: ( SymbolConstant )
        // Compiler\\Grammar\\AplusParser.g:460:5: SymbolConstant
        {
        	Match(input,SymbolConstant,FOLLOW_SymbolConstant_in_synpred137_AplusParser3036); if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred137_AplusParser"

    // Delegated rules

   	public bool synpred21_AplusParser() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred21_AplusParser_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred18_AplusParser() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred18_AplusParser_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred20_AplusParser() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred20_AplusParser_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred127_AplusParser() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred127_AplusParser_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred34_AplusParser() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred34_AplusParser_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred27_AplusParser() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred27_AplusParser_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred136_AplusParser() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred136_AplusParser_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred24_AplusParser() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred24_AplusParser_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred3_AplusParser() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred3_AplusParser_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred29_AplusParser() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred29_AplusParser_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred137_AplusParser() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred137_AplusParser_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred1_AplusParser() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred1_AplusParser_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred4_AplusParser() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred4_AplusParser_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred26_AplusParser() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred26_AplusParser_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred17_AplusParser() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred17_AplusParser_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred124_AplusParser() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred124_AplusParser_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred23_AplusParser() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred23_AplusParser_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred22_AplusParser() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred22_AplusParser_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred30_AplusParser() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred30_AplusParser_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred33_AplusParser() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred33_AplusParser_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred28_AplusParser() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred28_AplusParser_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred25_AplusParser() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred25_AplusParser_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred5_AplusParser() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred5_AplusParser_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred16_AplusParser() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred16_AplusParser_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred126_AplusParser() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred126_AplusParser_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred15_AplusParser() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred15_AplusParser_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}


   	protected DFA1 dfa1;
   	protected DFA2 dfa2;
   	protected DFA5 dfa5;
   	protected DFA6 dfa6;
   	protected DFA9 dfa9;
   	protected DFA11 dfa11;
   	protected DFA12 dfa12;
   	protected DFA13 dfa13;
   	protected DFA14 dfa14;
   	protected DFA16 dfa16;
   	protected DFA17 dfa17;
   	protected DFA18 dfa18;
   	protected DFA23 dfa23;
   	protected DFA35 dfa35;
	private void InitializeCyclicDFAs()
	{
    	this.dfa1 = new DFA1(this);
    	this.dfa2 = new DFA2(this);
    	this.dfa5 = new DFA5(this);
    	this.dfa6 = new DFA6(this);
    	this.dfa9 = new DFA9(this);
    	this.dfa11 = new DFA11(this);
    	this.dfa12 = new DFA12(this);
    	this.dfa13 = new DFA13(this);
    	this.dfa14 = new DFA14(this);
    	this.dfa16 = new DFA16(this);
    	this.dfa17 = new DFA17(this);
    	this.dfa18 = new DFA18(this);
    	this.dfa23 = new DFA23(this);
    	this.dfa35 = new DFA35(this);
	    this.dfa1.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA1_SpecialStateTransition);
	    this.dfa2.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA2_SpecialStateTransition);
	    this.dfa9.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA9_SpecialStateTransition);
	    this.dfa11.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA11_SpecialStateTransition);
	    this.dfa12.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA12_SpecialStateTransition);
	    this.dfa13.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA13_SpecialStateTransition);
	    this.dfa14.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA14_SpecialStateTransition);
	    this.dfa16.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA16_SpecialStateTransition);
	    this.dfa17.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA17_SpecialStateTransition);
	    this.dfa18.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA18_SpecialStateTransition);
	    this.dfa23.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA23_SpecialStateTransition);
	    this.dfa35.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA35_SpecialStateTransition);
	}

    const string DFA1_eotS =
        "\x6b\uffff";
    const string DFA1_eofS =
        "\x01\x69\x6a\uffff";
    const string DFA1_minS =
        "\x01\x04\x68\x00\x02\uffff";
    const string DFA1_maxS =
        "\x01\u0081\x68\x00\x02\uffff";
    const string DFA1_acceptS =
        "\x69\uffff\x01\x02\x01\x01";
    const string DFA1_specialS =
        "\x01\uffff\x01\x00\x01\x01\x01\x02\x01\x03\x01\x04\x01\x05\x01"+
        "\x06\x01\x07\x01\x08\x01\x09\x01\x0a\x01\x0b\x01\x0c\x01\x0d\x01"+
        "\x0e\x01\x0f\x01\x10\x01\x11\x01\x12\x01\x13\x01\x14\x01\x15\x01"+
        "\x16\x01\x17\x01\x18\x01\x19\x01\x1a\x01\x1b\x01\x1c\x01\x1d\x01"+
        "\x1e\x01\x1f\x01\x20\x01\x21\x01\x22\x01\x23\x01\x24\x01\x25\x01"+
        "\x26\x01\x27\x01\x28\x01\x29\x01\x2a\x01\x2b\x01\x2c\x01\x2d\x01"+
        "\x2e\x01\x2f\x01\x30\x01\x31\x01\x32\x01\x33\x01\x34\x01\x35\x01"+
        "\x36\x01\x37\x01\x38\x01\x39\x01\x3a\x01\x3b\x01\x3c\x01\x3d\x01"+
        "\x3e\x01\x3f\x01\x40\x01\x41\x01\x42\x01\x43\x01\x44\x01\x45\x01"+
        "\x46\x01\x47\x01\x48\x01\x49\x01\x4a\x01\x4b\x01\x4c\x01\x4d\x01"+
        "\x4e\x01\x4f\x01\x50\x01\x51\x01\x52\x01\x53\x01\x54\x01\x55\x01"+
        "\x56\x01\x57\x01\x58\x01\x59\x01\x5a\x01\x5b\x01\x5c\x01\x5d\x01"+
        "\x5e\x01\x5f\x01\x60\x01\x61\x01\x62\x01\x63\x01\x64\x01\x65\x01"+
        "\x66\x01\x67\x02\uffff}>";
    static readonly string[] DFA1_transitionS = {
            "\x01\x01\x01\uffff\x01\x06\x01\uffff\x01\x5f\x01\x08\x01\x07"+
            "\x01\x44\x01\x45\x01\x46\x01\x47\x01\x48\x01\x49\x01\x4a\x01"+
            "\x4b\x01\x4c\x01\x4d\x01\x4e\x01\x4f\x01\x09\x01\x0a\x01\x0b"+
            "\x01\x0c\x01\x0d\x01\x0e\x01\x0f\x01\x10\x01\x11\x01\x12\x01"+
            "\x13\x01\x14\x01\x15\x01\x16\x01\x17\x01\x18\x01\x19\x01\x1a"+
            "\x01\x1b\x01\x1c\x01\x1d\x01\x1e\x01\x1f\x01\x20\x01\x21\x01"+
            "\x22\x01\x24\x01\x23\x01\x25\x01\x27\x01\x28\x01\x29\x01\x2a"+
            "\x01\x2b\x01\x2c\x01\x2d\x01\x2e\x01\x2f\x01\x30\x01\x31\x01"+
            "\x50\x01\x51\x01\x52\x01\x53\x01\x54\x01\x32\x01\x55\x01\x26"+
            "\x01\x33\x01\x34\x01\x35\x01\x36\x01\x37\x01\x38\x01\x39\x01"+
            "\x3a\x01\x3b\x01\x3c\x01\x3d\x01\x3e\x01\x3f\x01\x40\x01\x41"+
            "\x01\x42\x01\x43\x01\x56\x01\x57\x01\x58\x01\x59\x01\x5a\x01"+
            "\x5b\x01\x5c\x01\x5d\x01\x5e\x01\x67\x01\x05\x03\uffff\x01\x68"+
            "\x05\uffff\x01\x60\x03\uffff\x01\x6a\x02\uffff\x01\x61\x01\uffff"+
            "\x01\x62\x01\x63\x03\uffff\x01\x65\x01\x66\x02\uffff\x01\x64"+
            "\x01\x04\x01\x03\x01\x02",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "",
            ""
    };

    static readonly short[] DFA1_eot = DFA.UnpackEncodedString(DFA1_eotS);
    static readonly short[] DFA1_eof = DFA.UnpackEncodedString(DFA1_eofS);
    static readonly char[] DFA1_min = DFA.UnpackEncodedStringToUnsignedChars(DFA1_minS);
    static readonly char[] DFA1_max = DFA.UnpackEncodedStringToUnsignedChars(DFA1_maxS);
    static readonly short[] DFA1_accept = DFA.UnpackEncodedString(DFA1_acceptS);
    static readonly short[] DFA1_special = DFA.UnpackEncodedString(DFA1_specialS);
    static readonly short[][] DFA1_transition = DFA.UnpackEncodedStringArray(DFA1_transitionS);

    protected class DFA1 : DFA
    {
        public DFA1(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 1;
            this.eot = DFA1_eot;
            this.eof = DFA1_eof;
            this.min = DFA1_min;
            this.max = DFA1_max;
            this.accept = DFA1_accept;
            this.special = DFA1_special;
            this.transition = DFA1_transition;

        }

        override public string Description
        {
            get { return "()* loopback of 23:4: (items= statement NewLine )*"; }
        }

    }


    protected internal int DFA1_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            ITokenStream input = (ITokenStream)_input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA1_1 = input.LA(1);

                   	 
                   	int index1_1 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred1_AplusParser()) ) { s = 106; }

                   	else if ( (true) ) { s = 105; }

                   	 
                   	input.Seek(index1_1);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 1 : 
                   	int LA1_2 = input.LA(1);

                   	 
                   	int index1_2 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (((synpred1_AplusParser() && (  IsGlobalFunction(input.LT(1)) ))|| synpred1_AplusParser())) ) { s = 106; }

                   	else if ( (true) ) { s = 105; }

                   	 
                   	input.Seek(index1_2);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 2 : 
                   	int LA1_3 = input.LA(1);

                   	 
                   	int index1_3 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (((synpred1_AplusParser() && (  IsGlobalFunction(input.LT(1)) ))|| synpred1_AplusParser())) ) { s = 106; }

                   	else if ( (true) ) { s = 105; }

                   	 
                   	input.Seek(index1_3);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 3 : 
                   	int LA1_4 = input.LA(1);

                   	 
                   	int index1_4 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (((synpred1_AplusParser() && (  IsGlobalFunction(input.LT(1)) ))|| synpred1_AplusParser())) ) { s = 106; }

                   	else if ( (true) ) { s = 105; }

                   	 
                   	input.Seek(index1_4);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 4 : 
                   	int LA1_5 = input.LA(1);

                   	 
                   	int index1_5 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred1_AplusParser()) ) { s = 106; }

                   	else if ( (true) ) { s = 105; }

                   	 
                   	input.Seek(index1_5);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 5 : 
                   	int LA1_6 = input.LA(1);

                   	 
                   	int index1_6 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred1_AplusParser()) ) { s = 106; }

                   	else if ( (true) ) { s = 105; }

                   	 
                   	input.Seek(index1_6);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 6 : 
                   	int LA1_7 = input.LA(1);

                   	 
                   	int index1_7 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred1_AplusParser()) ) { s = 106; }

                   	else if ( (true) ) { s = 105; }

                   	 
                   	input.Seek(index1_7);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 7 : 
                   	int LA1_8 = input.LA(1);

                   	 
                   	int index1_8 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred1_AplusParser()) ) { s = 106; }

                   	else if ( (true) ) { s = 105; }

                   	 
                   	input.Seek(index1_8);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 8 : 
                   	int LA1_9 = input.LA(1);

                   	 
                   	int index1_9 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred1_AplusParser()) ) { s = 106; }

                   	else if ( (true) ) { s = 105; }

                   	 
                   	input.Seek(index1_9);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 9 : 
                   	int LA1_10 = input.LA(1);

                   	 
                   	int index1_10 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred1_AplusParser()) ) { s = 106; }

                   	else if ( (true) ) { s = 105; }

                   	 
                   	input.Seek(index1_10);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 10 : 
                   	int LA1_11 = input.LA(1);

                   	 
                   	int index1_11 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred1_AplusParser()) ) { s = 106; }

                   	else if ( (true) ) { s = 105; }

                   	 
                   	input.Seek(index1_11);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 11 : 
                   	int LA1_12 = input.LA(1);

                   	 
                   	int index1_12 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred1_AplusParser()) ) { s = 106; }

                   	else if ( (true) ) { s = 105; }

                   	 
                   	input.Seek(index1_12);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 12 : 
                   	int LA1_13 = input.LA(1);

                   	 
                   	int index1_13 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred1_AplusParser()) ) { s = 106; }

                   	else if ( (true) ) { s = 105; }

                   	 
                   	input.Seek(index1_13);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 13 : 
                   	int LA1_14 = input.LA(1);

                   	 
                   	int index1_14 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred1_AplusParser()) ) { s = 106; }

                   	else if ( (true) ) { s = 105; }

                   	 
                   	input.Seek(index1_14);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 14 : 
                   	int LA1_15 = input.LA(1);

                   	 
                   	int index1_15 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred1_AplusParser()) ) { s = 106; }

                   	else if ( (true) ) { s = 105; }

                   	 
                   	input.Seek(index1_15);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 15 : 
                   	int LA1_16 = input.LA(1);

                   	 
                   	int index1_16 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred1_AplusParser()) ) { s = 106; }

                   	else if ( (true) ) { s = 105; }

                   	 
                   	input.Seek(index1_16);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 16 : 
                   	int LA1_17 = input.LA(1);

                   	 
                   	int index1_17 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred1_AplusParser()) ) { s = 106; }

                   	else if ( (true) ) { s = 105; }

                   	 
                   	input.Seek(index1_17);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 17 : 
                   	int LA1_18 = input.LA(1);

                   	 
                   	int index1_18 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred1_AplusParser()) ) { s = 106; }

                   	else if ( (true) ) { s = 105; }

                   	 
                   	input.Seek(index1_18);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 18 : 
                   	int LA1_19 = input.LA(1);

                   	 
                   	int index1_19 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred1_AplusParser()) ) { s = 106; }

                   	else if ( (true) ) { s = 105; }

                   	 
                   	input.Seek(index1_19);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 19 : 
                   	int LA1_20 = input.LA(1);

                   	 
                   	int index1_20 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred1_AplusParser()) ) { s = 106; }

                   	else if ( (true) ) { s = 105; }

                   	 
                   	input.Seek(index1_20);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 20 : 
                   	int LA1_21 = input.LA(1);

                   	 
                   	int index1_21 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred1_AplusParser()) ) { s = 106; }

                   	else if ( (true) ) { s = 105; }

                   	 
                   	input.Seek(index1_21);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 21 : 
                   	int LA1_22 = input.LA(1);

                   	 
                   	int index1_22 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred1_AplusParser()) ) { s = 106; }

                   	else if ( (true) ) { s = 105; }

                   	 
                   	input.Seek(index1_22);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 22 : 
                   	int LA1_23 = input.LA(1);

                   	 
                   	int index1_23 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred1_AplusParser()) ) { s = 106; }

                   	else if ( (true) ) { s = 105; }

                   	 
                   	input.Seek(index1_23);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 23 : 
                   	int LA1_24 = input.LA(1);

                   	 
                   	int index1_24 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred1_AplusParser()) ) { s = 106; }

                   	else if ( (true) ) { s = 105; }

                   	 
                   	input.Seek(index1_24);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 24 : 
                   	int LA1_25 = input.LA(1);

                   	 
                   	int index1_25 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred1_AplusParser()) ) { s = 106; }

                   	else if ( (true) ) { s = 105; }

                   	 
                   	input.Seek(index1_25);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 25 : 
                   	int LA1_26 = input.LA(1);

                   	 
                   	int index1_26 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred1_AplusParser()) ) { s = 106; }

                   	else if ( (true) ) { s = 105; }

                   	 
                   	input.Seek(index1_26);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 26 : 
                   	int LA1_27 = input.LA(1);

                   	 
                   	int index1_27 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred1_AplusParser()) ) { s = 106; }

                   	else if ( (true) ) { s = 105; }

                   	 
                   	input.Seek(index1_27);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 27 : 
                   	int LA1_28 = input.LA(1);

                   	 
                   	int index1_28 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred1_AplusParser()) ) { s = 106; }

                   	else if ( (true) ) { s = 105; }

                   	 
                   	input.Seek(index1_28);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 28 : 
                   	int LA1_29 = input.LA(1);

                   	 
                   	int index1_29 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred1_AplusParser()) ) { s = 106; }

                   	else if ( (true) ) { s = 105; }

                   	 
                   	input.Seek(index1_29);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 29 : 
                   	int LA1_30 = input.LA(1);

                   	 
                   	int index1_30 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred1_AplusParser()) ) { s = 106; }

                   	else if ( (true) ) { s = 105; }

                   	 
                   	input.Seek(index1_30);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 30 : 
                   	int LA1_31 = input.LA(1);

                   	 
                   	int index1_31 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred1_AplusParser()) ) { s = 106; }

                   	else if ( (true) ) { s = 105; }

                   	 
                   	input.Seek(index1_31);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 31 : 
                   	int LA1_32 = input.LA(1);

                   	 
                   	int index1_32 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred1_AplusParser()) ) { s = 106; }

                   	else if ( (true) ) { s = 105; }

                   	 
                   	input.Seek(index1_32);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 32 : 
                   	int LA1_33 = input.LA(1);

                   	 
                   	int index1_33 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred1_AplusParser()) ) { s = 106; }

                   	else if ( (true) ) { s = 105; }

                   	 
                   	input.Seek(index1_33);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 33 : 
                   	int LA1_34 = input.LA(1);

                   	 
                   	int index1_34 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred1_AplusParser()) ) { s = 106; }

                   	else if ( (true) ) { s = 105; }

                   	 
                   	input.Seek(index1_34);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 34 : 
                   	int LA1_35 = input.LA(1);

                   	 
                   	int index1_35 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred1_AplusParser()) ) { s = 106; }

                   	else if ( (true) ) { s = 105; }

                   	 
                   	input.Seek(index1_35);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 35 : 
                   	int LA1_36 = input.LA(1);

                   	 
                   	int index1_36 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred1_AplusParser()) ) { s = 106; }

                   	else if ( (true) ) { s = 105; }

                   	 
                   	input.Seek(index1_36);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 36 : 
                   	int LA1_37 = input.LA(1);

                   	 
                   	int index1_37 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred1_AplusParser()) ) { s = 106; }

                   	else if ( (true) ) { s = 105; }

                   	 
                   	input.Seek(index1_37);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 37 : 
                   	int LA1_38 = input.LA(1);

                   	 
                   	int index1_38 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred1_AplusParser()) ) { s = 106; }

                   	else if ( (true) ) { s = 105; }

                   	 
                   	input.Seek(index1_38);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 38 : 
                   	int LA1_39 = input.LA(1);

                   	 
                   	int index1_39 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred1_AplusParser()) ) { s = 106; }

                   	else if ( (true) ) { s = 105; }

                   	 
                   	input.Seek(index1_39);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 39 : 
                   	int LA1_40 = input.LA(1);

                   	 
                   	int index1_40 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred1_AplusParser()) ) { s = 106; }

                   	else if ( (true) ) { s = 105; }

                   	 
                   	input.Seek(index1_40);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 40 : 
                   	int LA1_41 = input.LA(1);

                   	 
                   	int index1_41 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred1_AplusParser()) ) { s = 106; }

                   	else if ( (true) ) { s = 105; }

                   	 
                   	input.Seek(index1_41);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 41 : 
                   	int LA1_42 = input.LA(1);

                   	 
                   	int index1_42 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred1_AplusParser()) ) { s = 106; }

                   	else if ( (true) ) { s = 105; }

                   	 
                   	input.Seek(index1_42);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 42 : 
                   	int LA1_43 = input.LA(1);

                   	 
                   	int index1_43 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred1_AplusParser()) ) { s = 106; }

                   	else if ( (true) ) { s = 105; }

                   	 
                   	input.Seek(index1_43);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 43 : 
                   	int LA1_44 = input.LA(1);

                   	 
                   	int index1_44 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred1_AplusParser()) ) { s = 106; }

                   	else if ( (true) ) { s = 105; }

                   	 
                   	input.Seek(index1_44);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 44 : 
                   	int LA1_45 = input.LA(1);

                   	 
                   	int index1_45 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred1_AplusParser()) ) { s = 106; }

                   	else if ( (true) ) { s = 105; }

                   	 
                   	input.Seek(index1_45);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 45 : 
                   	int LA1_46 = input.LA(1);

                   	 
                   	int index1_46 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred1_AplusParser()) ) { s = 106; }

                   	else if ( (true) ) { s = 105; }

                   	 
                   	input.Seek(index1_46);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 46 : 
                   	int LA1_47 = input.LA(1);

                   	 
                   	int index1_47 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred1_AplusParser()) ) { s = 106; }

                   	else if ( (true) ) { s = 105; }

                   	 
                   	input.Seek(index1_47);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 47 : 
                   	int LA1_48 = input.LA(1);

                   	 
                   	int index1_48 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred1_AplusParser()) ) { s = 106; }

                   	else if ( (true) ) { s = 105; }

                   	 
                   	input.Seek(index1_48);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 48 : 
                   	int LA1_49 = input.LA(1);

                   	 
                   	int index1_49 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred1_AplusParser()) ) { s = 106; }

                   	else if ( (true) ) { s = 105; }

                   	 
                   	input.Seek(index1_49);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 49 : 
                   	int LA1_50 = input.LA(1);

                   	 
                   	int index1_50 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred1_AplusParser()) ) { s = 106; }

                   	else if ( (true) ) { s = 105; }

                   	 
                   	input.Seek(index1_50);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 50 : 
                   	int LA1_51 = input.LA(1);

                   	 
                   	int index1_51 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred1_AplusParser()) ) { s = 106; }

                   	else if ( (true) ) { s = 105; }

                   	 
                   	input.Seek(index1_51);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 51 : 
                   	int LA1_52 = input.LA(1);

                   	 
                   	int index1_52 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred1_AplusParser()) ) { s = 106; }

                   	else if ( (true) ) { s = 105; }

                   	 
                   	input.Seek(index1_52);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 52 : 
                   	int LA1_53 = input.LA(1);

                   	 
                   	int index1_53 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred1_AplusParser()) ) { s = 106; }

                   	else if ( (true) ) { s = 105; }

                   	 
                   	input.Seek(index1_53);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 53 : 
                   	int LA1_54 = input.LA(1);

                   	 
                   	int index1_54 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred1_AplusParser()) ) { s = 106; }

                   	else if ( (true) ) { s = 105; }

                   	 
                   	input.Seek(index1_54);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 54 : 
                   	int LA1_55 = input.LA(1);

                   	 
                   	int index1_55 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred1_AplusParser()) ) { s = 106; }

                   	else if ( (true) ) { s = 105; }

                   	 
                   	input.Seek(index1_55);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 55 : 
                   	int LA1_56 = input.LA(1);

                   	 
                   	int index1_56 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred1_AplusParser()) ) { s = 106; }

                   	else if ( (true) ) { s = 105; }

                   	 
                   	input.Seek(index1_56);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 56 : 
                   	int LA1_57 = input.LA(1);

                   	 
                   	int index1_57 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred1_AplusParser()) ) { s = 106; }

                   	else if ( (true) ) { s = 105; }

                   	 
                   	input.Seek(index1_57);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 57 : 
                   	int LA1_58 = input.LA(1);

                   	 
                   	int index1_58 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred1_AplusParser()) ) { s = 106; }

                   	else if ( (true) ) { s = 105; }

                   	 
                   	input.Seek(index1_58);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 58 : 
                   	int LA1_59 = input.LA(1);

                   	 
                   	int index1_59 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred1_AplusParser()) ) { s = 106; }

                   	else if ( (true) ) { s = 105; }

                   	 
                   	input.Seek(index1_59);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 59 : 
                   	int LA1_60 = input.LA(1);

                   	 
                   	int index1_60 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred1_AplusParser()) ) { s = 106; }

                   	else if ( (true) ) { s = 105; }

                   	 
                   	input.Seek(index1_60);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 60 : 
                   	int LA1_61 = input.LA(1);

                   	 
                   	int index1_61 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred1_AplusParser()) ) { s = 106; }

                   	else if ( (true) ) { s = 105; }

                   	 
                   	input.Seek(index1_61);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 61 : 
                   	int LA1_62 = input.LA(1);

                   	 
                   	int index1_62 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred1_AplusParser()) ) { s = 106; }

                   	else if ( (true) ) { s = 105; }

                   	 
                   	input.Seek(index1_62);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 62 : 
                   	int LA1_63 = input.LA(1);

                   	 
                   	int index1_63 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred1_AplusParser()) ) { s = 106; }

                   	else if ( (true) ) { s = 105; }

                   	 
                   	input.Seek(index1_63);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 63 : 
                   	int LA1_64 = input.LA(1);

                   	 
                   	int index1_64 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred1_AplusParser()) ) { s = 106; }

                   	else if ( (true) ) { s = 105; }

                   	 
                   	input.Seek(index1_64);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 64 : 
                   	int LA1_65 = input.LA(1);

                   	 
                   	int index1_65 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred1_AplusParser()) ) { s = 106; }

                   	else if ( (true) ) { s = 105; }

                   	 
                   	input.Seek(index1_65);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 65 : 
                   	int LA1_66 = input.LA(1);

                   	 
                   	int index1_66 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred1_AplusParser()) ) { s = 106; }

                   	else if ( (true) ) { s = 105; }

                   	 
                   	input.Seek(index1_66);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 66 : 
                   	int LA1_67 = input.LA(1);

                   	 
                   	int index1_67 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred1_AplusParser()) ) { s = 106; }

                   	else if ( (true) ) { s = 105; }

                   	 
                   	input.Seek(index1_67);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 67 : 
                   	int LA1_68 = input.LA(1);

                   	 
                   	int index1_68 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred1_AplusParser()) ) { s = 106; }

                   	else if ( (true) ) { s = 105; }

                   	 
                   	input.Seek(index1_68);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 68 : 
                   	int LA1_69 = input.LA(1);

                   	 
                   	int index1_69 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred1_AplusParser()) ) { s = 106; }

                   	else if ( (true) ) { s = 105; }

                   	 
                   	input.Seek(index1_69);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 69 : 
                   	int LA1_70 = input.LA(1);

                   	 
                   	int index1_70 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred1_AplusParser()) ) { s = 106; }

                   	else if ( (true) ) { s = 105; }

                   	 
                   	input.Seek(index1_70);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 70 : 
                   	int LA1_71 = input.LA(1);

                   	 
                   	int index1_71 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred1_AplusParser()) ) { s = 106; }

                   	else if ( (true) ) { s = 105; }

                   	 
                   	input.Seek(index1_71);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 71 : 
                   	int LA1_72 = input.LA(1);

                   	 
                   	int index1_72 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred1_AplusParser()) ) { s = 106; }

                   	else if ( (true) ) { s = 105; }

                   	 
                   	input.Seek(index1_72);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 72 : 
                   	int LA1_73 = input.LA(1);

                   	 
                   	int index1_73 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred1_AplusParser()) ) { s = 106; }

                   	else if ( (true) ) { s = 105; }

                   	 
                   	input.Seek(index1_73);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 73 : 
                   	int LA1_74 = input.LA(1);

                   	 
                   	int index1_74 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred1_AplusParser()) ) { s = 106; }

                   	else if ( (true) ) { s = 105; }

                   	 
                   	input.Seek(index1_74);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 74 : 
                   	int LA1_75 = input.LA(1);

                   	 
                   	int index1_75 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred1_AplusParser()) ) { s = 106; }

                   	else if ( (true) ) { s = 105; }

                   	 
                   	input.Seek(index1_75);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 75 : 
                   	int LA1_76 = input.LA(1);

                   	 
                   	int index1_76 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred1_AplusParser()) ) { s = 106; }

                   	else if ( (true) ) { s = 105; }

                   	 
                   	input.Seek(index1_76);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 76 : 
                   	int LA1_77 = input.LA(1);

                   	 
                   	int index1_77 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred1_AplusParser()) ) { s = 106; }

                   	else if ( (true) ) { s = 105; }

                   	 
                   	input.Seek(index1_77);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 77 : 
                   	int LA1_78 = input.LA(1);

                   	 
                   	int index1_78 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred1_AplusParser()) ) { s = 106; }

                   	else if ( (true) ) { s = 105; }

                   	 
                   	input.Seek(index1_78);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 78 : 
                   	int LA1_79 = input.LA(1);

                   	 
                   	int index1_79 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred1_AplusParser()) ) { s = 106; }

                   	else if ( (true) ) { s = 105; }

                   	 
                   	input.Seek(index1_79);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 79 : 
                   	int LA1_80 = input.LA(1);

                   	 
                   	int index1_80 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred1_AplusParser()) ) { s = 106; }

                   	else if ( (true) ) { s = 105; }

                   	 
                   	input.Seek(index1_80);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 80 : 
                   	int LA1_81 = input.LA(1);

                   	 
                   	int index1_81 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred1_AplusParser()) ) { s = 106; }

                   	else if ( (true) ) { s = 105; }

                   	 
                   	input.Seek(index1_81);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 81 : 
                   	int LA1_82 = input.LA(1);

                   	 
                   	int index1_82 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred1_AplusParser()) ) { s = 106; }

                   	else if ( (true) ) { s = 105; }

                   	 
                   	input.Seek(index1_82);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 82 : 
                   	int LA1_83 = input.LA(1);

                   	 
                   	int index1_83 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred1_AplusParser()) ) { s = 106; }

                   	else if ( (true) ) { s = 105; }

                   	 
                   	input.Seek(index1_83);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 83 : 
                   	int LA1_84 = input.LA(1);

                   	 
                   	int index1_84 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred1_AplusParser()) ) { s = 106; }

                   	else if ( (true) ) { s = 105; }

                   	 
                   	input.Seek(index1_84);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 84 : 
                   	int LA1_85 = input.LA(1);

                   	 
                   	int index1_85 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred1_AplusParser()) ) { s = 106; }

                   	else if ( (true) ) { s = 105; }

                   	 
                   	input.Seek(index1_85);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 85 : 
                   	int LA1_86 = input.LA(1);

                   	 
                   	int index1_86 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred1_AplusParser()) ) { s = 106; }

                   	else if ( (true) ) { s = 105; }

                   	 
                   	input.Seek(index1_86);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 86 : 
                   	int LA1_87 = input.LA(1);

                   	 
                   	int index1_87 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred1_AplusParser()) ) { s = 106; }

                   	else if ( (true) ) { s = 105; }

                   	 
                   	input.Seek(index1_87);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 87 : 
                   	int LA1_88 = input.LA(1);

                   	 
                   	int index1_88 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred1_AplusParser()) ) { s = 106; }

                   	else if ( (true) ) { s = 105; }

                   	 
                   	input.Seek(index1_88);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 88 : 
                   	int LA1_89 = input.LA(1);

                   	 
                   	int index1_89 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred1_AplusParser()) ) { s = 106; }

                   	else if ( (true) ) { s = 105; }

                   	 
                   	input.Seek(index1_89);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 89 : 
                   	int LA1_90 = input.LA(1);

                   	 
                   	int index1_90 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred1_AplusParser()) ) { s = 106; }

                   	else if ( (true) ) { s = 105; }

                   	 
                   	input.Seek(index1_90);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 90 : 
                   	int LA1_91 = input.LA(1);

                   	 
                   	int index1_91 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred1_AplusParser()) ) { s = 106; }

                   	else if ( (true) ) { s = 105; }

                   	 
                   	input.Seek(index1_91);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 91 : 
                   	int LA1_92 = input.LA(1);

                   	 
                   	int index1_92 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred1_AplusParser()) ) { s = 106; }

                   	else if ( (true) ) { s = 105; }

                   	 
                   	input.Seek(index1_92);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 92 : 
                   	int LA1_93 = input.LA(1);

                   	 
                   	int index1_93 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred1_AplusParser()) ) { s = 106; }

                   	else if ( (true) ) { s = 105; }

                   	 
                   	input.Seek(index1_93);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 93 : 
                   	int LA1_94 = input.LA(1);

                   	 
                   	int index1_94 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred1_AplusParser()) ) { s = 106; }

                   	else if ( (true) ) { s = 105; }

                   	 
                   	input.Seek(index1_94);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 94 : 
                   	int LA1_95 = input.LA(1);

                   	 
                   	int index1_95 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred1_AplusParser()) ) { s = 106; }

                   	else if ( (true) ) { s = 105; }

                   	 
                   	input.Seek(index1_95);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 95 : 
                   	int LA1_96 = input.LA(1);

                   	 
                   	int index1_96 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred1_AplusParser()) ) { s = 106; }

                   	else if ( (true) ) { s = 105; }

                   	 
                   	input.Seek(index1_96);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 96 : 
                   	int LA1_97 = input.LA(1);

                   	 
                   	int index1_97 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred1_AplusParser()) ) { s = 106; }

                   	else if ( (true) ) { s = 105; }

                   	 
                   	input.Seek(index1_97);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 97 : 
                   	int LA1_98 = input.LA(1);

                   	 
                   	int index1_98 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred1_AplusParser()) ) { s = 106; }

                   	else if ( (true) ) { s = 105; }

                   	 
                   	input.Seek(index1_98);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 98 : 
                   	int LA1_99 = input.LA(1);

                   	 
                   	int index1_99 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred1_AplusParser()) ) { s = 106; }

                   	else if ( (true) ) { s = 105; }

                   	 
                   	input.Seek(index1_99);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 99 : 
                   	int LA1_100 = input.LA(1);

                   	 
                   	int index1_100 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred1_AplusParser()) ) { s = 106; }

                   	else if ( (true) ) { s = 105; }

                   	 
                   	input.Seek(index1_100);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 100 : 
                   	int LA1_101 = input.LA(1);

                   	 
                   	int index1_101 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred1_AplusParser()) ) { s = 106; }

                   	else if ( (true) ) { s = 105; }

                   	 
                   	input.Seek(index1_101);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 101 : 
                   	int LA1_102 = input.LA(1);

                   	 
                   	int index1_102 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred1_AplusParser()) ) { s = 106; }

                   	else if ( (true) ) { s = 105; }

                   	 
                   	input.Seek(index1_102);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 102 : 
                   	int LA1_103 = input.LA(1);

                   	 
                   	int index1_103 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (((synpred1_AplusParser() && ( this.isfunction ))|| (synpred1_AplusParser() && ( this.isfunction )))) ) { s = 106; }

                   	else if ( (( this.isfunction )) ) { s = 105; }

                   	 
                   	input.Seek(index1_103);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 103 : 
                   	int LA1_104 = input.LA(1);

                   	 
                   	int index1_104 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred1_AplusParser()) ) { s = 106; }

                   	else if ( (true) ) { s = 105; }

                   	 
                   	input.Seek(index1_104);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        if (state.backtracking > 0) {state.failed = true; return -1;}
        NoViableAltException nvae1 =
            new NoViableAltException(dfa.Description, 1, _s, input);
        dfa.Error(nvae1);
        throw nvae1;
    }
    const string DFA2_eotS =
        "\x6e\uffff";
    const string DFA2_eofS =
        "\x01\x06\x6d\uffff";
    const string DFA2_minS =
        "\x01\x04\x01\uffff\x04\x00\x68\uffff";
    const string DFA2_maxS =
        "\x01\u0081\x01\uffff\x04\x00\x68\uffff";
    const string DFA2_acceptS =
        "\x01\uffff\x01\x01\x04\uffff\x01\x05\x64\uffff\x01\x02\x01\x03"+
        "\x01\x04";
    const string DFA2_specialS =
        "\x02\uffff\x01\x00\x01\x01\x01\x02\x01\x03\x68\uffff}>";
    static readonly string[] DFA2_transitionS = {
            "\x01\x01\x01\uffff\x01\x06\x01\uffff\x5a\x06\x01\x05\x03\uffff"+
            "\x01\x06\x05\uffff\x01\x06\x03\uffff\x01\x06\x02\uffff\x01\x06"+
            "\x01\uffff\x02\x06\x03\uffff\x02\x06\x02\uffff\x01\x06\x01\x04"+
            "\x01\x03\x01\x02",
            "",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            ""
    };

    static readonly short[] DFA2_eot = DFA.UnpackEncodedString(DFA2_eotS);
    static readonly short[] DFA2_eof = DFA.UnpackEncodedString(DFA2_eofS);
    static readonly char[] DFA2_min = DFA.UnpackEncodedStringToUnsignedChars(DFA2_minS);
    static readonly char[] DFA2_max = DFA.UnpackEncodedStringToUnsignedChars(DFA2_maxS);
    static readonly short[] DFA2_accept = DFA.UnpackEncodedString(DFA2_acceptS);
    static readonly short[] DFA2_special = DFA.UnpackEncodedString(DFA2_specialS);
    static readonly short[][] DFA2_transition = DFA.UnpackEncodedStringArray(DFA2_transitionS);

    protected class DFA2 : DFA
    {
        public DFA2(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 2;
            this.eot = DFA2_eot;
            this.eof = DFA2_eof;
            this.min = DFA2_min;
            this.max = DFA2_max;
            this.accept = DFA2_accept;
            this.special = DFA2_special;
            this.transition = DFA2_transition;

        }

        override public string Description
        {
            get { return "29:1: statement returns [AST.Node node] : ( systemCommand | dependencyDefinition | userDefinedOperator | userDefinedFunction | expressionList );"; }
        }

    }


    protected internal int DFA2_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            ITokenStream input = (ITokenStream)_input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA2_2 = input.LA(1);

                   	 
                   	int index2_2 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred3_AplusParser()) ) { s = 107; }

                   	else if ( (synpred4_AplusParser()) ) { s = 108; }

                   	else if ( (synpred5_AplusParser()) ) { s = 109; }

                   	else if ( (true) ) { s = 6; }

                   	 
                   	input.Seek(index2_2);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 1 : 
                   	int LA2_3 = input.LA(1);

                   	 
                   	int index2_3 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred3_AplusParser()) ) { s = 107; }

                   	else if ( (synpred4_AplusParser()) ) { s = 108; }

                   	else if ( (synpred5_AplusParser()) ) { s = 109; }

                   	else if ( (true) ) { s = 6; }

                   	 
                   	input.Seek(index2_3);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 2 : 
                   	int LA2_4 = input.LA(1);

                   	 
                   	int index2_4 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred3_AplusParser()) ) { s = 107; }

                   	else if ( (synpred4_AplusParser()) ) { s = 108; }

                   	else if ( (synpred5_AplusParser()) ) { s = 109; }

                   	else if ( (true) ) { s = 6; }

                   	 
                   	input.Seek(index2_4);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 3 : 
                   	int LA2_5 = input.LA(1);

                   	 
                   	int index2_5 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred4_AplusParser()) ) { s = 108; }

                   	else if ( (true) ) { s = 6; }

                   	 
                   	input.Seek(index2_5);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        if (state.backtracking > 0) {state.failed = true; return -1;}
        NoViableAltException nvae2 =
            new NoViableAltException(dfa.Description, 2, _s, input);
        dfa.Error(nvae2);
        throw nvae2;
    }
    const string DFA5_eotS =
        "\x16\uffff";
    const string DFA5_eofS =
        "\x16\uffff";
    const string DFA5_minS =
        "\x01\x62\x01\x7f\x03\x62\x04\x7f\x03\x63\x03\x7f\x02\uffff\x03"+
        "\x63\x02\uffff";
    const string DFA5_maxS =
        "\x02\u0081\x03\x62\x0a\u0081\x02\uffff\x03\u0081\x02\uffff";
    const string DFA5_acceptS =
        "\x0f\uffff\x01\x01\x01\x02\x03\uffff\x01\x04\x01\x03";
    const string DFA5_specialS =
        "\x16\uffff}>";
    static readonly string[] DFA5_transitionS = {
            "\x01\x01\x1c\uffff\x01\x04\x01\x03\x01\x02",
            "\x01\x07\x01\x06\x01\x05",
            "\x01\x08",
            "\x01\x08",
            "\x01\x08",
            "\x01\x0b\x01\x0a\x01\x09",
            "\x01\x0b\x01\x0a\x01\x09",
            "\x01\x0b\x01\x0a\x01\x09",
            "\x01\x0e\x01\x0d\x01\x0c",
            "\x01\x0f\x1b\uffff\x03\x10",
            "\x01\x0f\x1b\uffff\x03\x10",
            "\x01\x0f\x1b\uffff\x03\x10",
            "\x01\x13\x01\x12\x01\x11",
            "\x01\x13\x01\x12\x01\x11",
            "\x01\x13\x01\x12\x01\x11",
            "",
            "",
            "\x01\x15\x1b\uffff\x03\x14",
            "\x01\x15\x1b\uffff\x03\x14",
            "\x01\x15\x1b\uffff\x03\x14",
            "",
            ""
    };

    static readonly short[] DFA5_eot = DFA.UnpackEncodedString(DFA5_eotS);
    static readonly short[] DFA5_eof = DFA.UnpackEncodedString(DFA5_eofS);
    static readonly char[] DFA5_min = DFA.UnpackEncodedStringToUnsignedChars(DFA5_minS);
    static readonly char[] DFA5_max = DFA.UnpackEncodedStringToUnsignedChars(DFA5_maxS);
    static readonly short[] DFA5_accept = DFA.UnpackEncodedString(DFA5_acceptS);
    static readonly short[] DFA5_special = DFA.UnpackEncodedString(DFA5_specialS);
    static readonly short[][] DFA5_transition = DFA.UnpackEncodedStringArray(DFA5_transitionS);

    protected class DFA5 : DFA
    {
        public DFA5(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 5;
            this.eot = DFA5_eot;
            this.eof = DFA5_eof;
            this.min = DFA5_min;
            this.max = DFA5_max;
            this.accept = DFA5_accept;
            this.special = DFA5_special;
            this.transition = DFA5_transition;

        }

        override public string Description
        {
            get { return "59:1: userDefinedOperator returns [AST.UserDefOperator node] : ( LP func= variableName name= variableName RP rhs= variableName Colon functionBody | LP func= variableName name= variableName opcondition= variableName RP rhs= variableName Colon functionBody | lhs= variableName LP func= variableName name= variableName RP rhs= variableName Colon functionBody | lhs= variableName LP func= variableName name= variableName opcondition= variableName RP rhs= variableName Colon functionBody );"; }
        }

    }

    const string DFA6_eotS =
        "\x0a\uffff";
    const string DFA6_eofS =
        "\x0a\uffff";
    const string DFA6_minS =
        "\x01\x7f\x03\x6c\x03\x67\x03\uffff";
    const string DFA6_maxS =
        "\x07\u0081\x03\uffff";
    const string DFA6_acceptS =
        "\x07\uffff\x01\x01\x01\x02\x01\x03";
    const string DFA6_specialS =
        "\x0a\uffff}>";
    static readonly string[] DFA6_transitionS = {
            "\x01\x03\x01\x02\x01\x01",
            "\x01\x07\x12\uffff\x01\x06\x01\x05\x01\x04",
            "\x01\x07\x12\uffff\x01\x06\x01\x05\x01\x04",
            "\x01\x07\x12\uffff\x01\x06\x01\x05\x01\x04",
            "\x01\x09\x17\uffff\x03\x08",
            "\x01\x09\x17\uffff\x03\x08",
            "\x01\x09\x17\uffff\x03\x08",
            "",
            "",
            ""
    };

    static readonly short[] DFA6_eot = DFA.UnpackEncodedString(DFA6_eotS);
    static readonly short[] DFA6_eof = DFA.UnpackEncodedString(DFA6_eofS);
    static readonly char[] DFA6_min = DFA.UnpackEncodedStringToUnsignedChars(DFA6_minS);
    static readonly char[] DFA6_max = DFA.UnpackEncodedStringToUnsignedChars(DFA6_maxS);
    static readonly short[] DFA6_accept = DFA.UnpackEncodedString(DFA6_acceptS);
    static readonly short[] DFA6_special = DFA.UnpackEncodedString(DFA6_specialS);
    static readonly short[][] DFA6_transition = DFA.UnpackEncodedStringArray(DFA6_transitionS);

    protected class DFA6 : DFA
    {
        public DFA6(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 6;
            this.eot = DFA6_eot;
            this.eof = DFA6_eof;
            this.min = DFA6_min;
            this.max = DFA6_max;
            this.accept = DFA6_accept;
            this.special = DFA6_special;
            this.transition = DFA6_transition;

        }

        override public string Description
        {
            get { return "87:1: userDefinedFunction returns [AST.UserDefFunction node] : ( variableName expressionGroup Colon functionBody | arg1= variableName name= variableName arg2= variableName Colon functionBody | name= variableName arg1= variableName Colon functionBody );"; }
        }

    }

    const string DFA9_eotS =
        "\x70\uffff";
    const string DFA9_eofS =
        "\x01\x67\x6f\uffff";
    const string DFA9_minS =
        "\x01\x06\x03\uffff\x62\x00\x0a\uffff";
    const string DFA9_maxS =
        "\x01\u0081\x03\uffff\x62\x00\x0a\uffff";
    const string DFA9_acceptS =
        "\x01\uffff\x01\x01\x65\uffff\x01\x04\x06\uffff\x01\x02\x01\x03";
    const string DFA9_specialS =
        "\x04\uffff\x01\x00\x01\x01\x01\x02\x01\x03\x01\x04\x01\x05\x01"+
        "\x06\x01\x07\x01\x08\x01\x09\x01\x0a\x01\x0b\x01\x0c\x01\x0d\x01"+
        "\x0e\x01\x0f\x01\x10\x01\x11\x01\x12\x01\x13\x01\x14\x01\x15\x01"+
        "\x16\x01\x17\x01\x18\x01\x19\x01\x1a\x01\x1b\x01\x1c\x01\x1d\x01"+
        "\x1e\x01\x1f\x01\x20\x01\x21\x01\x22\x01\x23\x01\x24\x01\x25\x01"+
        "\x26\x01\x27\x01\x28\x01\x29\x01\x2a\x01\x2b\x01\x2c\x01\x2d\x01"+
        "\x2e\x01\x2f\x01\x30\x01\x31\x01\x32\x01\x33\x01\x34\x01\x35\x01"+
        "\x36\x01\x37\x01\x38\x01\x39\x01\x3a\x01\x3b\x01\x3c\x01\x3d\x01"+
        "\x3e\x01\x3f\x01\x40\x01\x41\x01\x42\x01\x43\x01\x44\x01\x45\x01"+
        "\x46\x01\x47\x01\x48\x01\x49\x01\x4a\x01\x4b\x01\x4c\x01\x4d\x01"+
        "\x4e\x01\x4f\x01\x50\x01\x51\x01\x52\x01\x53\x01\x54\x01\x55\x01"+
        "\x56\x01\x57\x01\x58\x01\x59\x01\x5a\x01\x5b\x01\x5c\x01\x5d\x01"+
        "\x5e\x01\x5f\x01\x60\x01\x61\x0a\uffff}>";
    static readonly string[] DFA9_transitionS = {
            "\x01\x01\x01\x67\x01\x5b\x02\x01\x01\x40\x01\x41\x01\x42\x01"+
            "\x43\x01\x44\x01\x45\x01\x46\x01\x47\x01\x48\x01\x49\x01\x4a"+
            "\x01\x4b\x01\x05\x01\x06\x01\x07\x01\x08\x01\x09\x01\x0a\x01"+
            "\x0b\x01\x0c\x01\x0d\x01\x0e\x01\x0f\x01\x10\x01\x11\x01\x12"+
            "\x01\x13\x01\x14\x01\x15\x01\x16\x01\x17\x01\x18\x01\x19\x01"+
            "\x1a\x01\x1b\x01\x1c\x01\x1d\x01\x1e\x01\x20\x01\x1f\x01\x21"+
            "\x01\x23\x01\x24\x01\x25\x01\x26\x01\x27\x01\x28\x01\x29\x01"+
            "\x2a\x01\x2b\x01\x2c\x01\x2d\x01\x4c\x01\x4d\x01\x4e\x01\x4f"+
            "\x01\x50\x01\x2e\x01\x51\x01\x22\x01\x2f\x01\x30\x01\x31\x01"+
            "\x32\x01\x33\x01\x34\x01\x35\x01\x36\x01\x37\x01\x38\x01\x39"+
            "\x01\x3a\x01\x3b\x01\x3c\x01\x3d\x01\x3e\x01\x3f\x01\x52\x01"+
            "\x53\x01\x54\x01\x55\x01\x56\x01\x57\x01\x58\x01\x59\x01\x5a"+
            "\x01\x01\x01\x04\x01\x67\x01\uffff\x02\x67\x05\uffff\x01\x5c"+
            "\x01\x67\x02\uffff\x01\x67\x02\uffff\x01\x5d\x01\uffff\x01\x5e"+
            "\x01\x5f\x03\uffff\x01\x61\x01\x62\x02\uffff\x01\x60\x01\x65"+
            "\x01\x64\x01\x63",
            "",
            "",
            "",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            ""
    };

    static readonly short[] DFA9_eot = DFA.UnpackEncodedString(DFA9_eotS);
    static readonly short[] DFA9_eof = DFA.UnpackEncodedString(DFA9_eofS);
    static readonly char[] DFA9_min = DFA.UnpackEncodedStringToUnsignedChars(DFA9_minS);
    static readonly char[] DFA9_max = DFA.UnpackEncodedStringToUnsignedChars(DFA9_maxS);
    static readonly short[] DFA9_accept = DFA.UnpackEncodedString(DFA9_acceptS);
    static readonly short[] DFA9_special = DFA.UnpackEncodedString(DFA9_specialS);
    static readonly short[][] DFA9_transition = DFA.UnpackEncodedStringArray(DFA9_transitionS);

    protected class DFA9 : DFA
    {
        public DFA9(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 9;
            this.eot = DFA9_eot;
            this.eof = DFA9_eof;
            this.min = DFA9_min;
            this.max = DFA9_max;
            this.accept = DFA9_accept;
            this.special = DFA9_special;
            this.transition = DFA9_transition;

        }

        override public string Description
        {
            get { return "121:1: topExpressionNull returns [AST.Node node] : ( expression | operatorSymbol | functionSymbol | );"; }
        }

    }


    protected internal int DFA9_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            ITokenStream input = (ITokenStream)_input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA9_4 = input.LA(1);

                   	 
                   	int index9_4 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred15_AplusParser()) ) { s = 1; }

                   	else if ( (synpred16_AplusParser()) ) { s = 110; }

                   	else if ( (synpred17_AplusParser()) ) { s = 111; }

                   	 
                   	input.Seek(index9_4);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 1 : 
                   	int LA9_5 = input.LA(1);

                   	 
                   	int index9_5 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred15_AplusParser()) ) { s = 1; }

                   	else if ( (synpred16_AplusParser()) ) { s = 110; }

                   	else if ( (synpred17_AplusParser()) ) { s = 111; }

                   	 
                   	input.Seek(index9_5);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 2 : 
                   	int LA9_6 = input.LA(1);

                   	 
                   	int index9_6 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred15_AplusParser()) ) { s = 1; }

                   	else if ( (synpred16_AplusParser()) ) { s = 110; }

                   	else if ( (synpred17_AplusParser()) ) { s = 111; }

                   	 
                   	input.Seek(index9_6);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 3 : 
                   	int LA9_7 = input.LA(1);

                   	 
                   	int index9_7 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred15_AplusParser()) ) { s = 1; }

                   	else if ( (synpred16_AplusParser()) ) { s = 110; }

                   	else if ( (synpred17_AplusParser()) ) { s = 111; }

                   	 
                   	input.Seek(index9_7);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 4 : 
                   	int LA9_8 = input.LA(1);

                   	 
                   	int index9_8 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred15_AplusParser()) ) { s = 1; }

                   	else if ( (synpred16_AplusParser()) ) { s = 110; }

                   	else if ( (synpred17_AplusParser()) ) { s = 111; }

                   	 
                   	input.Seek(index9_8);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 5 : 
                   	int LA9_9 = input.LA(1);

                   	 
                   	int index9_9 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred15_AplusParser()) ) { s = 1; }

                   	else if ( (synpred16_AplusParser()) ) { s = 110; }

                   	else if ( (synpred17_AplusParser()) ) { s = 111; }

                   	 
                   	input.Seek(index9_9);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 6 : 
                   	int LA9_10 = input.LA(1);

                   	 
                   	int index9_10 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred15_AplusParser()) ) { s = 1; }

                   	else if ( (synpred16_AplusParser()) ) { s = 110; }

                   	else if ( (synpred17_AplusParser()) ) { s = 111; }

                   	 
                   	input.Seek(index9_10);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 7 : 
                   	int LA9_11 = input.LA(1);

                   	 
                   	int index9_11 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred15_AplusParser()) ) { s = 1; }

                   	else if ( (synpred16_AplusParser()) ) { s = 110; }

                   	else if ( (synpred17_AplusParser()) ) { s = 111; }

                   	 
                   	input.Seek(index9_11);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 8 : 
                   	int LA9_12 = input.LA(1);

                   	 
                   	int index9_12 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred15_AplusParser()) ) { s = 1; }

                   	else if ( (synpred16_AplusParser()) ) { s = 110; }

                   	else if ( (synpred17_AplusParser()) ) { s = 111; }

                   	 
                   	input.Seek(index9_12);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 9 : 
                   	int LA9_13 = input.LA(1);

                   	 
                   	int index9_13 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred15_AplusParser()) ) { s = 1; }

                   	else if ( (synpred16_AplusParser()) ) { s = 110; }

                   	else if ( (synpred17_AplusParser()) ) { s = 111; }

                   	 
                   	input.Seek(index9_13);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 10 : 
                   	int LA9_14 = input.LA(1);

                   	 
                   	int index9_14 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred15_AplusParser()) ) { s = 1; }

                   	else if ( (synpred16_AplusParser()) ) { s = 110; }

                   	else if ( (synpred17_AplusParser()) ) { s = 111; }

                   	 
                   	input.Seek(index9_14);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 11 : 
                   	int LA9_15 = input.LA(1);

                   	 
                   	int index9_15 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred15_AplusParser()) ) { s = 1; }

                   	else if ( (synpred16_AplusParser()) ) { s = 110; }

                   	else if ( (synpred17_AplusParser()) ) { s = 111; }

                   	 
                   	input.Seek(index9_15);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 12 : 
                   	int LA9_16 = input.LA(1);

                   	 
                   	int index9_16 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred15_AplusParser()) ) { s = 1; }

                   	else if ( (synpred16_AplusParser()) ) { s = 110; }

                   	else if ( (synpred17_AplusParser()) ) { s = 111; }

                   	 
                   	input.Seek(index9_16);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 13 : 
                   	int LA9_17 = input.LA(1);

                   	 
                   	int index9_17 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred15_AplusParser()) ) { s = 1; }

                   	else if ( (synpred16_AplusParser()) ) { s = 110; }

                   	else if ( (synpred17_AplusParser()) ) { s = 111; }

                   	 
                   	input.Seek(index9_17);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 14 : 
                   	int LA9_18 = input.LA(1);

                   	 
                   	int index9_18 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred15_AplusParser()) ) { s = 1; }

                   	else if ( (synpred16_AplusParser()) ) { s = 110; }

                   	else if ( (synpred17_AplusParser()) ) { s = 111; }

                   	 
                   	input.Seek(index9_18);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 15 : 
                   	int LA9_19 = input.LA(1);

                   	 
                   	int index9_19 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred15_AplusParser()) ) { s = 1; }

                   	else if ( (synpred16_AplusParser()) ) { s = 110; }

                   	else if ( (synpred17_AplusParser()) ) { s = 111; }

                   	 
                   	input.Seek(index9_19);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 16 : 
                   	int LA9_20 = input.LA(1);

                   	 
                   	int index9_20 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred15_AplusParser()) ) { s = 1; }

                   	else if ( (synpred16_AplusParser()) ) { s = 110; }

                   	else if ( (synpred17_AplusParser()) ) { s = 111; }

                   	 
                   	input.Seek(index9_20);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 17 : 
                   	int LA9_21 = input.LA(1);

                   	 
                   	int index9_21 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred15_AplusParser()) ) { s = 1; }

                   	else if ( (synpred16_AplusParser()) ) { s = 110; }

                   	else if ( (synpred17_AplusParser()) ) { s = 111; }

                   	 
                   	input.Seek(index9_21);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 18 : 
                   	int LA9_22 = input.LA(1);

                   	 
                   	int index9_22 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred15_AplusParser()) ) { s = 1; }

                   	else if ( (synpred16_AplusParser()) ) { s = 110; }

                   	else if ( (synpred17_AplusParser()) ) { s = 111; }

                   	 
                   	input.Seek(index9_22);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 19 : 
                   	int LA9_23 = input.LA(1);

                   	 
                   	int index9_23 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred15_AplusParser()) ) { s = 1; }

                   	else if ( (synpred16_AplusParser()) ) { s = 110; }

                   	else if ( (synpred17_AplusParser()) ) { s = 111; }

                   	 
                   	input.Seek(index9_23);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 20 : 
                   	int LA9_24 = input.LA(1);

                   	 
                   	int index9_24 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred15_AplusParser()) ) { s = 1; }

                   	else if ( (synpred16_AplusParser()) ) { s = 110; }

                   	else if ( (synpred17_AplusParser()) ) { s = 111; }

                   	 
                   	input.Seek(index9_24);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 21 : 
                   	int LA9_25 = input.LA(1);

                   	 
                   	int index9_25 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred15_AplusParser()) ) { s = 1; }

                   	else if ( (synpred16_AplusParser()) ) { s = 110; }

                   	else if ( (synpred17_AplusParser()) ) { s = 111; }

                   	 
                   	input.Seek(index9_25);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 22 : 
                   	int LA9_26 = input.LA(1);

                   	 
                   	int index9_26 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred15_AplusParser()) ) { s = 1; }

                   	else if ( (synpred16_AplusParser()) ) { s = 110; }

                   	else if ( (synpred17_AplusParser()) ) { s = 111; }

                   	 
                   	input.Seek(index9_26);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 23 : 
                   	int LA9_27 = input.LA(1);

                   	 
                   	int index9_27 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred15_AplusParser()) ) { s = 1; }

                   	else if ( (synpred16_AplusParser()) ) { s = 110; }

                   	else if ( (synpred17_AplusParser()) ) { s = 111; }

                   	 
                   	input.Seek(index9_27);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 24 : 
                   	int LA9_28 = input.LA(1);

                   	 
                   	int index9_28 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred15_AplusParser()) ) { s = 1; }

                   	else if ( (synpred16_AplusParser()) ) { s = 110; }

                   	else if ( (synpred17_AplusParser()) ) { s = 111; }

                   	 
                   	input.Seek(index9_28);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 25 : 
                   	int LA9_29 = input.LA(1);

                   	 
                   	int index9_29 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred15_AplusParser()) ) { s = 1; }

                   	else if ( (synpred16_AplusParser()) ) { s = 110; }

                   	else if ( (synpred17_AplusParser()) ) { s = 111; }

                   	 
                   	input.Seek(index9_29);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 26 : 
                   	int LA9_30 = input.LA(1);

                   	 
                   	int index9_30 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred15_AplusParser()) ) { s = 1; }

                   	else if ( (synpred16_AplusParser()) ) { s = 110; }

                   	else if ( (synpred17_AplusParser()) ) { s = 111; }

                   	 
                   	input.Seek(index9_30);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 27 : 
                   	int LA9_31 = input.LA(1);

                   	 
                   	int index9_31 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred15_AplusParser()) ) { s = 1; }

                   	else if ( (synpred16_AplusParser()) ) { s = 110; }

                   	else if ( (synpred17_AplusParser()) ) { s = 111; }

                   	 
                   	input.Seek(index9_31);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 28 : 
                   	int LA9_32 = input.LA(1);

                   	 
                   	int index9_32 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred15_AplusParser()) ) { s = 1; }

                   	else if ( (synpred16_AplusParser()) ) { s = 110; }

                   	else if ( (synpred17_AplusParser()) ) { s = 111; }

                   	 
                   	input.Seek(index9_32);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 29 : 
                   	int LA9_33 = input.LA(1);

                   	 
                   	int index9_33 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred15_AplusParser()) ) { s = 1; }

                   	else if ( (synpred16_AplusParser()) ) { s = 110; }

                   	else if ( (synpred17_AplusParser()) ) { s = 111; }

                   	 
                   	input.Seek(index9_33);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 30 : 
                   	int LA9_34 = input.LA(1);

                   	 
                   	int index9_34 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred15_AplusParser()) ) { s = 1; }

                   	else if ( (synpred16_AplusParser()) ) { s = 110; }

                   	else if ( (synpred17_AplusParser()) ) { s = 111; }

                   	 
                   	input.Seek(index9_34);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 31 : 
                   	int LA9_35 = input.LA(1);

                   	 
                   	int index9_35 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred15_AplusParser()) ) { s = 1; }

                   	else if ( (synpred16_AplusParser()) ) { s = 110; }

                   	else if ( (synpred17_AplusParser()) ) { s = 111; }

                   	 
                   	input.Seek(index9_35);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 32 : 
                   	int LA9_36 = input.LA(1);

                   	 
                   	int index9_36 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred15_AplusParser()) ) { s = 1; }

                   	else if ( (synpred16_AplusParser()) ) { s = 110; }

                   	else if ( (synpred17_AplusParser()) ) { s = 111; }

                   	 
                   	input.Seek(index9_36);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 33 : 
                   	int LA9_37 = input.LA(1);

                   	 
                   	int index9_37 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred15_AplusParser()) ) { s = 1; }

                   	else if ( (synpred16_AplusParser()) ) { s = 110; }

                   	else if ( (synpred17_AplusParser()) ) { s = 111; }

                   	 
                   	input.Seek(index9_37);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 34 : 
                   	int LA9_38 = input.LA(1);

                   	 
                   	int index9_38 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred15_AplusParser()) ) { s = 1; }

                   	else if ( (synpred16_AplusParser()) ) { s = 110; }

                   	else if ( (synpred17_AplusParser()) ) { s = 111; }

                   	 
                   	input.Seek(index9_38);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 35 : 
                   	int LA9_39 = input.LA(1);

                   	 
                   	int index9_39 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred15_AplusParser()) ) { s = 1; }

                   	else if ( (synpred16_AplusParser()) ) { s = 110; }

                   	else if ( (synpred17_AplusParser()) ) { s = 111; }

                   	 
                   	input.Seek(index9_39);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 36 : 
                   	int LA9_40 = input.LA(1);

                   	 
                   	int index9_40 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred15_AplusParser()) ) { s = 1; }

                   	else if ( (synpred16_AplusParser()) ) { s = 110; }

                   	else if ( (synpred17_AplusParser()) ) { s = 111; }

                   	 
                   	input.Seek(index9_40);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 37 : 
                   	int LA9_41 = input.LA(1);

                   	 
                   	int index9_41 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred15_AplusParser()) ) { s = 1; }

                   	else if ( (synpred16_AplusParser()) ) { s = 110; }

                   	else if ( (synpred17_AplusParser()) ) { s = 111; }

                   	 
                   	input.Seek(index9_41);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 38 : 
                   	int LA9_42 = input.LA(1);

                   	 
                   	int index9_42 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred15_AplusParser()) ) { s = 1; }

                   	else if ( (synpred16_AplusParser()) ) { s = 110; }

                   	else if ( (synpred17_AplusParser()) ) { s = 111; }

                   	 
                   	input.Seek(index9_42);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 39 : 
                   	int LA9_43 = input.LA(1);

                   	 
                   	int index9_43 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred15_AplusParser()) ) { s = 1; }

                   	else if ( (synpred16_AplusParser()) ) { s = 110; }

                   	else if ( (synpred17_AplusParser()) ) { s = 111; }

                   	 
                   	input.Seek(index9_43);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 40 : 
                   	int LA9_44 = input.LA(1);

                   	 
                   	int index9_44 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred15_AplusParser()) ) { s = 1; }

                   	else if ( (synpred16_AplusParser()) ) { s = 110; }

                   	else if ( (synpred17_AplusParser()) ) { s = 111; }

                   	 
                   	input.Seek(index9_44);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 41 : 
                   	int LA9_45 = input.LA(1);

                   	 
                   	int index9_45 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred15_AplusParser()) ) { s = 1; }

                   	else if ( (synpred16_AplusParser()) ) { s = 110; }

                   	else if ( (synpred17_AplusParser()) ) { s = 111; }

                   	 
                   	input.Seek(index9_45);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 42 : 
                   	int LA9_46 = input.LA(1);

                   	 
                   	int index9_46 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred15_AplusParser()) ) { s = 1; }

                   	else if ( (synpred16_AplusParser()) ) { s = 110; }

                   	else if ( (synpred17_AplusParser()) ) { s = 111; }

                   	 
                   	input.Seek(index9_46);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 43 : 
                   	int LA9_47 = input.LA(1);

                   	 
                   	int index9_47 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred15_AplusParser()) ) { s = 1; }

                   	else if ( (synpred16_AplusParser()) ) { s = 110; }

                   	else if ( (synpred17_AplusParser()) ) { s = 111; }

                   	 
                   	input.Seek(index9_47);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 44 : 
                   	int LA9_48 = input.LA(1);

                   	 
                   	int index9_48 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred15_AplusParser()) ) { s = 1; }

                   	else if ( (synpred16_AplusParser()) ) { s = 110; }

                   	else if ( (synpred17_AplusParser()) ) { s = 111; }

                   	 
                   	input.Seek(index9_48);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 45 : 
                   	int LA9_49 = input.LA(1);

                   	 
                   	int index9_49 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred15_AplusParser()) ) { s = 1; }

                   	else if ( (synpred16_AplusParser()) ) { s = 110; }

                   	else if ( (synpred17_AplusParser()) ) { s = 111; }

                   	 
                   	input.Seek(index9_49);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 46 : 
                   	int LA9_50 = input.LA(1);

                   	 
                   	int index9_50 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred15_AplusParser()) ) { s = 1; }

                   	else if ( (synpred16_AplusParser()) ) { s = 110; }

                   	else if ( (synpred17_AplusParser()) ) { s = 111; }

                   	 
                   	input.Seek(index9_50);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 47 : 
                   	int LA9_51 = input.LA(1);

                   	 
                   	int index9_51 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred15_AplusParser()) ) { s = 1; }

                   	else if ( (synpred16_AplusParser()) ) { s = 110; }

                   	else if ( (synpred17_AplusParser()) ) { s = 111; }

                   	 
                   	input.Seek(index9_51);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 48 : 
                   	int LA9_52 = input.LA(1);

                   	 
                   	int index9_52 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred15_AplusParser()) ) { s = 1; }

                   	else if ( (synpred16_AplusParser()) ) { s = 110; }

                   	else if ( (synpred17_AplusParser()) ) { s = 111; }

                   	 
                   	input.Seek(index9_52);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 49 : 
                   	int LA9_53 = input.LA(1);

                   	 
                   	int index9_53 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred15_AplusParser()) ) { s = 1; }

                   	else if ( (synpred16_AplusParser()) ) { s = 110; }

                   	else if ( (synpred17_AplusParser()) ) { s = 111; }

                   	 
                   	input.Seek(index9_53);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 50 : 
                   	int LA9_54 = input.LA(1);

                   	 
                   	int index9_54 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred15_AplusParser()) ) { s = 1; }

                   	else if ( (synpred16_AplusParser()) ) { s = 110; }

                   	else if ( (synpred17_AplusParser()) ) { s = 111; }

                   	 
                   	input.Seek(index9_54);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 51 : 
                   	int LA9_55 = input.LA(1);

                   	 
                   	int index9_55 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred15_AplusParser()) ) { s = 1; }

                   	else if ( (synpred16_AplusParser()) ) { s = 110; }

                   	else if ( (synpred17_AplusParser()) ) { s = 111; }

                   	 
                   	input.Seek(index9_55);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 52 : 
                   	int LA9_56 = input.LA(1);

                   	 
                   	int index9_56 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred15_AplusParser()) ) { s = 1; }

                   	else if ( (synpred16_AplusParser()) ) { s = 110; }

                   	else if ( (synpred17_AplusParser()) ) { s = 111; }

                   	 
                   	input.Seek(index9_56);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 53 : 
                   	int LA9_57 = input.LA(1);

                   	 
                   	int index9_57 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred15_AplusParser()) ) { s = 1; }

                   	else if ( (synpred16_AplusParser()) ) { s = 110; }

                   	else if ( (synpred17_AplusParser()) ) { s = 111; }

                   	 
                   	input.Seek(index9_57);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 54 : 
                   	int LA9_58 = input.LA(1);

                   	 
                   	int index9_58 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred15_AplusParser()) ) { s = 1; }

                   	else if ( (synpred16_AplusParser()) ) { s = 110; }

                   	else if ( (synpred17_AplusParser()) ) { s = 111; }

                   	 
                   	input.Seek(index9_58);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 55 : 
                   	int LA9_59 = input.LA(1);

                   	 
                   	int index9_59 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred15_AplusParser()) ) { s = 1; }

                   	else if ( (synpred16_AplusParser()) ) { s = 110; }

                   	else if ( (synpred17_AplusParser()) ) { s = 111; }

                   	 
                   	input.Seek(index9_59);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 56 : 
                   	int LA9_60 = input.LA(1);

                   	 
                   	int index9_60 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred15_AplusParser()) ) { s = 1; }

                   	else if ( (synpred16_AplusParser()) ) { s = 110; }

                   	else if ( (synpred17_AplusParser()) ) { s = 111; }

                   	 
                   	input.Seek(index9_60);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 57 : 
                   	int LA9_61 = input.LA(1);

                   	 
                   	int index9_61 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred15_AplusParser()) ) { s = 1; }

                   	else if ( (synpred16_AplusParser()) ) { s = 110; }

                   	else if ( (synpred17_AplusParser()) ) { s = 111; }

                   	 
                   	input.Seek(index9_61);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 58 : 
                   	int LA9_62 = input.LA(1);

                   	 
                   	int index9_62 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred15_AplusParser()) ) { s = 1; }

                   	else if ( (synpred16_AplusParser()) ) { s = 110; }

                   	else if ( (synpred17_AplusParser()) ) { s = 111; }

                   	 
                   	input.Seek(index9_62);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 59 : 
                   	int LA9_63 = input.LA(1);

                   	 
                   	int index9_63 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred15_AplusParser()) ) { s = 1; }

                   	else if ( (synpred16_AplusParser()) ) { s = 110; }

                   	else if ( (synpred17_AplusParser()) ) { s = 111; }

                   	 
                   	input.Seek(index9_63);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 60 : 
                   	int LA9_64 = input.LA(1);

                   	 
                   	int index9_64 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred15_AplusParser()) ) { s = 1; }

                   	else if ( (synpred16_AplusParser()) ) { s = 110; }

                   	else if ( (synpred17_AplusParser()) ) { s = 111; }

                   	 
                   	input.Seek(index9_64);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 61 : 
                   	int LA9_65 = input.LA(1);

                   	 
                   	int index9_65 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred15_AplusParser()) ) { s = 1; }

                   	else if ( (synpred16_AplusParser()) ) { s = 110; }

                   	else if ( (synpred17_AplusParser()) ) { s = 111; }

                   	 
                   	input.Seek(index9_65);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 62 : 
                   	int LA9_66 = input.LA(1);

                   	 
                   	int index9_66 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred15_AplusParser()) ) { s = 1; }

                   	else if ( (synpred16_AplusParser()) ) { s = 110; }

                   	else if ( (synpred17_AplusParser()) ) { s = 111; }

                   	 
                   	input.Seek(index9_66);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 63 : 
                   	int LA9_67 = input.LA(1);

                   	 
                   	int index9_67 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred15_AplusParser()) ) { s = 1; }

                   	else if ( (synpred16_AplusParser()) ) { s = 110; }

                   	else if ( (synpred17_AplusParser()) ) { s = 111; }

                   	 
                   	input.Seek(index9_67);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 64 : 
                   	int LA9_68 = input.LA(1);

                   	 
                   	int index9_68 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred15_AplusParser()) ) { s = 1; }

                   	else if ( (synpred16_AplusParser()) ) { s = 110; }

                   	else if ( (synpred17_AplusParser()) ) { s = 111; }

                   	 
                   	input.Seek(index9_68);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 65 : 
                   	int LA9_69 = input.LA(1);

                   	 
                   	int index9_69 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred15_AplusParser()) ) { s = 1; }

                   	else if ( (synpred16_AplusParser()) ) { s = 110; }

                   	else if ( (synpred17_AplusParser()) ) { s = 111; }

                   	 
                   	input.Seek(index9_69);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 66 : 
                   	int LA9_70 = input.LA(1);

                   	 
                   	int index9_70 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred15_AplusParser()) ) { s = 1; }

                   	else if ( (synpred16_AplusParser()) ) { s = 110; }

                   	else if ( (synpred17_AplusParser()) ) { s = 111; }

                   	 
                   	input.Seek(index9_70);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 67 : 
                   	int LA9_71 = input.LA(1);

                   	 
                   	int index9_71 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred15_AplusParser()) ) { s = 1; }

                   	else if ( (synpred16_AplusParser()) ) { s = 110; }

                   	else if ( (synpred17_AplusParser()) ) { s = 111; }

                   	 
                   	input.Seek(index9_71);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 68 : 
                   	int LA9_72 = input.LA(1);

                   	 
                   	int index9_72 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred15_AplusParser()) ) { s = 1; }

                   	else if ( (synpred16_AplusParser()) ) { s = 110; }

                   	else if ( (synpred17_AplusParser()) ) { s = 111; }

                   	 
                   	input.Seek(index9_72);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 69 : 
                   	int LA9_73 = input.LA(1);

                   	 
                   	int index9_73 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred15_AplusParser()) ) { s = 1; }

                   	else if ( (synpred16_AplusParser()) ) { s = 110; }

                   	else if ( (synpred17_AplusParser()) ) { s = 111; }

                   	 
                   	input.Seek(index9_73);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 70 : 
                   	int LA9_74 = input.LA(1);

                   	 
                   	int index9_74 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred15_AplusParser()) ) { s = 1; }

                   	else if ( (synpred16_AplusParser()) ) { s = 110; }

                   	else if ( (synpred17_AplusParser()) ) { s = 111; }

                   	 
                   	input.Seek(index9_74);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 71 : 
                   	int LA9_75 = input.LA(1);

                   	 
                   	int index9_75 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred15_AplusParser()) ) { s = 1; }

                   	else if ( (synpred16_AplusParser()) ) { s = 110; }

                   	else if ( (synpred17_AplusParser()) ) { s = 111; }

                   	 
                   	input.Seek(index9_75);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 72 : 
                   	int LA9_76 = input.LA(1);

                   	 
                   	int index9_76 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred15_AplusParser()) ) { s = 1; }

                   	else if ( (synpred16_AplusParser()) ) { s = 110; }

                   	else if ( (synpred17_AplusParser()) ) { s = 111; }

                   	 
                   	input.Seek(index9_76);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 73 : 
                   	int LA9_77 = input.LA(1);

                   	 
                   	int index9_77 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred15_AplusParser()) ) { s = 1; }

                   	else if ( (synpred16_AplusParser()) ) { s = 110; }

                   	else if ( (synpred17_AplusParser()) ) { s = 111; }

                   	 
                   	input.Seek(index9_77);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 74 : 
                   	int LA9_78 = input.LA(1);

                   	 
                   	int index9_78 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred15_AplusParser()) ) { s = 1; }

                   	else if ( (synpred16_AplusParser()) ) { s = 110; }

                   	else if ( (synpred17_AplusParser()) ) { s = 111; }

                   	 
                   	input.Seek(index9_78);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 75 : 
                   	int LA9_79 = input.LA(1);

                   	 
                   	int index9_79 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred15_AplusParser()) ) { s = 1; }

                   	else if ( (synpred16_AplusParser()) ) { s = 110; }

                   	else if ( (synpred17_AplusParser()) ) { s = 111; }

                   	 
                   	input.Seek(index9_79);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 76 : 
                   	int LA9_80 = input.LA(1);

                   	 
                   	int index9_80 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred15_AplusParser()) ) { s = 1; }

                   	else if ( (synpred16_AplusParser()) ) { s = 110; }

                   	else if ( (synpred17_AplusParser()) ) { s = 111; }

                   	 
                   	input.Seek(index9_80);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 77 : 
                   	int LA9_81 = input.LA(1);

                   	 
                   	int index9_81 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred15_AplusParser()) ) { s = 1; }

                   	else if ( (synpred16_AplusParser()) ) { s = 110; }

                   	else if ( (synpred17_AplusParser()) ) { s = 111; }

                   	 
                   	input.Seek(index9_81);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 78 : 
                   	int LA9_82 = input.LA(1);

                   	 
                   	int index9_82 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred15_AplusParser()) ) { s = 1; }

                   	else if ( (synpred16_AplusParser()) ) { s = 110; }

                   	else if ( (synpred17_AplusParser()) ) { s = 111; }

                   	 
                   	input.Seek(index9_82);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 79 : 
                   	int LA9_83 = input.LA(1);

                   	 
                   	int index9_83 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred15_AplusParser()) ) { s = 1; }

                   	else if ( (synpred16_AplusParser()) ) { s = 110; }

                   	else if ( (synpred17_AplusParser()) ) { s = 111; }

                   	 
                   	input.Seek(index9_83);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 80 : 
                   	int LA9_84 = input.LA(1);

                   	 
                   	int index9_84 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred15_AplusParser()) ) { s = 1; }

                   	else if ( (synpred16_AplusParser()) ) { s = 110; }

                   	else if ( (synpred17_AplusParser()) ) { s = 111; }

                   	 
                   	input.Seek(index9_84);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 81 : 
                   	int LA9_85 = input.LA(1);

                   	 
                   	int index9_85 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred15_AplusParser()) ) { s = 1; }

                   	else if ( (synpred16_AplusParser()) ) { s = 110; }

                   	else if ( (synpred17_AplusParser()) ) { s = 111; }

                   	 
                   	input.Seek(index9_85);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 82 : 
                   	int LA9_86 = input.LA(1);

                   	 
                   	int index9_86 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred15_AplusParser()) ) { s = 1; }

                   	else if ( (synpred16_AplusParser()) ) { s = 110; }

                   	else if ( (synpred17_AplusParser()) ) { s = 111; }

                   	 
                   	input.Seek(index9_86);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 83 : 
                   	int LA9_87 = input.LA(1);

                   	 
                   	int index9_87 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred15_AplusParser()) ) { s = 1; }

                   	else if ( (synpred16_AplusParser()) ) { s = 110; }

                   	else if ( (synpred17_AplusParser()) ) { s = 111; }

                   	 
                   	input.Seek(index9_87);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 84 : 
                   	int LA9_88 = input.LA(1);

                   	 
                   	int index9_88 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred15_AplusParser()) ) { s = 1; }

                   	else if ( (synpred16_AplusParser()) ) { s = 110; }

                   	else if ( (synpred17_AplusParser()) ) { s = 111; }

                   	 
                   	input.Seek(index9_88);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 85 : 
                   	int LA9_89 = input.LA(1);

                   	 
                   	int index9_89 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred15_AplusParser()) ) { s = 1; }

                   	else if ( (synpred16_AplusParser()) ) { s = 110; }

                   	else if ( (synpred17_AplusParser()) ) { s = 111; }

                   	 
                   	input.Seek(index9_89);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 86 : 
                   	int LA9_90 = input.LA(1);

                   	 
                   	int index9_90 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred15_AplusParser()) ) { s = 1; }

                   	else if ( (synpred16_AplusParser()) ) { s = 110; }

                   	else if ( (synpred17_AplusParser()) ) { s = 111; }

                   	 
                   	input.Seek(index9_90);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 87 : 
                   	int LA9_91 = input.LA(1);

                   	 
                   	int index9_91 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred15_AplusParser()) ) { s = 1; }

                   	else if ( (synpred16_AplusParser()) ) { s = 110; }

                   	else if ( (synpred17_AplusParser()) ) { s = 111; }

                   	 
                   	input.Seek(index9_91);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 88 : 
                   	int LA9_92 = input.LA(1);

                   	 
                   	int index9_92 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred15_AplusParser()) ) { s = 1; }

                   	else if ( (synpred16_AplusParser()) ) { s = 110; }

                   	 
                   	input.Seek(index9_92);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 89 : 
                   	int LA9_93 = input.LA(1);

                   	 
                   	int index9_93 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred15_AplusParser()) ) { s = 1; }

                   	else if ( (synpred16_AplusParser()) ) { s = 110; }

                   	 
                   	input.Seek(index9_93);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 90 : 
                   	int LA9_94 = input.LA(1);

                   	 
                   	int index9_94 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred15_AplusParser()) ) { s = 1; }

                   	else if ( (synpred16_AplusParser()) ) { s = 110; }

                   	 
                   	input.Seek(index9_94);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 91 : 
                   	int LA9_95 = input.LA(1);

                   	 
                   	int index9_95 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred15_AplusParser()) ) { s = 1; }

                   	else if ( (synpred16_AplusParser()) ) { s = 110; }

                   	 
                   	input.Seek(index9_95);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 92 : 
                   	int LA9_96 = input.LA(1);

                   	 
                   	int index9_96 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred15_AplusParser()) ) { s = 1; }

                   	else if ( (synpred16_AplusParser()) ) { s = 110; }

                   	 
                   	input.Seek(index9_96);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 93 : 
                   	int LA9_97 = input.LA(1);

                   	 
                   	int index9_97 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred15_AplusParser()) ) { s = 1; }

                   	else if ( (synpred16_AplusParser()) ) { s = 110; }

                   	 
                   	input.Seek(index9_97);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 94 : 
                   	int LA9_98 = input.LA(1);

                   	 
                   	int index9_98 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred15_AplusParser()) ) { s = 1; }

                   	else if ( (synpred16_AplusParser()) ) { s = 110; }

                   	 
                   	input.Seek(index9_98);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 95 : 
                   	int LA9_99 = input.LA(1);

                   	 
                   	int index9_99 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (((synpred15_AplusParser() && (  IsGlobalFunction(input.LT(1)) ))|| synpred15_AplusParser())) ) { s = 1; }

                   	else if ( (synpred16_AplusParser()) ) { s = 110; }

                   	 
                   	input.Seek(index9_99);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 96 : 
                   	int LA9_100 = input.LA(1);

                   	 
                   	int index9_100 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (((synpred15_AplusParser() && (  IsGlobalFunction(input.LT(1)) ))|| synpred15_AplusParser())) ) { s = 1; }

                   	else if ( (synpred16_AplusParser()) ) { s = 110; }

                   	 
                   	input.Seek(index9_100);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 97 : 
                   	int LA9_101 = input.LA(1);

                   	 
                   	int index9_101 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (((synpred15_AplusParser() && (  IsGlobalFunction(input.LT(1)) ))|| synpred15_AplusParser())) ) { s = 1; }

                   	else if ( (synpred16_AplusParser()) ) { s = 110; }

                   	 
                   	input.Seek(index9_101);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        if (state.backtracking > 0) {state.failed = true; return -1;}
        NoViableAltException nvae9 =
            new NoViableAltException(dfa.Description, 9, _s, input);
        dfa.Error(nvae9);
        throw nvae9;
    }
    const string DFA11_eotS =
        "\x6a\uffff";
    const string DFA11_eofS =
        "\x6a\uffff";
    const string DFA11_minS =
        "\x01\x06\x03\uffff\x63\x00\x03\uffff";
    const string DFA11_maxS =
        "\x01\u0081\x03\uffff\x63\x00\x03\uffff";
    const string DFA11_acceptS =
        "\x01\uffff\x01\x01\x65\uffff\x01\x02\x01\x03\x01\x04";
    const string DFA11_specialS =
        "\x04\uffff\x01\x00\x01\x01\x01\x02\x01\x03\x01\x04\x01\x05\x01"+
        "\x06\x01\x07\x01\x08\x01\x09\x01\x0a\x01\x0b\x01\x0c\x01\x0d\x01"+
        "\x0e\x01\x0f\x01\x10\x01\x11\x01\x12\x01\x13\x01\x14\x01\x15\x01"+
        "\x16\x01\x17\x01\x18\x01\x19\x01\x1a\x01\x1b\x01\x1c\x01\x1d\x01"+
        "\x1e\x01\x1f\x01\x20\x01\x21\x01\x22\x01\x23\x01\x24\x01\x25\x01"+
        "\x26\x01\x27\x01\x28\x01\x29\x01\x2a\x01\x2b\x01\x2c\x01\x2d\x01"+
        "\x2e\x01\x2f\x01\x30\x01\x31\x01\x32\x01\x33\x01\x34\x01\x35\x01"+
        "\x36\x01\x37\x01\x38\x01\x39\x01\x3a\x01\x3b\x01\x3c\x01\x3d\x01"+
        "\x3e\x01\x3f\x01\x40\x01\x41\x01\x42\x01\x43\x01\x44\x01\x45\x01"+
        "\x46\x01\x47\x01\x48\x01\x49\x01\x4a\x01\x4b\x01\x4c\x01\x4d\x01"+
        "\x4e\x01\x4f\x01\x50\x01\x51\x01\x52\x01\x53\x01\x54\x01\x55\x01"+
        "\x56\x01\x57\x01\x58\x01\x59\x01\x5a\x01\x5b\x01\x5c\x01\x5d\x01"+
        "\x5e\x01\x5f\x01\x60\x01\x61\x01\x62\x03\uffff}>";
    static readonly string[] DFA11_transitionS = {
            "\x01\x01\x01\uffff\x01\x5b\x02\x01\x01\x40\x01\x41\x01\x42"+
            "\x01\x43\x01\x44\x01\x45\x01\x46\x01\x47\x01\x48\x01\x49\x01"+
            "\x4a\x01\x4b\x01\x05\x01\x06\x01\x07\x01\x08\x01\x09\x01\x0a"+
            "\x01\x0b\x01\x0c\x01\x0d\x01\x0e\x01\x0f\x01\x10\x01\x11\x01"+
            "\x12\x01\x13\x01\x14\x01\x15\x01\x16\x01\x17\x01\x18\x01\x19"+
            "\x01\x1a\x01\x1b\x01\x1c\x01\x1d\x01\x1e\x01\x20\x01\x1f\x01"+
            "\x21\x01\x23\x01\x24\x01\x25\x01\x26\x01\x27\x01\x28\x01\x29"+
            "\x01\x2a\x01\x2b\x01\x2c\x01\x2d\x01\x4c\x01\x4d\x01\x4e\x01"+
            "\x4f\x01\x50\x01\x2e\x01\x51\x01\x22\x01\x2f\x01\x30\x01\x31"+
            "\x01\x32\x01\x33\x01\x34\x01\x35\x01\x36\x01\x37\x01\x38\x01"+
            "\x39\x01\x3a\x01\x3b\x01\x3c\x01\x3d\x01\x3e\x01\x3f\x01\x52"+
            "\x01\x53\x01\x54\x01\x55\x01\x56\x01\x57\x01\x58\x01\x59\x01"+
            "\x5a\x01\x66\x01\x04\x09\uffff\x01\x5c\x06\uffff\x01\x5d\x01"+
            "\uffff\x01\x5e\x01\x5f\x03\uffff\x01\x61\x01\x62\x02\uffff\x01"+
            "\x60\x01\x65\x01\x64\x01\x63",
            "",
            "",
            "",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "",
            "",
            ""
    };

    static readonly short[] DFA11_eot = DFA.UnpackEncodedString(DFA11_eotS);
    static readonly short[] DFA11_eof = DFA.UnpackEncodedString(DFA11_eofS);
    static readonly char[] DFA11_min = DFA.UnpackEncodedStringToUnsignedChars(DFA11_minS);
    static readonly char[] DFA11_max = DFA.UnpackEncodedStringToUnsignedChars(DFA11_maxS);
    static readonly short[] DFA11_accept = DFA.UnpackEncodedString(DFA11_acceptS);
    static readonly short[] DFA11_special = DFA.UnpackEncodedString(DFA11_specialS);
    static readonly short[][] DFA11_transition = DFA.UnpackEncodedStringArray(DFA11_transitionS);

    protected class DFA11 : DFA
    {
        public DFA11(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 11;
            this.eot = DFA11_eot;
            this.eof = DFA11_eof;
            this.min = DFA11_min;
            this.max = DFA11_max;
            this.accept = DFA11_accept;
            this.special = DFA11_special;
            this.transition = DFA11_transition;

        }

        override public string Description
        {
            get { return "133:1: expression returns [AST.Node node] : ( controlStatements | lhs= dyadicLeftArg func= dyadicFunctionSelector rhs= expression | func= monadicFunctionSelector arg= expression | simpleExpression );"; }
        }

    }


    protected internal int DFA11_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            ITokenStream input = (ITokenStream)_input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA11_4 = input.LA(1);

                   	 
                   	int index11_4 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred20_AplusParser()) ) { s = 103; }

                   	else if ( (synpred21_AplusParser()) ) { s = 104; }

                   	else if ( (true) ) { s = 105; }

                   	 
                   	input.Seek(index11_4);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 1 : 
                   	int LA11_5 = input.LA(1);

                   	 
                   	int index11_5 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred20_AplusParser()) ) { s = 103; }

                   	else if ( (synpred21_AplusParser()) ) { s = 104; }

                   	 
                   	input.Seek(index11_5);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 2 : 
                   	int LA11_6 = input.LA(1);

                   	 
                   	int index11_6 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred20_AplusParser()) ) { s = 103; }

                   	else if ( (synpred21_AplusParser()) ) { s = 104; }

                   	 
                   	input.Seek(index11_6);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 3 : 
                   	int LA11_7 = input.LA(1);

                   	 
                   	int index11_7 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred20_AplusParser()) ) { s = 103; }

                   	else if ( (synpred21_AplusParser()) ) { s = 104; }

                   	 
                   	input.Seek(index11_7);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 4 : 
                   	int LA11_8 = input.LA(1);

                   	 
                   	int index11_8 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred20_AplusParser()) ) { s = 103; }

                   	else if ( (synpred21_AplusParser()) ) { s = 104; }

                   	 
                   	input.Seek(index11_8);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 5 : 
                   	int LA11_9 = input.LA(1);

                   	 
                   	int index11_9 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred20_AplusParser()) ) { s = 103; }

                   	else if ( (synpred21_AplusParser()) ) { s = 104; }

                   	 
                   	input.Seek(index11_9);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 6 : 
                   	int LA11_10 = input.LA(1);

                   	 
                   	int index11_10 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred20_AplusParser()) ) { s = 103; }

                   	else if ( (synpred21_AplusParser()) ) { s = 104; }

                   	 
                   	input.Seek(index11_10);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 7 : 
                   	int LA11_11 = input.LA(1);

                   	 
                   	int index11_11 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred20_AplusParser()) ) { s = 103; }

                   	else if ( (synpred21_AplusParser()) ) { s = 104; }

                   	 
                   	input.Seek(index11_11);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 8 : 
                   	int LA11_12 = input.LA(1);

                   	 
                   	int index11_12 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred20_AplusParser()) ) { s = 103; }

                   	else if ( (synpred21_AplusParser()) ) { s = 104; }

                   	 
                   	input.Seek(index11_12);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 9 : 
                   	int LA11_13 = input.LA(1);

                   	 
                   	int index11_13 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred20_AplusParser()) ) { s = 103; }

                   	else if ( (synpred21_AplusParser()) ) { s = 104; }

                   	 
                   	input.Seek(index11_13);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 10 : 
                   	int LA11_14 = input.LA(1);

                   	 
                   	int index11_14 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred20_AplusParser()) ) { s = 103; }

                   	else if ( (synpred21_AplusParser()) ) { s = 104; }

                   	 
                   	input.Seek(index11_14);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 11 : 
                   	int LA11_15 = input.LA(1);

                   	 
                   	int index11_15 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred20_AplusParser()) ) { s = 103; }

                   	else if ( (synpred21_AplusParser()) ) { s = 104; }

                   	 
                   	input.Seek(index11_15);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 12 : 
                   	int LA11_16 = input.LA(1);

                   	 
                   	int index11_16 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred20_AplusParser()) ) { s = 103; }

                   	else if ( (synpred21_AplusParser()) ) { s = 104; }

                   	 
                   	input.Seek(index11_16);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 13 : 
                   	int LA11_17 = input.LA(1);

                   	 
                   	int index11_17 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred20_AplusParser()) ) { s = 103; }

                   	else if ( (synpred21_AplusParser()) ) { s = 104; }

                   	 
                   	input.Seek(index11_17);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 14 : 
                   	int LA11_18 = input.LA(1);

                   	 
                   	int index11_18 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred20_AplusParser()) ) { s = 103; }

                   	else if ( (synpred21_AplusParser()) ) { s = 104; }

                   	 
                   	input.Seek(index11_18);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 15 : 
                   	int LA11_19 = input.LA(1);

                   	 
                   	int index11_19 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred20_AplusParser()) ) { s = 103; }

                   	else if ( (synpred21_AplusParser()) ) { s = 104; }

                   	 
                   	input.Seek(index11_19);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 16 : 
                   	int LA11_20 = input.LA(1);

                   	 
                   	int index11_20 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred20_AplusParser()) ) { s = 103; }

                   	else if ( (synpred21_AplusParser()) ) { s = 104; }

                   	 
                   	input.Seek(index11_20);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 17 : 
                   	int LA11_21 = input.LA(1);

                   	 
                   	int index11_21 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred20_AplusParser()) ) { s = 103; }

                   	else if ( (synpred21_AplusParser()) ) { s = 104; }

                   	 
                   	input.Seek(index11_21);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 18 : 
                   	int LA11_22 = input.LA(1);

                   	 
                   	int index11_22 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred20_AplusParser()) ) { s = 103; }

                   	else if ( (synpred21_AplusParser()) ) { s = 104; }

                   	 
                   	input.Seek(index11_22);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 19 : 
                   	int LA11_23 = input.LA(1);

                   	 
                   	int index11_23 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred20_AplusParser()) ) { s = 103; }

                   	else if ( (synpred21_AplusParser()) ) { s = 104; }

                   	 
                   	input.Seek(index11_23);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 20 : 
                   	int LA11_24 = input.LA(1);

                   	 
                   	int index11_24 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred20_AplusParser()) ) { s = 103; }

                   	else if ( (synpred21_AplusParser()) ) { s = 104; }

                   	 
                   	input.Seek(index11_24);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 21 : 
                   	int LA11_25 = input.LA(1);

                   	 
                   	int index11_25 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred20_AplusParser()) ) { s = 103; }

                   	else if ( (synpred21_AplusParser()) ) { s = 104; }

                   	 
                   	input.Seek(index11_25);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 22 : 
                   	int LA11_26 = input.LA(1);

                   	 
                   	int index11_26 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred20_AplusParser()) ) { s = 103; }

                   	else if ( (synpred21_AplusParser()) ) { s = 104; }

                   	 
                   	input.Seek(index11_26);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 23 : 
                   	int LA11_27 = input.LA(1);

                   	 
                   	int index11_27 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred20_AplusParser()) ) { s = 103; }

                   	else if ( (synpred21_AplusParser()) ) { s = 104; }

                   	 
                   	input.Seek(index11_27);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 24 : 
                   	int LA11_28 = input.LA(1);

                   	 
                   	int index11_28 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred20_AplusParser()) ) { s = 103; }

                   	else if ( (synpred21_AplusParser()) ) { s = 104; }

                   	 
                   	input.Seek(index11_28);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 25 : 
                   	int LA11_29 = input.LA(1);

                   	 
                   	int index11_29 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred20_AplusParser()) ) { s = 103; }

                   	else if ( (synpred21_AplusParser()) ) { s = 104; }

                   	 
                   	input.Seek(index11_29);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 26 : 
                   	int LA11_30 = input.LA(1);

                   	 
                   	int index11_30 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred20_AplusParser()) ) { s = 103; }

                   	else if ( (synpred21_AplusParser()) ) { s = 104; }

                   	 
                   	input.Seek(index11_30);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 27 : 
                   	int LA11_31 = input.LA(1);

                   	 
                   	int index11_31 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred20_AplusParser()) ) { s = 103; }

                   	else if ( (synpred21_AplusParser()) ) { s = 104; }

                   	 
                   	input.Seek(index11_31);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 28 : 
                   	int LA11_32 = input.LA(1);

                   	 
                   	int index11_32 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred20_AplusParser()) ) { s = 103; }

                   	else if ( (synpred21_AplusParser()) ) { s = 104; }

                   	 
                   	input.Seek(index11_32);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 29 : 
                   	int LA11_33 = input.LA(1);

                   	 
                   	int index11_33 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred20_AplusParser()) ) { s = 103; }

                   	else if ( (synpred21_AplusParser()) ) { s = 104; }

                   	 
                   	input.Seek(index11_33);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 30 : 
                   	int LA11_34 = input.LA(1);

                   	 
                   	int index11_34 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred20_AplusParser()) ) { s = 103; }

                   	else if ( (synpred21_AplusParser()) ) { s = 104; }

                   	 
                   	input.Seek(index11_34);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 31 : 
                   	int LA11_35 = input.LA(1);

                   	 
                   	int index11_35 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred20_AplusParser()) ) { s = 103; }

                   	else if ( (synpred21_AplusParser()) ) { s = 104; }

                   	 
                   	input.Seek(index11_35);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 32 : 
                   	int LA11_36 = input.LA(1);

                   	 
                   	int index11_36 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred20_AplusParser()) ) { s = 103; }

                   	else if ( (synpred21_AplusParser()) ) { s = 104; }

                   	 
                   	input.Seek(index11_36);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 33 : 
                   	int LA11_37 = input.LA(1);

                   	 
                   	int index11_37 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred20_AplusParser()) ) { s = 103; }

                   	else if ( (synpred21_AplusParser()) ) { s = 104; }

                   	 
                   	input.Seek(index11_37);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 34 : 
                   	int LA11_38 = input.LA(1);

                   	 
                   	int index11_38 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred20_AplusParser()) ) { s = 103; }

                   	else if ( (synpred21_AplusParser()) ) { s = 104; }

                   	 
                   	input.Seek(index11_38);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 35 : 
                   	int LA11_39 = input.LA(1);

                   	 
                   	int index11_39 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred20_AplusParser()) ) { s = 103; }

                   	else if ( (synpred21_AplusParser()) ) { s = 104; }

                   	 
                   	input.Seek(index11_39);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 36 : 
                   	int LA11_40 = input.LA(1);

                   	 
                   	int index11_40 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred20_AplusParser()) ) { s = 103; }

                   	else if ( (synpred21_AplusParser()) ) { s = 104; }

                   	 
                   	input.Seek(index11_40);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 37 : 
                   	int LA11_41 = input.LA(1);

                   	 
                   	int index11_41 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred20_AplusParser()) ) { s = 103; }

                   	else if ( (synpred21_AplusParser()) ) { s = 104; }

                   	 
                   	input.Seek(index11_41);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 38 : 
                   	int LA11_42 = input.LA(1);

                   	 
                   	int index11_42 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred20_AplusParser()) ) { s = 103; }

                   	else if ( (synpred21_AplusParser()) ) { s = 104; }

                   	 
                   	input.Seek(index11_42);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 39 : 
                   	int LA11_43 = input.LA(1);

                   	 
                   	int index11_43 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred20_AplusParser()) ) { s = 103; }

                   	else if ( (synpred21_AplusParser()) ) { s = 104; }

                   	 
                   	input.Seek(index11_43);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 40 : 
                   	int LA11_44 = input.LA(1);

                   	 
                   	int index11_44 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred20_AplusParser()) ) { s = 103; }

                   	else if ( (synpred21_AplusParser()) ) { s = 104; }

                   	 
                   	input.Seek(index11_44);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 41 : 
                   	int LA11_45 = input.LA(1);

                   	 
                   	int index11_45 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred20_AplusParser()) ) { s = 103; }

                   	else if ( (synpred21_AplusParser()) ) { s = 104; }

                   	 
                   	input.Seek(index11_45);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 42 : 
                   	int LA11_46 = input.LA(1);

                   	 
                   	int index11_46 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred20_AplusParser()) ) { s = 103; }

                   	else if ( (synpred21_AplusParser()) ) { s = 104; }

                   	 
                   	input.Seek(index11_46);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 43 : 
                   	int LA11_47 = input.LA(1);

                   	 
                   	int index11_47 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred20_AplusParser()) ) { s = 103; }

                   	else if ( (synpred21_AplusParser()) ) { s = 104; }

                   	 
                   	input.Seek(index11_47);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 44 : 
                   	int LA11_48 = input.LA(1);

                   	 
                   	int index11_48 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred20_AplusParser()) ) { s = 103; }

                   	else if ( (synpred21_AplusParser()) ) { s = 104; }

                   	 
                   	input.Seek(index11_48);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 45 : 
                   	int LA11_49 = input.LA(1);

                   	 
                   	int index11_49 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred20_AplusParser()) ) { s = 103; }

                   	else if ( (synpred21_AplusParser()) ) { s = 104; }

                   	 
                   	input.Seek(index11_49);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 46 : 
                   	int LA11_50 = input.LA(1);

                   	 
                   	int index11_50 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred20_AplusParser()) ) { s = 103; }

                   	else if ( (synpred21_AplusParser()) ) { s = 104; }

                   	 
                   	input.Seek(index11_50);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 47 : 
                   	int LA11_51 = input.LA(1);

                   	 
                   	int index11_51 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred20_AplusParser()) ) { s = 103; }

                   	else if ( (synpred21_AplusParser()) ) { s = 104; }

                   	 
                   	input.Seek(index11_51);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 48 : 
                   	int LA11_52 = input.LA(1);

                   	 
                   	int index11_52 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred20_AplusParser()) ) { s = 103; }

                   	else if ( (synpred21_AplusParser()) ) { s = 104; }

                   	 
                   	input.Seek(index11_52);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 49 : 
                   	int LA11_53 = input.LA(1);

                   	 
                   	int index11_53 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred20_AplusParser()) ) { s = 103; }

                   	else if ( (synpred21_AplusParser()) ) { s = 104; }

                   	 
                   	input.Seek(index11_53);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 50 : 
                   	int LA11_54 = input.LA(1);

                   	 
                   	int index11_54 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred20_AplusParser()) ) { s = 103; }

                   	else if ( (synpred21_AplusParser()) ) { s = 104; }

                   	 
                   	input.Seek(index11_54);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 51 : 
                   	int LA11_55 = input.LA(1);

                   	 
                   	int index11_55 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred20_AplusParser()) ) { s = 103; }

                   	else if ( (synpred21_AplusParser()) ) { s = 104; }

                   	 
                   	input.Seek(index11_55);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 52 : 
                   	int LA11_56 = input.LA(1);

                   	 
                   	int index11_56 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred20_AplusParser()) ) { s = 103; }

                   	else if ( (synpred21_AplusParser()) ) { s = 104; }

                   	 
                   	input.Seek(index11_56);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 53 : 
                   	int LA11_57 = input.LA(1);

                   	 
                   	int index11_57 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred20_AplusParser()) ) { s = 103; }

                   	else if ( (synpred21_AplusParser()) ) { s = 104; }

                   	 
                   	input.Seek(index11_57);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 54 : 
                   	int LA11_58 = input.LA(1);

                   	 
                   	int index11_58 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred20_AplusParser()) ) { s = 103; }

                   	else if ( (synpred21_AplusParser()) ) { s = 104; }

                   	 
                   	input.Seek(index11_58);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 55 : 
                   	int LA11_59 = input.LA(1);

                   	 
                   	int index11_59 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred20_AplusParser()) ) { s = 103; }

                   	else if ( (synpred21_AplusParser()) ) { s = 104; }

                   	 
                   	input.Seek(index11_59);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 56 : 
                   	int LA11_60 = input.LA(1);

                   	 
                   	int index11_60 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred20_AplusParser()) ) { s = 103; }

                   	else if ( (synpred21_AplusParser()) ) { s = 104; }

                   	 
                   	input.Seek(index11_60);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 57 : 
                   	int LA11_61 = input.LA(1);

                   	 
                   	int index11_61 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred20_AplusParser()) ) { s = 103; }

                   	else if ( (synpred21_AplusParser()) ) { s = 104; }

                   	 
                   	input.Seek(index11_61);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 58 : 
                   	int LA11_62 = input.LA(1);

                   	 
                   	int index11_62 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred20_AplusParser()) ) { s = 103; }

                   	else if ( (synpred21_AplusParser()) ) { s = 104; }

                   	 
                   	input.Seek(index11_62);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 59 : 
                   	int LA11_63 = input.LA(1);

                   	 
                   	int index11_63 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred20_AplusParser()) ) { s = 103; }

                   	else if ( (synpred21_AplusParser()) ) { s = 104; }

                   	 
                   	input.Seek(index11_63);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 60 : 
                   	int LA11_64 = input.LA(1);

                   	 
                   	int index11_64 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred20_AplusParser()) ) { s = 103; }

                   	else if ( (synpred21_AplusParser()) ) { s = 104; }

                   	 
                   	input.Seek(index11_64);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 61 : 
                   	int LA11_65 = input.LA(1);

                   	 
                   	int index11_65 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred20_AplusParser()) ) { s = 103; }

                   	else if ( (synpred21_AplusParser()) ) { s = 104; }

                   	 
                   	input.Seek(index11_65);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 62 : 
                   	int LA11_66 = input.LA(1);

                   	 
                   	int index11_66 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred20_AplusParser()) ) { s = 103; }

                   	else if ( (synpred21_AplusParser()) ) { s = 104; }

                   	 
                   	input.Seek(index11_66);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 63 : 
                   	int LA11_67 = input.LA(1);

                   	 
                   	int index11_67 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred20_AplusParser()) ) { s = 103; }

                   	else if ( (synpred21_AplusParser()) ) { s = 104; }

                   	 
                   	input.Seek(index11_67);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 64 : 
                   	int LA11_68 = input.LA(1);

                   	 
                   	int index11_68 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred20_AplusParser()) ) { s = 103; }

                   	else if ( (synpred21_AplusParser()) ) { s = 104; }

                   	 
                   	input.Seek(index11_68);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 65 : 
                   	int LA11_69 = input.LA(1);

                   	 
                   	int index11_69 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred20_AplusParser()) ) { s = 103; }

                   	else if ( (synpred21_AplusParser()) ) { s = 104; }

                   	 
                   	input.Seek(index11_69);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 66 : 
                   	int LA11_70 = input.LA(1);

                   	 
                   	int index11_70 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred20_AplusParser()) ) { s = 103; }

                   	else if ( (synpred21_AplusParser()) ) { s = 104; }

                   	 
                   	input.Seek(index11_70);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 67 : 
                   	int LA11_71 = input.LA(1);

                   	 
                   	int index11_71 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred20_AplusParser()) ) { s = 103; }

                   	else if ( (synpred21_AplusParser()) ) { s = 104; }

                   	 
                   	input.Seek(index11_71);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 68 : 
                   	int LA11_72 = input.LA(1);

                   	 
                   	int index11_72 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred20_AplusParser()) ) { s = 103; }

                   	else if ( (synpred21_AplusParser()) ) { s = 104; }

                   	 
                   	input.Seek(index11_72);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 69 : 
                   	int LA11_73 = input.LA(1);

                   	 
                   	int index11_73 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred20_AplusParser()) ) { s = 103; }

                   	else if ( (synpred21_AplusParser()) ) { s = 104; }

                   	 
                   	input.Seek(index11_73);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 70 : 
                   	int LA11_74 = input.LA(1);

                   	 
                   	int index11_74 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred20_AplusParser()) ) { s = 103; }

                   	else if ( (synpred21_AplusParser()) ) { s = 104; }

                   	 
                   	input.Seek(index11_74);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 71 : 
                   	int LA11_75 = input.LA(1);

                   	 
                   	int index11_75 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred20_AplusParser()) ) { s = 103; }

                   	else if ( (synpred21_AplusParser()) ) { s = 104; }

                   	 
                   	input.Seek(index11_75);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 72 : 
                   	int LA11_76 = input.LA(1);

                   	 
                   	int index11_76 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred20_AplusParser()) ) { s = 103; }

                   	else if ( (synpred21_AplusParser()) ) { s = 104; }

                   	 
                   	input.Seek(index11_76);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 73 : 
                   	int LA11_77 = input.LA(1);

                   	 
                   	int index11_77 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred20_AplusParser()) ) { s = 103; }

                   	else if ( (synpred21_AplusParser()) ) { s = 104; }

                   	 
                   	input.Seek(index11_77);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 74 : 
                   	int LA11_78 = input.LA(1);

                   	 
                   	int index11_78 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred20_AplusParser()) ) { s = 103; }

                   	else if ( (synpred21_AplusParser()) ) { s = 104; }

                   	 
                   	input.Seek(index11_78);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 75 : 
                   	int LA11_79 = input.LA(1);

                   	 
                   	int index11_79 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred20_AplusParser()) ) { s = 103; }

                   	else if ( (synpred21_AplusParser()) ) { s = 104; }

                   	 
                   	input.Seek(index11_79);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 76 : 
                   	int LA11_80 = input.LA(1);

                   	 
                   	int index11_80 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred20_AplusParser()) ) { s = 103; }

                   	else if ( (synpred21_AplusParser()) ) { s = 104; }

                   	 
                   	input.Seek(index11_80);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 77 : 
                   	int LA11_81 = input.LA(1);

                   	 
                   	int index11_81 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred20_AplusParser()) ) { s = 103; }

                   	else if ( (synpred21_AplusParser()) ) { s = 104; }

                   	 
                   	input.Seek(index11_81);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 78 : 
                   	int LA11_82 = input.LA(1);

                   	 
                   	int index11_82 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred20_AplusParser()) ) { s = 103; }

                   	else if ( (synpred21_AplusParser()) ) { s = 104; }

                   	 
                   	input.Seek(index11_82);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 79 : 
                   	int LA11_83 = input.LA(1);

                   	 
                   	int index11_83 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred20_AplusParser()) ) { s = 103; }

                   	else if ( (synpred21_AplusParser()) ) { s = 104; }

                   	 
                   	input.Seek(index11_83);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 80 : 
                   	int LA11_84 = input.LA(1);

                   	 
                   	int index11_84 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred20_AplusParser()) ) { s = 103; }

                   	else if ( (synpred21_AplusParser()) ) { s = 104; }

                   	 
                   	input.Seek(index11_84);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 81 : 
                   	int LA11_85 = input.LA(1);

                   	 
                   	int index11_85 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred20_AplusParser()) ) { s = 103; }

                   	else if ( (synpred21_AplusParser()) ) { s = 104; }

                   	 
                   	input.Seek(index11_85);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 82 : 
                   	int LA11_86 = input.LA(1);

                   	 
                   	int index11_86 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred20_AplusParser()) ) { s = 103; }

                   	else if ( (synpred21_AplusParser()) ) { s = 104; }

                   	 
                   	input.Seek(index11_86);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 83 : 
                   	int LA11_87 = input.LA(1);

                   	 
                   	int index11_87 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred20_AplusParser()) ) { s = 103; }

                   	else if ( (synpred21_AplusParser()) ) { s = 104; }

                   	 
                   	input.Seek(index11_87);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 84 : 
                   	int LA11_88 = input.LA(1);

                   	 
                   	int index11_88 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred20_AplusParser()) ) { s = 103; }

                   	else if ( (synpred21_AplusParser()) ) { s = 104; }

                   	 
                   	input.Seek(index11_88);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 85 : 
                   	int LA11_89 = input.LA(1);

                   	 
                   	int index11_89 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred20_AplusParser()) ) { s = 103; }

                   	else if ( (synpred21_AplusParser()) ) { s = 104; }

                   	 
                   	input.Seek(index11_89);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 86 : 
                   	int LA11_90 = input.LA(1);

                   	 
                   	int index11_90 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred20_AplusParser()) ) { s = 103; }

                   	else if ( (synpred21_AplusParser()) ) { s = 104; }

                   	 
                   	input.Seek(index11_90);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 87 : 
                   	int LA11_91 = input.LA(1);

                   	 
                   	int index11_91 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred20_AplusParser()) ) { s = 103; }

                   	else if ( (synpred21_AplusParser()) ) { s = 104; }

                   	 
                   	input.Seek(index11_91);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 88 : 
                   	int LA11_92 = input.LA(1);

                   	 
                   	int index11_92 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred20_AplusParser()) ) { s = 103; }

                   	else if ( (synpred21_AplusParser()) ) { s = 104; }

                   	else if ( (true) ) { s = 105; }

                   	 
                   	input.Seek(index11_92);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 89 : 
                   	int LA11_93 = input.LA(1);

                   	 
                   	int index11_93 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred20_AplusParser()) ) { s = 103; }

                   	else if ( (synpred21_AplusParser()) ) { s = 104; }

                   	else if ( (true) ) { s = 105; }

                   	 
                   	input.Seek(index11_93);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 90 : 
                   	int LA11_94 = input.LA(1);

                   	 
                   	int index11_94 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred20_AplusParser()) ) { s = 103; }

                   	else if ( (synpred21_AplusParser()) ) { s = 104; }

                   	else if ( (true) ) { s = 105; }

                   	 
                   	input.Seek(index11_94);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 91 : 
                   	int LA11_95 = input.LA(1);

                   	 
                   	int index11_95 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred20_AplusParser()) ) { s = 103; }

                   	else if ( (synpred21_AplusParser()) ) { s = 104; }

                   	else if ( (true) ) { s = 105; }

                   	 
                   	input.Seek(index11_95);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 92 : 
                   	int LA11_96 = input.LA(1);

                   	 
                   	int index11_96 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred20_AplusParser()) ) { s = 103; }

                   	else if ( (synpred21_AplusParser()) ) { s = 104; }

                   	else if ( (true) ) { s = 105; }

                   	 
                   	input.Seek(index11_96);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 93 : 
                   	int LA11_97 = input.LA(1);

                   	 
                   	int index11_97 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred20_AplusParser()) ) { s = 103; }

                   	else if ( (synpred21_AplusParser()) ) { s = 104; }

                   	else if ( (true) ) { s = 105; }

                   	 
                   	input.Seek(index11_97);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 94 : 
                   	int LA11_98 = input.LA(1);

                   	 
                   	int index11_98 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred20_AplusParser()) ) { s = 103; }

                   	else if ( (synpred21_AplusParser()) ) { s = 104; }

                   	else if ( (true) ) { s = 105; }

                   	 
                   	input.Seek(index11_98);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 95 : 
                   	int LA11_99 = input.LA(1);

                   	 
                   	int index11_99 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred20_AplusParser()) ) { s = 103; }

                   	else if ( ((synpred21_AplusParser()|| (synpred21_AplusParser() && (  IsGlobalFunction(input.LT(1)) )))) ) { s = 104; }

                   	else if ( (true) ) { s = 105; }

                   	 
                   	input.Seek(index11_99);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 96 : 
                   	int LA11_100 = input.LA(1);

                   	 
                   	int index11_100 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred20_AplusParser()) ) { s = 103; }

                   	else if ( ((synpred21_AplusParser()|| (synpred21_AplusParser() && (  IsGlobalFunction(input.LT(1)) )))) ) { s = 104; }

                   	else if ( (true) ) { s = 105; }

                   	 
                   	input.Seek(index11_100);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 97 : 
                   	int LA11_101 = input.LA(1);

                   	 
                   	int index11_101 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred20_AplusParser()) ) { s = 103; }

                   	else if ( ((synpred21_AplusParser()|| (synpred21_AplusParser() && (  IsGlobalFunction(input.LT(1)) )))) ) { s = 104; }

                   	else if ( (true) ) { s = 105; }

                   	 
                   	input.Seek(index11_101);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 98 : 
                   	int LA11_102 = input.LA(1);

                   	 
                   	int index11_102 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( ((synpred20_AplusParser() && ( this.isfunction ))) ) { s = 103; }

                   	else if ( (( this.isfunction )) ) { s = 105; }

                   	 
                   	input.Seek(index11_102);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        if (state.backtracking > 0) {state.failed = true; return -1;}
        NoViableAltException nvae11 =
            new NoViableAltException(dfa.Description, 11, _s, input);
        dfa.Error(nvae11);
        throw nvae11;
    }
    const string DFA12_eotS =
        "\x65\uffff";
    const string DFA12_eofS =
        "\x65\uffff";
    const string DFA12_minS =
        "\x01\x08\x58\x00\x07\uffff\x03\x00\x02\uffff";
    const string DFA12_maxS =
        "\x01\u0081\x58\x00\x07\uffff\x03\x00\x02\uffff";
    const string DFA12_acceptS =
        "\x59\uffff\x01\x01\x09\uffff\x01\x02\x01\x03";
    const string DFA12_specialS =
        "\x01\uffff\x01\x00\x01\x01\x01\x02\x01\x03\x01\x04\x01\x05\x01"+
        "\x06\x01\x07\x01\x08\x01\x09\x01\x0a\x01\x0b\x01\x0c\x01\x0d\x01"+
        "\x0e\x01\x0f\x01\x10\x01\x11\x01\x12\x01\x13\x01\x14\x01\x15\x01"+
        "\x16\x01\x17\x01\x18\x01\x19\x01\x1a\x01\x1b\x01\x1c\x01\x1d\x01"+
        "\x1e\x01\x1f\x01\x20\x01\x21\x01\x22\x01\x23\x01\x24\x01\x25\x01"+
        "\x26\x01\x27\x01\x28\x01\x29\x01\x2a\x01\x2b\x01\x2c\x01\x2d\x01"+
        "\x2e\x01\x2f\x01\x30\x01\x31\x01\x32\x01\x33\x01\x34\x01\x35\x01"+
        "\x36\x01\x37\x01\x38\x01\x39\x01\x3a\x01\x3b\x01\x3c\x01\x3d\x01"+
        "\x3e\x01\x3f\x01\x40\x01\x41\x01\x42\x01\x43\x01\x44\x01\x45\x01"+
        "\x46\x01\x47\x01\x48\x01\x49\x01\x4a\x01\x4b\x01\x4c\x01\x4d\x01"+
        "\x4e\x01\x4f\x01\x50\x01\x51\x01\x52\x01\x53\x01\x54\x01\x55\x01"+
        "\x56\x01\x57\x07\uffff\x01\x58\x01\x59\x01\x5a\x02\uffff}>";
    static readonly string[] DFA12_transitionS = {
            "\x01\x58\x02\uffff\x01\x3d\x01\x3e\x01\x3f\x01\x40\x01\x41"+
            "\x01\x42\x01\x43\x01\x44\x01\x45\x01\x46\x01\x47\x01\x48\x01"+
            "\x02\x01\x03\x01\x04\x01\x05\x01\x06\x01\x07\x01\x08\x01\x09"+
            "\x01\x0a\x01\x0b\x01\x0c\x01\x0d\x01\x0e\x01\x0f\x01\x10\x01"+
            "\x11\x01\x12\x01\x13\x01\x14\x01\x15\x01\x16\x01\x17\x01\x18"+
            "\x01\x19\x01\x1a\x01\x1b\x01\x1d\x01\x1c\x01\x1e\x01\x20\x01"+
            "\x21\x01\x22\x01\x23\x01\x24\x01\x25\x01\x26\x01\x27\x01\x28"+
            "\x01\x29\x01\x2a\x01\x49\x01\x4a\x01\x4b\x01\x4c\x01\x4d\x01"+
            "\x2b\x01\x4e\x01\x1f\x01\x2c\x01\x2d\x01\x2e\x01\x2f\x01\x30"+
            "\x01\x31\x01\x32\x01\x33\x01\x34\x01\x35\x01\x36\x01\x37\x01"+
            "\x38\x01\x39\x01\x3a\x01\x3b\x01\x3c\x01\x4f\x01\x50\x01\x51"+
            "\x01\x52\x01\x53\x01\x54\x01\x55\x01\x56\x01\x57\x01\uffff\x01"+
            "\x01\x09\uffff\x01\x59\x06\uffff\x01\x59\x01\uffff\x02\x59\x03"+
            "\uffff\x02\x59\x02\uffff\x01\x59\x01\x62\x01\x61\x01\x60",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "",
            ""
    };

    static readonly short[] DFA12_eot = DFA.UnpackEncodedString(DFA12_eotS);
    static readonly short[] DFA12_eof = DFA.UnpackEncodedString(DFA12_eofS);
    static readonly char[] DFA12_min = DFA.UnpackEncodedStringToUnsignedChars(DFA12_minS);
    static readonly char[] DFA12_max = DFA.UnpackEncodedStringToUnsignedChars(DFA12_maxS);
    static readonly short[] DFA12_accept = DFA.UnpackEncodedString(DFA12_acceptS);
    static readonly short[] DFA12_special = DFA.UnpackEncodedString(DFA12_specialS);
    static readonly short[][] DFA12_transition = DFA.UnpackEncodedStringArray(DFA12_transitionS);

    protected class DFA12 : DFA
    {
        public DFA12(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 12;
            this.eot = DFA12_eot;
            this.eof = DFA12_eof;
            this.min = DFA12_min;
            this.max = DFA12_max;
            this.accept = DFA12_accept;
            this.special = DFA12_special;
            this.transition = DFA12_transition;

        }

        override public string Description
        {
            get { return "191:1: monadicFunctionSelector returns [AST.Node node] : ( operatorSymbol | functionSymbol | {...}? variableName );"; }
        }

    }


    protected internal int DFA12_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            ITokenStream input = (ITokenStream)_input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA12_1 = input.LA(1);

                   	 
                   	int index12_1 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred22_AplusParser()) ) { s = 89; }

                   	else if ( (synpred23_AplusParser()) ) { s = 99; }

                   	 
                   	input.Seek(index12_1);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 1 : 
                   	int LA12_2 = input.LA(1);

                   	 
                   	int index12_2 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred22_AplusParser()) ) { s = 89; }

                   	else if ( (synpred23_AplusParser()) ) { s = 99; }

                   	 
                   	input.Seek(index12_2);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 2 : 
                   	int LA12_3 = input.LA(1);

                   	 
                   	int index12_3 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred22_AplusParser()) ) { s = 89; }

                   	else if ( (synpred23_AplusParser()) ) { s = 99; }

                   	 
                   	input.Seek(index12_3);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 3 : 
                   	int LA12_4 = input.LA(1);

                   	 
                   	int index12_4 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred22_AplusParser()) ) { s = 89; }

                   	else if ( (synpred23_AplusParser()) ) { s = 99; }

                   	 
                   	input.Seek(index12_4);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 4 : 
                   	int LA12_5 = input.LA(1);

                   	 
                   	int index12_5 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred22_AplusParser()) ) { s = 89; }

                   	else if ( (synpred23_AplusParser()) ) { s = 99; }

                   	 
                   	input.Seek(index12_5);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 5 : 
                   	int LA12_6 = input.LA(1);

                   	 
                   	int index12_6 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred22_AplusParser()) ) { s = 89; }

                   	else if ( (synpred23_AplusParser()) ) { s = 99; }

                   	 
                   	input.Seek(index12_6);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 6 : 
                   	int LA12_7 = input.LA(1);

                   	 
                   	int index12_7 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred22_AplusParser()) ) { s = 89; }

                   	else if ( (synpred23_AplusParser()) ) { s = 99; }

                   	 
                   	input.Seek(index12_7);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 7 : 
                   	int LA12_8 = input.LA(1);

                   	 
                   	int index12_8 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred22_AplusParser()) ) { s = 89; }

                   	else if ( (synpred23_AplusParser()) ) { s = 99; }

                   	 
                   	input.Seek(index12_8);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 8 : 
                   	int LA12_9 = input.LA(1);

                   	 
                   	int index12_9 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred22_AplusParser()) ) { s = 89; }

                   	else if ( (synpred23_AplusParser()) ) { s = 99; }

                   	 
                   	input.Seek(index12_9);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 9 : 
                   	int LA12_10 = input.LA(1);

                   	 
                   	int index12_10 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred22_AplusParser()) ) { s = 89; }

                   	else if ( (synpred23_AplusParser()) ) { s = 99; }

                   	 
                   	input.Seek(index12_10);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 10 : 
                   	int LA12_11 = input.LA(1);

                   	 
                   	int index12_11 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred22_AplusParser()) ) { s = 89; }

                   	else if ( (synpred23_AplusParser()) ) { s = 99; }

                   	 
                   	input.Seek(index12_11);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 11 : 
                   	int LA12_12 = input.LA(1);

                   	 
                   	int index12_12 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred22_AplusParser()) ) { s = 89; }

                   	else if ( (synpred23_AplusParser()) ) { s = 99; }

                   	 
                   	input.Seek(index12_12);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 12 : 
                   	int LA12_13 = input.LA(1);

                   	 
                   	int index12_13 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred22_AplusParser()) ) { s = 89; }

                   	else if ( (synpred23_AplusParser()) ) { s = 99; }

                   	 
                   	input.Seek(index12_13);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 13 : 
                   	int LA12_14 = input.LA(1);

                   	 
                   	int index12_14 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred22_AplusParser()) ) { s = 89; }

                   	else if ( (synpred23_AplusParser()) ) { s = 99; }

                   	 
                   	input.Seek(index12_14);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 14 : 
                   	int LA12_15 = input.LA(1);

                   	 
                   	int index12_15 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred22_AplusParser()) ) { s = 89; }

                   	else if ( (synpred23_AplusParser()) ) { s = 99; }

                   	 
                   	input.Seek(index12_15);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 15 : 
                   	int LA12_16 = input.LA(1);

                   	 
                   	int index12_16 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred22_AplusParser()) ) { s = 89; }

                   	else if ( (synpred23_AplusParser()) ) { s = 99; }

                   	 
                   	input.Seek(index12_16);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 16 : 
                   	int LA12_17 = input.LA(1);

                   	 
                   	int index12_17 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred22_AplusParser()) ) { s = 89; }

                   	else if ( (synpred23_AplusParser()) ) { s = 99; }

                   	 
                   	input.Seek(index12_17);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 17 : 
                   	int LA12_18 = input.LA(1);

                   	 
                   	int index12_18 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred22_AplusParser()) ) { s = 89; }

                   	else if ( (synpred23_AplusParser()) ) { s = 99; }

                   	 
                   	input.Seek(index12_18);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 18 : 
                   	int LA12_19 = input.LA(1);

                   	 
                   	int index12_19 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred22_AplusParser()) ) { s = 89; }

                   	else if ( (synpred23_AplusParser()) ) { s = 99; }

                   	 
                   	input.Seek(index12_19);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 19 : 
                   	int LA12_20 = input.LA(1);

                   	 
                   	int index12_20 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred22_AplusParser()) ) { s = 89; }

                   	else if ( (synpred23_AplusParser()) ) { s = 99; }

                   	 
                   	input.Seek(index12_20);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 20 : 
                   	int LA12_21 = input.LA(1);

                   	 
                   	int index12_21 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred22_AplusParser()) ) { s = 89; }

                   	else if ( (synpred23_AplusParser()) ) { s = 99; }

                   	 
                   	input.Seek(index12_21);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 21 : 
                   	int LA12_22 = input.LA(1);

                   	 
                   	int index12_22 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred22_AplusParser()) ) { s = 89; }

                   	else if ( (synpred23_AplusParser()) ) { s = 99; }

                   	 
                   	input.Seek(index12_22);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 22 : 
                   	int LA12_23 = input.LA(1);

                   	 
                   	int index12_23 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred22_AplusParser()) ) { s = 89; }

                   	else if ( (synpred23_AplusParser()) ) { s = 99; }

                   	 
                   	input.Seek(index12_23);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 23 : 
                   	int LA12_24 = input.LA(1);

                   	 
                   	int index12_24 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred22_AplusParser()) ) { s = 89; }

                   	else if ( (synpred23_AplusParser()) ) { s = 99; }

                   	 
                   	input.Seek(index12_24);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 24 : 
                   	int LA12_25 = input.LA(1);

                   	 
                   	int index12_25 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred22_AplusParser()) ) { s = 89; }

                   	else if ( (synpred23_AplusParser()) ) { s = 99; }

                   	 
                   	input.Seek(index12_25);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 25 : 
                   	int LA12_26 = input.LA(1);

                   	 
                   	int index12_26 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred22_AplusParser()) ) { s = 89; }

                   	else if ( (synpred23_AplusParser()) ) { s = 99; }

                   	 
                   	input.Seek(index12_26);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 26 : 
                   	int LA12_27 = input.LA(1);

                   	 
                   	int index12_27 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred22_AplusParser()) ) { s = 89; }

                   	else if ( (synpred23_AplusParser()) ) { s = 99; }

                   	 
                   	input.Seek(index12_27);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 27 : 
                   	int LA12_28 = input.LA(1);

                   	 
                   	int index12_28 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred22_AplusParser()) ) { s = 89; }

                   	else if ( (synpred23_AplusParser()) ) { s = 99; }

                   	 
                   	input.Seek(index12_28);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 28 : 
                   	int LA12_29 = input.LA(1);

                   	 
                   	int index12_29 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred22_AplusParser()) ) { s = 89; }

                   	else if ( (synpred23_AplusParser()) ) { s = 99; }

                   	 
                   	input.Seek(index12_29);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 29 : 
                   	int LA12_30 = input.LA(1);

                   	 
                   	int index12_30 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred22_AplusParser()) ) { s = 89; }

                   	else if ( (synpred23_AplusParser()) ) { s = 99; }

                   	 
                   	input.Seek(index12_30);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 30 : 
                   	int LA12_31 = input.LA(1);

                   	 
                   	int index12_31 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred22_AplusParser()) ) { s = 89; }

                   	else if ( (synpred23_AplusParser()) ) { s = 99; }

                   	 
                   	input.Seek(index12_31);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 31 : 
                   	int LA12_32 = input.LA(1);

                   	 
                   	int index12_32 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred22_AplusParser()) ) { s = 89; }

                   	else if ( (synpred23_AplusParser()) ) { s = 99; }

                   	 
                   	input.Seek(index12_32);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 32 : 
                   	int LA12_33 = input.LA(1);

                   	 
                   	int index12_33 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred22_AplusParser()) ) { s = 89; }

                   	else if ( (synpred23_AplusParser()) ) { s = 99; }

                   	 
                   	input.Seek(index12_33);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 33 : 
                   	int LA12_34 = input.LA(1);

                   	 
                   	int index12_34 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred22_AplusParser()) ) { s = 89; }

                   	else if ( (synpred23_AplusParser()) ) { s = 99; }

                   	 
                   	input.Seek(index12_34);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 34 : 
                   	int LA12_35 = input.LA(1);

                   	 
                   	int index12_35 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred22_AplusParser()) ) { s = 89; }

                   	else if ( (synpred23_AplusParser()) ) { s = 99; }

                   	 
                   	input.Seek(index12_35);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 35 : 
                   	int LA12_36 = input.LA(1);

                   	 
                   	int index12_36 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred22_AplusParser()) ) { s = 89; }

                   	else if ( (synpred23_AplusParser()) ) { s = 99; }

                   	 
                   	input.Seek(index12_36);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 36 : 
                   	int LA12_37 = input.LA(1);

                   	 
                   	int index12_37 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred22_AplusParser()) ) { s = 89; }

                   	else if ( (synpred23_AplusParser()) ) { s = 99; }

                   	 
                   	input.Seek(index12_37);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 37 : 
                   	int LA12_38 = input.LA(1);

                   	 
                   	int index12_38 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred22_AplusParser()) ) { s = 89; }

                   	else if ( (synpred23_AplusParser()) ) { s = 99; }

                   	 
                   	input.Seek(index12_38);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 38 : 
                   	int LA12_39 = input.LA(1);

                   	 
                   	int index12_39 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred22_AplusParser()) ) { s = 89; }

                   	else if ( (synpred23_AplusParser()) ) { s = 99; }

                   	 
                   	input.Seek(index12_39);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 39 : 
                   	int LA12_40 = input.LA(1);

                   	 
                   	int index12_40 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred22_AplusParser()) ) { s = 89; }

                   	else if ( (synpred23_AplusParser()) ) { s = 99; }

                   	 
                   	input.Seek(index12_40);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 40 : 
                   	int LA12_41 = input.LA(1);

                   	 
                   	int index12_41 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred22_AplusParser()) ) { s = 89; }

                   	else if ( (synpred23_AplusParser()) ) { s = 99; }

                   	 
                   	input.Seek(index12_41);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 41 : 
                   	int LA12_42 = input.LA(1);

                   	 
                   	int index12_42 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred22_AplusParser()) ) { s = 89; }

                   	else if ( (synpred23_AplusParser()) ) { s = 99; }

                   	 
                   	input.Seek(index12_42);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 42 : 
                   	int LA12_43 = input.LA(1);

                   	 
                   	int index12_43 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred22_AplusParser()) ) { s = 89; }

                   	else if ( (synpred23_AplusParser()) ) { s = 99; }

                   	 
                   	input.Seek(index12_43);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 43 : 
                   	int LA12_44 = input.LA(1);

                   	 
                   	int index12_44 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred22_AplusParser()) ) { s = 89; }

                   	else if ( (synpred23_AplusParser()) ) { s = 99; }

                   	 
                   	input.Seek(index12_44);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 44 : 
                   	int LA12_45 = input.LA(1);

                   	 
                   	int index12_45 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred22_AplusParser()) ) { s = 89; }

                   	else if ( (synpred23_AplusParser()) ) { s = 99; }

                   	 
                   	input.Seek(index12_45);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 45 : 
                   	int LA12_46 = input.LA(1);

                   	 
                   	int index12_46 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred22_AplusParser()) ) { s = 89; }

                   	else if ( (synpred23_AplusParser()) ) { s = 99; }

                   	 
                   	input.Seek(index12_46);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 46 : 
                   	int LA12_47 = input.LA(1);

                   	 
                   	int index12_47 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred22_AplusParser()) ) { s = 89; }

                   	else if ( (synpred23_AplusParser()) ) { s = 99; }

                   	 
                   	input.Seek(index12_47);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 47 : 
                   	int LA12_48 = input.LA(1);

                   	 
                   	int index12_48 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred22_AplusParser()) ) { s = 89; }

                   	else if ( (synpred23_AplusParser()) ) { s = 99; }

                   	 
                   	input.Seek(index12_48);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 48 : 
                   	int LA12_49 = input.LA(1);

                   	 
                   	int index12_49 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred22_AplusParser()) ) { s = 89; }

                   	else if ( (synpred23_AplusParser()) ) { s = 99; }

                   	 
                   	input.Seek(index12_49);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 49 : 
                   	int LA12_50 = input.LA(1);

                   	 
                   	int index12_50 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred22_AplusParser()) ) { s = 89; }

                   	else if ( (synpred23_AplusParser()) ) { s = 99; }

                   	 
                   	input.Seek(index12_50);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 50 : 
                   	int LA12_51 = input.LA(1);

                   	 
                   	int index12_51 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred22_AplusParser()) ) { s = 89; }

                   	else if ( (synpred23_AplusParser()) ) { s = 99; }

                   	 
                   	input.Seek(index12_51);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 51 : 
                   	int LA12_52 = input.LA(1);

                   	 
                   	int index12_52 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred22_AplusParser()) ) { s = 89; }

                   	else if ( (synpred23_AplusParser()) ) { s = 99; }

                   	 
                   	input.Seek(index12_52);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 52 : 
                   	int LA12_53 = input.LA(1);

                   	 
                   	int index12_53 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred22_AplusParser()) ) { s = 89; }

                   	else if ( (synpred23_AplusParser()) ) { s = 99; }

                   	 
                   	input.Seek(index12_53);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 53 : 
                   	int LA12_54 = input.LA(1);

                   	 
                   	int index12_54 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred22_AplusParser()) ) { s = 89; }

                   	else if ( (synpred23_AplusParser()) ) { s = 99; }

                   	 
                   	input.Seek(index12_54);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 54 : 
                   	int LA12_55 = input.LA(1);

                   	 
                   	int index12_55 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred22_AplusParser()) ) { s = 89; }

                   	else if ( (synpred23_AplusParser()) ) { s = 99; }

                   	 
                   	input.Seek(index12_55);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 55 : 
                   	int LA12_56 = input.LA(1);

                   	 
                   	int index12_56 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred22_AplusParser()) ) { s = 89; }

                   	else if ( (synpred23_AplusParser()) ) { s = 99; }

                   	 
                   	input.Seek(index12_56);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 56 : 
                   	int LA12_57 = input.LA(1);

                   	 
                   	int index12_57 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred22_AplusParser()) ) { s = 89; }

                   	else if ( (synpred23_AplusParser()) ) { s = 99; }

                   	 
                   	input.Seek(index12_57);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 57 : 
                   	int LA12_58 = input.LA(1);

                   	 
                   	int index12_58 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred22_AplusParser()) ) { s = 89; }

                   	else if ( (synpred23_AplusParser()) ) { s = 99; }

                   	 
                   	input.Seek(index12_58);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 58 : 
                   	int LA12_59 = input.LA(1);

                   	 
                   	int index12_59 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred22_AplusParser()) ) { s = 89; }

                   	else if ( (synpred23_AplusParser()) ) { s = 99; }

                   	 
                   	input.Seek(index12_59);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 59 : 
                   	int LA12_60 = input.LA(1);

                   	 
                   	int index12_60 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred22_AplusParser()) ) { s = 89; }

                   	else if ( (synpred23_AplusParser()) ) { s = 99; }

                   	 
                   	input.Seek(index12_60);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 60 : 
                   	int LA12_61 = input.LA(1);

                   	 
                   	int index12_61 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred22_AplusParser()) ) { s = 89; }

                   	else if ( (synpred23_AplusParser()) ) { s = 99; }

                   	 
                   	input.Seek(index12_61);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 61 : 
                   	int LA12_62 = input.LA(1);

                   	 
                   	int index12_62 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred22_AplusParser()) ) { s = 89; }

                   	else if ( (synpred23_AplusParser()) ) { s = 99; }

                   	 
                   	input.Seek(index12_62);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 62 : 
                   	int LA12_63 = input.LA(1);

                   	 
                   	int index12_63 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred22_AplusParser()) ) { s = 89; }

                   	else if ( (synpred23_AplusParser()) ) { s = 99; }

                   	 
                   	input.Seek(index12_63);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 63 : 
                   	int LA12_64 = input.LA(1);

                   	 
                   	int index12_64 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred22_AplusParser()) ) { s = 89; }

                   	else if ( (synpred23_AplusParser()) ) { s = 99; }

                   	 
                   	input.Seek(index12_64);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 64 : 
                   	int LA12_65 = input.LA(1);

                   	 
                   	int index12_65 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred22_AplusParser()) ) { s = 89; }

                   	else if ( (synpred23_AplusParser()) ) { s = 99; }

                   	 
                   	input.Seek(index12_65);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 65 : 
                   	int LA12_66 = input.LA(1);

                   	 
                   	int index12_66 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred22_AplusParser()) ) { s = 89; }

                   	else if ( (synpred23_AplusParser()) ) { s = 99; }

                   	 
                   	input.Seek(index12_66);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 66 : 
                   	int LA12_67 = input.LA(1);

                   	 
                   	int index12_67 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred22_AplusParser()) ) { s = 89; }

                   	else if ( (synpred23_AplusParser()) ) { s = 99; }

                   	 
                   	input.Seek(index12_67);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 67 : 
                   	int LA12_68 = input.LA(1);

                   	 
                   	int index12_68 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred22_AplusParser()) ) { s = 89; }

                   	else if ( (synpred23_AplusParser()) ) { s = 99; }

                   	 
                   	input.Seek(index12_68);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 68 : 
                   	int LA12_69 = input.LA(1);

                   	 
                   	int index12_69 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred22_AplusParser()) ) { s = 89; }

                   	else if ( (synpred23_AplusParser()) ) { s = 99; }

                   	 
                   	input.Seek(index12_69);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 69 : 
                   	int LA12_70 = input.LA(1);

                   	 
                   	int index12_70 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred22_AplusParser()) ) { s = 89; }

                   	else if ( (synpred23_AplusParser()) ) { s = 99; }

                   	 
                   	input.Seek(index12_70);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 70 : 
                   	int LA12_71 = input.LA(1);

                   	 
                   	int index12_71 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred22_AplusParser()) ) { s = 89; }

                   	else if ( (synpred23_AplusParser()) ) { s = 99; }

                   	 
                   	input.Seek(index12_71);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 71 : 
                   	int LA12_72 = input.LA(1);

                   	 
                   	int index12_72 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred22_AplusParser()) ) { s = 89; }

                   	else if ( (synpred23_AplusParser()) ) { s = 99; }

                   	 
                   	input.Seek(index12_72);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 72 : 
                   	int LA12_73 = input.LA(1);

                   	 
                   	int index12_73 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred22_AplusParser()) ) { s = 89; }

                   	else if ( (synpred23_AplusParser()) ) { s = 99; }

                   	 
                   	input.Seek(index12_73);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 73 : 
                   	int LA12_74 = input.LA(1);

                   	 
                   	int index12_74 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred22_AplusParser()) ) { s = 89; }

                   	else if ( (synpred23_AplusParser()) ) { s = 99; }

                   	 
                   	input.Seek(index12_74);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 74 : 
                   	int LA12_75 = input.LA(1);

                   	 
                   	int index12_75 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred22_AplusParser()) ) { s = 89; }

                   	else if ( (synpred23_AplusParser()) ) { s = 99; }

                   	 
                   	input.Seek(index12_75);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 75 : 
                   	int LA12_76 = input.LA(1);

                   	 
                   	int index12_76 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred22_AplusParser()) ) { s = 89; }

                   	else if ( (synpred23_AplusParser()) ) { s = 99; }

                   	 
                   	input.Seek(index12_76);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 76 : 
                   	int LA12_77 = input.LA(1);

                   	 
                   	int index12_77 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred22_AplusParser()) ) { s = 89; }

                   	else if ( (synpred23_AplusParser()) ) { s = 99; }

                   	 
                   	input.Seek(index12_77);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 77 : 
                   	int LA12_78 = input.LA(1);

                   	 
                   	int index12_78 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred22_AplusParser()) ) { s = 89; }

                   	else if ( (synpred23_AplusParser()) ) { s = 99; }

                   	 
                   	input.Seek(index12_78);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 78 : 
                   	int LA12_79 = input.LA(1);

                   	 
                   	int index12_79 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred22_AplusParser()) ) { s = 89; }

                   	else if ( (synpred23_AplusParser()) ) { s = 99; }

                   	 
                   	input.Seek(index12_79);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 79 : 
                   	int LA12_80 = input.LA(1);

                   	 
                   	int index12_80 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred22_AplusParser()) ) { s = 89; }

                   	else if ( (synpred23_AplusParser()) ) { s = 99; }

                   	 
                   	input.Seek(index12_80);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 80 : 
                   	int LA12_81 = input.LA(1);

                   	 
                   	int index12_81 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred22_AplusParser()) ) { s = 89; }

                   	else if ( (synpred23_AplusParser()) ) { s = 99; }

                   	 
                   	input.Seek(index12_81);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 81 : 
                   	int LA12_82 = input.LA(1);

                   	 
                   	int index12_82 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred22_AplusParser()) ) { s = 89; }

                   	else if ( (synpred23_AplusParser()) ) { s = 99; }

                   	 
                   	input.Seek(index12_82);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 82 : 
                   	int LA12_83 = input.LA(1);

                   	 
                   	int index12_83 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred22_AplusParser()) ) { s = 89; }

                   	else if ( (synpred23_AplusParser()) ) { s = 99; }

                   	 
                   	input.Seek(index12_83);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 83 : 
                   	int LA12_84 = input.LA(1);

                   	 
                   	int index12_84 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred22_AplusParser()) ) { s = 89; }

                   	else if ( (synpred23_AplusParser()) ) { s = 99; }

                   	 
                   	input.Seek(index12_84);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 84 : 
                   	int LA12_85 = input.LA(1);

                   	 
                   	int index12_85 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred22_AplusParser()) ) { s = 89; }

                   	else if ( (synpred23_AplusParser()) ) { s = 99; }

                   	 
                   	input.Seek(index12_85);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 85 : 
                   	int LA12_86 = input.LA(1);

                   	 
                   	int index12_86 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred22_AplusParser()) ) { s = 89; }

                   	else if ( (synpred23_AplusParser()) ) { s = 99; }

                   	 
                   	input.Seek(index12_86);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 86 : 
                   	int LA12_87 = input.LA(1);

                   	 
                   	int index12_87 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred22_AplusParser()) ) { s = 89; }

                   	else if ( (synpred23_AplusParser()) ) { s = 99; }

                   	 
                   	input.Seek(index12_87);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 87 : 
                   	int LA12_88 = input.LA(1);

                   	 
                   	int index12_88 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred22_AplusParser()) ) { s = 89; }

                   	else if ( (synpred23_AplusParser()) ) { s = 99; }

                   	 
                   	input.Seek(index12_88);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 88 : 
                   	int LA12_96 = input.LA(1);

                   	 
                   	int index12_96 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred22_AplusParser()) ) { s = 89; }

                   	else if ( ((  IsGlobalFunction(input.LT(1)) )) ) { s = 100; }

                   	 
                   	input.Seek(index12_96);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 89 : 
                   	int LA12_97 = input.LA(1);

                   	 
                   	int index12_97 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred22_AplusParser()) ) { s = 89; }

                   	else if ( ((  IsGlobalFunction(input.LT(1)) )) ) { s = 100; }

                   	 
                   	input.Seek(index12_97);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 90 : 
                   	int LA12_98 = input.LA(1);

                   	 
                   	int index12_98 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred22_AplusParser()) ) { s = 89; }

                   	else if ( ((  IsGlobalFunction(input.LT(1)) )) ) { s = 100; }

                   	 
                   	input.Seek(index12_98);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        if (state.backtracking > 0) {state.failed = true; return -1;}
        NoViableAltException nvae12 =
            new NoViableAltException(dfa.Description, 12, _s, input);
        dfa.Error(nvae12);
        throw nvae12;
    }
    const string DFA13_eotS =
        "\x65\uffff";
    const string DFA13_eofS =
        "\x65\uffff";
    const string DFA13_minS =
        "\x01\x08\x58\x00\x07\uffff\x03\x00\x02\uffff";
    const string DFA13_maxS =
        "\x01\u0081\x58\x00\x07\uffff\x03\x00\x02\uffff";
    const string DFA13_acceptS =
        "\x59\uffff\x01\x01\x09\uffff\x01\x02\x01\x03";
    const string DFA13_specialS =
        "\x01\uffff\x01\x00\x01\x01\x01\x02\x01\x03\x01\x04\x01\x05\x01"+
        "\x06\x01\x07\x01\x08\x01\x09\x01\x0a\x01\x0b\x01\x0c\x01\x0d\x01"+
        "\x0e\x01\x0f\x01\x10\x01\x11\x01\x12\x01\x13\x01\x14\x01\x15\x01"+
        "\x16\x01\x17\x01\x18\x01\x19\x01\x1a\x01\x1b\x01\x1c\x01\x1d\x01"+
        "\x1e\x01\x1f\x01\x20\x01\x21\x01\x22\x01\x23\x01\x24\x01\x25\x01"+
        "\x26\x01\x27\x01\x28\x01\x29\x01\x2a\x01\x2b\x01\x2c\x01\x2d\x01"+
        "\x2e\x01\x2f\x01\x30\x01\x31\x01\x32\x01\x33\x01\x34\x01\x35\x01"+
        "\x36\x01\x37\x01\x38\x01\x39\x01\x3a\x01\x3b\x01\x3c\x01\x3d\x01"+
        "\x3e\x01\x3f\x01\x40\x01\x41\x01\x42\x01\x43\x01\x44\x01\x45\x01"+
        "\x46\x01\x47\x01\x48\x01\x49\x01\x4a\x01\x4b\x01\x4c\x01\x4d\x01"+
        "\x4e\x01\x4f\x01\x50\x01\x51\x01\x52\x01\x53\x01\x54\x01\x55\x01"+
        "\x56\x01\x57\x07\uffff\x01\x58\x01\x59\x01\x5a\x02\uffff}>";
    static readonly string[] DFA13_transitionS = {
            "\x01\x58\x02\uffff\x01\x3d\x01\x3e\x01\x3f\x01\x40\x01\x41"+
            "\x01\x42\x01\x43\x01\x44\x01\x45\x01\x46\x01\x47\x01\x48\x01"+
            "\x02\x01\x03\x01\x04\x01\x05\x01\x06\x01\x07\x01\x08\x01\x09"+
            "\x01\x0a\x01\x0b\x01\x0c\x01\x0d\x01\x0e\x01\x0f\x01\x10\x01"+
            "\x11\x01\x12\x01\x13\x01\x14\x01\x15\x01\x16\x01\x17\x01\x18"+
            "\x01\x19\x01\x1a\x01\x1b\x01\x1d\x01\x1c\x01\x1e\x01\x20\x01"+
            "\x21\x01\x22\x01\x23\x01\x24\x01\x25\x01\x26\x01\x27\x01\x28"+
            "\x01\x29\x01\x2a\x01\x49\x01\x4a\x01\x4b\x01\x4c\x01\x4d\x01"+
            "\x2b\x01\x4e\x01\x1f\x01\x2c\x01\x2d\x01\x2e\x01\x2f\x01\x30"+
            "\x01\x31\x01\x32\x01\x33\x01\x34\x01\x35\x01\x36\x01\x37\x01"+
            "\x38\x01\x39\x01\x3a\x01\x3b\x01\x3c\x01\x4f\x01\x50\x01\x51"+
            "\x01\x52\x01\x53\x01\x54\x01\x55\x01\x56\x01\x57\x01\uffff\x01"+
            "\x01\x09\uffff\x01\x59\x06\uffff\x01\x59\x01\uffff\x02\x59\x03"+
            "\uffff\x02\x59\x02\uffff\x01\x59\x01\x62\x01\x61\x01\x60",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "",
            ""
    };

    static readonly short[] DFA13_eot = DFA.UnpackEncodedString(DFA13_eotS);
    static readonly short[] DFA13_eof = DFA.UnpackEncodedString(DFA13_eofS);
    static readonly char[] DFA13_min = DFA.UnpackEncodedStringToUnsignedChars(DFA13_minS);
    static readonly char[] DFA13_max = DFA.UnpackEncodedStringToUnsignedChars(DFA13_maxS);
    static readonly short[] DFA13_accept = DFA.UnpackEncodedString(DFA13_acceptS);
    static readonly short[] DFA13_special = DFA.UnpackEncodedString(DFA13_specialS);
    static readonly short[][] DFA13_transition = DFA.UnpackEncodedStringArray(DFA13_transitionS);

    protected class DFA13 : DFA
    {
        public DFA13(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 13;
            this.eot = DFA13_eot;
            this.eof = DFA13_eof;
            this.min = DFA13_min;
            this.max = DFA13_max;
            this.accept = DFA13_accept;
            this.special = DFA13_special;
            this.transition = DFA13_transition;

        }

        override public string Description
        {
            get { return "199:1: dyadicFunctionSelector returns [AST.Node node] : ( operatorSymbol | functionSymbol | {...}? variableName );"; }
        }

    }


    protected internal int DFA13_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            ITokenStream input = (ITokenStream)_input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA13_1 = input.LA(1);

                   	 
                   	int index13_1 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred24_AplusParser()) ) { s = 89; }

                   	else if ( (synpred25_AplusParser()) ) { s = 99; }

                   	 
                   	input.Seek(index13_1);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 1 : 
                   	int LA13_2 = input.LA(1);

                   	 
                   	int index13_2 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred24_AplusParser()) ) { s = 89; }

                   	else if ( (synpred25_AplusParser()) ) { s = 99; }

                   	 
                   	input.Seek(index13_2);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 2 : 
                   	int LA13_3 = input.LA(1);

                   	 
                   	int index13_3 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred24_AplusParser()) ) { s = 89; }

                   	else if ( (synpred25_AplusParser()) ) { s = 99; }

                   	 
                   	input.Seek(index13_3);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 3 : 
                   	int LA13_4 = input.LA(1);

                   	 
                   	int index13_4 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred24_AplusParser()) ) { s = 89; }

                   	else if ( (synpred25_AplusParser()) ) { s = 99; }

                   	 
                   	input.Seek(index13_4);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 4 : 
                   	int LA13_5 = input.LA(1);

                   	 
                   	int index13_5 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred24_AplusParser()) ) { s = 89; }

                   	else if ( (synpred25_AplusParser()) ) { s = 99; }

                   	 
                   	input.Seek(index13_5);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 5 : 
                   	int LA13_6 = input.LA(1);

                   	 
                   	int index13_6 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred24_AplusParser()) ) { s = 89; }

                   	else if ( (synpred25_AplusParser()) ) { s = 99; }

                   	 
                   	input.Seek(index13_6);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 6 : 
                   	int LA13_7 = input.LA(1);

                   	 
                   	int index13_7 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred24_AplusParser()) ) { s = 89; }

                   	else if ( (synpred25_AplusParser()) ) { s = 99; }

                   	 
                   	input.Seek(index13_7);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 7 : 
                   	int LA13_8 = input.LA(1);

                   	 
                   	int index13_8 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred24_AplusParser()) ) { s = 89; }

                   	else if ( (synpred25_AplusParser()) ) { s = 99; }

                   	 
                   	input.Seek(index13_8);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 8 : 
                   	int LA13_9 = input.LA(1);

                   	 
                   	int index13_9 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred24_AplusParser()) ) { s = 89; }

                   	else if ( (synpred25_AplusParser()) ) { s = 99; }

                   	 
                   	input.Seek(index13_9);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 9 : 
                   	int LA13_10 = input.LA(1);

                   	 
                   	int index13_10 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred24_AplusParser()) ) { s = 89; }

                   	else if ( (synpred25_AplusParser()) ) { s = 99; }

                   	 
                   	input.Seek(index13_10);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 10 : 
                   	int LA13_11 = input.LA(1);

                   	 
                   	int index13_11 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred24_AplusParser()) ) { s = 89; }

                   	else if ( (synpred25_AplusParser()) ) { s = 99; }

                   	 
                   	input.Seek(index13_11);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 11 : 
                   	int LA13_12 = input.LA(1);

                   	 
                   	int index13_12 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred24_AplusParser()) ) { s = 89; }

                   	else if ( (synpred25_AplusParser()) ) { s = 99; }

                   	 
                   	input.Seek(index13_12);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 12 : 
                   	int LA13_13 = input.LA(1);

                   	 
                   	int index13_13 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred24_AplusParser()) ) { s = 89; }

                   	else if ( (synpred25_AplusParser()) ) { s = 99; }

                   	 
                   	input.Seek(index13_13);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 13 : 
                   	int LA13_14 = input.LA(1);

                   	 
                   	int index13_14 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred24_AplusParser()) ) { s = 89; }

                   	else if ( (synpred25_AplusParser()) ) { s = 99; }

                   	 
                   	input.Seek(index13_14);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 14 : 
                   	int LA13_15 = input.LA(1);

                   	 
                   	int index13_15 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred24_AplusParser()) ) { s = 89; }

                   	else if ( (synpred25_AplusParser()) ) { s = 99; }

                   	 
                   	input.Seek(index13_15);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 15 : 
                   	int LA13_16 = input.LA(1);

                   	 
                   	int index13_16 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred24_AplusParser()) ) { s = 89; }

                   	else if ( (synpred25_AplusParser()) ) { s = 99; }

                   	 
                   	input.Seek(index13_16);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 16 : 
                   	int LA13_17 = input.LA(1);

                   	 
                   	int index13_17 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred24_AplusParser()) ) { s = 89; }

                   	else if ( (synpred25_AplusParser()) ) { s = 99; }

                   	 
                   	input.Seek(index13_17);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 17 : 
                   	int LA13_18 = input.LA(1);

                   	 
                   	int index13_18 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred24_AplusParser()) ) { s = 89; }

                   	else if ( (synpred25_AplusParser()) ) { s = 99; }

                   	 
                   	input.Seek(index13_18);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 18 : 
                   	int LA13_19 = input.LA(1);

                   	 
                   	int index13_19 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred24_AplusParser()) ) { s = 89; }

                   	else if ( (synpred25_AplusParser()) ) { s = 99; }

                   	 
                   	input.Seek(index13_19);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 19 : 
                   	int LA13_20 = input.LA(1);

                   	 
                   	int index13_20 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred24_AplusParser()) ) { s = 89; }

                   	else if ( (synpred25_AplusParser()) ) { s = 99; }

                   	 
                   	input.Seek(index13_20);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 20 : 
                   	int LA13_21 = input.LA(1);

                   	 
                   	int index13_21 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred24_AplusParser()) ) { s = 89; }

                   	else if ( (synpred25_AplusParser()) ) { s = 99; }

                   	 
                   	input.Seek(index13_21);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 21 : 
                   	int LA13_22 = input.LA(1);

                   	 
                   	int index13_22 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred24_AplusParser()) ) { s = 89; }

                   	else if ( (synpred25_AplusParser()) ) { s = 99; }

                   	 
                   	input.Seek(index13_22);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 22 : 
                   	int LA13_23 = input.LA(1);

                   	 
                   	int index13_23 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred24_AplusParser()) ) { s = 89; }

                   	else if ( (synpred25_AplusParser()) ) { s = 99; }

                   	 
                   	input.Seek(index13_23);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 23 : 
                   	int LA13_24 = input.LA(1);

                   	 
                   	int index13_24 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred24_AplusParser()) ) { s = 89; }

                   	else if ( (synpred25_AplusParser()) ) { s = 99; }

                   	 
                   	input.Seek(index13_24);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 24 : 
                   	int LA13_25 = input.LA(1);

                   	 
                   	int index13_25 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred24_AplusParser()) ) { s = 89; }

                   	else if ( (synpred25_AplusParser()) ) { s = 99; }

                   	 
                   	input.Seek(index13_25);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 25 : 
                   	int LA13_26 = input.LA(1);

                   	 
                   	int index13_26 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred24_AplusParser()) ) { s = 89; }

                   	else if ( (synpred25_AplusParser()) ) { s = 99; }

                   	 
                   	input.Seek(index13_26);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 26 : 
                   	int LA13_27 = input.LA(1);

                   	 
                   	int index13_27 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred24_AplusParser()) ) { s = 89; }

                   	else if ( (synpred25_AplusParser()) ) { s = 99; }

                   	 
                   	input.Seek(index13_27);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 27 : 
                   	int LA13_28 = input.LA(1);

                   	 
                   	int index13_28 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred24_AplusParser()) ) { s = 89; }

                   	else if ( (synpred25_AplusParser()) ) { s = 99; }

                   	 
                   	input.Seek(index13_28);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 28 : 
                   	int LA13_29 = input.LA(1);

                   	 
                   	int index13_29 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred24_AplusParser()) ) { s = 89; }

                   	else if ( (synpred25_AplusParser()) ) { s = 99; }

                   	 
                   	input.Seek(index13_29);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 29 : 
                   	int LA13_30 = input.LA(1);

                   	 
                   	int index13_30 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred24_AplusParser()) ) { s = 89; }

                   	else if ( (synpred25_AplusParser()) ) { s = 99; }

                   	 
                   	input.Seek(index13_30);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 30 : 
                   	int LA13_31 = input.LA(1);

                   	 
                   	int index13_31 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred24_AplusParser()) ) { s = 89; }

                   	else if ( (synpred25_AplusParser()) ) { s = 99; }

                   	 
                   	input.Seek(index13_31);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 31 : 
                   	int LA13_32 = input.LA(1);

                   	 
                   	int index13_32 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred24_AplusParser()) ) { s = 89; }

                   	else if ( (synpred25_AplusParser()) ) { s = 99; }

                   	 
                   	input.Seek(index13_32);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 32 : 
                   	int LA13_33 = input.LA(1);

                   	 
                   	int index13_33 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred24_AplusParser()) ) { s = 89; }

                   	else if ( (synpred25_AplusParser()) ) { s = 99; }

                   	 
                   	input.Seek(index13_33);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 33 : 
                   	int LA13_34 = input.LA(1);

                   	 
                   	int index13_34 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred24_AplusParser()) ) { s = 89; }

                   	else if ( (synpred25_AplusParser()) ) { s = 99; }

                   	 
                   	input.Seek(index13_34);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 34 : 
                   	int LA13_35 = input.LA(1);

                   	 
                   	int index13_35 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred24_AplusParser()) ) { s = 89; }

                   	else if ( (synpred25_AplusParser()) ) { s = 99; }

                   	 
                   	input.Seek(index13_35);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 35 : 
                   	int LA13_36 = input.LA(1);

                   	 
                   	int index13_36 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred24_AplusParser()) ) { s = 89; }

                   	else if ( (synpred25_AplusParser()) ) { s = 99; }

                   	 
                   	input.Seek(index13_36);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 36 : 
                   	int LA13_37 = input.LA(1);

                   	 
                   	int index13_37 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred24_AplusParser()) ) { s = 89; }

                   	else if ( (synpred25_AplusParser()) ) { s = 99; }

                   	 
                   	input.Seek(index13_37);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 37 : 
                   	int LA13_38 = input.LA(1);

                   	 
                   	int index13_38 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred24_AplusParser()) ) { s = 89; }

                   	else if ( (synpred25_AplusParser()) ) { s = 99; }

                   	 
                   	input.Seek(index13_38);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 38 : 
                   	int LA13_39 = input.LA(1);

                   	 
                   	int index13_39 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred24_AplusParser()) ) { s = 89; }

                   	else if ( (synpred25_AplusParser()) ) { s = 99; }

                   	 
                   	input.Seek(index13_39);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 39 : 
                   	int LA13_40 = input.LA(1);

                   	 
                   	int index13_40 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred24_AplusParser()) ) { s = 89; }

                   	else if ( (synpred25_AplusParser()) ) { s = 99; }

                   	 
                   	input.Seek(index13_40);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 40 : 
                   	int LA13_41 = input.LA(1);

                   	 
                   	int index13_41 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred24_AplusParser()) ) { s = 89; }

                   	else if ( (synpred25_AplusParser()) ) { s = 99; }

                   	 
                   	input.Seek(index13_41);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 41 : 
                   	int LA13_42 = input.LA(1);

                   	 
                   	int index13_42 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred24_AplusParser()) ) { s = 89; }

                   	else if ( (synpred25_AplusParser()) ) { s = 99; }

                   	 
                   	input.Seek(index13_42);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 42 : 
                   	int LA13_43 = input.LA(1);

                   	 
                   	int index13_43 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred24_AplusParser()) ) { s = 89; }

                   	else if ( (synpred25_AplusParser()) ) { s = 99; }

                   	 
                   	input.Seek(index13_43);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 43 : 
                   	int LA13_44 = input.LA(1);

                   	 
                   	int index13_44 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred24_AplusParser()) ) { s = 89; }

                   	else if ( (synpred25_AplusParser()) ) { s = 99; }

                   	 
                   	input.Seek(index13_44);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 44 : 
                   	int LA13_45 = input.LA(1);

                   	 
                   	int index13_45 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred24_AplusParser()) ) { s = 89; }

                   	else if ( (synpred25_AplusParser()) ) { s = 99; }

                   	 
                   	input.Seek(index13_45);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 45 : 
                   	int LA13_46 = input.LA(1);

                   	 
                   	int index13_46 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred24_AplusParser()) ) { s = 89; }

                   	else if ( (synpred25_AplusParser()) ) { s = 99; }

                   	 
                   	input.Seek(index13_46);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 46 : 
                   	int LA13_47 = input.LA(1);

                   	 
                   	int index13_47 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred24_AplusParser()) ) { s = 89; }

                   	else if ( (synpred25_AplusParser()) ) { s = 99; }

                   	 
                   	input.Seek(index13_47);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 47 : 
                   	int LA13_48 = input.LA(1);

                   	 
                   	int index13_48 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred24_AplusParser()) ) { s = 89; }

                   	else if ( (synpred25_AplusParser()) ) { s = 99; }

                   	 
                   	input.Seek(index13_48);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 48 : 
                   	int LA13_49 = input.LA(1);

                   	 
                   	int index13_49 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred24_AplusParser()) ) { s = 89; }

                   	else if ( (synpred25_AplusParser()) ) { s = 99; }

                   	 
                   	input.Seek(index13_49);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 49 : 
                   	int LA13_50 = input.LA(1);

                   	 
                   	int index13_50 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred24_AplusParser()) ) { s = 89; }

                   	else if ( (synpred25_AplusParser()) ) { s = 99; }

                   	 
                   	input.Seek(index13_50);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 50 : 
                   	int LA13_51 = input.LA(1);

                   	 
                   	int index13_51 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred24_AplusParser()) ) { s = 89; }

                   	else if ( (synpred25_AplusParser()) ) { s = 99; }

                   	 
                   	input.Seek(index13_51);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 51 : 
                   	int LA13_52 = input.LA(1);

                   	 
                   	int index13_52 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred24_AplusParser()) ) { s = 89; }

                   	else if ( (synpred25_AplusParser()) ) { s = 99; }

                   	 
                   	input.Seek(index13_52);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 52 : 
                   	int LA13_53 = input.LA(1);

                   	 
                   	int index13_53 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred24_AplusParser()) ) { s = 89; }

                   	else if ( (synpred25_AplusParser()) ) { s = 99; }

                   	 
                   	input.Seek(index13_53);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 53 : 
                   	int LA13_54 = input.LA(1);

                   	 
                   	int index13_54 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred24_AplusParser()) ) { s = 89; }

                   	else if ( (synpred25_AplusParser()) ) { s = 99; }

                   	 
                   	input.Seek(index13_54);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 54 : 
                   	int LA13_55 = input.LA(1);

                   	 
                   	int index13_55 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred24_AplusParser()) ) { s = 89; }

                   	else if ( (synpred25_AplusParser()) ) { s = 99; }

                   	 
                   	input.Seek(index13_55);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 55 : 
                   	int LA13_56 = input.LA(1);

                   	 
                   	int index13_56 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred24_AplusParser()) ) { s = 89; }

                   	else if ( (synpred25_AplusParser()) ) { s = 99; }

                   	 
                   	input.Seek(index13_56);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 56 : 
                   	int LA13_57 = input.LA(1);

                   	 
                   	int index13_57 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred24_AplusParser()) ) { s = 89; }

                   	else if ( (synpred25_AplusParser()) ) { s = 99; }

                   	 
                   	input.Seek(index13_57);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 57 : 
                   	int LA13_58 = input.LA(1);

                   	 
                   	int index13_58 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred24_AplusParser()) ) { s = 89; }

                   	else if ( (synpred25_AplusParser()) ) { s = 99; }

                   	 
                   	input.Seek(index13_58);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 58 : 
                   	int LA13_59 = input.LA(1);

                   	 
                   	int index13_59 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred24_AplusParser()) ) { s = 89; }

                   	else if ( (synpred25_AplusParser()) ) { s = 99; }

                   	 
                   	input.Seek(index13_59);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 59 : 
                   	int LA13_60 = input.LA(1);

                   	 
                   	int index13_60 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred24_AplusParser()) ) { s = 89; }

                   	else if ( (synpred25_AplusParser()) ) { s = 99; }

                   	 
                   	input.Seek(index13_60);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 60 : 
                   	int LA13_61 = input.LA(1);

                   	 
                   	int index13_61 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred24_AplusParser()) ) { s = 89; }

                   	else if ( (synpred25_AplusParser()) ) { s = 99; }

                   	 
                   	input.Seek(index13_61);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 61 : 
                   	int LA13_62 = input.LA(1);

                   	 
                   	int index13_62 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred24_AplusParser()) ) { s = 89; }

                   	else if ( (synpred25_AplusParser()) ) { s = 99; }

                   	 
                   	input.Seek(index13_62);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 62 : 
                   	int LA13_63 = input.LA(1);

                   	 
                   	int index13_63 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred24_AplusParser()) ) { s = 89; }

                   	else if ( (synpred25_AplusParser()) ) { s = 99; }

                   	 
                   	input.Seek(index13_63);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 63 : 
                   	int LA13_64 = input.LA(1);

                   	 
                   	int index13_64 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred24_AplusParser()) ) { s = 89; }

                   	else if ( (synpred25_AplusParser()) ) { s = 99; }

                   	 
                   	input.Seek(index13_64);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 64 : 
                   	int LA13_65 = input.LA(1);

                   	 
                   	int index13_65 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred24_AplusParser()) ) { s = 89; }

                   	else if ( (synpred25_AplusParser()) ) { s = 99; }

                   	 
                   	input.Seek(index13_65);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 65 : 
                   	int LA13_66 = input.LA(1);

                   	 
                   	int index13_66 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred24_AplusParser()) ) { s = 89; }

                   	else if ( (synpred25_AplusParser()) ) { s = 99; }

                   	 
                   	input.Seek(index13_66);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 66 : 
                   	int LA13_67 = input.LA(1);

                   	 
                   	int index13_67 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred24_AplusParser()) ) { s = 89; }

                   	else if ( (synpred25_AplusParser()) ) { s = 99; }

                   	 
                   	input.Seek(index13_67);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 67 : 
                   	int LA13_68 = input.LA(1);

                   	 
                   	int index13_68 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred24_AplusParser()) ) { s = 89; }

                   	else if ( (synpred25_AplusParser()) ) { s = 99; }

                   	 
                   	input.Seek(index13_68);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 68 : 
                   	int LA13_69 = input.LA(1);

                   	 
                   	int index13_69 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred24_AplusParser()) ) { s = 89; }

                   	else if ( (synpred25_AplusParser()) ) { s = 99; }

                   	 
                   	input.Seek(index13_69);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 69 : 
                   	int LA13_70 = input.LA(1);

                   	 
                   	int index13_70 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred24_AplusParser()) ) { s = 89; }

                   	else if ( (synpred25_AplusParser()) ) { s = 99; }

                   	 
                   	input.Seek(index13_70);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 70 : 
                   	int LA13_71 = input.LA(1);

                   	 
                   	int index13_71 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred24_AplusParser()) ) { s = 89; }

                   	else if ( (synpred25_AplusParser()) ) { s = 99; }

                   	 
                   	input.Seek(index13_71);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 71 : 
                   	int LA13_72 = input.LA(1);

                   	 
                   	int index13_72 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred24_AplusParser()) ) { s = 89; }

                   	else if ( (synpred25_AplusParser()) ) { s = 99; }

                   	 
                   	input.Seek(index13_72);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 72 : 
                   	int LA13_73 = input.LA(1);

                   	 
                   	int index13_73 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred24_AplusParser()) ) { s = 89; }

                   	else if ( (synpred25_AplusParser()) ) { s = 99; }

                   	 
                   	input.Seek(index13_73);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 73 : 
                   	int LA13_74 = input.LA(1);

                   	 
                   	int index13_74 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred24_AplusParser()) ) { s = 89; }

                   	else if ( (synpred25_AplusParser()) ) { s = 99; }

                   	 
                   	input.Seek(index13_74);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 74 : 
                   	int LA13_75 = input.LA(1);

                   	 
                   	int index13_75 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred24_AplusParser()) ) { s = 89; }

                   	else if ( (synpred25_AplusParser()) ) { s = 99; }

                   	 
                   	input.Seek(index13_75);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 75 : 
                   	int LA13_76 = input.LA(1);

                   	 
                   	int index13_76 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred24_AplusParser()) ) { s = 89; }

                   	else if ( (synpred25_AplusParser()) ) { s = 99; }

                   	 
                   	input.Seek(index13_76);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 76 : 
                   	int LA13_77 = input.LA(1);

                   	 
                   	int index13_77 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred24_AplusParser()) ) { s = 89; }

                   	else if ( (synpred25_AplusParser()) ) { s = 99; }

                   	 
                   	input.Seek(index13_77);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 77 : 
                   	int LA13_78 = input.LA(1);

                   	 
                   	int index13_78 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred24_AplusParser()) ) { s = 89; }

                   	else if ( (synpred25_AplusParser()) ) { s = 99; }

                   	 
                   	input.Seek(index13_78);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 78 : 
                   	int LA13_79 = input.LA(1);

                   	 
                   	int index13_79 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred24_AplusParser()) ) { s = 89; }

                   	else if ( (synpred25_AplusParser()) ) { s = 99; }

                   	 
                   	input.Seek(index13_79);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 79 : 
                   	int LA13_80 = input.LA(1);

                   	 
                   	int index13_80 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred24_AplusParser()) ) { s = 89; }

                   	else if ( (synpred25_AplusParser()) ) { s = 99; }

                   	 
                   	input.Seek(index13_80);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 80 : 
                   	int LA13_81 = input.LA(1);

                   	 
                   	int index13_81 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred24_AplusParser()) ) { s = 89; }

                   	else if ( (synpred25_AplusParser()) ) { s = 99; }

                   	 
                   	input.Seek(index13_81);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 81 : 
                   	int LA13_82 = input.LA(1);

                   	 
                   	int index13_82 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred24_AplusParser()) ) { s = 89; }

                   	else if ( (synpred25_AplusParser()) ) { s = 99; }

                   	 
                   	input.Seek(index13_82);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 82 : 
                   	int LA13_83 = input.LA(1);

                   	 
                   	int index13_83 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred24_AplusParser()) ) { s = 89; }

                   	else if ( (synpred25_AplusParser()) ) { s = 99; }

                   	 
                   	input.Seek(index13_83);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 83 : 
                   	int LA13_84 = input.LA(1);

                   	 
                   	int index13_84 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred24_AplusParser()) ) { s = 89; }

                   	else if ( (synpred25_AplusParser()) ) { s = 99; }

                   	 
                   	input.Seek(index13_84);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 84 : 
                   	int LA13_85 = input.LA(1);

                   	 
                   	int index13_85 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred24_AplusParser()) ) { s = 89; }

                   	else if ( (synpred25_AplusParser()) ) { s = 99; }

                   	 
                   	input.Seek(index13_85);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 85 : 
                   	int LA13_86 = input.LA(1);

                   	 
                   	int index13_86 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred24_AplusParser()) ) { s = 89; }

                   	else if ( (synpred25_AplusParser()) ) { s = 99; }

                   	 
                   	input.Seek(index13_86);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 86 : 
                   	int LA13_87 = input.LA(1);

                   	 
                   	int index13_87 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred24_AplusParser()) ) { s = 89; }

                   	else if ( (synpred25_AplusParser()) ) { s = 99; }

                   	 
                   	input.Seek(index13_87);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 87 : 
                   	int LA13_88 = input.LA(1);

                   	 
                   	int index13_88 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred24_AplusParser()) ) { s = 89; }

                   	else if ( (synpred25_AplusParser()) ) { s = 99; }

                   	 
                   	input.Seek(index13_88);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 88 : 
                   	int LA13_96 = input.LA(1);

                   	 
                   	int index13_96 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred24_AplusParser()) ) { s = 89; }

                   	else if ( ((  IsGlobalFunction(input.LT(1)) )) ) { s = 100; }

                   	 
                   	input.Seek(index13_96);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 89 : 
                   	int LA13_97 = input.LA(1);

                   	 
                   	int index13_97 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred24_AplusParser()) ) { s = 89; }

                   	else if ( ((  IsGlobalFunction(input.LT(1)) )) ) { s = 100; }

                   	 
                   	input.Seek(index13_97);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 90 : 
                   	int LA13_98 = input.LA(1);

                   	 
                   	int index13_98 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred24_AplusParser()) ) { s = 89; }

                   	else if ( ((  IsGlobalFunction(input.LT(1)) )) ) { s = 100; }

                   	 
                   	input.Seek(index13_98);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        if (state.backtracking > 0) {state.failed = true; return -1;}
        NoViableAltException nvae13 =
            new NoViableAltException(dfa.Description, 13, _s, input);
        dfa.Error(nvae13);
        throw nvae13;
    }
    const string DFA14_eotS =
        "\x66\uffff";
    const string DFA14_eofS =
        "\x66\uffff";
    const string DFA14_minS =
        "\x01\x08\x62\x00\x03\uffff";
    const string DFA14_maxS =
        "\x01\u0081\x62\x00\x03\uffff";
    const string DFA14_acceptS =
        "\x63\uffff\x01\x03\x01\x01\x01\x02";
    const string DFA14_specialS =
        "\x01\uffff\x01\x00\x01\x01\x01\x02\x01\x03\x01\x04\x01\x05\x01"+
        "\x06\x01\x07\x01\x08\x01\x09\x01\x0a\x01\x0b\x01\x0c\x01\x0d\x01"+
        "\x0e\x01\x0f\x01\x10\x01\x11\x01\x12\x01\x13\x01\x14\x01\x15\x01"+
        "\x16\x01\x17\x01\x18\x01\x19\x01\x1a\x01\x1b\x01\x1c\x01\x1d\x01"+
        "\x1e\x01\x1f\x01\x20\x01\x21\x01\x22\x01\x23\x01\x24\x01\x25\x01"+
        "\x26\x01\x27\x01\x28\x01\x29\x01\x2a\x01\x2b\x01\x2c\x01\x2d\x01"+
        "\x2e\x01\x2f\x01\x30\x01\x31\x01\x32\x01\x33\x01\x34\x01\x35\x01"+
        "\x36\x01\x37\x01\x38\x01\x39\x01\x3a\x01\x3b\x01\x3c\x01\x3d\x01"+
        "\x3e\x01\x3f\x01\x40\x01\x41\x01\x42\x01\x43\x01\x44\x01\x45\x01"+
        "\x46\x01\x47\x01\x48\x01\x49\x01\x4a\x01\x4b\x01\x4c\x01\x4d\x01"+
        "\x4e\x01\x4f\x01\x50\x01\x51\x01\x52\x01\x53\x01\x54\x01\x55\x01"+
        "\x56\x01\x57\x01\x58\x01\x59\x01\x5a\x01\x5b\x01\x5c\x01\x5d\x01"+
        "\x5e\x01\x5f\x01\x60\x01\x61\x03\uffff}>";
    static readonly string[] DFA14_transitionS = {
            "\x01\x58\x02\uffff\x01\x3d\x01\x3e\x01\x3f\x01\x40\x01\x41"+
            "\x01\x42\x01\x43\x01\x44\x01\x45\x01\x46\x01\x47\x01\x48\x01"+
            "\x02\x01\x03\x01\x04\x01\x05\x01\x06\x01\x07\x01\x08\x01\x09"+
            "\x01\x0a\x01\x0b\x01\x0c\x01\x0d\x01\x0e\x01\x0f\x01\x10\x01"+
            "\x11\x01\x12\x01\x13\x01\x14\x01\x15\x01\x16\x01\x17\x01\x18"+
            "\x01\x19\x01\x1a\x01\x1b\x01\x1d\x01\x1c\x01\x1e\x01\x20\x01"+
            "\x21\x01\x22\x01\x23\x01\x24\x01\x25\x01\x26\x01\x27\x01\x28"+
            "\x01\x29\x01\x2a\x01\x49\x01\x4a\x01\x4b\x01\x4c\x01\x4d\x01"+
            "\x2b\x01\x4e\x01\x1f\x01\x2c\x01\x2d\x01\x2e\x01\x2f\x01\x30"+
            "\x01\x31\x01\x32\x01\x33\x01\x34\x01\x35\x01\x36\x01\x37\x01"+
            "\x38\x01\x39\x01\x3a\x01\x3b\x01\x3c\x01\x4f\x01\x50\x01\x51"+
            "\x01\x52\x01\x53\x01\x54\x01\x55\x01\x56\x01\x57\x01\x63\x01"+
            "\x01\x09\uffff\x01\x59\x06\uffff\x01\x5a\x01\uffff\x01\x5b\x01"+
            "\x5c\x03\uffff\x01\x5e\x01\x5f\x02\uffff\x01\x5d\x01\x62\x01"+
            "\x61\x01\x60",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "",
            "",
            ""
    };

    static readonly short[] DFA14_eot = DFA.UnpackEncodedString(DFA14_eotS);
    static readonly short[] DFA14_eof = DFA.UnpackEncodedString(DFA14_eofS);
    static readonly char[] DFA14_min = DFA.UnpackEncodedStringToUnsignedChars(DFA14_minS);
    static readonly char[] DFA14_max = DFA.UnpackEncodedStringToUnsignedChars(DFA14_maxS);
    static readonly short[] DFA14_accept = DFA.UnpackEncodedString(DFA14_acceptS);
    static readonly short[] DFA14_special = DFA.UnpackEncodedString(DFA14_specialS);
    static readonly short[][] DFA14_transition = DFA.UnpackEncodedStringArray(DFA14_transitionS);

    protected class DFA14 : DFA
    {
        public DFA14(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 14;
            this.eot = DFA14_eot;
            this.eof = DFA14_eof;
            this.min = DFA14_min;
            this.max = DFA14_max;
            this.accept = DFA14_accept;
            this.special = DFA14_special;
            this.transition = DFA14_transition;

        }

        override public string Description
        {
            get { return "206:1: dyadicLeftArg returns [AST.Node node] : ( operatorSymbol expressionGroup | functionSymbol expressionGroup | simpleExpression );"; }
        }

    }


    protected internal int DFA14_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            ITokenStream input = (ITokenStream)_input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA14_1 = input.LA(1);

                   	 
                   	int index14_1 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred26_AplusParser()) ) { s = 100; }

                   	else if ( (synpred27_AplusParser()) ) { s = 101; }

                   	else if ( (true) ) { s = 99; }

                   	 
                   	input.Seek(index14_1);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 1 : 
                   	int LA14_2 = input.LA(1);

                   	 
                   	int index14_2 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred26_AplusParser()) ) { s = 100; }

                   	else if ( (synpred27_AplusParser()) ) { s = 101; }

                   	 
                   	input.Seek(index14_2);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 2 : 
                   	int LA14_3 = input.LA(1);

                   	 
                   	int index14_3 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred26_AplusParser()) ) { s = 100; }

                   	else if ( (synpred27_AplusParser()) ) { s = 101; }

                   	 
                   	input.Seek(index14_3);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 3 : 
                   	int LA14_4 = input.LA(1);

                   	 
                   	int index14_4 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred26_AplusParser()) ) { s = 100; }

                   	else if ( (synpred27_AplusParser()) ) { s = 101; }

                   	 
                   	input.Seek(index14_4);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 4 : 
                   	int LA14_5 = input.LA(1);

                   	 
                   	int index14_5 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred26_AplusParser()) ) { s = 100; }

                   	else if ( (synpred27_AplusParser()) ) { s = 101; }

                   	 
                   	input.Seek(index14_5);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 5 : 
                   	int LA14_6 = input.LA(1);

                   	 
                   	int index14_6 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred26_AplusParser()) ) { s = 100; }

                   	else if ( (synpred27_AplusParser()) ) { s = 101; }

                   	 
                   	input.Seek(index14_6);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 6 : 
                   	int LA14_7 = input.LA(1);

                   	 
                   	int index14_7 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred26_AplusParser()) ) { s = 100; }

                   	else if ( (synpred27_AplusParser()) ) { s = 101; }

                   	 
                   	input.Seek(index14_7);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 7 : 
                   	int LA14_8 = input.LA(1);

                   	 
                   	int index14_8 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred26_AplusParser()) ) { s = 100; }

                   	else if ( (synpred27_AplusParser()) ) { s = 101; }

                   	 
                   	input.Seek(index14_8);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 8 : 
                   	int LA14_9 = input.LA(1);

                   	 
                   	int index14_9 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred26_AplusParser()) ) { s = 100; }

                   	else if ( (synpred27_AplusParser()) ) { s = 101; }

                   	 
                   	input.Seek(index14_9);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 9 : 
                   	int LA14_10 = input.LA(1);

                   	 
                   	int index14_10 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred26_AplusParser()) ) { s = 100; }

                   	else if ( (synpred27_AplusParser()) ) { s = 101; }

                   	 
                   	input.Seek(index14_10);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 10 : 
                   	int LA14_11 = input.LA(1);

                   	 
                   	int index14_11 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred26_AplusParser()) ) { s = 100; }

                   	else if ( (synpred27_AplusParser()) ) { s = 101; }

                   	 
                   	input.Seek(index14_11);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 11 : 
                   	int LA14_12 = input.LA(1);

                   	 
                   	int index14_12 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred26_AplusParser()) ) { s = 100; }

                   	else if ( (synpred27_AplusParser()) ) { s = 101; }

                   	 
                   	input.Seek(index14_12);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 12 : 
                   	int LA14_13 = input.LA(1);

                   	 
                   	int index14_13 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred26_AplusParser()) ) { s = 100; }

                   	else if ( (synpred27_AplusParser()) ) { s = 101; }

                   	 
                   	input.Seek(index14_13);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 13 : 
                   	int LA14_14 = input.LA(1);

                   	 
                   	int index14_14 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred26_AplusParser()) ) { s = 100; }

                   	else if ( (synpred27_AplusParser()) ) { s = 101; }

                   	 
                   	input.Seek(index14_14);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 14 : 
                   	int LA14_15 = input.LA(1);

                   	 
                   	int index14_15 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred26_AplusParser()) ) { s = 100; }

                   	else if ( (synpred27_AplusParser()) ) { s = 101; }

                   	 
                   	input.Seek(index14_15);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 15 : 
                   	int LA14_16 = input.LA(1);

                   	 
                   	int index14_16 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred26_AplusParser()) ) { s = 100; }

                   	else if ( (synpred27_AplusParser()) ) { s = 101; }

                   	 
                   	input.Seek(index14_16);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 16 : 
                   	int LA14_17 = input.LA(1);

                   	 
                   	int index14_17 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred26_AplusParser()) ) { s = 100; }

                   	else if ( (synpred27_AplusParser()) ) { s = 101; }

                   	 
                   	input.Seek(index14_17);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 17 : 
                   	int LA14_18 = input.LA(1);

                   	 
                   	int index14_18 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred26_AplusParser()) ) { s = 100; }

                   	else if ( (synpred27_AplusParser()) ) { s = 101; }

                   	 
                   	input.Seek(index14_18);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 18 : 
                   	int LA14_19 = input.LA(1);

                   	 
                   	int index14_19 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred26_AplusParser()) ) { s = 100; }

                   	else if ( (synpred27_AplusParser()) ) { s = 101; }

                   	 
                   	input.Seek(index14_19);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 19 : 
                   	int LA14_20 = input.LA(1);

                   	 
                   	int index14_20 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred26_AplusParser()) ) { s = 100; }

                   	else if ( (synpred27_AplusParser()) ) { s = 101; }

                   	 
                   	input.Seek(index14_20);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 20 : 
                   	int LA14_21 = input.LA(1);

                   	 
                   	int index14_21 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred26_AplusParser()) ) { s = 100; }

                   	else if ( (synpred27_AplusParser()) ) { s = 101; }

                   	 
                   	input.Seek(index14_21);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 21 : 
                   	int LA14_22 = input.LA(1);

                   	 
                   	int index14_22 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred26_AplusParser()) ) { s = 100; }

                   	else if ( (synpred27_AplusParser()) ) { s = 101; }

                   	 
                   	input.Seek(index14_22);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 22 : 
                   	int LA14_23 = input.LA(1);

                   	 
                   	int index14_23 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred26_AplusParser()) ) { s = 100; }

                   	else if ( (synpred27_AplusParser()) ) { s = 101; }

                   	 
                   	input.Seek(index14_23);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 23 : 
                   	int LA14_24 = input.LA(1);

                   	 
                   	int index14_24 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred26_AplusParser()) ) { s = 100; }

                   	else if ( (synpred27_AplusParser()) ) { s = 101; }

                   	 
                   	input.Seek(index14_24);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 24 : 
                   	int LA14_25 = input.LA(1);

                   	 
                   	int index14_25 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred26_AplusParser()) ) { s = 100; }

                   	else if ( (synpred27_AplusParser()) ) { s = 101; }

                   	 
                   	input.Seek(index14_25);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 25 : 
                   	int LA14_26 = input.LA(1);

                   	 
                   	int index14_26 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred26_AplusParser()) ) { s = 100; }

                   	else if ( (synpred27_AplusParser()) ) { s = 101; }

                   	 
                   	input.Seek(index14_26);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 26 : 
                   	int LA14_27 = input.LA(1);

                   	 
                   	int index14_27 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred26_AplusParser()) ) { s = 100; }

                   	else if ( (synpred27_AplusParser()) ) { s = 101; }

                   	 
                   	input.Seek(index14_27);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 27 : 
                   	int LA14_28 = input.LA(1);

                   	 
                   	int index14_28 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred26_AplusParser()) ) { s = 100; }

                   	else if ( (synpred27_AplusParser()) ) { s = 101; }

                   	 
                   	input.Seek(index14_28);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 28 : 
                   	int LA14_29 = input.LA(1);

                   	 
                   	int index14_29 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred26_AplusParser()) ) { s = 100; }

                   	else if ( (synpred27_AplusParser()) ) { s = 101; }

                   	 
                   	input.Seek(index14_29);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 29 : 
                   	int LA14_30 = input.LA(1);

                   	 
                   	int index14_30 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred26_AplusParser()) ) { s = 100; }

                   	else if ( (synpred27_AplusParser()) ) { s = 101; }

                   	 
                   	input.Seek(index14_30);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 30 : 
                   	int LA14_31 = input.LA(1);

                   	 
                   	int index14_31 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred26_AplusParser()) ) { s = 100; }

                   	else if ( (synpred27_AplusParser()) ) { s = 101; }

                   	 
                   	input.Seek(index14_31);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 31 : 
                   	int LA14_32 = input.LA(1);

                   	 
                   	int index14_32 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred26_AplusParser()) ) { s = 100; }

                   	else if ( (synpred27_AplusParser()) ) { s = 101; }

                   	 
                   	input.Seek(index14_32);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 32 : 
                   	int LA14_33 = input.LA(1);

                   	 
                   	int index14_33 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred26_AplusParser()) ) { s = 100; }

                   	else if ( (synpred27_AplusParser()) ) { s = 101; }

                   	 
                   	input.Seek(index14_33);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 33 : 
                   	int LA14_34 = input.LA(1);

                   	 
                   	int index14_34 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred26_AplusParser()) ) { s = 100; }

                   	else if ( (synpred27_AplusParser()) ) { s = 101; }

                   	 
                   	input.Seek(index14_34);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 34 : 
                   	int LA14_35 = input.LA(1);

                   	 
                   	int index14_35 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred26_AplusParser()) ) { s = 100; }

                   	else if ( (synpred27_AplusParser()) ) { s = 101; }

                   	 
                   	input.Seek(index14_35);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 35 : 
                   	int LA14_36 = input.LA(1);

                   	 
                   	int index14_36 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred26_AplusParser()) ) { s = 100; }

                   	else if ( (synpred27_AplusParser()) ) { s = 101; }

                   	 
                   	input.Seek(index14_36);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 36 : 
                   	int LA14_37 = input.LA(1);

                   	 
                   	int index14_37 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred26_AplusParser()) ) { s = 100; }

                   	else if ( (synpred27_AplusParser()) ) { s = 101; }

                   	 
                   	input.Seek(index14_37);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 37 : 
                   	int LA14_38 = input.LA(1);

                   	 
                   	int index14_38 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred26_AplusParser()) ) { s = 100; }

                   	else if ( (synpred27_AplusParser()) ) { s = 101; }

                   	 
                   	input.Seek(index14_38);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 38 : 
                   	int LA14_39 = input.LA(1);

                   	 
                   	int index14_39 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred26_AplusParser()) ) { s = 100; }

                   	else if ( (synpred27_AplusParser()) ) { s = 101; }

                   	 
                   	input.Seek(index14_39);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 39 : 
                   	int LA14_40 = input.LA(1);

                   	 
                   	int index14_40 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred26_AplusParser()) ) { s = 100; }

                   	else if ( (synpred27_AplusParser()) ) { s = 101; }

                   	 
                   	input.Seek(index14_40);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 40 : 
                   	int LA14_41 = input.LA(1);

                   	 
                   	int index14_41 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred26_AplusParser()) ) { s = 100; }

                   	else if ( (synpred27_AplusParser()) ) { s = 101; }

                   	 
                   	input.Seek(index14_41);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 41 : 
                   	int LA14_42 = input.LA(1);

                   	 
                   	int index14_42 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred26_AplusParser()) ) { s = 100; }

                   	else if ( (synpred27_AplusParser()) ) { s = 101; }

                   	 
                   	input.Seek(index14_42);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 42 : 
                   	int LA14_43 = input.LA(1);

                   	 
                   	int index14_43 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred26_AplusParser()) ) { s = 100; }

                   	else if ( (synpred27_AplusParser()) ) { s = 101; }

                   	 
                   	input.Seek(index14_43);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 43 : 
                   	int LA14_44 = input.LA(1);

                   	 
                   	int index14_44 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred26_AplusParser()) ) { s = 100; }

                   	else if ( (synpred27_AplusParser()) ) { s = 101; }

                   	 
                   	input.Seek(index14_44);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 44 : 
                   	int LA14_45 = input.LA(1);

                   	 
                   	int index14_45 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred26_AplusParser()) ) { s = 100; }

                   	else if ( (synpred27_AplusParser()) ) { s = 101; }

                   	 
                   	input.Seek(index14_45);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 45 : 
                   	int LA14_46 = input.LA(1);

                   	 
                   	int index14_46 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred26_AplusParser()) ) { s = 100; }

                   	else if ( (synpred27_AplusParser()) ) { s = 101; }

                   	 
                   	input.Seek(index14_46);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 46 : 
                   	int LA14_47 = input.LA(1);

                   	 
                   	int index14_47 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred26_AplusParser()) ) { s = 100; }

                   	else if ( (synpred27_AplusParser()) ) { s = 101; }

                   	 
                   	input.Seek(index14_47);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 47 : 
                   	int LA14_48 = input.LA(1);

                   	 
                   	int index14_48 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred26_AplusParser()) ) { s = 100; }

                   	else if ( (synpred27_AplusParser()) ) { s = 101; }

                   	 
                   	input.Seek(index14_48);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 48 : 
                   	int LA14_49 = input.LA(1);

                   	 
                   	int index14_49 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred26_AplusParser()) ) { s = 100; }

                   	else if ( (synpred27_AplusParser()) ) { s = 101; }

                   	 
                   	input.Seek(index14_49);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 49 : 
                   	int LA14_50 = input.LA(1);

                   	 
                   	int index14_50 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred26_AplusParser()) ) { s = 100; }

                   	else if ( (synpred27_AplusParser()) ) { s = 101; }

                   	 
                   	input.Seek(index14_50);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 50 : 
                   	int LA14_51 = input.LA(1);

                   	 
                   	int index14_51 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred26_AplusParser()) ) { s = 100; }

                   	else if ( (synpred27_AplusParser()) ) { s = 101; }

                   	 
                   	input.Seek(index14_51);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 51 : 
                   	int LA14_52 = input.LA(1);

                   	 
                   	int index14_52 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred26_AplusParser()) ) { s = 100; }

                   	else if ( (synpred27_AplusParser()) ) { s = 101; }

                   	 
                   	input.Seek(index14_52);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 52 : 
                   	int LA14_53 = input.LA(1);

                   	 
                   	int index14_53 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred26_AplusParser()) ) { s = 100; }

                   	else if ( (synpred27_AplusParser()) ) { s = 101; }

                   	 
                   	input.Seek(index14_53);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 53 : 
                   	int LA14_54 = input.LA(1);

                   	 
                   	int index14_54 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred26_AplusParser()) ) { s = 100; }

                   	else if ( (synpred27_AplusParser()) ) { s = 101; }

                   	 
                   	input.Seek(index14_54);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 54 : 
                   	int LA14_55 = input.LA(1);

                   	 
                   	int index14_55 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred26_AplusParser()) ) { s = 100; }

                   	else if ( (synpred27_AplusParser()) ) { s = 101; }

                   	 
                   	input.Seek(index14_55);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 55 : 
                   	int LA14_56 = input.LA(1);

                   	 
                   	int index14_56 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred26_AplusParser()) ) { s = 100; }

                   	else if ( (synpred27_AplusParser()) ) { s = 101; }

                   	 
                   	input.Seek(index14_56);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 56 : 
                   	int LA14_57 = input.LA(1);

                   	 
                   	int index14_57 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred26_AplusParser()) ) { s = 100; }

                   	else if ( (synpred27_AplusParser()) ) { s = 101; }

                   	 
                   	input.Seek(index14_57);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 57 : 
                   	int LA14_58 = input.LA(1);

                   	 
                   	int index14_58 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred26_AplusParser()) ) { s = 100; }

                   	else if ( (synpred27_AplusParser()) ) { s = 101; }

                   	 
                   	input.Seek(index14_58);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 58 : 
                   	int LA14_59 = input.LA(1);

                   	 
                   	int index14_59 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred26_AplusParser()) ) { s = 100; }

                   	else if ( (synpred27_AplusParser()) ) { s = 101; }

                   	 
                   	input.Seek(index14_59);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 59 : 
                   	int LA14_60 = input.LA(1);

                   	 
                   	int index14_60 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred26_AplusParser()) ) { s = 100; }

                   	else if ( (synpred27_AplusParser()) ) { s = 101; }

                   	 
                   	input.Seek(index14_60);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 60 : 
                   	int LA14_61 = input.LA(1);

                   	 
                   	int index14_61 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred26_AplusParser()) ) { s = 100; }

                   	else if ( (synpred27_AplusParser()) ) { s = 101; }

                   	 
                   	input.Seek(index14_61);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 61 : 
                   	int LA14_62 = input.LA(1);

                   	 
                   	int index14_62 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred26_AplusParser()) ) { s = 100; }

                   	else if ( (synpred27_AplusParser()) ) { s = 101; }

                   	 
                   	input.Seek(index14_62);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 62 : 
                   	int LA14_63 = input.LA(1);

                   	 
                   	int index14_63 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred26_AplusParser()) ) { s = 100; }

                   	else if ( (synpred27_AplusParser()) ) { s = 101; }

                   	 
                   	input.Seek(index14_63);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 63 : 
                   	int LA14_64 = input.LA(1);

                   	 
                   	int index14_64 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred26_AplusParser()) ) { s = 100; }

                   	else if ( (synpred27_AplusParser()) ) { s = 101; }

                   	 
                   	input.Seek(index14_64);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 64 : 
                   	int LA14_65 = input.LA(1);

                   	 
                   	int index14_65 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred26_AplusParser()) ) { s = 100; }

                   	else if ( (synpred27_AplusParser()) ) { s = 101; }

                   	 
                   	input.Seek(index14_65);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 65 : 
                   	int LA14_66 = input.LA(1);

                   	 
                   	int index14_66 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred26_AplusParser()) ) { s = 100; }

                   	else if ( (synpred27_AplusParser()) ) { s = 101; }

                   	 
                   	input.Seek(index14_66);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 66 : 
                   	int LA14_67 = input.LA(1);

                   	 
                   	int index14_67 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred26_AplusParser()) ) { s = 100; }

                   	else if ( (synpred27_AplusParser()) ) { s = 101; }

                   	 
                   	input.Seek(index14_67);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 67 : 
                   	int LA14_68 = input.LA(1);

                   	 
                   	int index14_68 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred26_AplusParser()) ) { s = 100; }

                   	else if ( (synpred27_AplusParser()) ) { s = 101; }

                   	 
                   	input.Seek(index14_68);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 68 : 
                   	int LA14_69 = input.LA(1);

                   	 
                   	int index14_69 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred26_AplusParser()) ) { s = 100; }

                   	else if ( (synpred27_AplusParser()) ) { s = 101; }

                   	 
                   	input.Seek(index14_69);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 69 : 
                   	int LA14_70 = input.LA(1);

                   	 
                   	int index14_70 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred26_AplusParser()) ) { s = 100; }

                   	else if ( (synpred27_AplusParser()) ) { s = 101; }

                   	 
                   	input.Seek(index14_70);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 70 : 
                   	int LA14_71 = input.LA(1);

                   	 
                   	int index14_71 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred26_AplusParser()) ) { s = 100; }

                   	else if ( (synpred27_AplusParser()) ) { s = 101; }

                   	 
                   	input.Seek(index14_71);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 71 : 
                   	int LA14_72 = input.LA(1);

                   	 
                   	int index14_72 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred26_AplusParser()) ) { s = 100; }

                   	else if ( (synpred27_AplusParser()) ) { s = 101; }

                   	 
                   	input.Seek(index14_72);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 72 : 
                   	int LA14_73 = input.LA(1);

                   	 
                   	int index14_73 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred26_AplusParser()) ) { s = 100; }

                   	else if ( (synpred27_AplusParser()) ) { s = 101; }

                   	 
                   	input.Seek(index14_73);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 73 : 
                   	int LA14_74 = input.LA(1);

                   	 
                   	int index14_74 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred26_AplusParser()) ) { s = 100; }

                   	else if ( (synpred27_AplusParser()) ) { s = 101; }

                   	 
                   	input.Seek(index14_74);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 74 : 
                   	int LA14_75 = input.LA(1);

                   	 
                   	int index14_75 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred26_AplusParser()) ) { s = 100; }

                   	else if ( (synpred27_AplusParser()) ) { s = 101; }

                   	 
                   	input.Seek(index14_75);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 75 : 
                   	int LA14_76 = input.LA(1);

                   	 
                   	int index14_76 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred26_AplusParser()) ) { s = 100; }

                   	else if ( (synpred27_AplusParser()) ) { s = 101; }

                   	 
                   	input.Seek(index14_76);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 76 : 
                   	int LA14_77 = input.LA(1);

                   	 
                   	int index14_77 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred26_AplusParser()) ) { s = 100; }

                   	else if ( (synpred27_AplusParser()) ) { s = 101; }

                   	 
                   	input.Seek(index14_77);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 77 : 
                   	int LA14_78 = input.LA(1);

                   	 
                   	int index14_78 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred26_AplusParser()) ) { s = 100; }

                   	else if ( (synpred27_AplusParser()) ) { s = 101; }

                   	 
                   	input.Seek(index14_78);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 78 : 
                   	int LA14_79 = input.LA(1);

                   	 
                   	int index14_79 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred26_AplusParser()) ) { s = 100; }

                   	else if ( (synpred27_AplusParser()) ) { s = 101; }

                   	 
                   	input.Seek(index14_79);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 79 : 
                   	int LA14_80 = input.LA(1);

                   	 
                   	int index14_80 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred26_AplusParser()) ) { s = 100; }

                   	else if ( (synpred27_AplusParser()) ) { s = 101; }

                   	 
                   	input.Seek(index14_80);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 80 : 
                   	int LA14_81 = input.LA(1);

                   	 
                   	int index14_81 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred26_AplusParser()) ) { s = 100; }

                   	else if ( (synpred27_AplusParser()) ) { s = 101; }

                   	 
                   	input.Seek(index14_81);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 81 : 
                   	int LA14_82 = input.LA(1);

                   	 
                   	int index14_82 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred26_AplusParser()) ) { s = 100; }

                   	else if ( (synpred27_AplusParser()) ) { s = 101; }

                   	 
                   	input.Seek(index14_82);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 82 : 
                   	int LA14_83 = input.LA(1);

                   	 
                   	int index14_83 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred26_AplusParser()) ) { s = 100; }

                   	else if ( (synpred27_AplusParser()) ) { s = 101; }

                   	 
                   	input.Seek(index14_83);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 83 : 
                   	int LA14_84 = input.LA(1);

                   	 
                   	int index14_84 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred26_AplusParser()) ) { s = 100; }

                   	else if ( (synpred27_AplusParser()) ) { s = 101; }

                   	 
                   	input.Seek(index14_84);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 84 : 
                   	int LA14_85 = input.LA(1);

                   	 
                   	int index14_85 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred26_AplusParser()) ) { s = 100; }

                   	else if ( (synpred27_AplusParser()) ) { s = 101; }

                   	 
                   	input.Seek(index14_85);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 85 : 
                   	int LA14_86 = input.LA(1);

                   	 
                   	int index14_86 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred26_AplusParser()) ) { s = 100; }

                   	else if ( (synpred27_AplusParser()) ) { s = 101; }

                   	 
                   	input.Seek(index14_86);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 86 : 
                   	int LA14_87 = input.LA(1);

                   	 
                   	int index14_87 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred26_AplusParser()) ) { s = 100; }

                   	else if ( (synpred27_AplusParser()) ) { s = 101; }

                   	 
                   	input.Seek(index14_87);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 87 : 
                   	int LA14_88 = input.LA(1);

                   	 
                   	int index14_88 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred26_AplusParser()) ) { s = 100; }

                   	else if ( (synpred27_AplusParser()) ) { s = 101; }

                   	 
                   	input.Seek(index14_88);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 88 : 
                   	int LA14_89 = input.LA(1);

                   	 
                   	int index14_89 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred26_AplusParser()) ) { s = 100; }

                   	else if ( (true) ) { s = 99; }

                   	 
                   	input.Seek(index14_89);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 89 : 
                   	int LA14_90 = input.LA(1);

                   	 
                   	int index14_90 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred26_AplusParser()) ) { s = 100; }

                   	else if ( (true) ) { s = 99; }

                   	 
                   	input.Seek(index14_90);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 90 : 
                   	int LA14_91 = input.LA(1);

                   	 
                   	int index14_91 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred26_AplusParser()) ) { s = 100; }

                   	else if ( (true) ) { s = 99; }

                   	 
                   	input.Seek(index14_91);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 91 : 
                   	int LA14_92 = input.LA(1);

                   	 
                   	int index14_92 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred26_AplusParser()) ) { s = 100; }

                   	else if ( (true) ) { s = 99; }

                   	 
                   	input.Seek(index14_92);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 92 : 
                   	int LA14_93 = input.LA(1);

                   	 
                   	int index14_93 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred26_AplusParser()) ) { s = 100; }

                   	else if ( (true) ) { s = 99; }

                   	 
                   	input.Seek(index14_93);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 93 : 
                   	int LA14_94 = input.LA(1);

                   	 
                   	int index14_94 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred26_AplusParser()) ) { s = 100; }

                   	else if ( (true) ) { s = 99; }

                   	 
                   	input.Seek(index14_94);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 94 : 
                   	int LA14_95 = input.LA(1);

                   	 
                   	int index14_95 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred26_AplusParser()) ) { s = 100; }

                   	else if ( (true) ) { s = 99; }

                   	 
                   	input.Seek(index14_95);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 95 : 
                   	int LA14_96 = input.LA(1);

                   	 
                   	int index14_96 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred26_AplusParser()) ) { s = 100; }

                   	else if ( (true) ) { s = 99; }

                   	 
                   	input.Seek(index14_96);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 96 : 
                   	int LA14_97 = input.LA(1);

                   	 
                   	int index14_97 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred26_AplusParser()) ) { s = 100; }

                   	else if ( (true) ) { s = 99; }

                   	 
                   	input.Seek(index14_97);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 97 : 
                   	int LA14_98 = input.LA(1);

                   	 
                   	int index14_98 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred26_AplusParser()) ) { s = 100; }

                   	else if ( (true) ) { s = 99; }

                   	 
                   	input.Seek(index14_98);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        if (state.backtracking > 0) {state.failed = true; return -1;}
        NoViableAltException nvae14 =
            new NoViableAltException(dfa.Description, 14, _s, input);
        dfa.Error(nvae14);
        throw nvae14;
    }
    const string DFA16_eotS =
        "\x64\uffff";
    const string DFA16_eofS =
        "\x64\uffff";
    const string DFA16_minS =
        "\x01\x08\x01\x00\x62\uffff";
    const string DFA16_maxS =
        "\x01\u0081\x01\x00\x62\uffff";
    const string DFA16_acceptS =
        "\x02\uffff\x01\x01\x60\uffff\x01\x02";
    const string DFA16_specialS =
        "\x01\uffff\x01\x00\x62\uffff}>";
    static readonly string[] DFA16_transitionS = {
            "\x01\x02\x02\uffff\x56\x02\x01\uffff\x01\x01\x09\uffff\x01"+
            "\x02\x06\uffff\x01\x02\x01\uffff\x02\x02\x03\uffff\x02\x02\x02"+
            "\uffff\x04\x02",
            "\x01\uffff",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            ""
    };

    static readonly short[] DFA16_eot = DFA.UnpackEncodedString(DFA16_eotS);
    static readonly short[] DFA16_eof = DFA.UnpackEncodedString(DFA16_eofS);
    static readonly char[] DFA16_min = DFA.UnpackEncodedStringToUnsignedChars(DFA16_minS);
    static readonly char[] DFA16_max = DFA.UnpackEncodedStringToUnsignedChars(DFA16_maxS);
    static readonly short[] DFA16_accept = DFA.UnpackEncodedString(DFA16_acceptS);
    static readonly short[] DFA16_special = DFA.UnpackEncodedString(DFA16_specialS);
    static readonly short[][] DFA16_transition = DFA.UnpackEncodedStringArray(DFA16_transitionS);

    protected class DFA16 : DFA
    {
        public DFA16(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 16;
            this.eot = DFA16_eot;
            this.eof = DFA16_eof;
            this.min = DFA16_min;
            this.max = DFA16_max;
            this.accept = DFA16_accept;
            this.special = DFA16_special;
            this.transition = DFA16_transition;

        }

        override public string Description
        {
            get { return "212:1: operatorSymbol returns [AST.Operator node] : ( opArg ( opTail )+ | LP op= operatorSymbol RP );"; }
        }

    }


    protected internal int DFA16_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            ITokenStream input = (ITokenStream)_input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA16_1 = input.LA(1);

                   	 
                   	int index16_1 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred29_AplusParser()) ) { s = 2; }

                   	else if ( (true) ) { s = 99; }

                   	 
                   	input.Seek(index16_1);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        if (state.backtracking > 0) {state.failed = true; return -1;}
        NoViableAltException nvae16 =
            new NoViableAltException(dfa.Description, 16, _s, input);
        dfa.Error(nvae16);
        throw nvae16;
    }
    const string DFA17_eotS =
        "\x63\uffff";
    const string DFA17_eofS =
        "\x63\uffff";
    const string DFA17_minS =
        "\x01\x08\x01\x00\x61\uffff";
    const string DFA17_maxS =
        "\x01\u0081\x01\x00\x61\uffff";
    const string DFA17_acceptS =
        "\x02\uffff\x01\x01\x56\uffff\x01\x02\x09\uffff";
    const string DFA17_specialS =
        "\x01\uffff\x01\x00\x61\uffff}>";
    static readonly string[] DFA17_transitionS = {
            "\x01\x02\x02\uffff\x56\x02\x01\uffff\x01\x01\x09\uffff\x01"+
            "\x59\x06\uffff\x01\x59\x01\uffff\x02\x59\x03\uffff\x02\x59\x02"+
            "\uffff\x04\x59",
            "\x01\uffff",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            ""
    };

    static readonly short[] DFA17_eot = DFA.UnpackEncodedString(DFA17_eotS);
    static readonly short[] DFA17_eof = DFA.UnpackEncodedString(DFA17_eofS);
    static readonly char[] DFA17_min = DFA.UnpackEncodedStringToUnsignedChars(DFA17_minS);
    static readonly char[] DFA17_max = DFA.UnpackEncodedStringToUnsignedChars(DFA17_maxS);
    static readonly short[] DFA17_accept = DFA.UnpackEncodedString(DFA17_acceptS);
    static readonly short[] DFA17_special = DFA.UnpackEncodedString(DFA17_specialS);
    static readonly short[][] DFA17_transition = DFA.UnpackEncodedStringArray(DFA17_transitionS);

    protected class DFA17 : DFA
    {
        public DFA17(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 17;
            this.eot = DFA17_eot;
            this.eof = DFA17_eof;
            this.min = DFA17_min;
            this.max = DFA17_max;
            this.accept = DFA17_accept;
            this.special = DFA17_special;
            this.transition = DFA17_transition;

        }

        override public string Description
        {
            get { return "234:1: opArg returns [AST.Node node] : ( functionSymbol | termExpression );"; }
        }

    }


    protected internal int DFA17_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            ITokenStream input = (ITokenStream)_input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA17_1 = input.LA(1);

                   	 
                   	int index17_1 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred30_AplusParser()) ) { s = 2; }

                   	else if ( (true) ) { s = 89; }

                   	 
                   	input.Seek(index17_1);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        if (state.backtracking > 0) {state.failed = true; return -1;}
        NoViableAltException nvae17 =
            new NoViableAltException(dfa.Description, 17, _s, input);
        dfa.Error(nvae17);
        throw nvae17;
    }
    const string DFA18_eotS =
        "\x63\uffff";
    const string DFA18_eofS =
        "\x63\uffff";
    const string DFA18_minS =
        "\x01\x08\x01\x00\x61\uffff";
    const string DFA18_maxS =
        "\x01\u0081\x01\x00\x61\uffff";
    const string DFA18_acceptS =
        "\x02\uffff\x01\x01\x09\uffff\x01\x02\x56\uffff";
    const string DFA18_specialS =
        "\x01\uffff\x01\x00\x61\uffff}>";
    static readonly string[] DFA18_transitionS = {
            "\x01\x0c\x02\uffff\x56\x0c\x01\uffff\x01\x01\x09\uffff\x01"+
            "\x02\x06\uffff\x01\x02\x01\uffff\x02\x02\x03\uffff\x02\x02\x02"+
            "\uffff\x04\x02",
            "\x01\uffff",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            ""
    };

    static readonly short[] DFA18_eot = DFA.UnpackEncodedString(DFA18_eotS);
    static readonly short[] DFA18_eof = DFA.UnpackEncodedString(DFA18_eofS);
    static readonly char[] DFA18_min = DFA.UnpackEncodedStringToUnsignedChars(DFA18_minS);
    static readonly char[] DFA18_max = DFA.UnpackEncodedStringToUnsignedChars(DFA18_maxS);
    static readonly short[] DFA18_accept = DFA.UnpackEncodedString(DFA18_acceptS);
    static readonly short[] DFA18_special = DFA.UnpackEncodedString(DFA18_specialS);
    static readonly short[][] DFA18_transition = DFA.UnpackEncodedStringArray(DFA18_transitionS);

    protected class DFA18 : DFA
    {
        public DFA18(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 18;
            this.eot = DFA18_eot;
            this.eof = DFA18_eof;
            this.min = DFA18_min;
            this.max = DFA18_max;
            this.accept = DFA18_accept;
            this.special = DFA18_special;
            this.transition = DFA18_transition;

        }

        override public string Description
        {
            get { return "243:52: ( condition | functionSymbol )"; }
        }

    }


    protected internal int DFA18_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            ITokenStream input = (ITokenStream)_input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA18_1 = input.LA(1);

                   	 
                   	int index18_1 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred33_AplusParser()) ) { s = 2; }

                   	else if ( (true) ) { s = 12; }

                   	 
                   	input.Seek(index18_1);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        if (state.backtracking > 0) {state.failed = true; return -1;}
        NoViableAltException nvae18 =
            new NoViableAltException(dfa.Description, 18, _s, input);
        dfa.Error(nvae18);
        throw nvae18;
    }
    const string DFA23_eotS =
        "\x6b\uffff";
    const string DFA23_eofS =
        "\x01\x02\x6a\uffff";
    const string DFA23_minS =
        "\x01\x07\x01\x00\x69\uffff";
    const string DFA23_maxS =
        "\x01\u0081\x01\x00\x69\uffff";
    const string DFA23_acceptS =
        "\x02\uffff\x01\x02\x67\uffff\x01\x01";
    const string DFA23_specialS =
        "\x01\uffff\x01\x00\x69\uffff}>";
    static readonly string[] DFA23_transitionS = {
            "\x02\x02\x02\uffff\x56\x02\x01\uffff\x02\x02\x01\uffff\x02"+
            "\x02\x05\uffff\x01\x01\x01\x02\x02\uffff\x01\x02\x02\uffff\x01"+
            "\x02\x01\uffff\x02\x02\x03\uffff\x02\x02\x02\uffff\x04\x02",
            "\x01\uffff",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            ""
    };

    static readonly short[] DFA23_eot = DFA.UnpackEncodedString(DFA23_eotS);
    static readonly short[] DFA23_eof = DFA.UnpackEncodedString(DFA23_eofS);
    static readonly char[] DFA23_min = DFA.UnpackEncodedStringToUnsignedChars(DFA23_minS);
    static readonly char[] DFA23_max = DFA.UnpackEncodedStringToUnsignedChars(DFA23_maxS);
    static readonly short[] DFA23_accept = DFA.UnpackEncodedString(DFA23_acceptS);
    static readonly short[] DFA23_special = DFA.UnpackEncodedString(DFA23_specialS);
    static readonly short[][] DFA23_transition = DFA.UnpackEncodedStringArray(DFA23_transitionS);

    protected class DFA23 : DFA
    {
        public DFA23(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 23;
            this.eot = DFA23_eot;
            this.eof = DFA23_eof;
            this.min = DFA23_min;
            this.max = DFA23_max;
            this.accept = DFA23_accept;
            this.special = DFA23_special;
            this.transition = DFA23_transition;

        }

        override public string Description
        {
            get { return "389:3: ( expressionGroup )?"; }
        }

    }


    protected internal int DFA23_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            ITokenStream input = (ITokenStream)_input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA23_1 = input.LA(1);

                   	 
                   	int index23_1 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred126_AplusParser()) ) { s = 106; }

                   	else if ( (true) ) { s = 2; }

                   	 
                   	input.Seek(index23_1);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        if (state.backtracking > 0) {state.failed = true; return -1;}
        NoViableAltException nvae23 =
            new NoViableAltException(dfa.Description, 23, _s, input);
        dfa.Error(nvae23);
        throw nvae23;
    }
    const string DFA35_eotS =
        "\x63\uffff";
    const string DFA35_eofS =
        "\x63\uffff";
    const string DFA35_minS =
        "\x01\x08\x01\x00\x61\uffff";
    const string DFA35_maxS =
        "\x01\u0081\x01\x00\x61\uffff";
    const string DFA35_acceptS =
        "\x02\uffff\x01\x01\x09\uffff\x01\x02\x56\uffff";
    const string DFA35_specialS =
        "\x01\uffff\x01\x00\x61\uffff}>";
    static readonly string[] DFA35_transitionS = {
            "\x01\x0c\x02\uffff\x56\x0c\x01\uffff\x01\x01\x09\uffff\x01"+
            "\x02\x06\uffff\x01\x02\x01\uffff\x02\x02\x03\uffff\x02\x02\x02"+
            "\uffff\x04\x02",
            "\x01\uffff",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            ""
    };

    static readonly short[] DFA35_eot = DFA.UnpackEncodedString(DFA35_eotS);
    static readonly short[] DFA35_eof = DFA.UnpackEncodedString(DFA35_eofS);
    static readonly char[] DFA35_min = DFA.UnpackEncodedStringToUnsignedChars(DFA35_minS);
    static readonly char[] DFA35_max = DFA.UnpackEncodedStringToUnsignedChars(DFA35_maxS);
    static readonly short[] DFA35_accept = DFA.UnpackEncodedString(DFA35_acceptS);
    static readonly short[] DFA35_special = DFA.UnpackEncodedString(DFA35_specialS);
    static readonly short[][] DFA35_transition = DFA.UnpackEncodedStringArray(DFA35_transitionS);

    protected class DFA35 : DFA
    {
        public DFA35(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 35;
            this.eot = DFA35_eot;
            this.eof = DFA35_eof;
            this.min = DFA35_min;
            this.max = DFA35_max;
            this.accept = DFA35_accept;
            this.special = DFA35_special;
            this.transition = DFA35_transition;

        }

        override public string Description
        {
            get { return "243:52: ( condition | functionSymbol )"; }
        }

    }


    protected internal int DFA35_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            ITokenStream input = (ITokenStream)_input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA35_1 = input.LA(1);

                   	 
                   	int index35_1 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred33_AplusParser()) ) { s = 2; }

                   	else if ( (true) ) { s = 12; }

                   	 
                   	input.Seek(index35_1);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        if (state.backtracking > 0) {state.failed = true; return -1;}
        NoViableAltException nvae35 =
            new NoViableAltException(dfa.Description, 35, _s, input);
        dfa.Error(nvae35);
        throw nvae35;
    }
 

    public static readonly BitSet FOLLOW_statements_in_script66 = new BitSet(new ulong[]{0x0000000000000000UL});
    public static readonly BitSet FOLLOW_EOF_in_script68 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_statement_in_statements100 = new BitSet(new ulong[]{0x0000000000000000UL,0x0001000000000000UL});
    public static readonly BitSet FOLLOW_NewLine_in_statements112 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFF50UL,0xCC681047FFFFFFFFUL,0x0000000000000003UL});
    public static readonly BitSet FOLLOW_statement_in_statements124 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_systemCommand_in_statement148 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_dependencyDefinition_in_statement160 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_userDefinedOperator_in_statement170 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_userDefinedFunction_in_statement181 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_expressionList_in_statement192 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_SystemCommand_in_systemCommand215 = new BitSet(new ulong[]{0x0000000000000022UL});
    public static readonly BitSet FOLLOW_SystemCommandArgument_in_systemCommand229 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variableName_in_dependencyDefinition264 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000009000000000UL});
    public static readonly BitSet FOLLOW_LSBracket_in_dependencyDefinition271 = new BitSet(new ulong[]{0x0000000000000000UL,0x8000000000000000UL,0x0000000000000003UL});
    public static readonly BitSet FOLLOW_variableName_in_dependencyDefinition275 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000002000000000UL});
    public static readonly BitSet FOLLOW_RSBracket_in_dependencyDefinition277 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000008000000000UL});
    public static readonly BitSet FOLLOW_Colon_in_dependencyDefinition283 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFF40UL,0xCC691007FFFFFFFFUL,0x0000000000000003UL});
    public static readonly BitSet FOLLOW_functionBody_in_dependencyDefinition285 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LP_in_userDefinedOperator316 = new BitSet(new ulong[]{0x0000000000000000UL,0x8000000000000000UL,0x0000000000000003UL});
    public static readonly BitSet FOLLOW_variableName_in_userDefinedOperator320 = new BitSet(new ulong[]{0x0000000000000000UL,0x8000000000000000UL,0x0000000000000003UL});
    public static readonly BitSet FOLLOW_variableName_in_userDefinedOperator324 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000800000000UL});
    public static readonly BitSet FOLLOW_RP_in_userDefinedOperator326 = new BitSet(new ulong[]{0x0000000000000000UL,0x8000000000000000UL,0x0000000000000003UL});
    public static readonly BitSet FOLLOW_variableName_in_userDefinedOperator330 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000008000000000UL});
    public static readonly BitSet FOLLOW_Colon_in_userDefinedOperator335 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFF40UL,0xCC691007FFFFFFFFUL,0x0000000000000003UL});
    public static readonly BitSet FOLLOW_functionBody_in_userDefinedOperator337 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LP_in_userDefinedOperator346 = new BitSet(new ulong[]{0x0000000000000000UL,0x8000000000000000UL,0x0000000000000003UL});
    public static readonly BitSet FOLLOW_variableName_in_userDefinedOperator350 = new BitSet(new ulong[]{0x0000000000000000UL,0x8000000000000000UL,0x0000000000000003UL});
    public static readonly BitSet FOLLOW_variableName_in_userDefinedOperator354 = new BitSet(new ulong[]{0x0000000000000000UL,0x8000000000000000UL,0x0000000000000003UL});
    public static readonly BitSet FOLLOW_variableName_in_userDefinedOperator358 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000800000000UL});
    public static readonly BitSet FOLLOW_RP_in_userDefinedOperator360 = new BitSet(new ulong[]{0x0000000000000000UL,0x8000000000000000UL,0x0000000000000003UL});
    public static readonly BitSet FOLLOW_variableName_in_userDefinedOperator364 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000008000000000UL});
    public static readonly BitSet FOLLOW_Colon_in_userDefinedOperator368 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFF40UL,0xCC691007FFFFFFFFUL,0x0000000000000003UL});
    public static readonly BitSet FOLLOW_functionBody_in_userDefinedOperator370 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variableName_in_userDefinedOperator381 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000400000000UL});
    public static readonly BitSet FOLLOW_LP_in_userDefinedOperator383 = new BitSet(new ulong[]{0x0000000000000000UL,0x8000000000000000UL,0x0000000000000003UL});
    public static readonly BitSet FOLLOW_variableName_in_userDefinedOperator387 = new BitSet(new ulong[]{0x0000000000000000UL,0x8000000000000000UL,0x0000000000000003UL});
    public static readonly BitSet FOLLOW_variableName_in_userDefinedOperator391 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000800000000UL});
    public static readonly BitSet FOLLOW_RP_in_userDefinedOperator393 = new BitSet(new ulong[]{0x0000000000000000UL,0x8000000000000000UL,0x0000000000000003UL});
    public static readonly BitSet FOLLOW_variableName_in_userDefinedOperator397 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000008000000000UL});
    public static readonly BitSet FOLLOW_Colon_in_userDefinedOperator401 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFF40UL,0xCC691007FFFFFFFFUL,0x0000000000000003UL});
    public static readonly BitSet FOLLOW_functionBody_in_userDefinedOperator403 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variableName_in_userDefinedOperator414 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000400000000UL});
    public static readonly BitSet FOLLOW_LP_in_userDefinedOperator416 = new BitSet(new ulong[]{0x0000000000000000UL,0x8000000000000000UL,0x0000000000000003UL});
    public static readonly BitSet FOLLOW_variableName_in_userDefinedOperator420 = new BitSet(new ulong[]{0x0000000000000000UL,0x8000000000000000UL,0x0000000000000003UL});
    public static readonly BitSet FOLLOW_variableName_in_userDefinedOperator424 = new BitSet(new ulong[]{0x0000000000000000UL,0x8000000000000000UL,0x0000000000000003UL});
    public static readonly BitSet FOLLOW_variableName_in_userDefinedOperator428 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000800000000UL});
    public static readonly BitSet FOLLOW_RP_in_userDefinedOperator430 = new BitSet(new ulong[]{0x0000000000000000UL,0x8000000000000000UL,0x0000000000000003UL});
    public static readonly BitSet FOLLOW_variableName_in_userDefinedOperator434 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000008000000000UL});
    public static readonly BitSet FOLLOW_Colon_in_userDefinedOperator438 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFF40UL,0xCC691007FFFFFFFFUL,0x0000000000000003UL});
    public static readonly BitSet FOLLOW_functionBody_in_userDefinedOperator440 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variableName_in_userDefinedFunction472 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000100000000000UL});
    public static readonly BitSet FOLLOW_expressionGroup_in_userDefinedFunction487 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000008000000000UL});
    public static readonly BitSet FOLLOW_Colon_in_userDefinedFunction489 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFF40UL,0xCC691007FFFFFFFFUL,0x0000000000000003UL});
    public static readonly BitSet FOLLOW_functionBody_in_userDefinedFunction491 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variableName_in_userDefinedFunction503 = new BitSet(new ulong[]{0x0000000000000000UL,0x8000000000000000UL,0x0000000000000003UL});
    public static readonly BitSet FOLLOW_variableName_in_userDefinedFunction509 = new BitSet(new ulong[]{0x0000000000000000UL,0x8000000000000000UL,0x0000000000000003UL});
    public static readonly BitSet FOLLOW_variableName_in_userDefinedFunction526 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000008000000000UL});
    public static readonly BitSet FOLLOW_Colon_in_userDefinedFunction528 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFF40UL,0xCC691007FFFFFFFFUL,0x0000000000000003UL});
    public static readonly BitSet FOLLOW_functionBody_in_userDefinedFunction530 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variableName_in_userDefinedFunction542 = new BitSet(new ulong[]{0x0000000000000000UL,0x8000000000000000UL,0x0000000000000003UL});
    public static readonly BitSet FOLLOW_variableName_in_userDefinedFunction558 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000008000000000UL});
    public static readonly BitSet FOLLOW_Colon_in_userDefinedFunction560 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFF40UL,0xCC691007FFFFFFFFUL,0x0000000000000003UL});
    public static readonly BitSet FOLLOW_functionBody_in_userDefinedFunction562 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_expression_in_functionBody582 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_NewLine_in_functionBody593 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFF40UL,0xCC681007FFFFFFFFUL,0x0000000000000003UL});
    public static readonly BitSet FOLLOW_expression_in_functionBody595 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_topExpressionNull_in_expressionList625 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000004000000000UL});
    public static readonly BitSet FOLLOW_SemiColon_in_expressionList633 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFF40UL,0xCC681047FFFFFFFFUL,0x0000000000000003UL});
    public static readonly BitSet FOLLOW_topExpressionNull_in_expressionList640 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000004000000000UL});
    public static readonly BitSet FOLLOW_expression_in_topExpressionNull667 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_operatorSymbol_in_topExpressionNull680 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_functionSymbol_in_topExpressionNull692 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LSB_in_expressionGroup727 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000200000000000UL});
    public static readonly BitSet FOLLOW_RSB_in_expressionGroup729 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LSB_in_expressionGroup743 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFF50UL,0xCC681047FFFFFFFFUL,0x0000000000000003UL});
    public static readonly BitSet FOLLOW_expressionList_in_expressionGroup745 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000200000000000UL});
    public static readonly BitSet FOLLOW_RSB_in_expressionGroup747 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_controlStatements_in_expression767 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_dyadicLeftArg_in_expression783 = new BitSet(new ulong[]{0xFFFFFFFFFFFFF900UL,0xCC681005FFFFFFFFUL,0x0000000000000003UL});
    public static readonly BitSet FOLLOW_dyadicFunctionSelector_in_expression787 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFF40UL,0xCC681007FFFFFFFFUL,0x0000000000000003UL});
    public static readonly BitSet FOLLOW_expression_in_expression791 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_monadicFunctionSelector_in_expression803 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFF40UL,0xCC681007FFFFFFFFUL,0x0000000000000003UL});
    public static readonly BitSet FOLLOW_expression_in_expression807 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_simpleExpression_in_expression817 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_operatorSymbol_in_monadicFunctionSelector837 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_functionSymbol_in_monadicFunctionSelector850 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variableName_in_monadicFunctionSelector865 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_operatorSymbol_in_dyadicFunctionSelector888 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_functionSymbol_in_dyadicFunctionSelector901 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variableName_in_dyadicFunctionSelector916 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_operatorSymbol_in_dyadicLeftArg938 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000100000000000UL});
    public static readonly BitSet FOLLOW_expressionGroup_in_dyadicLeftArg940 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_functionSymbol_in_dyadicLeftArg949 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000100000000000UL});
    public static readonly BitSet FOLLOW_expressionGroup_in_dyadicLeftArg951 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_simpleExpression_in_dyadicLeftArg960 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_opArg_in_operatorSymbol990 = new BitSet(new ulong[]{0x0000000000000000UL,0x8000030000000000UL,0x0000000000000003UL});
    public static readonly BitSet FOLLOW_opTail_in_operatorSymbol1005 = new BitSet(new ulong[]{0x0000000000000002UL,0x8000030000000000UL,0x0000000000000003UL});
    public static readonly BitSet FOLLOW_LP_in_operatorSymbol1020 = new BitSet(new ulong[]{0xFFFFFFFFFFFFF900UL,0xCC681005FFFFFFFFUL,0x0000000000000003UL});
    public static readonly BitSet FOLLOW_operatorSymbol_in_operatorSymbol1024 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000800000000UL});
    public static readonly BitSet FOLLOW_RP_in_operatorSymbol1026 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_functionSymbol_in_opArg1046 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_termExpression_in_opArg1058 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Each_in_opTail1080 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Rank_in_opTail1094 = new BitSet(new ulong[]{0xFFFFFFFFFFFFF900UL,0xCC681005FFFFFFFFUL,0x0000000000000003UL});
    public static readonly BitSet FOLLOW_condition_in_opTail1096 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variableName_in_opTail1110 = new BitSet(new ulong[]{0xFFFFFFFFFFFFF900UL,0xCC681005FFFFFFFFUL,0x0000000000000003UL});
    public static readonly BitSet FOLLOW_condition_in_opTail1113 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_functionSymbol_in_opTail1117 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variableName_in_opTail1131 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LP_in_functionSymbol1148 = new BitSet(new ulong[]{0xFFFFFFFFFFFFF900UL,0x00000005FFFFFFFFUL});
    public static readonly BitSet FOLLOW_functionSymbol_in_functionSymbol1152 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000800000000UL});
    public static readonly BitSet FOLLOW_RP_in_functionSymbol1154 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_AbsoluteValue_in_functionSymbol1167 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Ceiling_in_functionSymbol1181 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Count_in_functionSymbol1196 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_DefaultFormat_in_functionSymbol1212 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Depth_in_functionSymbol1226 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Disclose_in_functionSymbol1242 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Enclose_in_functionSymbol1257 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Execute_in_functionSymbol1272 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Exponential_in_functionSymbol1287 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Floor_in_functionSymbol1301 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_GradeDown_in_functionSymbol1317 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_GradeUp_in_functionSymbol1332 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Identity_in_functionSymbol1347 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Interval_in_functionSymbol1362 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ItemRavel_in_functionSymbol1377 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_MapIn_in_functionSymbol1392 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_MatrixInverse_in_functionSymbol1408 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_NaturalLog_in_functionSymbol1422 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Negate_in_functionSymbol1436 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Not_in_functionSymbol1451 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Null_in_functionSymbol1467 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Pack_in_functionSymbol1483 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_PartitionCount_in_functionSymbol1499 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_PiTimes_in_functionSymbol1512 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Print_in_functionSymbol1527 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Rake_in_functionSymbol1543 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Raze_in_functionSymbol1559 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Ravel_in_functionSymbol1598 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Reciprocal_in_functionSymbol1614 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Result_in_functionSymbol1628 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Reverse_in_functionSymbol1643 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Roll_in_functionSymbol1658 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Right_in_functionSymbol1674 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_SeparateSymbols_in_functionSymbol1690 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Shape_in_functionSymbol1703 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Sign_in_functionSymbol1719 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Signal_in_functionSymbol1735 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Stop_in_functionSymbol1750 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Transpose_in_functionSymbol1766 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Unpack_in_functionSymbol1781 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Value_in_functionSymbol1796 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Or_in_functionSymbol1813 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_IPAddMultiply_in_functionSymbol1834 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_IPMaxAdd_in_functionSymbol1848 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_IPMinAdd_in_functionSymbol1863 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_OPAdd_in_functionSymbol1880 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_OPDivide_in_functionSymbol1896 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_OPEqual_in_functionSymbol1911 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_OPGT_in_functionSymbol1926 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_OPGTE_in_functionSymbol1942 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_OPLT_in_functionSymbol1958 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_OPLTE_in_functionSymbol1974 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_OPMax_in_functionSymbol1990 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_OPMin_in_functionSymbol2006 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_OPMultiply_in_functionSymbol2022 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_OPNotEqual_in_functionSymbol2036 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_OPResidue_in_functionSymbol2050 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_OPSubstract_in_functionSymbol2065 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_OPPower_in_functionSymbol2079 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_RAdd_in_functionSymbol2097 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_RAnd_in_functionSymbol2113 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_RMax_in_functionSymbol2129 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_RMin_in_functionSymbol2145 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_RMultiply_in_functionSymbol2161 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ROr_in_functionSymbol2176 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_SAdd_in_functionSymbol2194 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_SAnd_in_functionSymbol2210 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_SMax_in_functionSymbol2226 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_SMin_in_functionSymbol2242 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_SMultiply_in_functionSymbol2258 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_SOr_in_functionSymbol2273 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Equal_in_functionSymbol2292 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Expand_in_functionSymbol2308 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_GTE_in_functionSymbol2323 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LTE_in_functionSymbol2339 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_NotEqual_in_functionSymbol2355 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Replicate_in_functionSymbol2370 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_BWNot_in_functionSymbol2388 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_BWAnd_in_functionSymbol2405 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_BWOr_in_functionSymbol2422 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_BWLT_in_functionSymbol2439 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_BWLTE_in_functionSymbol2456 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_BWGT_in_functionSymbol2473 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_BWGTE_in_functionSymbol2490 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_BWEqual_in_functionSymbol2507 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_BWNotEqual_in_functionSymbol2523 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Do_in_functionSymbol2540 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ifStatement_in_controlStatements2569 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_caseStatement_in_controlStatements2582 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_whileStatement_in_controlStatements2594 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_termExpression_in_condition2616 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_If_in_ifStatement2637 = new BitSet(new ulong[]{0xFFFFFFFFFFFFF900UL,0xCC681005FFFFFFFFUL,0x0000000000000003UL});
    public static readonly BitSet FOLLOW_condition_in_ifStatement2639 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFC0UL,0xCC681007FFFFFFFFUL,0x0000000000000003UL});
    public static readonly BitSet FOLLOW_topExpressionNull_in_ifStatement2643 = new BitSet(new ulong[]{0x0000000000000082UL});
    public static readonly BitSet FOLLOW_Else_in_ifStatement2651 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFF40UL,0xCC681007FFFFFFFFUL,0x0000000000000003UL});
    public static readonly BitSet FOLLOW_topExpressionNull_in_ifStatement2658 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Case_in_caseStatement2684 = new BitSet(new ulong[]{0xFFFFFFFFFFFFF900UL,0xCC681005FFFFFFFFUL,0x0000000000000003UL});
    public static readonly BitSet FOLLOW_condition_in_caseStatement2686 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000100000000000UL});
    public static readonly BitSet FOLLOW_expressionGroup_in_caseStatement2688 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_While_in_whileStatement2708 = new BitSet(new ulong[]{0xFFFFFFFFFFFFF900UL,0xCC681005FFFFFFFFUL,0x0000000000000003UL});
    public static readonly BitSet FOLLOW_condition_in_whileStatement2710 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFF40UL,0xCC681007FFFFFFFFUL,0x0000000000000003UL});
    public static readonly BitSet FOLLOW_topExpressionNull_in_whileStatement2712 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_StackReference_in_simpleExpression2732 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000100000000000UL});
    public static readonly BitSet FOLLOW_expressionGroup_in_simpleExpression2734 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_termExpression_in_simpleExpression2745 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000100000000000UL});
    public static readonly BitSet FOLLOW_expressionGroup_in_simpleExpression2759 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_term_in_termExpression2784 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000001000000000UL});
    public static readonly BitSet FOLLOW_LSBracket_in_termExpression2791 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFF50UL,0xCC681067FFFFFFFFUL,0x0000000000000003UL});
    public static readonly BitSet FOLLOW_expressionList_in_termExpression2800 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000002000000000UL});
    public static readonly BitSet FOLLOW_RSBracket_in_termExpression2803 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000001000000000UL});
    public static readonly BitSet FOLLOW_LP_in_term2829 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFF50UL,0xCC681047FFFFFFFFUL,0x0000000000000003UL});
    public static readonly BitSet FOLLOW_expressionList_in_term2831 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000800000000UL});
    public static readonly BitSet FOLLOW_RP_in_term2833 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_expressionGroup_in_term2846 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_constant_in_term2858 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variableName_in_term2871 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_numericConstantList_in_constant2893 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_symbolConsantList_in_constant2909 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_characterConstant_in_constant2920 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Int_in_numericConstant2942 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Float_in_numericConstant2957 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Inf_in_numericConstant2971 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_numericConstant_in_numericConstantList3004 = new BitSet(new ulong[]{0x0000000000000002UL,0x0068000000000000UL});
    public static readonly BitSet FOLLOW_SymbolConstant_in_symbolConsantList3036 = new BitSet(new ulong[]{0x0000000000000002UL,0x4000000000000000UL});
    public static readonly BitSet FOLLOW_CharachterConstantSQ_in_characterConstant3060 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_CharachterConstantDQ_in_characterConstant3070 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_SystemName_in_variableName3091 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_QualifiedName_in_variableName3107 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_UnqualifiedName_in_variableName3119 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_statement_in_synpred1_AplusParser100 = new BitSet(new ulong[]{0x0000000000000000UL,0x0001000000000000UL});
    public static readonly BitSet FOLLOW_NewLine_in_synpred1_AplusParser112 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_dependencyDefinition_in_synpred3_AplusParser160 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_userDefinedOperator_in_synpred4_AplusParser170 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_userDefinedFunction_in_synpred5_AplusParser181 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_expression_in_synpred15_AplusParser667 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_operatorSymbol_in_synpred16_AplusParser680 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_functionSymbol_in_synpred17_AplusParser692 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LSB_in_synpred18_AplusParser727 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000200000000000UL});
    public static readonly BitSet FOLLOW_RSB_in_synpred18_AplusParser729 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_dyadicLeftArg_in_synpred20_AplusParser783 = new BitSet(new ulong[]{0xFFFFFFFFFFFFF900UL,0xCC681005FFFFFFFFUL,0x0000000000000003UL});
    public static readonly BitSet FOLLOW_dyadicFunctionSelector_in_synpred20_AplusParser787 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFF40UL,0xCC681007FFFFFFFFUL,0x0000000000000003UL});
    public static readonly BitSet FOLLOW_expression_in_synpred20_AplusParser791 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_monadicFunctionSelector_in_synpred21_AplusParser803 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFF40UL,0xCC681007FFFFFFFFUL,0x0000000000000003UL});
    public static readonly BitSet FOLLOW_expression_in_synpred21_AplusParser807 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_operatorSymbol_in_synpred22_AplusParser837 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_functionSymbol_in_synpred23_AplusParser850 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_operatorSymbol_in_synpred24_AplusParser888 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_functionSymbol_in_synpred25_AplusParser901 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_operatorSymbol_in_synpred26_AplusParser938 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000100000000000UL});
    public static readonly BitSet FOLLOW_expressionGroup_in_synpred26_AplusParser940 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_functionSymbol_in_synpred27_AplusParser949 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000100000000000UL});
    public static readonly BitSet FOLLOW_expressionGroup_in_synpred27_AplusParser951 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_opTail_in_synpred28_AplusParser1005 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_opArg_in_synpred29_AplusParser990 = new BitSet(new ulong[]{0x0000000000000000UL,0x8000030000000000UL,0x0000000000000003UL});
    public static readonly BitSet FOLLOW_opTail_in_synpred29_AplusParser1005 = new BitSet(new ulong[]{0x0000000000000002UL,0x8000030000000000UL,0x0000000000000003UL});
    public static readonly BitSet FOLLOW_functionSymbol_in_synpred30_AplusParser1046 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_condition_in_synpred33_AplusParser1113 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variableName_in_synpred34_AplusParser1110 = new BitSet(new ulong[]{0xFFFFFFFFFFFFF900UL,0xCC681005FFFFFFFFUL,0x0000000000000003UL});
    public static readonly BitSet FOLLOW_condition_in_synpred34_AplusParser1113 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_functionSymbol_in_synpred34_AplusParser1117 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Else_in_synpred124_AplusParser2651 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFF40UL,0xCC681007FFFFFFFFUL,0x0000000000000003UL});
    public static readonly BitSet FOLLOW_topExpressionNull_in_synpred124_AplusParser2658 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_expressionGroup_in_synpred126_AplusParser2759 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_numericConstant_in_synpred136_AplusParser3004 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_SymbolConstant_in_synpred137_AplusParser3036 = new BitSet(new ulong[]{0x0000000000000002UL});

}
}