// $ANTLR 3.2 Sep 23, 2009 12:02:23 Compiler\\Grammar\\Apl\\AplusLexer.g 2015-05-03 12:08:59

// The variable 'variable' is assigned but its value is never used.
#pragma warning disable 168, 219
// Unreachable code detected.
#pragma warning disable 162


using System.Text;
using System.Collections.Generic;
using AplusCore.Compiler.Grammar;


using System;
using Antlr.Runtime;
using IList 		= System.Collections.IList;
using ArrayList 	= System.Collections.ArrayList;
using Stack 		= Antlr.Runtime.Collections.StackList;


namespace  AplusCore.Compiler.Grammar.Apl 
{
public partial class AplusLexer : Lexer {
    public const int Disclose = 28;
    public const int Enclose = 29;
    public const int SMax = 19;
    public const int LP = 98;
    public const int Inf = 118;
    public const int DQ = 120;
    public const int QualifiedName = 128;
    public const int Replicate = 69;
    public const int SOr = 22;
    public const int EOF = -1;
    public const int Negate = 41;
    public const int Int = 115;
    public const int NewLine = 112;
    public const int Result = 70;
    public const int Rake = 48;
    public const int Signal = 58;
    public const int Transpose = 60;
    public const int Comment = 110;
    public const int RMax = 13;
    public const int OPGT = 77;
    public const int Do = 8;
    public const int Ravel = 49;
    public const int WhiteSpace = 106;
    public const int Sign = 57;
    public const int NaturalLog = 40;
    public const int Null = 43;
    public const int SystemCommand = 4;
    public const int SemiColon = 102;
    public const int RSBracket = 101;
    public const int SystemCommandArgument = 5;
    public const int Interval = 36;
    public const int BWOr = 90;
    public const int RMin = 14;
    public const int Reciprocal = 51;
    public const int RAdd = 11;
    public const int BWGT = 93;
    public const int PartitionCount = 45;
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
    public const int IPMaxAdd = 72;
    public const int IPMinAdd = 73;
    public const int OPMax = 81;
    public const int Unpack = 61;
    public const int Or = 68;
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
    public const int UnqualifiedName = 127;
    public const int OPResidue = 85;
    public const int Depth = 27;
    public const int BWGTE = 94;
    public const int OPPower = 87;
    public const int CharachterConstantSQ = 122;
    public const int Digit = 113;
    public const int BWEqual = 95;
    public const int BWLTE = 92;
    public const int ItemRavel = 37;
    public const int BWLT = 91;
    public const int AbsoluteValue = 23;
    public const int OPSubstract = 86;
    public const int BWNotEqual = 96;
    public const int Alphabetic = 124;
    public const int SQ = 119;
    public const int Not = 42;
    public const int SMin = 20;
    public const int Shape = 56;
    public const int GradeUp = 34;
    public const int SeparateSymbols = 55;
    public const int Identity = 35;
    public const int CR = 111;
    public const int Execute = 30;
    public const int OPMultiply = 83;
    public const int Expand = 64;

    	private int mode = 0;

    	Queue<IToken> tokens = new Queue<IToken>();
    	public override void Emit(IToken token) 
    	{
    		state.token = token;
    		tokens.Enqueue(token);
    	}
    	public override IToken NextToken()
    	{
    		base.NextToken();
    		if ( tokens.Count ==0 )
    			return Token.EOF_TOKEN;
    		return tokens.Dequeue();
    	}


    // delegates
    // delegators

    public AplusLexer() 
    {
		InitializeCyclicDFAs();
    }
    public AplusLexer(ICharStream input)
		: this(input, null) {
    }
    public AplusLexer(ICharStream input, RecognizerSharedState state)
		: base(input, state) {
		InitializeCyclicDFAs(); 

    }
    
    override public string GrammarFileName
    {
    	get { return "Compiler\\Grammar\\Apl\\AplusLexer.g";} 
    }

    // $ANTLR start "If"
    public void mIf() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = If;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Compiler\\Grammar\\Apl\\AplusLexer.g:39:3: ( 'if' )
            // Compiler\\Grammar\\Apl\\AplusLexer.g:39:8: 'if'
            {
            	Match("if"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "If"

    // $ANTLR start "Else"
    public void mElse() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = Else;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Compiler\\Grammar\\Apl\\AplusLexer.g:40:5: ( 'else' )
            // Compiler\\Grammar\\Apl\\AplusLexer.g:40:9: 'else'
            {
            	Match("else"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "Else"

    // $ANTLR start "Do"
    public void mDo() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = Do;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Compiler\\Grammar\\Apl\\AplusLexer.g:41:3: ( 'do' )
            // Compiler\\Grammar\\Apl\\AplusLexer.g:41:8: 'do'
            {
            	Match("do"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "Do"

    // $ANTLR start "While"
    public void mWhile() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = While;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Compiler\\Grammar\\Apl\\AplusLexer.g:42:6: ( 'while' )
            // Compiler\\Grammar\\Apl\\AplusLexer.g:42:10: 'while'
            {
            	Match("while"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "While"

    // $ANTLR start "Case"
    public void mCase() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = Case;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Compiler\\Grammar\\Apl\\AplusLexer.g:43:5: ( 'case' )
            // Compiler\\Grammar\\Apl\\AplusLexer.g:43:9: 'case'
            {
            	Match("case"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "Case"

    // $ANTLR start "RAdd"
    public void mRAdd() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = RAdd;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Compiler\\Grammar\\Apl\\AplusLexer.g:46:5: ( '+/' )
            // Compiler\\Grammar\\Apl\\AplusLexer.g:46:9: '+/'
            {
            	Match("+/"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "RAdd"

    // $ANTLR start "RAnd"
    public void mRAnd() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = RAnd;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Compiler\\Grammar\\Apl\\AplusLexer.g:47:5: ( '^/' )
            // Compiler\\Grammar\\Apl\\AplusLexer.g:47:9: '^/'
            {
            	Match("^/"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "RAnd"

    // $ANTLR start "RMax"
    public void mRMax() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = RMax;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Compiler\\Grammar\\Apl\\AplusLexer.g:48:5: ( '\\u00D3/' )
            // Compiler\\Grammar\\Apl\\AplusLexer.g:48:9: '\\u00D3/'
            {
            	Match("\u00D3/"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "RMax"

    // $ANTLR start "RMin"
    public void mRMin() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = RMin;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Compiler\\Grammar\\Apl\\AplusLexer.g:49:5: ( '\\u00C4/' )
            // Compiler\\Grammar\\Apl\\AplusLexer.g:49:9: '\\u00C4/'
            {
            	Match("\u00C4/"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "RMin"

    // $ANTLR start "RMultiply"
    public void mRMultiply() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = RMultiply;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Compiler\\Grammar\\Apl\\AplusLexer.g:50:10: ( '\\u00AB/' )
            // Compiler\\Grammar\\Apl\\AplusLexer.g:50:13: '\\u00AB/'
            {
            	Match("\u00AB/"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "RMultiply"

    // $ANTLR start "ROr"
    public void mROr() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = ROr;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Compiler\\Grammar\\Apl\\AplusLexer.g:51:4: ( '\\u00A9/' )
            // Compiler\\Grammar\\Apl\\AplusLexer.g:51:8: '\\u00A9/'
            {
            	Match("\u00A9/"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "ROr"

    // $ANTLR start "SAdd"
    public void mSAdd() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = SAdd;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Compiler\\Grammar\\Apl\\AplusLexer.g:52:5: ( '+\\\\' )
            // Compiler\\Grammar\\Apl\\AplusLexer.g:52:9: '+\\\\'
            {
            	Match("+\\"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "SAdd"

    // $ANTLR start "SAnd"
    public void mSAnd() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = SAnd;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Compiler\\Grammar\\Apl\\AplusLexer.g:53:5: ( '^\\\\' )
            // Compiler\\Grammar\\Apl\\AplusLexer.g:53:9: '^\\\\'
            {
            	Match("^\\"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "SAnd"

    // $ANTLR start "SMax"
    public void mSMax() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = SMax;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Compiler\\Grammar\\Apl\\AplusLexer.g:54:5: ( '\\u00D3\\\\' )
            // Compiler\\Grammar\\Apl\\AplusLexer.g:54:9: '\\u00D3\\\\'
            {
            	Match("\u00D3\\"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "SMax"

    // $ANTLR start "SMin"
    public void mSMin() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = SMin;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Compiler\\Grammar\\Apl\\AplusLexer.g:55:5: ( '\\u00C4\\\\' )
            // Compiler\\Grammar\\Apl\\AplusLexer.g:55:9: '\\u00C4\\\\'
            {
            	Match("\u00C4\\"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "SMin"

    // $ANTLR start "SMultiply"
    public void mSMultiply() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = SMultiply;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Compiler\\Grammar\\Apl\\AplusLexer.g:56:10: ( '\\u00AB\\\\' )
            // Compiler\\Grammar\\Apl\\AplusLexer.g:56:13: '\\u00AB\\\\'
            {
            	Match("\u00AB\\"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "SMultiply"

    // $ANTLR start "SOr"
    public void mSOr() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = SOr;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Compiler\\Grammar\\Apl\\AplusLexer.g:57:4: ( '\\u00A9\\\\' )
            // Compiler\\Grammar\\Apl\\AplusLexer.g:57:8: '\\u00A9\\\\'
            {
            	Match("\u00A9\\"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "SOr"

    // $ANTLR start "AbsoluteValue"
    public void mAbsoluteValue() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = AbsoluteValue;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Compiler\\Grammar\\Apl\\AplusLexer.g:59:14: ( '|' )
            // Compiler\\Grammar\\Apl\\AplusLexer.g:59:17: '|'
            {
            	Match('|'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "AbsoluteValue"

    // $ANTLR start "Ceiling"
    public void mCeiling() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = Ceiling;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Compiler\\Grammar\\Apl\\AplusLexer.g:60:8: ( '\\u00D3' )
            // Compiler\\Grammar\\Apl\\AplusLexer.g:60:12: '\\u00D3'
            {
            	Match('\u00D3'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "Ceiling"

    // $ANTLR start "Count"
    public void mCount() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = Count;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Compiler\\Grammar\\Apl\\AplusLexer.g:61:6: ( '\\u0023' )
            // Compiler\\Grammar\\Apl\\AplusLexer.g:61:11: '\\u0023'
            {
            	Match('#'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "Count"

    // $ANTLR start "DefaultFormat"
    public void mDefaultFormat() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = DefaultFormat;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Compiler\\Grammar\\Apl\\AplusLexer.g:62:14: ( '\\u00EE' )
            // Compiler\\Grammar\\Apl\\AplusLexer.g:62:17: '\\u00EE'
            {
            	Match('\u00EE'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "DefaultFormat"

    // $ANTLR start "Depth"
    public void mDepth() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = Depth;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Compiler\\Grammar\\Apl\\AplusLexer.g:63:6: ( '\\u00BD' )
            // Compiler\\Grammar\\Apl\\AplusLexer.g:63:11: '\\u00BD'
            {
            	Match('\u00BD'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "Depth"

    // $ANTLR start "Disclose"
    public void mDisclose() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = Disclose;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Compiler\\Grammar\\Apl\\AplusLexer.g:64:9: ( '\\u003E' )
            // Compiler\\Grammar\\Apl\\AplusLexer.g:64:13: '\\u003E'
            {
            	Match('>'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "Disclose"

    // $ANTLR start "Enclose"
    public void mEnclose() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = Enclose;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Compiler\\Grammar\\Apl\\AplusLexer.g:65:8: ( '\\u003C' )
            // Compiler\\Grammar\\Apl\\AplusLexer.g:65:12: '\\u003C'
            {
            	Match('<'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "Enclose"

    // $ANTLR start "Execute"
    public void mExecute() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = Execute;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Compiler\\Grammar\\Apl\\AplusLexer.g:66:8: ( '\\u00E2' )
            // Compiler\\Grammar\\Apl\\AplusLexer.g:66:12: '\\u00E2'
            {
            	Match('\u00E2'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "Execute"

    // $ANTLR start "Exponential"
    public void mExponential() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = Exponential;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Compiler\\Grammar\\Apl\\AplusLexer.g:67:12: ( '\\u002A' )
            // Compiler\\Grammar\\Apl\\AplusLexer.g:67:15: '\\u002A'
            {
            	Match('*'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "Exponential"

    // $ANTLR start "Floor"
    public void mFloor() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = Floor;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Compiler\\Grammar\\Apl\\AplusLexer.g:68:6: ( '\\u00C4' )
            // Compiler\\Grammar\\Apl\\AplusLexer.g:68:11: '\\u00C4'
            {
            	Match('\u00C4'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "Floor"

    // $ANTLR start "GradeDown"
    public void mGradeDown() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = GradeDown;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Compiler\\Grammar\\Apl\\AplusLexer.g:69:10: ( '\\u00E7' )
            // Compiler\\Grammar\\Apl\\AplusLexer.g:69:14: '\\u00E7'
            {
            	Match('\u00E7'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "GradeDown"

    // $ANTLR start "GradeUp"
    public void mGradeUp() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = GradeUp;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Compiler\\Grammar\\Apl\\AplusLexer.g:70:8: ( '\\u00E8' )
            // Compiler\\Grammar\\Apl\\AplusLexer.g:70:12: '\\u00E8'
            {
            	Match('\u00E8'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "GradeUp"

    // $ANTLR start "Identity"
    public void mIdentity() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = Identity;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Compiler\\Grammar\\Apl\\AplusLexer.g:71:9: ( '\\u002B' )
            // Compiler\\Grammar\\Apl\\AplusLexer.g:71:13: '\\u002B'
            {
            	Match('+'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "Identity"

    // $ANTLR start "Interval"
    public void mInterval() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = Interval;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Compiler\\Grammar\\Apl\\AplusLexer.g:72:9: ( '\\u00C9' )
            // Compiler\\Grammar\\Apl\\AplusLexer.g:72:13: '\\u00C9'
            {
            	Match('\u00C9'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "Interval"

    // $ANTLR start "ItemRavel"
    public void mItemRavel() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = ItemRavel;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Compiler\\Grammar\\Apl\\AplusLexer.g:73:10: ( '\\u0021' )
            // Compiler\\Grammar\\Apl\\AplusLexer.g:73:14: '\\u0021'
            {
            	Match('!'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "ItemRavel"

    // $ANTLR start "MapIn"
    public void mMapIn() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = MapIn;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Compiler\\Grammar\\Apl\\AplusLexer.g:74:6: ( '\\u00E0' )
            // Compiler\\Grammar\\Apl\\AplusLexer.g:74:11: '\\u00E0'
            {
            	Match('\u00E0'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "MapIn"

    // $ANTLR start "MatrixInverse"
    public void mMatrixInverse() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = MatrixInverse;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Compiler\\Grammar\\Apl\\AplusLexer.g:75:14: ( '\\u00AD' )
            // Compiler\\Grammar\\Apl\\AplusLexer.g:75:17: '\\u00AD'
            {
            	Match('\u00AD'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "MatrixInverse"

    // $ANTLR start "NaturalLog"
    public void mNaturalLog() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = NaturalLog;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Compiler\\Grammar\\Apl\\AplusLexer.g:76:11: ( '\\u00F0' )
            // Compiler\\Grammar\\Apl\\AplusLexer.g:76:15: '\\u00F0'
            {
            	Match('\u00F0'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "NaturalLog"

    // $ANTLR start "Negate"
    public void mNegate() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = Negate;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Compiler\\Grammar\\Apl\\AplusLexer.g:77:7: ( '\\u002D' )
            // Compiler\\Grammar\\Apl\\AplusLexer.g:77:12: '\\u002D'
            {
            	Match('-'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "Negate"

    // $ANTLR start "Not"
    public void mNot() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = Not;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Compiler\\Grammar\\Apl\\AplusLexer.g:78:4: ( '\\u007E' )
            // Compiler\\Grammar\\Apl\\AplusLexer.g:78:9: '\\u007E'
            {
            	Match('~'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "Not"

    // $ANTLR start "Null"
    public void mNull() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = Null;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Compiler\\Grammar\\Apl\\AplusLexer.g:79:5: ( '\\u00DD' )
            // Compiler\\Grammar\\Apl\\AplusLexer.g:79:10: '\\u00DD'
            {
            	Match('\u00DD'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "Null"

    // $ANTLR start "Pack"
    public void mPack() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = Pack;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Compiler\\Grammar\\Apl\\AplusLexer.g:80:5: ( '\\u00C2' )
            // Compiler\\Grammar\\Apl\\AplusLexer.g:80:10: '\\u00C2'
            {
            	Match('\u00C2'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "Pack"

    // $ANTLR start "PartitionCount"
    public void mPartitionCount() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = PartitionCount;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Compiler\\Grammar\\Apl\\AplusLexer.g:81:15: ( '\\u00DA' )
            // Compiler\\Grammar\\Apl\\AplusLexer.g:81:18: '\\u00DA'
            {
            	Match('\u00DA'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "PartitionCount"

    // $ANTLR start "PiTimes"
    public void mPiTimes() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = PiTimes;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Compiler\\Grammar\\Apl\\AplusLexer.g:82:8: ( '\\u00CF' )
            // Compiler\\Grammar\\Apl\\AplusLexer.g:82:12: '\\u00CF'
            {
            	Match('\u00CF'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "PiTimes"

    // $ANTLR start "Print"
    public void mPrint() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = Print;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Compiler\\Grammar\\Apl\\AplusLexer.g:83:6: ( '\\u00D5' )
            // Compiler\\Grammar\\Apl\\AplusLexer.g:83:11: '\\u00D5'
            {
            	Match('\u00D5'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "Print"

    // $ANTLR start "Rake"
    public void mRake() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = Rake;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Compiler\\Grammar\\Apl\\AplusLexer.g:84:5: ( '\\u00C5' )
            // Compiler\\Grammar\\Apl\\AplusLexer.g:84:10: '\\u00C5'
            {
            	Match('\u00C5'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "Rake"

    // $ANTLR start "Ravel"
    public void mRavel() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = Ravel;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Compiler\\Grammar\\Apl\\AplusLexer.g:85:6: ( '\\u002C' )
            // Compiler\\Grammar\\Apl\\AplusLexer.g:85:11: '\\u002C'
            {
            	Match(','); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "Ravel"

    // $ANTLR start "Raze"
    public void mRaze() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = Raze;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Compiler\\Grammar\\Apl\\AplusLexer.g:86:5: ( '\\u00D8' )
            // Compiler\\Grammar\\Apl\\AplusLexer.g:86:10: '\\u00D8'
            {
            	Match('\u00D8'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "Raze"

    // $ANTLR start "Reciprocal"
    public void mReciprocal() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = Reciprocal;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Compiler\\Grammar\\Apl\\AplusLexer.g:87:11: ( '\\u00DF' )
            // Compiler\\Grammar\\Apl\\AplusLexer.g:87:15: '\\u00DF'
            {
            	Match('\u00DF'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "Reciprocal"

    // $ANTLR start "Reverse"
    public void mReverse() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = Reverse;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Compiler\\Grammar\\Apl\\AplusLexer.g:88:8: ( '\\u00F7' )
            // Compiler\\Grammar\\Apl\\AplusLexer.g:88:12: '\\u00F7'
            {
            	Match('\u00F7'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "Reverse"

    // $ANTLR start "Roll"
    public void mRoll() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = Roll;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Compiler\\Grammar\\Apl\\AplusLexer.g:89:5: ( '?' )
            // Compiler\\Grammar\\Apl\\AplusLexer.g:89:10: '?'
            {
            	Match('?'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "Roll"

    // $ANTLR start "Right"
    public void mRight() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = Right;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Compiler\\Grammar\\Apl\\AplusLexer.g:90:6: ( '\\u00DB' )
            // Compiler\\Grammar\\Apl\\AplusLexer.g:90:11: '\\u00DB'
            {
            	Match('\u00DB'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "Right"

    // $ANTLR start "SeparateSymbols"
    public void mSeparateSymbols() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = SeparateSymbols;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Compiler\\Grammar\\Apl\\AplusLexer.g:91:16: ( '\\u002E' )
            // Compiler\\Grammar\\Apl\\AplusLexer.g:91:18: '\\u002E'
            {
            	Match('.'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "SeparateSymbols"

    // $ANTLR start "Shape"
    public void mShape() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = Shape;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Compiler\\Grammar\\Apl\\AplusLexer.g:92:6: ( '\\u00D2' )
            // Compiler\\Grammar\\Apl\\AplusLexer.g:92:11: '\\u00D2'
            {
            	Match('\u00D2'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "Shape"

    // $ANTLR start "Sign"
    public void mSign() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = Sign;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Compiler\\Grammar\\Apl\\AplusLexer.g:93:5: ( '\\u00AB' )
            // Compiler\\Grammar\\Apl\\AplusLexer.g:93:10: '\\u00AB'
            {
            	Match('\u00AB'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "Sign"

    // $ANTLR start "Signal"
    public void mSignal() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = Signal;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Compiler\\Grammar\\Apl\\AplusLexer.g:94:7: ( '\\u00D9' )
            // Compiler\\Grammar\\Apl\\AplusLexer.g:94:12: '\\u00D9'
            {
            	Match('\u00D9'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "Signal"

    // $ANTLR start "Stop"
    public void mStop() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = Stop;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Compiler\\Grammar\\Apl\\AplusLexer.g:95:5: ( '^' )
            // Compiler\\Grammar\\Apl\\AplusLexer.g:95:10: '^'
            {
            	Match('^'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "Stop"

    // $ANTLR start "Transpose"
    public void mTranspose() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = Transpose;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Compiler\\Grammar\\Apl\\AplusLexer.g:96:10: ( '\\u00F4' )
            // Compiler\\Grammar\\Apl\\AplusLexer.g:96:14: '\\u00F4'
            {
            	Match('\u00F4'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "Transpose"

    // $ANTLR start "Unpack"
    public void mUnpack() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = Unpack;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Compiler\\Grammar\\Apl\\AplusLexer.g:97:7: ( '\\u00CE' )
            // Compiler\\Grammar\\Apl\\AplusLexer.g:97:12: '\\u00CE'
            {
            	Match('\u00CE'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "Unpack"

    // $ANTLR start "Value"
    public void mValue() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = Value;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Compiler\\Grammar\\Apl\\AplusLexer.g:98:6: ( '%' )
            // Compiler\\Grammar\\Apl\\AplusLexer.g:98:11: '%'
            {
            	Match('%'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "Value"

    // $ANTLR start "Equal"
    public void mEqual() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = Equal;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Compiler\\Grammar\\Apl\\AplusLexer.g:103:6: ( '=' )
            // Compiler\\Grammar\\Apl\\AplusLexer.g:103:10: '='
            {
            	Match('='); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "Equal"

    // $ANTLR start "Expand"
    public void mExpand() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = Expand;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Compiler\\Grammar\\Apl\\AplusLexer.g:104:7: ( '\\\\' )
            // Compiler\\Grammar\\Apl\\AplusLexer.g:104:11: '\\\\'
            {
            	Match('\\'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "Expand"

    // $ANTLR start "GTE"
    public void mGTE() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = GTE;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Compiler\\Grammar\\Apl\\AplusLexer.g:105:4: ( '\\u00A6' )
            // Compiler\\Grammar\\Apl\\AplusLexer.g:105:8: '\\u00A6'
            {
            	Match('\u00A6'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "GTE"

    // $ANTLR start "LTE"
    public void mLTE() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = LTE;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Compiler\\Grammar\\Apl\\AplusLexer.g:106:4: ( '\\u00A4' )
            // Compiler\\Grammar\\Apl\\AplusLexer.g:106:8: '\\u00A4'
            {
            	Match('\u00A4'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "LTE"

    // $ANTLR start "NotEqual"
    public void mNotEqual() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = NotEqual;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Compiler\\Grammar\\Apl\\AplusLexer.g:107:9: ( '\\u00A8' )
            // Compiler\\Grammar\\Apl\\AplusLexer.g:107:12: '\\u00A8'
            {
            	Match('\u00A8'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "NotEqual"

    // $ANTLR start "Or"
    public void mOr() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = Or;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Compiler\\Grammar\\Apl\\AplusLexer.g:108:3: ( '\\u00A9' )
            // Compiler\\Grammar\\Apl\\AplusLexer.g:108:8: '\\u00A9'
            {
            	Match('\u00A9'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "Or"

    // $ANTLR start "Replicate"
    public void mReplicate() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = Replicate;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Compiler\\Grammar\\Apl\\AplusLexer.g:109:10: ( '/' )
            // Compiler\\Grammar\\Apl\\AplusLexer.g:109:13: '/'
            {
            	Match('/'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "Replicate"

    // $ANTLR start "Result"
    public void mResult() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = Result;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Compiler\\Grammar\\Apl\\AplusLexer.g:110:7: ( '\\u00FB' )
            // Compiler\\Grammar\\Apl\\AplusLexer.g:110:11: '\\u00FB'
            {
            	Match('\u00FB'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "Result"

    // $ANTLR start "IPAddMultiply"
    public void mIPAddMultiply() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = IPAddMultiply;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Compiler\\Grammar\\Apl\\AplusLexer.g:112:14: ( '+.\\u00AB' )
            // Compiler\\Grammar\\Apl\\AplusLexer.g:112:16: '+.\\u00AB'
            {
            	Match("+.\u00AB"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "IPAddMultiply"

    // $ANTLR start "IPMaxAdd"
    public void mIPMaxAdd() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = IPMaxAdd;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Compiler\\Grammar\\Apl\\AplusLexer.g:113:9: ( '\\u00D3.+' )
            // Compiler\\Grammar\\Apl\\AplusLexer.g:113:12: '\\u00D3.+'
            {
            	Match("\u00D3.+"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "IPMaxAdd"

    // $ANTLR start "IPMinAdd"
    public void mIPMinAdd() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = IPMinAdd;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Compiler\\Grammar\\Apl\\AplusLexer.g:114:9: ( '\\u00C4.+' )
            // Compiler\\Grammar\\Apl\\AplusLexer.g:114:12: '\\u00C4.+'
            {
            	Match("\u00C4.+"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "IPMinAdd"

    // $ANTLR start "OPAdd"
    public void mOPAdd() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = OPAdd;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Compiler\\Grammar\\Apl\\AplusLexer.g:115:6: ( '\\u00CA.+' )
            // Compiler\\Grammar\\Apl\\AplusLexer.g:115:10: '\\u00CA.+'
            {
            	Match("\u00CA.+"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "OPAdd"

    // $ANTLR start "OPDivide"
    public void mOPDivide() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = OPDivide;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Compiler\\Grammar\\Apl\\AplusLexer.g:116:9: ( '\\u00CA.\\u00DF' )
            // Compiler\\Grammar\\Apl\\AplusLexer.g:116:12: '\\u00CA.\\u00DF'
            {
            	Match("\u00CA.\u00DF"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "OPDivide"

    // $ANTLR start "OPEqual"
    public void mOPEqual() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = OPEqual;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Compiler\\Grammar\\Apl\\AplusLexer.g:117:8: ( '\\u00CA.=' )
            // Compiler\\Grammar\\Apl\\AplusLexer.g:117:11: '\\u00CA.='
            {
            	Match("\u00CA.="); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "OPEqual"

    // $ANTLR start "OPGT"
    public void mOPGT() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = OPGT;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Compiler\\Grammar\\Apl\\AplusLexer.g:118:5: ( '\\u00CA.>' )
            // Compiler\\Grammar\\Apl\\AplusLexer.g:118:9: '\\u00CA.>'
            {
            	Match("\u00CA.>"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "OPGT"

    // $ANTLR start "OPGTE"
    public void mOPGTE() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = OPGTE;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Compiler\\Grammar\\Apl\\AplusLexer.g:119:6: ( '\\u00CA.\\u00A6' )
            // Compiler\\Grammar\\Apl\\AplusLexer.g:119:10: '\\u00CA.\\u00A6'
            {
            	Match("\u00CA.\u00A6"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "OPGTE"

    // $ANTLR start "OPLT"
    public void mOPLT() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = OPLT;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Compiler\\Grammar\\Apl\\AplusLexer.g:120:5: ( '\\u00CA.<' )
            // Compiler\\Grammar\\Apl\\AplusLexer.g:120:9: '\\u00CA.<'
            {
            	Match("\u00CA.<"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "OPLT"

    // $ANTLR start "OPLTE"
    public void mOPLTE() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = OPLTE;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Compiler\\Grammar\\Apl\\AplusLexer.g:121:6: ( '\\u00CA.\\u00A4' )
            // Compiler\\Grammar\\Apl\\AplusLexer.g:121:10: '\\u00CA.\\u00A4'
            {
            	Match("\u00CA.\u00A4"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "OPLTE"

    // $ANTLR start "OPMax"
    public void mOPMax() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = OPMax;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Compiler\\Grammar\\Apl\\AplusLexer.g:122:6: ( '\\u00CA.\\u00D3' )
            // Compiler\\Grammar\\Apl\\AplusLexer.g:122:10: '\\u00CA.\\u00D3'
            {
            	Match("\u00CA.\u00D3"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "OPMax"

    // $ANTLR start "OPMin"
    public void mOPMin() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = OPMin;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Compiler\\Grammar\\Apl\\AplusLexer.g:123:6: ( '\\u00CA.\\u00C4' )
            // Compiler\\Grammar\\Apl\\AplusLexer.g:123:10: '\\u00CA.\\u00C4'
            {
            	Match("\u00CA.\u00C4"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "OPMin"

    // $ANTLR start "OPMultiply"
    public void mOPMultiply() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = OPMultiply;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Compiler\\Grammar\\Apl\\AplusLexer.g:124:11: ( '\\u00CA.\\u00AB' )
            // Compiler\\Grammar\\Apl\\AplusLexer.g:124:14: '\\u00CA.\\u00AB'
            {
            	Match("\u00CA.\u00AB"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "OPMultiply"

    // $ANTLR start "OPNotEqual"
    public void mOPNotEqual() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = OPNotEqual;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Compiler\\Grammar\\Apl\\AplusLexer.g:125:11: ( '\\u00CA.\\u00A8' )
            // Compiler\\Grammar\\Apl\\AplusLexer.g:125:14: '\\u00CA.\\u00A8'
            {
            	Match("\u00CA.\u00A8"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "OPNotEqual"

    // $ANTLR start "OPResidue"
    public void mOPResidue() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = OPResidue;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Compiler\\Grammar\\Apl\\AplusLexer.g:126:10: ( '\\u00CA.|' )
            // Compiler\\Grammar\\Apl\\AplusLexer.g:126:13: '\\u00CA.|'
            {
            	Match("\u00CA.|"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "OPResidue"

    // $ANTLR start "OPSubstract"
    public void mOPSubstract() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = OPSubstract;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Compiler\\Grammar\\Apl\\AplusLexer.g:127:12: ( '\\u00CA.-' )
            // Compiler\\Grammar\\Apl\\AplusLexer.g:127:14: '\\u00CA.-'
            {
            	Match("\u00CA.-"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "OPSubstract"

    // $ANTLR start "OPPower"
    public void mOPPower() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = OPPower;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Compiler\\Grammar\\Apl\\AplusLexer.g:128:8: ( '\\u00CA.\\u002A' )
            // Compiler\\Grammar\\Apl\\AplusLexer.g:128:11: '\\u00CA.\\u002A'
            {
            	Match("\u00CA.\u002A"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "OPPower"

    // $ANTLR start "BWNot"
    public void mBWNot() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = BWNot;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Compiler\\Grammar\\Apl\\AplusLexer.g:131:6: ( '\\u007E\\u00AE' )
            // Compiler\\Grammar\\Apl\\AplusLexer.g:131:10: '\\u007E\\u00AE'
            {
            	Match("\u007E\u00AE"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "BWNot"

    // $ANTLR start "BWAnd"
    public void mBWAnd() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = BWAnd;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Compiler\\Grammar\\Apl\\AplusLexer.g:132:6: ( '^\\u00AE' )
            // Compiler\\Grammar\\Apl\\AplusLexer.g:132:10: '^\\u00AE'
            {
            	Match("^\u00AE"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "BWAnd"

    // $ANTLR start "BWOr"
    public void mBWOr() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = BWOr;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Compiler\\Grammar\\Apl\\AplusLexer.g:133:5: ( '\\u00A9\\u00AE' )
            // Compiler\\Grammar\\Apl\\AplusLexer.g:133:9: '\\u00A9\\u00AE'
            {
            	Match("\u00A9\u00AE"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "BWOr"

    // $ANTLR start "BWLT"
    public void mBWLT() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = BWLT;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Compiler\\Grammar\\Apl\\AplusLexer.g:134:5: ( '<\\u00AE' )
            // Compiler\\Grammar\\Apl\\AplusLexer.g:134:9: '<\\u00AE'
            {
            	Match("<\u00AE"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "BWLT"

    // $ANTLR start "BWLTE"
    public void mBWLTE() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = BWLTE;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Compiler\\Grammar\\Apl\\AplusLexer.g:135:6: ( '\\u00A4\\u00AE' )
            // Compiler\\Grammar\\Apl\\AplusLexer.g:135:10: '\\u00A4\\u00AE'
            {
            	Match("\u00A4\u00AE"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "BWLTE"

    // $ANTLR start "BWGT"
    public void mBWGT() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = BWGT;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Compiler\\Grammar\\Apl\\AplusLexer.g:136:5: ( '>\\u00AE' )
            // Compiler\\Grammar\\Apl\\AplusLexer.g:136:9: '>\\u00AE'
            {
            	Match(">\u00AE"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "BWGT"

    // $ANTLR start "BWGTE"
    public void mBWGTE() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = BWGTE;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Compiler\\Grammar\\Apl\\AplusLexer.g:137:6: ( '\\u00A6\\u00AE' )
            // Compiler\\Grammar\\Apl\\AplusLexer.g:137:10: '\\u00A6\\u00AE'
            {
            	Match("\u00A6\u00AE"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "BWGTE"

    // $ANTLR start "BWEqual"
    public void mBWEqual() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = BWEqual;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Compiler\\Grammar\\Apl\\AplusLexer.g:138:8: ( '=\\u00AE' )
            // Compiler\\Grammar\\Apl\\AplusLexer.g:138:11: '=\\u00AE'
            {
            	Match("=\u00AE"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "BWEqual"

    // $ANTLR start "BWNotEqual"
    public void mBWNotEqual() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = BWNotEqual;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Compiler\\Grammar\\Apl\\AplusLexer.g:139:11: ( '\\u00A8\\u00AE' )
            // Compiler\\Grammar\\Apl\\AplusLexer.g:139:14: '\\u00A8\\u00AE'
            {
            	Match("\u00A8\u00AE"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "BWNotEqual"

    // $ANTLR start "StackReference"
    public void mStackReference() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = StackReference;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Compiler\\Grammar\\Apl\\AplusLexer.g:142:15: ( '&' )
            // Compiler\\Grammar\\Apl\\AplusLexer.g:142:17: '&'
            {
            	Match('&'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "StackReference"

    // $ANTLR start "LP"
    public void mLP() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = LP;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Compiler\\Grammar\\Apl\\AplusLexer.g:144:3: ( '(' )
            // Compiler\\Grammar\\Apl\\AplusLexer.g:144:8: '('
            {
            	Match('('); 
            	mode++;

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "LP"

    // $ANTLR start "RP"
    public void mRP() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = RP;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Compiler\\Grammar\\Apl\\AplusLexer.g:145:3: ( ')' )
            // Compiler\\Grammar\\Apl\\AplusLexer.g:145:8: ')'
            {
            	Match(')'); 
            	mode--;

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "RP"

    // $ANTLR start "LSBracket"
    public void mLSBracket() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = LSBracket;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Compiler\\Grammar\\Apl\\AplusLexer.g:146:10: ( '[' )
            // Compiler\\Grammar\\Apl\\AplusLexer.g:146:13: '['
            {
            	Match('['); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "LSBracket"

    // $ANTLR start "RSBracket"
    public void mRSBracket() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = RSBracket;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Compiler\\Grammar\\Apl\\AplusLexer.g:147:10: ( ']' )
            // Compiler\\Grammar\\Apl\\AplusLexer.g:147:13: ']'
            {
            	Match(']'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "RSBracket"

    // $ANTLR start "SemiColon"
    public void mSemiColon() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = SemiColon;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Compiler\\Grammar\\Apl\\AplusLexer.g:148:10: ( ';' )
            // Compiler\\Grammar\\Apl\\AplusLexer.g:148:13: ';'
            {
            	Match(';'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "SemiColon"

    // $ANTLR start "Colon"
    public void mColon() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = Colon;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Compiler\\Grammar\\Apl\\AplusLexer.g:149:6: ( ':' )
            // Compiler\\Grammar\\Apl\\AplusLexer.g:149:10: ':'
            {
            	Match(':'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "Colon"

    // $ANTLR start "Each"
    public void mEach() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = Each;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Compiler\\Grammar\\Apl\\AplusLexer.g:150:5: ( '\\u00A1' )
            // Compiler\\Grammar\\Apl\\AplusLexer.g:150:9: '\\u00A1'
            {
            	Match('\u00A1'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "Each"

    // $ANTLR start "Rank"
    public void mRank() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = Rank;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Compiler\\Grammar\\Apl\\AplusLexer.g:151:5: ( '@' )
            // Compiler\\Grammar\\Apl\\AplusLexer.g:151:9: '@'
            {
            	Match('@'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "Rank"

    // $ANTLR start "Blank"
    public void mBlank() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = Blank;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Compiler\\Grammar\\Apl\\AplusLexer.g:153:6: ( WhiteSpace )
            // Compiler\\Grammar\\Apl\\AplusLexer.g:153:10: WhiteSpace
            {
            	mWhiteSpace(); 
            	_channel = HIDDEN;

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "Blank"

    // $ANTLR start "LSB"
    public void mLSB() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = LSB;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Compiler\\Grammar\\Apl\\AplusLexer.g:154:4: ( '{' )
            // Compiler\\Grammar\\Apl\\AplusLexer.g:154:8: '{'
            {
            	Match('{'); 
            	mode++;

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "LSB"

    // $ANTLR start "RSB"
    public void mRSB() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = RSB;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Compiler\\Grammar\\Apl\\AplusLexer.g:155:4: ( '}' )
            // Compiler\\Grammar\\Apl\\AplusLexer.g:155:8: '}'
            {
            	Match('}'); 
            	mode--;

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "RSB"

    // $ANTLR start "Comment"
    public void mComment() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = Comment;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Compiler\\Grammar\\Apl\\AplusLexer.g:156:8: ( '\\u00E3' (~ '\\n' )* )
            // Compiler\\Grammar\\Apl\\AplusLexer.g:156:11: '\\u00E3' (~ '\\n' )*
            {
            	Match('\u00E3'); 
            	// Compiler\\Grammar\\Apl\\AplusLexer.g:156:20: (~ '\\n' )*
            	do 
            	{
            	    int alt1 = 2;
            	    int LA1_0 = input.LA(1);

            	    if ( ((LA1_0 >= '\u0000' && LA1_0 <= '\t') || (LA1_0 >= '\u000B' && LA1_0 <= '\uFFFF')) )
            	    {
            	        alt1 = 1;
            	    }


            	    switch (alt1) 
            		{
            			case 1 :
            			    // Compiler\\Grammar\\Apl\\AplusLexer.g:156:21: ~ '\\n'
            			    {
            			    	if ( (input.LA(1) >= '\u0000' && input.LA(1) <= '\t') || (input.LA(1) >= '\u000B' && input.LA(1) <= '\uFFFF') ) 
            			    	{
            			    	    input.Consume();

            			    	}
            			    	else 
            			    	{
            			    	    MismatchedSetException mse = new MismatchedSetException(null,input);
            			    	    Recover(mse);
            			    	    throw mse;}


            			    }
            			    break;

            			default:
            			    goto loop1;
            	    }
            	} while (true);

            	loop1:
            		;	// Stops C# compiler whining that label 'loop1' has no statements

            	 _channel = HIDDEN; 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "Comment"

    // $ANTLR start "CR"
    public void mCR() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = CR;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Compiler\\Grammar\\Apl\\AplusLexer.g:157:3: ( '\\r' )
            // Compiler\\Grammar\\Apl\\AplusLexer.g:157:8: '\\r'
            {
            	Match('\r'); 
            	 _channel = HIDDEN; 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "CR"

    // $ANTLR start "NewLine"
    public void mNewLine() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = NewLine;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Compiler\\Grammar\\Apl\\AplusLexer.g:160:2: ({...}? => '\\n' | {...}? => '\\n' )
            int alt2 = 2;
            int LA2_0 = input.LA(1);

            if ( (LA2_0 == '\n') && (((mode > 0)|| (mode == 0))) )
            {
                int LA2_1 = input.LA(2);

                if ( ((mode > 0)) )
                {
                    alt2 = 1;
                }
                else if ( ((mode == 0)) )
                {
                    alt2 = 2;
                }
                else 
                {
                    NoViableAltException nvae_d2s1 =
                        new NoViableAltException("", 2, 1, input);

                    throw nvae_d2s1;
                }
            }
            else 
            {
                NoViableAltException nvae_d2s0 =
                    new NoViableAltException("", 2, 0, input);

                throw nvae_d2s0;
            }
            switch (alt2) 
            {
                case 1 :
                    // Compiler\\Grammar\\Apl\\AplusLexer.g:160:6: {...}? => '\\n'
                    {
                    	if ( !((mode > 0)) ) 
                    	{
                    	    throw new FailedPredicateException(input, "NewLine", "mode > 0");
                    	}
                    	Match('\n'); 
                    	_channel = HIDDEN;

                    }
                    break;
                case 2 :
                    // Compiler\\Grammar\\Apl\\AplusLexer.g:161:6: {...}? => '\\n'
                    {
                    	if ( !((mode == 0)) ) 
                    	{
                    	    throw new FailedPredicateException(input, "NewLine", "mode == 0");
                    	}
                    	Match('\n'); 
                    	_channel = DEFAULT_TOKEN_CHANNEL;

                    }
                    break;

            }
            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "NewLine"

    // $ANTLR start "WhiteSpace"
    public void mWhiteSpace() // throws RecognitionException [2]
    {
    		try
    		{
            // Compiler\\Grammar\\Apl\\AplusLexer.g:165:2: ( ' ' | '\\t' )
            // Compiler\\Grammar\\Apl\\AplusLexer.g:
            {
            	if ( input.LA(1) == '\t' || input.LA(1) == ' ' ) 
            	{
            	    input.Consume();

            	}
            	else 
            	{
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    Recover(mse);
            	    throw mse;}


            }

        }
        finally 
    	{
        }
    }
    // $ANTLR end "WhiteSpace"

    // $ANTLR start "Digit"
    public void mDigit() // throws RecognitionException [2]
    {
    		try
    		{
            // Compiler\\Grammar\\Apl\\AplusLexer.g:170:2: ( '0' .. '9' )
            // Compiler\\Grammar\\Apl\\AplusLexer.g:170:4: '0' .. '9'
            {
            	MatchRange('0','9'); 

            }

        }
        finally 
    	{
        }
    }
    // $ANTLR end "Digit"

    // $ANTLR start "Number"
    public void mNumber() // throws RecognitionException [2]
    {
    		try
    		{
            // Compiler\\Grammar\\Apl\\AplusLexer.g:174:2: ( ( Digit )+ )
            // Compiler\\Grammar\\Apl\\AplusLexer.g:174:4: ( Digit )+
            {
            	// Compiler\\Grammar\\Apl\\AplusLexer.g:174:4: ( Digit )+
            	int cnt3 = 0;
            	do 
            	{
            	    int alt3 = 2;
            	    int LA3_0 = input.LA(1);

            	    if ( ((LA3_0 >= '0' && LA3_0 <= '9')) )
            	    {
            	        alt3 = 1;
            	    }


            	    switch (alt3) 
            		{
            			case 1 :
            			    // Compiler\\Grammar\\Apl\\AplusLexer.g:174:4: Digit
            			    {
            			    	mDigit(); 

            			    }
            			    break;

            			default:
            			    if ( cnt3 >= 1 ) goto loop3;
            		            EarlyExitException eee3 =
            		                new EarlyExitException(3, input);
            		            throw eee3;
            	    }
            	    cnt3++;
            	} while (true);

            	loop3:
            		;	// Stops C# compiler whining that label 'loop3' has no statements


            }

        }
        finally 
    	{
        }
    }
    // $ANTLR end "Number"

    // $ANTLR start "Int"
    public void mInt() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = Int;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Compiler\\Grammar\\Apl\\AplusLexer.g:178:2: ( ( '\\u00A2' )? Number )
            // Compiler\\Grammar\\Apl\\AplusLexer.g:178:4: ( '\\u00A2' )? Number
            {
            	// Compiler\\Grammar\\Apl\\AplusLexer.g:178:4: ( '\\u00A2' )?
            	int alt4 = 2;
            	int LA4_0 = input.LA(1);

            	if ( (LA4_0 == '\u00A2') )
            	{
            	    alt4 = 1;
            	}
            	switch (alt4) 
            	{
            	    case 1 :
            	        // Compiler\\Grammar\\Apl\\AplusLexer.g:178:4: '\\u00A2'
            	        {
            	        	Match('\u00A2'); 

            	        }
            	        break;

            	}

            	mNumber(); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "Int"

    // $ANTLR start "Exponent"
    public void mExponent() // throws RecognitionException [2]
    {
    		try
    		{
            // Compiler\\Grammar\\Apl\\AplusLexer.g:182:2: ( ( 'e' | 'E' ) ( '-' | '+' )? Number )
            // Compiler\\Grammar\\Apl\\AplusLexer.g:182:4: ( 'e' | 'E' ) ( '-' | '+' )? Number
            {
            	if ( input.LA(1) == 'E' || input.LA(1) == 'e' ) 
            	{
            	    input.Consume();

            	}
            	else 
            	{
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    Recover(mse);
            	    throw mse;}

            	// Compiler\\Grammar\\Apl\\AplusLexer.g:182:14: ( '-' | '+' )?
            	int alt5 = 2;
            	int LA5_0 = input.LA(1);

            	if ( (LA5_0 == '+' || LA5_0 == '-') )
            	{
            	    alt5 = 1;
            	}
            	switch (alt5) 
            	{
            	    case 1 :
            	        // Compiler\\Grammar\\Apl\\AplusLexer.g:
            	        {
            	        	if ( input.LA(1) == '+' || input.LA(1) == '-' ) 
            	        	{
            	        	    input.Consume();

            	        	}
            	        	else 
            	        	{
            	        	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	        	    Recover(mse);
            	        	    throw mse;}


            	        }
            	        break;

            	}

            	mNumber(); 

            }

        }
        finally 
    	{
        }
    }
    // $ANTLR end "Exponent"

    // $ANTLR start "Float"
    public void mFloat() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = Float;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Compiler\\Grammar\\Apl\\AplusLexer.g:186:2: ( ( '\\u00A2' )? Number Exponent | ( '\\u00A2' )? '.' Number ( Exponent )? | ( '\\u00A2' )? Number '.' ( Number )? ( Exponent )? )
            int alt12 = 3;
            alt12 = dfa12.Predict(input);
            switch (alt12) 
            {
                case 1 :
                    // Compiler\\Grammar\\Apl\\AplusLexer.g:186:4: ( '\\u00A2' )? Number Exponent
                    {
                    	// Compiler\\Grammar\\Apl\\AplusLexer.g:186:4: ( '\\u00A2' )?
                    	int alt6 = 2;
                    	int LA6_0 = input.LA(1);

                    	if ( (LA6_0 == '\u00A2') )
                    	{
                    	    alt6 = 1;
                    	}
                    	switch (alt6) 
                    	{
                    	    case 1 :
                    	        // Compiler\\Grammar\\Apl\\AplusLexer.g:186:4: '\\u00A2'
                    	        {
                    	        	Match('\u00A2'); 

                    	        }
                    	        break;

                    	}

                    	mNumber(); 
                    	mExponent(); 

                    }
                    break;
                case 2 :
                    // Compiler\\Grammar\\Apl\\AplusLexer.g:187:4: ( '\\u00A2' )? '.' Number ( Exponent )?
                    {
                    	// Compiler\\Grammar\\Apl\\AplusLexer.g:187:4: ( '\\u00A2' )?
                    	int alt7 = 2;
                    	int LA7_0 = input.LA(1);

                    	if ( (LA7_0 == '\u00A2') )
                    	{
                    	    alt7 = 1;
                    	}
                    	switch (alt7) 
                    	{
                    	    case 1 :
                    	        // Compiler\\Grammar\\Apl\\AplusLexer.g:187:4: '\\u00A2'
                    	        {
                    	        	Match('\u00A2'); 

                    	        }
                    	        break;

                    	}

                    	Match('.'); 
                    	mNumber(); 
                    	// Compiler\\Grammar\\Apl\\AplusLexer.g:187:25: ( Exponent )?
                    	int alt8 = 2;
                    	int LA8_0 = input.LA(1);

                    	if ( (LA8_0 == 'E' || LA8_0 == 'e') )
                    	{
                    	    alt8 = 1;
                    	}
                    	switch (alt8) 
                    	{
                    	    case 1 :
                    	        // Compiler\\Grammar\\Apl\\AplusLexer.g:187:25: Exponent
                    	        {
                    	        	mExponent(); 

                    	        }
                    	        break;

                    	}


                    }
                    break;
                case 3 :
                    // Compiler\\Grammar\\Apl\\AplusLexer.g:188:4: ( '\\u00A2' )? Number '.' ( Number )? ( Exponent )?
                    {
                    	// Compiler\\Grammar\\Apl\\AplusLexer.g:188:4: ( '\\u00A2' )?
                    	int alt9 = 2;
                    	int LA9_0 = input.LA(1);

                    	if ( (LA9_0 == '\u00A2') )
                    	{
                    	    alt9 = 1;
                    	}
                    	switch (alt9) 
                    	{
                    	    case 1 :
                    	        // Compiler\\Grammar\\Apl\\AplusLexer.g:188:4: '\\u00A2'
                    	        {
                    	        	Match('\u00A2'); 

                    	        }
                    	        break;

                    	}

                    	mNumber(); 
                    	Match('.'); 
                    	// Compiler\\Grammar\\Apl\\AplusLexer.g:188:25: ( Number )?
                    	int alt10 = 2;
                    	int LA10_0 = input.LA(1);

                    	if ( ((LA10_0 >= '0' && LA10_0 <= '9')) )
                    	{
                    	    alt10 = 1;
                    	}
                    	switch (alt10) 
                    	{
                    	    case 1 :
                    	        // Compiler\\Grammar\\Apl\\AplusLexer.g:188:25: Number
                    	        {
                    	        	mNumber(); 

                    	        }
                    	        break;

                    	}

                    	// Compiler\\Grammar\\Apl\\AplusLexer.g:188:33: ( Exponent )?
                    	int alt11 = 2;
                    	int LA11_0 = input.LA(1);

                    	if ( (LA11_0 == 'E' || LA11_0 == 'e') )
                    	{
                    	    alt11 = 1;
                    	}
                    	switch (alt11) 
                    	{
                    	    case 1 :
                    	        // Compiler\\Grammar\\Apl\\AplusLexer.g:188:33: Exponent
                    	        {
                    	        	mExponent(); 

                    	        }
                    	        break;

                    	}


                    }
                    break;

            }
            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "Float"

    // $ANTLR start "Inf"
    public void mInf() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = Inf;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Compiler\\Grammar\\Apl\\AplusLexer.g:192:2: ( ( '\\u00A2' )? 'Inf' )
            // Compiler\\Grammar\\Apl\\AplusLexer.g:192:4: ( '\\u00A2' )? 'Inf'
            {
            	// Compiler\\Grammar\\Apl\\AplusLexer.g:192:4: ( '\\u00A2' )?
            	int alt13 = 2;
            	int LA13_0 = input.LA(1);

            	if ( (LA13_0 == '\u00A2') )
            	{
            	    alt13 = 1;
            	}
            	switch (alt13) 
            	{
            	    case 1 :
            	        // Compiler\\Grammar\\Apl\\AplusLexer.g:192:4: '\\u00A2'
            	        {
            	        	Match('\u00A2'); 

            	        }
            	        break;

            	}

            	Match("Inf"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "Inf"

    // $ANTLR start "SQ"
    public void mSQ() // throws RecognitionException [2]
    {
    		try
    		{
            // Compiler\\Grammar\\Apl\\AplusLexer.g:195:12: ( '\\'' )
            // Compiler\\Grammar\\Apl\\AplusLexer.g:195:14: '\\''
            {
            	Match('\''); 

            }

        }
        finally 
    	{
        }
    }
    // $ANTLR end "SQ"

    // $ANTLR start "DQ"
    public void mDQ() // throws RecognitionException [2]
    {
    		try
    		{
            // Compiler\\Grammar\\Apl\\AplusLexer.g:197:12: ( '\"' )
            // Compiler\\Grammar\\Apl\\AplusLexer.g:197:14: '\"'
            {
            	Match('\"'); 

            }

        }
        finally 
    	{
        }
    }
    // $ANTLR end "DQ"

    // $ANTLR start "Backslash"
    public void mBackslash() // throws RecognitionException [2]
    {
    		try
    		{
            // Compiler\\Grammar\\Apl\\AplusLexer.g:199:19: ( '\\\\' )
            // Compiler\\Grammar\\Apl\\AplusLexer.g:199:21: '\\\\'
            {
            	Match('\\'); 

            }

        }
        finally 
    	{
        }
    }
    // $ANTLR end "Backslash"

    // $ANTLR start "CharachterConstantSQ"
    public void mCharachterConstantSQ() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = CharachterConstantSQ;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Compiler\\Grammar\\Apl\\AplusLexer.g:203:2: ( SQ ( SQ SQ | ( 'R' | ~ SQ ) )* SQ )
            // Compiler\\Grammar\\Apl\\AplusLexer.g:203:4: SQ ( SQ SQ | ( 'R' | ~ SQ ) )* SQ
            {
            	mSQ(); 
            	// Compiler\\Grammar\\Apl\\AplusLexer.g:203:7: ( SQ SQ | ( 'R' | ~ SQ ) )*
            	do 
            	{
            	    int alt14 = 3;
            	    int LA14_0 = input.LA(1);

            	    if ( (LA14_0 == '\'') )
            	    {
            	        int LA14_1 = input.LA(2);

            	        if ( (LA14_1 == '\'') )
            	        {
            	            alt14 = 1;
            	        }


            	    }
            	    else if ( ((LA14_0 >= '\u0000' && LA14_0 <= '&') || (LA14_0 >= '(' && LA14_0 <= '\uFFFF')) )
            	    {
            	        alt14 = 2;
            	    }


            	    switch (alt14) 
            		{
            			case 1 :
            			    // Compiler\\Grammar\\Apl\\AplusLexer.g:203:9: SQ SQ
            			    {
            			    	mSQ(); 
            			    	mSQ(); 

            			    }
            			    break;
            			case 2 :
            			    // Compiler\\Grammar\\Apl\\AplusLexer.g:203:17: ( 'R' | ~ SQ )
            			    {
            			    	if ( (input.LA(1) >= '\u0000' && input.LA(1) <= '&') || (input.LA(1) >= '(' && input.LA(1) <= '\uFFFF') ) 
            			    	{
            			    	    input.Consume();

            			    	}
            			    	else 
            			    	{
            			    	    MismatchedSetException mse = new MismatchedSetException(null,input);
            			    	    Recover(mse);
            			    	    throw mse;}


            			    }
            			    break;

            			default:
            			    goto loop14;
            	    }
            	} while (true);

            	loop14:
            		;	// Stops C# compiler whining that label 'loop14' has no statements

            	mSQ(); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "CharachterConstantSQ"

    // $ANTLR start "CharachterConstantDQ"
    public void mCharachterConstantDQ() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = CharachterConstantDQ;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Compiler\\Grammar\\Apl\\AplusLexer.g:208:2: ( DQ ( 'S' | ~ DQ )* DQ )
            // Compiler\\Grammar\\Apl\\AplusLexer.g:208:4: DQ ( 'S' | ~ DQ )* DQ
            {
            	mDQ(); 
            	// Compiler\\Grammar\\Apl\\AplusLexer.g:208:7: ( 'S' | ~ DQ )*
            	do 
            	{
            	    int alt15 = 2;
            	    int LA15_0 = input.LA(1);

            	    if ( ((LA15_0 >= '\u0000' && LA15_0 <= '!') || (LA15_0 >= '#' && LA15_0 <= '\uFFFF')) )
            	    {
            	        alt15 = 1;
            	    }


            	    switch (alt15) 
            		{
            			case 1 :
            			    // Compiler\\Grammar\\Apl\\AplusLexer.g:
            			    {
            			    	if ( (input.LA(1) >= '\u0000' && input.LA(1) <= '!') || (input.LA(1) >= '#' && input.LA(1) <= '\uFFFF') ) 
            			    	{
            			    	    input.Consume();

            			    	}
            			    	else 
            			    	{
            			    	    MismatchedSetException mse = new MismatchedSetException(null,input);
            			    	    Recover(mse);
            			    	    throw mse;}


            			    }
            			    break;

            			default:
            			    goto loop15;
            	    }
            	} while (true);

            	loop15:
            		;	// Stops C# compiler whining that label 'loop15' has no statements

            	mDQ(); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "CharachterConstantDQ"

    // $ANTLR start "Alphabetic"
    public void mAlphabetic() // throws RecognitionException [2]
    {
    		try
    		{
            // Compiler\\Grammar\\Apl\\AplusLexer.g:212:2: ( ( 'a' .. 'z' | 'A' .. 'Z' ) )
            // Compiler\\Grammar\\Apl\\AplusLexer.g:212:4: ( 'a' .. 'z' | 'A' .. 'Z' )
            {
            	if ( (input.LA(1) >= 'A' && input.LA(1) <= 'Z') || (input.LA(1) >= 'a' && input.LA(1) <= 'z') ) 
            	{
            	    input.Consume();

            	}
            	else 
            	{
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    Recover(mse);
            	    throw mse;}


            }

        }
        finally 
    	{
        }
    }
    // $ANTLR end "Alphabetic"

    // $ANTLR start "Alphanumeric"
    public void mAlphanumeric() // throws RecognitionException [2]
    {
    		try
    		{
            // Compiler\\Grammar\\Apl\\AplusLexer.g:216:2: ( ( Alphabetic | Digit ) )
            // Compiler\\Grammar\\Apl\\AplusLexer.g:216:4: ( Alphabetic | Digit )
            {
            	if ( (input.LA(1) >= '0' && input.LA(1) <= '9') || (input.LA(1) >= 'A' && input.LA(1) <= 'Z') || (input.LA(1) >= 'a' && input.LA(1) <= 'z') ) 
            	{
            	    input.Consume();

            	}
            	else 
            	{
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    Recover(mse);
            	    throw mse;}


            }

        }
        finally 
    	{
        }
    }
    // $ANTLR end "Alphanumeric"

    // $ANTLR start "SymbolConstant"
    public void mSymbolConstant() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = SymbolConstant;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Compiler\\Grammar\\Apl\\AplusLexer.g:220:2: ( '`' ( Alphanumeric | '_' | '.' )* )
            // Compiler\\Grammar\\Apl\\AplusLexer.g:220:4: '`' ( Alphanumeric | '_' | '.' )*
            {
            	Match('`'); 
            	// Compiler\\Grammar\\Apl\\AplusLexer.g:220:9: ( Alphanumeric | '_' | '.' )*
            	do 
            	{
            	    int alt16 = 2;
            	    int LA16_0 = input.LA(1);

            	    if ( (LA16_0 == '.' || (LA16_0 >= '0' && LA16_0 <= '9') || (LA16_0 >= 'A' && LA16_0 <= 'Z') || LA16_0 == '_' || (LA16_0 >= 'a' && LA16_0 <= 'z')) )
            	    {
            	        alt16 = 1;
            	    }


            	    switch (alt16) 
            		{
            			case 1 :
            			    // Compiler\\Grammar\\Apl\\AplusLexer.g:
            			    {
            			    	if ( input.LA(1) == '.' || (input.LA(1) >= '0' && input.LA(1) <= '9') || (input.LA(1) >= 'A' && input.LA(1) <= 'Z') || input.LA(1) == '_' || (input.LA(1) >= 'a' && input.LA(1) <= 'z') ) 
            			    	{
            			    	    input.Consume();

            			    	}
            			    	else 
            			    	{
            			    	    MismatchedSetException mse = new MismatchedSetException(null,input);
            			    	    Recover(mse);
            			    	    throw mse;}


            			    }
            			    break;

            			default:
            			    goto loop16;
            	    }
            	} while (true);

            	loop16:
            		;	// Stops C# compiler whining that label 'loop16' has no statements


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "SymbolConstant"

    // $ANTLR start "UnqualifiedName"
    public void mUnqualifiedName() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = UnqualifiedName;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Compiler\\Grammar\\Apl\\AplusLexer.g:224:2: ( Alphabetic ( Alphanumeric | '_' )* )
            // Compiler\\Grammar\\Apl\\AplusLexer.g:224:4: Alphabetic ( Alphanumeric | '_' )*
            {
            	mAlphabetic(); 
            	// Compiler\\Grammar\\Apl\\AplusLexer.g:224:15: ( Alphanumeric | '_' )*
            	do 
            	{
            	    int alt17 = 2;
            	    int LA17_0 = input.LA(1);

            	    if ( ((LA17_0 >= '0' && LA17_0 <= '9') || (LA17_0 >= 'A' && LA17_0 <= 'Z') || LA17_0 == '_' || (LA17_0 >= 'a' && LA17_0 <= 'z')) )
            	    {
            	        alt17 = 1;
            	    }


            	    switch (alt17) 
            		{
            			case 1 :
            			    // Compiler\\Grammar\\Apl\\AplusLexer.g:
            			    {
            			    	if ( (input.LA(1) >= '0' && input.LA(1) <= '9') || (input.LA(1) >= 'A' && input.LA(1) <= 'Z') || input.LA(1) == '_' || (input.LA(1) >= 'a' && input.LA(1) <= 'z') ) 
            			    	{
            			    	    input.Consume();

            			    	}
            			    	else 
            			    	{
            			    	    MismatchedSetException mse = new MismatchedSetException(null,input);
            			    	    Recover(mse);
            			    	    throw mse;}


            			    }
            			    break;

            			default:
            			    goto loop17;
            	    }
            	} while (true);

            	loop17:
            		;	// Stops C# compiler whining that label 'loop17' has no statements


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "UnqualifiedName"

    // $ANTLR start "QualifiedName"
    public void mQualifiedName() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = QualifiedName;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Compiler\\Grammar\\Apl\\AplusLexer.g:229:2: ( ( UnqualifiedName '.' )+ UnqualifiedName | '.' UnqualifiedName | UnqualifiedName )
            int alt19 = 3;
            alt19 = dfa19.Predict(input);
            switch (alt19) 
            {
                case 1 :
                    // Compiler\\Grammar\\Apl\\AplusLexer.g:229:4: ( UnqualifiedName '.' )+ UnqualifiedName
                    {
                    	// Compiler\\Grammar\\Apl\\AplusLexer.g:229:4: ( UnqualifiedName '.' )+
                    	int cnt18 = 0;
                    	do 
                    	{
                    	    int alt18 = 2;
                    	    alt18 = dfa18.Predict(input);
                    	    switch (alt18) 
                    		{
                    			case 1 :
                    			    // Compiler\\Grammar\\Apl\\AplusLexer.g:229:5: UnqualifiedName '.'
                    			    {
                    			    	mUnqualifiedName(); 
                    			    	Match('.'); 

                    			    }
                    			    break;

                    			default:
                    			    if ( cnt18 >= 1 ) goto loop18;
                    		            EarlyExitException eee18 =
                    		                new EarlyExitException(18, input);
                    		            throw eee18;
                    	    }
                    	    cnt18++;
                    	} while (true);

                    	loop18:
                    		;	// Stops C# compiler whining that label 'loop18' has no statements

                    	mUnqualifiedName(); 

                    }
                    break;
                case 2 :
                    // Compiler\\Grammar\\Apl\\AplusLexer.g:230:4: '.' UnqualifiedName
                    {
                    	Match('.'); 
                    	mUnqualifiedName(); 

                    }
                    break;
                case 3 :
                    // Compiler\\Grammar\\Apl\\AplusLexer.g:231:6: UnqualifiedName
                    {
                    	mUnqualifiedName(); 

                    }
                    break;

            }
            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "QualifiedName"

    // $ANTLR start "SystemName"
    public void mSystemName() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = SystemName;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Compiler\\Grammar\\Apl\\AplusLexer.g:235:2: ( '_' UnqualifiedName )
            // Compiler\\Grammar\\Apl\\AplusLexer.g:235:4: '_' UnqualifiedName
            {
            	Match('_'); 
            	mUnqualifiedName(); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "SystemName"

    // $ANTLR start "SystemCommandName"
    public void mSystemCommandName() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = SystemCommandName;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Compiler\\Grammar\\Apl\\AplusLexer.g:240:2: ( '$' (~ ( '\\n' | '\\r' ) )* )
            // Compiler\\Grammar\\Apl\\AplusLexer.g:240:4: '$' (~ ( '\\n' | '\\r' ) )*
            {
            	Match('$'); 
            	// Compiler\\Grammar\\Apl\\AplusLexer.g:240:8: (~ ( '\\n' | '\\r' ) )*
            	do 
            	{
            	    int alt20 = 2;
            	    int LA20_0 = input.LA(1);

            	    if ( ((LA20_0 >= '\u0000' && LA20_0 <= '\t') || (LA20_0 >= '\u000B' && LA20_0 <= '\f') || (LA20_0 >= '\u000E' && LA20_0 <= '\uFFFF')) )
            	    {
            	        alt20 = 1;
            	    }


            	    switch (alt20) 
            		{
            			case 1 :
            			    // Compiler\\Grammar\\Apl\\AplusLexer.g:240:8: ~ ( '\\n' | '\\r' )
            			    {
            			    	if ( (input.LA(1) >= '\u0000' && input.LA(1) <= '\t') || (input.LA(1) >= '\u000B' && input.LA(1) <= '\f') || (input.LA(1) >= '\u000E' && input.LA(1) <= '\uFFFF') ) 
            			    	{
            			    	    input.Consume();

            			    	}
            			    	else 
            			    	{
            			    	    MismatchedSetException mse = new MismatchedSetException(null,input);
            			    	    Recover(mse);
            			    	    throw mse;}


            			    }
            			    break;

            			default:
            			    goto loop20;
            	    }
            	} while (true);

            	loop20:
            		;	// Stops C# compiler whining that label 'loop20' has no statements


            			// split the line to 2 parts: command and argument
            			// cut at the first space character
            			string[] parts = Text.Split(new char[]{' '}, 2);

            			// Emit the system command token
            			Emit(new CommonToken(SystemCommand, parts[0]));

            			// Emit the argument of the system command if there is any
            			if(parts.Length > 1)
            			{
            				Emit(new CommonToken(SystemCommandArgument, parts[1].Trim()));
            			}
            		

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "SystemCommandName"

    override public void mTokens() // throws RecognitionException 
    {
        // Compiler\\Grammar\\Apl\\AplusLexer.g:1:8: ( If | Else | Do | While | Case | RAdd | RAnd | RMax | RMin | RMultiply | ROr | SAdd | SAnd | SMax | SMin | SMultiply | SOr | AbsoluteValue | Ceiling | Count | DefaultFormat | Depth | Disclose | Enclose | Execute | Exponential | Floor | GradeDown | GradeUp | Identity | Interval | ItemRavel | MapIn | MatrixInverse | NaturalLog | Negate | Not | Null | Pack | PartitionCount | PiTimes | Print | Rake | Ravel | Raze | Reciprocal | Reverse | Roll | Right | SeparateSymbols | Shape | Sign | Signal | Stop | Transpose | Unpack | Value | Equal | Expand | GTE | LTE | NotEqual | Or | Replicate | Result | IPAddMultiply | IPMaxAdd | IPMinAdd | OPAdd | OPDivide | OPEqual | OPGT | OPGTE | OPLT | OPLTE | OPMax | OPMin | OPMultiply | OPNotEqual | OPResidue | OPSubstract | OPPower | BWNot | BWAnd | BWOr | BWLT | BWLTE | BWGT | BWGTE | BWEqual | BWNotEqual | StackReference | LP | RP | LSBracket | RSBracket | SemiColon | Colon | Each | Rank | Blank | LSB | RSB | Comment | CR | NewLine | Int | Float | Inf | CharachterConstantSQ | CharachterConstantDQ | SymbolConstant | UnqualifiedName | QualifiedName | SystemName | SystemCommandName )
        int alt21 = 116;
        alt21 = dfa21.Predict(input);
        switch (alt21) 
        {
            case 1 :
                // Compiler\\Grammar\\Apl\\AplusLexer.g:1:10: If
                {
                	mIf(); 

                }
                break;
            case 2 :
                // Compiler\\Grammar\\Apl\\AplusLexer.g:1:13: Else
                {
                	mElse(); 

                }
                break;
            case 3 :
                // Compiler\\Grammar\\Apl\\AplusLexer.g:1:18: Do
                {
                	mDo(); 

                }
                break;
            case 4 :
                // Compiler\\Grammar\\Apl\\AplusLexer.g:1:21: While
                {
                	mWhile(); 

                }
                break;
            case 5 :
                // Compiler\\Grammar\\Apl\\AplusLexer.g:1:27: Case
                {
                	mCase(); 

                }
                break;
            case 6 :
                // Compiler\\Grammar\\Apl\\AplusLexer.g:1:32: RAdd
                {
                	mRAdd(); 

                }
                break;
            case 7 :
                // Compiler\\Grammar\\Apl\\AplusLexer.g:1:37: RAnd
                {
                	mRAnd(); 

                }
                break;
            case 8 :
                // Compiler\\Grammar\\Apl\\AplusLexer.g:1:42: RMax
                {
                	mRMax(); 

                }
                break;
            case 9 :
                // Compiler\\Grammar\\Apl\\AplusLexer.g:1:47: RMin
                {
                	mRMin(); 

                }
                break;
            case 10 :
                // Compiler\\Grammar\\Apl\\AplusLexer.g:1:52: RMultiply
                {
                	mRMultiply(); 

                }
                break;
            case 11 :
                // Compiler\\Grammar\\Apl\\AplusLexer.g:1:62: ROr
                {
                	mROr(); 

                }
                break;
            case 12 :
                // Compiler\\Grammar\\Apl\\AplusLexer.g:1:66: SAdd
                {
                	mSAdd(); 

                }
                break;
            case 13 :
                // Compiler\\Grammar\\Apl\\AplusLexer.g:1:71: SAnd
                {
                	mSAnd(); 

                }
                break;
            case 14 :
                // Compiler\\Grammar\\Apl\\AplusLexer.g:1:76: SMax
                {
                	mSMax(); 

                }
                break;
            case 15 :
                // Compiler\\Grammar\\Apl\\AplusLexer.g:1:81: SMin
                {
                	mSMin(); 

                }
                break;
            case 16 :
                // Compiler\\Grammar\\Apl\\AplusLexer.g:1:86: SMultiply
                {
                	mSMultiply(); 

                }
                break;
            case 17 :
                // Compiler\\Grammar\\Apl\\AplusLexer.g:1:96: SOr
                {
                	mSOr(); 

                }
                break;
            case 18 :
                // Compiler\\Grammar\\Apl\\AplusLexer.g:1:100: AbsoluteValue
                {
                	mAbsoluteValue(); 

                }
                break;
            case 19 :
                // Compiler\\Grammar\\Apl\\AplusLexer.g:1:114: Ceiling
                {
                	mCeiling(); 

                }
                break;
            case 20 :
                // Compiler\\Grammar\\Apl\\AplusLexer.g:1:122: Count
                {
                	mCount(); 

                }
                break;
            case 21 :
                // Compiler\\Grammar\\Apl\\AplusLexer.g:1:128: DefaultFormat
                {
                	mDefaultFormat(); 

                }
                break;
            case 22 :
                // Compiler\\Grammar\\Apl\\AplusLexer.g:1:142: Depth
                {
                	mDepth(); 

                }
                break;
            case 23 :
                // Compiler\\Grammar\\Apl\\AplusLexer.g:1:148: Disclose
                {
                	mDisclose(); 

                }
                break;
            case 24 :
                // Compiler\\Grammar\\Apl\\AplusLexer.g:1:157: Enclose
                {
                	mEnclose(); 

                }
                break;
            case 25 :
                // Compiler\\Grammar\\Apl\\AplusLexer.g:1:165: Execute
                {
                	mExecute(); 

                }
                break;
            case 26 :
                // Compiler\\Grammar\\Apl\\AplusLexer.g:1:173: Exponential
                {
                	mExponential(); 

                }
                break;
            case 27 :
                // Compiler\\Grammar\\Apl\\AplusLexer.g:1:185: Floor
                {
                	mFloor(); 

                }
                break;
            case 28 :
                // Compiler\\Grammar\\Apl\\AplusLexer.g:1:191: GradeDown
                {
                	mGradeDown(); 

                }
                break;
            case 29 :
                // Compiler\\Grammar\\Apl\\AplusLexer.g:1:201: GradeUp
                {
                	mGradeUp(); 

                }
                break;
            case 30 :
                // Compiler\\Grammar\\Apl\\AplusLexer.g:1:209: Identity
                {
                	mIdentity(); 

                }
                break;
            case 31 :
                // Compiler\\Grammar\\Apl\\AplusLexer.g:1:218: Interval
                {
                	mInterval(); 

                }
                break;
            case 32 :
                // Compiler\\Grammar\\Apl\\AplusLexer.g:1:227: ItemRavel
                {
                	mItemRavel(); 

                }
                break;
            case 33 :
                // Compiler\\Grammar\\Apl\\AplusLexer.g:1:237: MapIn
                {
                	mMapIn(); 

                }
                break;
            case 34 :
                // Compiler\\Grammar\\Apl\\AplusLexer.g:1:243: MatrixInverse
                {
                	mMatrixInverse(); 

                }
                break;
            case 35 :
                // Compiler\\Grammar\\Apl\\AplusLexer.g:1:257: NaturalLog
                {
                	mNaturalLog(); 

                }
                break;
            case 36 :
                // Compiler\\Grammar\\Apl\\AplusLexer.g:1:268: Negate
                {
                	mNegate(); 

                }
                break;
            case 37 :
                // Compiler\\Grammar\\Apl\\AplusLexer.g:1:275: Not
                {
                	mNot(); 

                }
                break;
            case 38 :
                // Compiler\\Grammar\\Apl\\AplusLexer.g:1:279: Null
                {
                	mNull(); 

                }
                break;
            case 39 :
                // Compiler\\Grammar\\Apl\\AplusLexer.g:1:284: Pack
                {
                	mPack(); 

                }
                break;
            case 40 :
                // Compiler\\Grammar\\Apl\\AplusLexer.g:1:289: PartitionCount
                {
                	mPartitionCount(); 

                }
                break;
            case 41 :
                // Compiler\\Grammar\\Apl\\AplusLexer.g:1:304: PiTimes
                {
                	mPiTimes(); 

                }
                break;
            case 42 :
                // Compiler\\Grammar\\Apl\\AplusLexer.g:1:312: Print
                {
                	mPrint(); 

                }
                break;
            case 43 :
                // Compiler\\Grammar\\Apl\\AplusLexer.g:1:318: Rake
                {
                	mRake(); 

                }
                break;
            case 44 :
                // Compiler\\Grammar\\Apl\\AplusLexer.g:1:323: Ravel
                {
                	mRavel(); 

                }
                break;
            case 45 :
                // Compiler\\Grammar\\Apl\\AplusLexer.g:1:329: Raze
                {
                	mRaze(); 

                }
                break;
            case 46 :
                // Compiler\\Grammar\\Apl\\AplusLexer.g:1:334: Reciprocal
                {
                	mReciprocal(); 

                }
                break;
            case 47 :
                // Compiler\\Grammar\\Apl\\AplusLexer.g:1:345: Reverse
                {
                	mReverse(); 

                }
                break;
            case 48 :
                // Compiler\\Grammar\\Apl\\AplusLexer.g:1:353: Roll
                {
                	mRoll(); 

                }
                break;
            case 49 :
                // Compiler\\Grammar\\Apl\\AplusLexer.g:1:358: Right
                {
                	mRight(); 

                }
                break;
            case 50 :
                // Compiler\\Grammar\\Apl\\AplusLexer.g:1:364: SeparateSymbols
                {
                	mSeparateSymbols(); 

                }
                break;
            case 51 :
                // Compiler\\Grammar\\Apl\\AplusLexer.g:1:380: Shape
                {
                	mShape(); 

                }
                break;
            case 52 :
                // Compiler\\Grammar\\Apl\\AplusLexer.g:1:386: Sign
                {
                	mSign(); 

                }
                break;
            case 53 :
                // Compiler\\Grammar\\Apl\\AplusLexer.g:1:391: Signal
                {
                	mSignal(); 

                }
                break;
            case 54 :
                // Compiler\\Grammar\\Apl\\AplusLexer.g:1:398: Stop
                {
                	mStop(); 

                }
                break;
            case 55 :
                // Compiler\\Grammar\\Apl\\AplusLexer.g:1:403: Transpose
                {
                	mTranspose(); 

                }
                break;
            case 56 :
                // Compiler\\Grammar\\Apl\\AplusLexer.g:1:413: Unpack
                {
                	mUnpack(); 

                }
                break;
            case 57 :
                // Compiler\\Grammar\\Apl\\AplusLexer.g:1:420: Value
                {
                	mValue(); 

                }
                break;
            case 58 :
                // Compiler\\Grammar\\Apl\\AplusLexer.g:1:426: Equal
                {
                	mEqual(); 

                }
                break;
            case 59 :
                // Compiler\\Grammar\\Apl\\AplusLexer.g:1:432: Expand
                {
                	mExpand(); 

                }
                break;
            case 60 :
                // Compiler\\Grammar\\Apl\\AplusLexer.g:1:439: GTE
                {
                	mGTE(); 

                }
                break;
            case 61 :
                // Compiler\\Grammar\\Apl\\AplusLexer.g:1:443: LTE
                {
                	mLTE(); 

                }
                break;
            case 62 :
                // Compiler\\Grammar\\Apl\\AplusLexer.g:1:447: NotEqual
                {
                	mNotEqual(); 

                }
                break;
            case 63 :
                // Compiler\\Grammar\\Apl\\AplusLexer.g:1:456: Or
                {
                	mOr(); 

                }
                break;
            case 64 :
                // Compiler\\Grammar\\Apl\\AplusLexer.g:1:459: Replicate
                {
                	mReplicate(); 

                }
                break;
            case 65 :
                // Compiler\\Grammar\\Apl\\AplusLexer.g:1:469: Result
                {
                	mResult(); 

                }
                break;
            case 66 :
                // Compiler\\Grammar\\Apl\\AplusLexer.g:1:476: IPAddMultiply
                {
                	mIPAddMultiply(); 

                }
                break;
            case 67 :
                // Compiler\\Grammar\\Apl\\AplusLexer.g:1:490: IPMaxAdd
                {
                	mIPMaxAdd(); 

                }
                break;
            case 68 :
                // Compiler\\Grammar\\Apl\\AplusLexer.g:1:499: IPMinAdd
                {
                	mIPMinAdd(); 

                }
                break;
            case 69 :
                // Compiler\\Grammar\\Apl\\AplusLexer.g:1:508: OPAdd
                {
                	mOPAdd(); 

                }
                break;
            case 70 :
                // Compiler\\Grammar\\Apl\\AplusLexer.g:1:514: OPDivide
                {
                	mOPDivide(); 

                }
                break;
            case 71 :
                // Compiler\\Grammar\\Apl\\AplusLexer.g:1:523: OPEqual
                {
                	mOPEqual(); 

                }
                break;
            case 72 :
                // Compiler\\Grammar\\Apl\\AplusLexer.g:1:531: OPGT
                {
                	mOPGT(); 

                }
                break;
            case 73 :
                // Compiler\\Grammar\\Apl\\AplusLexer.g:1:536: OPGTE
                {
                	mOPGTE(); 

                }
                break;
            case 74 :
                // Compiler\\Grammar\\Apl\\AplusLexer.g:1:542: OPLT
                {
                	mOPLT(); 

                }
                break;
            case 75 :
                // Compiler\\Grammar\\Apl\\AplusLexer.g:1:547: OPLTE
                {
                	mOPLTE(); 

                }
                break;
            case 76 :
                // Compiler\\Grammar\\Apl\\AplusLexer.g:1:553: OPMax
                {
                	mOPMax(); 

                }
                break;
            case 77 :
                // Compiler\\Grammar\\Apl\\AplusLexer.g:1:559: OPMin
                {
                	mOPMin(); 

                }
                break;
            case 78 :
                // Compiler\\Grammar\\Apl\\AplusLexer.g:1:565: OPMultiply
                {
                	mOPMultiply(); 

                }
                break;
            case 79 :
                // Compiler\\Grammar\\Apl\\AplusLexer.g:1:576: OPNotEqual
                {
                	mOPNotEqual(); 

                }
                break;
            case 80 :
                // Compiler\\Grammar\\Apl\\AplusLexer.g:1:587: OPResidue
                {
                	mOPResidue(); 

                }
                break;
            case 81 :
                // Compiler\\Grammar\\Apl\\AplusLexer.g:1:597: OPSubstract
                {
                	mOPSubstract(); 

                }
                break;
            case 82 :
                // Compiler\\Grammar\\Apl\\AplusLexer.g:1:609: OPPower
                {
                	mOPPower(); 

                }
                break;
            case 83 :
                // Compiler\\Grammar\\Apl\\AplusLexer.g:1:617: BWNot
                {
                	mBWNot(); 

                }
                break;
            case 84 :
                // Compiler\\Grammar\\Apl\\AplusLexer.g:1:623: BWAnd
                {
                	mBWAnd(); 

                }
                break;
            case 85 :
                // Compiler\\Grammar\\Apl\\AplusLexer.g:1:629: BWOr
                {
                	mBWOr(); 

                }
                break;
            case 86 :
                // Compiler\\Grammar\\Apl\\AplusLexer.g:1:634: BWLT
                {
                	mBWLT(); 

                }
                break;
            case 87 :
                // Compiler\\Grammar\\Apl\\AplusLexer.g:1:639: BWLTE
                {
                	mBWLTE(); 

                }
                break;
            case 88 :
                // Compiler\\Grammar\\Apl\\AplusLexer.g:1:645: BWGT
                {
                	mBWGT(); 

                }
                break;
            case 89 :
                // Compiler\\Grammar\\Apl\\AplusLexer.g:1:650: BWGTE
                {
                	mBWGTE(); 

                }
                break;
            case 90 :
                // Compiler\\Grammar\\Apl\\AplusLexer.g:1:656: BWEqual
                {
                	mBWEqual(); 

                }
                break;
            case 91 :
                // Compiler\\Grammar\\Apl\\AplusLexer.g:1:664: BWNotEqual
                {
                	mBWNotEqual(); 

                }
                break;
            case 92 :
                // Compiler\\Grammar\\Apl\\AplusLexer.g:1:675: StackReference
                {
                	mStackReference(); 

                }
                break;
            case 93 :
                // Compiler\\Grammar\\Apl\\AplusLexer.g:1:690: LP
                {
                	mLP(); 

                }
                break;
            case 94 :
                // Compiler\\Grammar\\Apl\\AplusLexer.g:1:693: RP
                {
                	mRP(); 

                }
                break;
            case 95 :
                // Compiler\\Grammar\\Apl\\AplusLexer.g:1:696: LSBracket
                {
                	mLSBracket(); 

                }
                break;
            case 96 :
                // Compiler\\Grammar\\Apl\\AplusLexer.g:1:706: RSBracket
                {
                	mRSBracket(); 

                }
                break;
            case 97 :
                // Compiler\\Grammar\\Apl\\AplusLexer.g:1:716: SemiColon
                {
                	mSemiColon(); 

                }
                break;
            case 98 :
                // Compiler\\Grammar\\Apl\\AplusLexer.g:1:726: Colon
                {
                	mColon(); 

                }
                break;
            case 99 :
                // Compiler\\Grammar\\Apl\\AplusLexer.g:1:732: Each
                {
                	mEach(); 

                }
                break;
            case 100 :
                // Compiler\\Grammar\\Apl\\AplusLexer.g:1:737: Rank
                {
                	mRank(); 

                }
                break;
            case 101 :
                // Compiler\\Grammar\\Apl\\AplusLexer.g:1:742: Blank
                {
                	mBlank(); 

                }
                break;
            case 102 :
                // Compiler\\Grammar\\Apl\\AplusLexer.g:1:748: LSB
                {
                	mLSB(); 

                }
                break;
            case 103 :
                // Compiler\\Grammar\\Apl\\AplusLexer.g:1:752: RSB
                {
                	mRSB(); 

                }
                break;
            case 104 :
                // Compiler\\Grammar\\Apl\\AplusLexer.g:1:756: Comment
                {
                	mComment(); 

                }
                break;
            case 105 :
                // Compiler\\Grammar\\Apl\\AplusLexer.g:1:764: CR
                {
                	mCR(); 

                }
                break;
            case 106 :
                // Compiler\\Grammar\\Apl\\AplusLexer.g:1:767: NewLine
                {
                	mNewLine(); 

                }
                break;
            case 107 :
                // Compiler\\Grammar\\Apl\\AplusLexer.g:1:775: Int
                {
                	mInt(); 

                }
                break;
            case 108 :
                // Compiler\\Grammar\\Apl\\AplusLexer.g:1:779: Float
                {
                	mFloat(); 

                }
                break;
            case 109 :
                // Compiler\\Grammar\\Apl\\AplusLexer.g:1:785: Inf
                {
                	mInf(); 

                }
                break;
            case 110 :
                // Compiler\\Grammar\\Apl\\AplusLexer.g:1:789: CharachterConstantSQ
                {
                	mCharachterConstantSQ(); 

                }
                break;
            case 111 :
                // Compiler\\Grammar\\Apl\\AplusLexer.g:1:810: CharachterConstantDQ
                {
                	mCharachterConstantDQ(); 

                }
                break;
            case 112 :
                // Compiler\\Grammar\\Apl\\AplusLexer.g:1:831: SymbolConstant
                {
                	mSymbolConstant(); 

                }
                break;
            case 113 :
                // Compiler\\Grammar\\Apl\\AplusLexer.g:1:846: UnqualifiedName
                {
                	mUnqualifiedName(); 

                }
                break;
            case 114 :
                // Compiler\\Grammar\\Apl\\AplusLexer.g:1:862: QualifiedName
                {
                	mQualifiedName(); 

                }
                break;
            case 115 :
                // Compiler\\Grammar\\Apl\\AplusLexer.g:1:876: SystemName
                {
                	mSystemName(); 

                }
                break;
            case 116 :
                // Compiler\\Grammar\\Apl\\AplusLexer.g:1:887: SystemCommandName
                {
                	mSystemCommandName(); 

                }
                break;

        }

    }


    protected DFA12 dfa12;
    protected DFA19 dfa19;
    protected DFA18 dfa18;
    protected DFA21 dfa21;
	private void InitializeCyclicDFAs()
	{
	    this.dfa12 = new DFA12(this);
	    this.dfa19 = new DFA19(this);
	    this.dfa18 = new DFA18(this);
	    this.dfa21 = new DFA21(this);
	    this.dfa21.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA21_SpecialStateTransition);
	}

    const string DFA12_eotS =
        "\x06\uffff";
    const string DFA12_eofS =
        "\x06\uffff";
    const string DFA12_minS =
        "\x03\x2e\x03\uffff";
    const string DFA12_maxS =
        "\x01\u00a2\x01\x39\x01\x65\x03\uffff";
    const string DFA12_acceptS =
        "\x03\uffff\x01\x02\x01\x01\x01\x03";
    const string DFA12_specialS =
        "\x06\uffff}>";
    static readonly string[] DFA12_transitionS = {
            "\x01\x03\x01\uffff\x0a\x02\x68\uffff\x01\x01",
            "\x01\x03\x01\uffff\x0a\x02",
            "\x01\x05\x01\uffff\x0a\x02\x0b\uffff\x01\x04\x1f\uffff\x01"+
            "\x04",
            "",
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
            get { return "185:1: Float : ( ( '\\u00A2' )? Number Exponent | ( '\\u00A2' )? '.' Number ( Exponent )? | ( '\\u00A2' )? Number '.' ( Number )? ( Exponent )? );"; }
        }

    }

    const string DFA19_eotS =
        "\x01\uffff\x01\x03\x02\uffff\x01\x03\x01\uffff";
    const string DFA19_eofS =
        "\x06\uffff";
    const string DFA19_minS =
        "\x02\x2e\x02\uffff\x01\x2e\x01\uffff";
    const string DFA19_maxS =
        "\x02\x7a\x02\uffff\x01\x7a\x01\uffff";
    const string DFA19_acceptS =
        "\x02\uffff\x01\x02\x01\x03\x01\uffff\x01\x01";
    const string DFA19_specialS =
        "\x06\uffff}>";
    static readonly string[] DFA19_transitionS = {
            "\x01\x02\x12\uffff\x1a\x01\x06\uffff\x1a\x01",
            "\x01\x05\x01\uffff\x0a\x04\x07\uffff\x1a\x04\x04\uffff\x01"+
            "\x04\x01\uffff\x1a\x04",
            "",
            "",
            "\x01\x05\x01\uffff\x0a\x04\x07\uffff\x1a\x04\x04\uffff\x01"+
            "\x04\x01\uffff\x1a\x04",
            ""
    };

    static readonly short[] DFA19_eot = DFA.UnpackEncodedString(DFA19_eotS);
    static readonly short[] DFA19_eof = DFA.UnpackEncodedString(DFA19_eofS);
    static readonly char[] DFA19_min = DFA.UnpackEncodedStringToUnsignedChars(DFA19_minS);
    static readonly char[] DFA19_max = DFA.UnpackEncodedStringToUnsignedChars(DFA19_maxS);
    static readonly short[] DFA19_accept = DFA.UnpackEncodedString(DFA19_acceptS);
    static readonly short[] DFA19_special = DFA.UnpackEncodedString(DFA19_specialS);
    static readonly short[][] DFA19_transition = DFA.UnpackEncodedStringArray(DFA19_transitionS);

    protected class DFA19 : DFA
    {
        public DFA19(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 19;
            this.eot = DFA19_eot;
            this.eof = DFA19_eof;
            this.min = DFA19_min;
            this.max = DFA19_max;
            this.accept = DFA19_accept;
            this.special = DFA19_special;
            this.transition = DFA19_transition;

        }

        override public string Description
        {
            get { return "228:1: QualifiedName : ( ( UnqualifiedName '.' )+ UnqualifiedName | '.' UnqualifiedName | UnqualifiedName );"; }
        }

    }

    const string DFA18_eotS =
        "\x01\uffff\x01\x02\x01\uffff\x01\x02\x01\uffff";
    const string DFA18_eofS =
        "\x05\uffff";
    const string DFA18_minS =
        "\x01\x41\x01\x2e\x01\uffff\x01\x2e\x01\uffff";
    const string DFA18_maxS =
        "\x02\x7a\x01\uffff\x01\x7a\x01\uffff";
    const string DFA18_acceptS =
        "\x02\uffff\x01\x02\x01\uffff\x01\x01";
    const string DFA18_specialS =
        "\x05\uffff}>";
    static readonly string[] DFA18_transitionS = {
            "\x1a\x01\x06\uffff\x1a\x01",
            "\x01\x04\x01\uffff\x0a\x03\x07\uffff\x1a\x03\x04\uffff\x01"+
            "\x03\x01\uffff\x1a\x03",
            "",
            "\x01\x04\x01\uffff\x0a\x03\x07\uffff\x1a\x03\x04\uffff\x01"+
            "\x03\x01\uffff\x1a\x03",
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
            get { return "()+ loopback of 229:4: ( UnqualifiedName '.' )+"; }
        }

    }

    const string DFA21_eotS =
        "\x01\uffff\x05\x50\x01\x5a\x01\x5e\x01\x62\x01\x66\x01\x69\x01"+
        "\x6d\x04\uffff\x01\x6f\x01\x71\x0a\uffff\x01\x73\x0c\uffff\x01\x75"+
        "\x05\uffff\x01\x77\x01\uffff\x01\x79\x01\x7b\x01\x7d\x13\uffff\x01"+
        "\u0080\x01\x50\x03\uffff\x01\x50\x02\uffff\x01\u0082\x01\uffff\x01"+
        "\x50\x01\uffff\x01\x50\x01\u0084\x02\x50\x2a\uffff\x01\x50\x01\uffff"+
        "\x01\x50\x01\uffff\x02\x50\x0e\uffff\x01\x7f\x01\u0099\x01\x50\x01"+
        "\u009b\x01\uffff\x01\u009c\x02\uffff";
    const string DFA21_eofS =
        "\u009d\uffff";
    const string DFA21_minS =
        "\x01\x09\x06\x2e\x01\x2f\x02\x2e\x02\x2f\x04\uffff\x02\u00ae\x0a"+
        "\uffff\x01\u00ae\x0c\uffff\x01\x30\x05\uffff\x01\u00ae\x01\uffff"+
        "\x03\u00ae\x02\uffff\x01\x2e\x0f\uffff\x03\x2e\x03\uffff\x01\x2e"+
        "\x02\uffff\x01\x2e\x01\uffff\x01\x2e\x01\uffff\x04\x2e\x27\uffff"+
        "\x01\x2a\x02\uffff\x01\x2e\x01\uffff\x01\x2e\x01\uffff\x02\x2e\x0e"+
        "\uffff\x04\x2e\x01\uffff\x01\x2e\x02\uffff";
    const string DFA21_maxS =
        "\x01\u00fb\x05\x7a\x01\x5c\x01\u00ae\x03\x5c\x01\u00ae\x04\uffff"+
        "\x02\u00ae\x0a\uffff\x01\u00ae\x0c\uffff\x01\x7a\x05\uffff\x01\u00ae"+
        "\x01\uffff\x03\u00ae\x02\uffff\x01\x2e\x0f\uffff\x01\x49\x01\x65"+
        "\x01\x7a\x03\uffff\x01\x7a\x02\uffff\x01\x7a\x01\uffff\x01\x7a\x01"+
        "\uffff\x04\x7a\x27\uffff\x01\u00df\x02\uffff\x01\x7a\x01\uffff\x01"+
        "\x7a\x01\uffff\x02\x7a\x0e\uffff\x04\x7a\x01\uffff\x01\x7a\x02\uffff";
    const string DFA21_acceptS =
        "\x0c\uffff\x01\x12\x01\x14\x01\x15\x01\x16\x02\uffff\x01\x19\x01"+
        "\x1a\x01\x1c\x01\x1d\x01\x1f\x01\x20\x01\x21\x01\x22\x01\x23\x01"+
        "\x24\x01\uffff\x01\x26\x01\x27\x01\x28\x01\x29\x01\x2a\x01\x2b\x01"+
        "\x2c\x01\x2d\x01\x2e\x01\x2f\x01\x30\x01\x31\x01\uffff\x01\x33\x01"+
        "\x35\x01\x37\x01\x38\x01\x39\x01\uffff\x01\x3b\x03\uffff\x01\x40"+
        "\x01\x41\x01\uffff\x01\x5c\x01\x5d\x01\x5e\x01\x5f\x01\x60\x01\x61"+
        "\x01\x62\x01\x63\x01\x64\x01\x65\x01\x66\x01\x67\x01\x68\x01\x69"+
        "\x01\x6a\x03\uffff\x01\x6e\x01\x6f\x01\x70\x01\uffff\x01\x73\x01"+
        "\x74\x01\uffff\x01\x71\x01\uffff\x01\x72\x04\uffff\x01\x06\x01\x0c"+
        "\x01\x42\x01\x1e\x01\x07\x01\x0d\x01\x54\x01\x36\x01\x08\x01\x0e"+
        "\x01\x43\x01\x13\x01\x09\x01\x0f\x01\x44\x01\x1b\x01\x0a\x01\x10"+
        "\x01\x34\x01\x0b\x01\x11\x01\x55\x01\x3f\x01\x58\x01\x17\x01\x56"+
        "\x01\x18\x01\x53\x01\x25\x01\x6c\x01\x32\x01\x5a\x01\x3a\x01\x59"+
        "\x01\x3c\x01\x57\x01\x3d\x01\x5b\x01\x3e\x01\uffff\x01\x6d\x01\x6b"+
        "\x01\uffff\x01\x01\x01\uffff\x01\x03\x02\uffff\x01\x45\x01\x46\x01"+
        "\x47\x01\x48\x01\x49\x01\x4a\x01\x4b\x01\x4c\x01\x4d\x01\x4e\x01"+
        "\x4f\x01\x50\x01\x51\x01\x52\x04\uffff\x01\x02\x01\uffff\x01\x05"+
        "\x01\x04";
    const string DFA21_specialS =
        "\x01\x00\u009c\uffff}>";
    static readonly string[] DFA21_transitionS = {
            "\x01\x40\x01\x45\x02\uffff\x01\x44\x12\uffff\x01\x40\x01\x17"+
            "\x01\x4a\x01\x0d\x01\x4e\x01\x2e\x01\x37\x01\x49\x01\x38\x01"+
            "\x39\x01\x13\x01\x06\x01\x23\x01\x1b\x01\x29\x01\x34\x0a\x47"+
            "\x01\x3d\x01\x3c\x01\x11\x01\x2f\x01\x10\x01\x27\x01\x3f\x08"+
            "\x4c\x01\x48\x11\x4c\x01\x3a\x01\x30\x01\x3b\x01\x07\x01\x4d"+
            "\x01\x4b\x02\x4c\x01\x05\x01\x03\x01\x02\x03\x4c\x01\x01\x0d"+
            "\x4c\x01\x04\x03\x4c\x01\x41\x01\x0c\x01\x42\x01\x1c\x22\uffff"+
            "\x01\x3e\x01\x46\x01\uffff\x01\x32\x01\uffff\x01\x31\x01\uffff"+
            "\x01\x33\x01\x0b\x01\uffff\x01\x0a\x01\uffff\x01\x19\x0f\uffff"+
            "\x01\x0f\x04\uffff\x01\x1e\x01\uffff\x01\x09\x01\x22\x03\uffff"+
            "\x01\x16\x01\x36\x03\uffff\x01\x2d\x01\x20\x02\uffff\x01\x2a"+
            "\x01\x08\x01\uffff\x01\x21\x02\uffff\x01\x24\x01\x2b\x01\x1f"+
            "\x01\x28\x01\uffff\x01\x1d\x01\uffff\x01\x25\x01\x18\x01\uffff"+
            "\x01\x12\x01\x43\x03\uffff\x01\x14\x01\x15\x05\uffff\x01\x0e"+
            "\x01\uffff\x01\x1a\x03\uffff\x01\x2c\x02\uffff\x01\x26\x03\uffff"+
            "\x01\x35",
            "\x01\x52\x01\uffff\x0a\x51\x07\uffff\x1a\x51\x04\uffff\x01"+
            "\x51\x01\uffff\x05\x51\x01\x4f\x14\x51",
            "\x01\x52\x01\uffff\x0a\x51\x07\uffff\x1a\x51\x04\uffff\x01"+
            "\x51\x01\uffff\x0b\x51\x01\x53\x0e\x51",
            "\x01\x52\x01\uffff\x0a\x51\x07\uffff\x1a\x51\x04\uffff\x01"+
            "\x51\x01\uffff\x0e\x51\x01\x54\x0b\x51",
            "\x01\x52\x01\uffff\x0a\x51\x07\uffff\x1a\x51\x04\uffff\x01"+
            "\x51\x01\uffff\x07\x51\x01\x55\x12\x51",
            "\x01\x52\x01\uffff\x0a\x51\x07\uffff\x1a\x51\x04\uffff\x01"+
            "\x51\x01\uffff\x01\x56\x19\x51",
            "\x01\x59\x01\x57\x2c\uffff\x01\x58",
            "\x01\x5b\x2c\uffff\x01\x5c\x51\uffff\x01\x5d",
            "\x01\x61\x01\x5f\x2c\uffff\x01\x60",
            "\x01\x65\x01\x63\x2c\uffff\x01\x64",
            "\x01\x67\x2c\uffff\x01\x68",
            "\x01\x6a\x2c\uffff\x01\x6b\x51\uffff\x01\x6c",
            "",
            "",
            "",
            "",
            "\x01\x6e",
            "\x01\x70",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "\x01\x72",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "\x0a\x74\x07\uffff\x1a\x52\x06\uffff\x1a\x52",
            "",
            "",
            "",
            "",
            "",
            "\x01\x76",
            "",
            "\x01\x78",
            "\x01\x7a",
            "\x01\x7c",
            "",
            "",
            "\x01\x7e",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "\x01\x74\x01\uffff\x0a\x47\x0f\uffff\x01\x7f",
            "\x01\x74\x01\uffff\x0a\x47\x0b\uffff\x01\x74\x1f\uffff\x01"+
            "\x74",
            "\x01\x52\x01\uffff\x0a\x51\x07\uffff\x1a\x51\x04\uffff\x01"+
            "\x51\x01\uffff\x0d\x51\x01\u0081\x0c\x51",
            "",
            "",
            "",
            "\x01\x52\x01\uffff\x0a\x51\x07\uffff\x1a\x51\x04\uffff\x01"+
            "\x51\x01\uffff\x1a\x51",
            "",
            "",
            "\x01\x52\x01\uffff\x0a\x51\x07\uffff\x1a\x51\x04\uffff\x01"+
            "\x51\x01\uffff\x1a\x51",
            "",
            "\x01\x52\x01\uffff\x0a\x51\x07\uffff\x1a\x51\x04\uffff\x01"+
            "\x51\x01\uffff\x1a\x51",
            "",
            "\x01\x52\x01\uffff\x0a\x51\x07\uffff\x1a\x51\x04\uffff\x01"+
            "\x51\x01\uffff\x12\x51\x01\u0083\x07\x51",
            "\x01\x52\x01\uffff\x0a\x51\x07\uffff\x1a\x51\x04\uffff\x01"+
            "\x51\x01\uffff\x1a\x51",
            "\x01\x52\x01\uffff\x0a\x51\x07\uffff\x1a\x51\x04\uffff\x01"+
            "\x51\x01\uffff\x08\x51\x01\u0085\x11\x51",
            "\x01\x52\x01\uffff\x0a\x51\x07\uffff\x1a\x51\x04\uffff\x01"+
            "\x51\x01\uffff\x12\x51\x01\u0086\x07\x51",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "\x01\u0094\x01\u0087\x01\uffff\x01\u0093\x0e\uffff\x01\u008c"+
            "\x01\u0089\x01\u008a\x3d\uffff\x01\u0092\x27\uffff\x01\u008d"+
            "\x01\uffff\x01\u008b\x01\uffff\x01\u0091\x02\uffff\x01\u0090"+
            "\x18\uffff\x01\u008f\x0e\uffff\x01\u008e\x0b\uffff\x01\u0088",
            "",
            "",
            "\x01\x52\x01\uffff\x0a\x51\x07\uffff\x1a\x51\x04\uffff\x01"+
            "\x51\x01\uffff\x05\x51\x01\u0095\x14\x51",
            "",
            "\x01\x52\x01\uffff\x0a\x51\x07\uffff\x1a\x51\x04\uffff\x01"+
            "\x51\x01\uffff\x04\x51\x01\u0096\x15\x51",
            "",
            "\x01\x52\x01\uffff\x0a\x51\x07\uffff\x1a\x51\x04\uffff\x01"+
            "\x51\x01\uffff\x0b\x51\x01\u0097\x0e\x51",
            "\x01\x52\x01\uffff\x0a\x51\x07\uffff\x1a\x51\x04\uffff\x01"+
            "\x51\x01\uffff\x04\x51\x01\u0098\x15\x51",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "\x01\x52\x01\uffff\x0a\x51\x07\uffff\x1a\x51\x04\uffff\x01"+
            "\x51\x01\uffff\x1a\x51",
            "\x01\x52\x01\uffff\x0a\x51\x07\uffff\x1a\x51\x04\uffff\x01"+
            "\x51\x01\uffff\x1a\x51",
            "\x01\x52\x01\uffff\x0a\x51\x07\uffff\x1a\x51\x04\uffff\x01"+
            "\x51\x01\uffff\x04\x51\x01\u009a\x15\x51",
            "\x01\x52\x01\uffff\x0a\x51\x07\uffff\x1a\x51\x04\uffff\x01"+
            "\x51\x01\uffff\x1a\x51",
            "",
            "\x01\x52\x01\uffff\x0a\x51\x07\uffff\x1a\x51\x04\uffff\x01"+
            "\x51\x01\uffff\x1a\x51",
            "",
            ""
    };

    static readonly short[] DFA21_eot = DFA.UnpackEncodedString(DFA21_eotS);
    static readonly short[] DFA21_eof = DFA.UnpackEncodedString(DFA21_eofS);
    static readonly char[] DFA21_min = DFA.UnpackEncodedStringToUnsignedChars(DFA21_minS);
    static readonly char[] DFA21_max = DFA.UnpackEncodedStringToUnsignedChars(DFA21_maxS);
    static readonly short[] DFA21_accept = DFA.UnpackEncodedString(DFA21_acceptS);
    static readonly short[] DFA21_special = DFA.UnpackEncodedString(DFA21_specialS);
    static readonly short[][] DFA21_transition = DFA.UnpackEncodedStringArray(DFA21_transitionS);

    protected class DFA21 : DFA
    {
        public DFA21(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 21;
            this.eot = DFA21_eot;
            this.eof = DFA21_eof;
            this.min = DFA21_min;
            this.max = DFA21_max;
            this.accept = DFA21_accept;
            this.special = DFA21_special;
            this.transition = DFA21_transition;

        }

        override public string Description
        {
            get { return "1:1: Tokens : ( If | Else | Do | While | Case | RAdd | RAnd | RMax | RMin | RMultiply | ROr | SAdd | SAnd | SMax | SMin | SMultiply | SOr | AbsoluteValue | Ceiling | Count | DefaultFormat | Depth | Disclose | Enclose | Execute | Exponential | Floor | GradeDown | GradeUp | Identity | Interval | ItemRavel | MapIn | MatrixInverse | NaturalLog | Negate | Not | Null | Pack | PartitionCount | PiTimes | Print | Rake | Ravel | Raze | Reciprocal | Reverse | Roll | Right | SeparateSymbols | Shape | Sign | Signal | Stop | Transpose | Unpack | Value | Equal | Expand | GTE | LTE | NotEqual | Or | Replicate | Result | IPAddMultiply | IPMaxAdd | IPMinAdd | OPAdd | OPDivide | OPEqual | OPGT | OPGTE | OPLT | OPLTE | OPMax | OPMin | OPMultiply | OPNotEqual | OPResidue | OPSubstract | OPPower | BWNot | BWAnd | BWOr | BWLT | BWLTE | BWGT | BWGTE | BWEqual | BWNotEqual | StackReference | LP | RP | LSBracket | RSBracket | SemiColon | Colon | Each | Rank | Blank | LSB | RSB | Comment | CR | NewLine | Int | Float | Inf | CharachterConstantSQ | CharachterConstantDQ | SymbolConstant | UnqualifiedName | QualifiedName | SystemName | SystemCommandName );"; }
        }

    }


    protected internal int DFA21_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            IIntStream input = _input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA21_0 = input.LA(1);

                   	 
                   	int index21_0 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (LA21_0 == 'i') ) { s = 1; }

                   	else if ( (LA21_0 == 'e') ) { s = 2; }

                   	else if ( (LA21_0 == 'd') ) { s = 3; }

                   	else if ( (LA21_0 == 'w') ) { s = 4; }

                   	else if ( (LA21_0 == 'c') ) { s = 5; }

                   	else if ( (LA21_0 == '+') ) { s = 6; }

                   	else if ( (LA21_0 == '^') ) { s = 7; }

                   	else if ( (LA21_0 == '\u00D3') ) { s = 8; }

                   	else if ( (LA21_0 == '\u00C4') ) { s = 9; }

                   	else if ( (LA21_0 == '\u00AB') ) { s = 10; }

                   	else if ( (LA21_0 == '\u00A9') ) { s = 11; }

                   	else if ( (LA21_0 == '|') ) { s = 12; }

                   	else if ( (LA21_0 == '#') ) { s = 13; }

                   	else if ( (LA21_0 == '\u00EE') ) { s = 14; }

                   	else if ( (LA21_0 == '\u00BD') ) { s = 15; }

                   	else if ( (LA21_0 == '>') ) { s = 16; }

                   	else if ( (LA21_0 == '<') ) { s = 17; }

                   	else if ( (LA21_0 == '\u00E2') ) { s = 18; }

                   	else if ( (LA21_0 == '*') ) { s = 19; }

                   	else if ( (LA21_0 == '\u00E7') ) { s = 20; }

                   	else if ( (LA21_0 == '\u00E8') ) { s = 21; }

                   	else if ( (LA21_0 == '\u00C9') ) { s = 22; }

                   	else if ( (LA21_0 == '!') ) { s = 23; }

                   	else if ( (LA21_0 == '\u00E0') ) { s = 24; }

                   	else if ( (LA21_0 == '\u00AD') ) { s = 25; }

                   	else if ( (LA21_0 == '\u00F0') ) { s = 26; }

                   	else if ( (LA21_0 == '-') ) { s = 27; }

                   	else if ( (LA21_0 == '~') ) { s = 28; }

                   	else if ( (LA21_0 == '\u00DD') ) { s = 29; }

                   	else if ( (LA21_0 == '\u00C2') ) { s = 30; }

                   	else if ( (LA21_0 == '\u00DA') ) { s = 31; }

                   	else if ( (LA21_0 == '\u00CF') ) { s = 32; }

                   	else if ( (LA21_0 == '\u00D5') ) { s = 33; }

                   	else if ( (LA21_0 == '\u00C5') ) { s = 34; }

                   	else if ( (LA21_0 == ',') ) { s = 35; }

                   	else if ( (LA21_0 == '\u00D8') ) { s = 36; }

                   	else if ( (LA21_0 == '\u00DF') ) { s = 37; }

                   	else if ( (LA21_0 == '\u00F7') ) { s = 38; }

                   	else if ( (LA21_0 == '?') ) { s = 39; }

                   	else if ( (LA21_0 == '\u00DB') ) { s = 40; }

                   	else if ( (LA21_0 == '.') ) { s = 41; }

                   	else if ( (LA21_0 == '\u00D2') ) { s = 42; }

                   	else if ( (LA21_0 == '\u00D9') ) { s = 43; }

                   	else if ( (LA21_0 == '\u00F4') ) { s = 44; }

                   	else if ( (LA21_0 == '\u00CE') ) { s = 45; }

                   	else if ( (LA21_0 == '%') ) { s = 46; }

                   	else if ( (LA21_0 == '=') ) { s = 47; }

                   	else if ( (LA21_0 == '\\') ) { s = 48; }

                   	else if ( (LA21_0 == '\u00A6') ) { s = 49; }

                   	else if ( (LA21_0 == '\u00A4') ) { s = 50; }

                   	else if ( (LA21_0 == '\u00A8') ) { s = 51; }

                   	else if ( (LA21_0 == '/') ) { s = 52; }

                   	else if ( (LA21_0 == '\u00FB') ) { s = 53; }

                   	else if ( (LA21_0 == '\u00CA') ) { s = 54; }

                   	else if ( (LA21_0 == '&') ) { s = 55; }

                   	else if ( (LA21_0 == '(') ) { s = 56; }

                   	else if ( (LA21_0 == ')') ) { s = 57; }

                   	else if ( (LA21_0 == '[') ) { s = 58; }

                   	else if ( (LA21_0 == ']') ) { s = 59; }

                   	else if ( (LA21_0 == ';') ) { s = 60; }

                   	else if ( (LA21_0 == ':') ) { s = 61; }

                   	else if ( (LA21_0 == '\u00A1') ) { s = 62; }

                   	else if ( (LA21_0 == '@') ) { s = 63; }

                   	else if ( (LA21_0 == '\t' || LA21_0 == ' ') ) { s = 64; }

                   	else if ( (LA21_0 == '{') ) { s = 65; }

                   	else if ( (LA21_0 == '}') ) { s = 66; }

                   	else if ( (LA21_0 == '\u00E3') ) { s = 67; }

                   	else if ( (LA21_0 == '\r') ) { s = 68; }

                   	else if ( (LA21_0 == '\n') && (((mode > 0)|| (mode == 0))) ) { s = 69; }

                   	else if ( (LA21_0 == '\u00A2') ) { s = 70; }

                   	else if ( ((LA21_0 >= '0' && LA21_0 <= '9')) ) { s = 71; }

                   	else if ( (LA21_0 == 'I') ) { s = 72; }

                   	else if ( (LA21_0 == '\'') ) { s = 73; }

                   	else if ( (LA21_0 == '\"') ) { s = 74; }

                   	else if ( (LA21_0 == '`') ) { s = 75; }

                   	else if ( ((LA21_0 >= 'A' && LA21_0 <= 'H') || (LA21_0 >= 'J' && LA21_0 <= 'Z') || (LA21_0 >= 'a' && LA21_0 <= 'b') || (LA21_0 >= 'f' && LA21_0 <= 'h') || (LA21_0 >= 'j' && LA21_0 <= 'v') || (LA21_0 >= 'x' && LA21_0 <= 'z')) ) { s = 76; }

                   	else if ( (LA21_0 == '_') ) { s = 77; }

                   	else if ( (LA21_0 == '$') ) { s = 78; }

                   	 
                   	input.Seek(index21_0);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        NoViableAltException nvae21 =
            new NoViableAltException(dfa.Description, 21, _s, input);
        dfa.Error(nvae21);
        throw nvae21;
    }
 
    
}
}