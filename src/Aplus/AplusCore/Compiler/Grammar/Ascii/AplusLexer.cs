// $ANTLR 3.2 Sep 23, 2009 12:02:23 Compiler\\Grammar\\Ascii\\AplusLexer.g 2015-05-03 12:08:40

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


namespace  AplusCore.Compiler.Grammar.Ascii 
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
    	get { return "Compiler\\Grammar\\Ascii\\AplusLexer.g";} 
    }

    // $ANTLR start "If"
    public void mIf() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = If;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:40:3: ( 'if' )
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:40:8: 'if'
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
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:41:5: ( 'else' )
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:41:9: 'else'
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
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:42:3: ( 'do' )
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:42:8: 'do'
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
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:43:6: ( 'while' )
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:43:10: 'while'
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
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:44:5: ( 'case' )
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:44:9: 'case'
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
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:47:5: ( '+/' )
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:47:9: '+/'
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
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:48:5: ( '&/' )
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:48:9: '&/'
            {
            	Match("&/"); 


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
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:49:5: ( 'max/' )
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:49:9: 'max/'
            {
            	Match("max/"); 


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
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:50:5: ( 'min/' )
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:50:9: 'min/'
            {
            	Match("min/"); 


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
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:51:10: ( '*/' )
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:51:13: '*/'
            {
            	Match("*/"); 


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
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:52:4: ( '?/' )
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:52:8: '?/'
            {
            	Match("?/"); 


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
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:53:5: ( '+\\\\' )
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:53:9: '+\\\\'
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
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:54:5: ( '&\\\\' )
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:54:9: '&\\\\'
            {
            	Match("&\\"); 


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
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:55:5: ( 'max\\\\' )
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:55:9: 'max\\\\'
            {
            	Match("max\\"); 


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
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:56:5: ( 'min\\\\' )
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:56:9: 'min\\\\'
            {
            	Match("min\\"); 


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
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:57:10: ( '*\\\\' )
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:57:13: '*\\\\'
            {
            	Match("*\\"); 


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
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:58:4: ( '?\\\\' )
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:58:8: '?\\\\'
            {
            	Match("?\\"); 


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
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:60:14: ( '|' )
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:60:17: '|'
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
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:61:8: ( 'max' )
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:61:12: 'max'
            {
            	Match("max"); 


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
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:62:6: ( '#' )
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:62:11: '#'
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
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:63:14: ( 'form' )
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:63:17: 'form'
            {
            	Match("form"); 


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
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:64:6: ( '==' )
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:64:11: '=='
            {
            	Match("=="); 


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
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:65:9: ( '>' )
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:65:13: '>'
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
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:66:8: ( '<' )
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:66:12: '<'
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
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:67:8: ( 'eval' )
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:67:12: 'eval'
            {
            	Match("eval"); 


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
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:68:12: ( '^' )
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:68:15: '^'
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
    // $ANTLR end "Exponential"

    // $ANTLR start "Floor"
    public void mFloor() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = Floor;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:69:6: ( 'min' )
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:69:11: 'min'
            {
            	Match("min"); 


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
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:70:10: ( 'dng' )
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:70:14: 'dng'
            {
            	Match("dng"); 


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
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:71:8: ( 'upg' )
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:71:12: 'upg'
            {
            	Match("upg"); 


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
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:72:9: ( '+' )
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:72:13: '+'
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
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:73:9: ( 'iota' )
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:73:13: 'iota'
            {
            	Match("iota"); 


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
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:74:10: ( '!' )
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:74:14: '!'
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
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:75:6: ( 'beam' )
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:75:11: 'beam'
            {
            	Match("beam"); 


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
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:76:14: ( 'mdiv' )
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:76:17: 'mdiv'
            {
            	Match("mdiv"); 


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
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:77:11: ( 'log' )
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:77:15: 'log'
            {
            	Match("log"); 


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
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:78:7: ( '-' )
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:78:12: '-'
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
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:79:4: ( '~' )
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:79:9: '~'
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
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:80:5: ( 'where' )
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:80:10: 'where'
            {
            	Match("where"); 


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
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:81:5: ( 'pack' )
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:81:10: 'pack'
            {
            	Match("pack"); 


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
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:82:15: ( 'bag' )
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:82:18: 'bag'
            {
            	Match("bag"); 


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
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:83:8: ( 'pi' )
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:83:12: 'pi'
            {
            	Match("pi"); 


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
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:84:6: ( 'drop' )
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:84:11: 'drop'
            {
            	Match("drop"); 


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
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:85:5: ( 'in' )
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:85:10: 'in'
            {
            	Match("in"); 


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
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:86:6: ( ',' )
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:86:11: ','
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
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:87:5: ( 'pick' )
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:87:10: 'pick'
            {
            	Match("pick"); 


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
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:88:11: ( '%' )
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:88:15: '%'
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
    // $ANTLR end "Reciprocal"

    // $ANTLR start "Reverse"
    public void mReverse() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = Reverse;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:89:8: ( 'rot' )
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:89:12: 'rot'
            {
            	Match("rot"); 


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
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:90:5: ( 'rand' )
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:90:10: 'rand'
            {
            	Match("rand"); 


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
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:91:6: ( 'rtack' )
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:91:11: 'rtack'
            {
            	Match("rtack"); 


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
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:92:16: ( 'dot' )
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:92:18: 'dot'
            {
            	Match("dot"); 


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
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:93:6: ( 'rho' )
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:93:11: 'rho'
            {
            	Match("rho"); 


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
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:94:5: ( '*' )
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:94:10: '*'
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
    // $ANTLR end "Sign"

    // $ANTLR start "Signal"
    public void mSignal() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = Signal;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:95:7: ( 'take' )
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:95:12: 'take'
            {
            	Match("take"); 


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
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:96:5: ( '&' )
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:96:10: '&'
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
    // $ANTLR end "Stop"

    // $ANTLR start "Transpose"
    public void mTranspose() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = Transpose;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:97:10: ( 'flip' )
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:97:14: 'flip'
            {
            	Match("flip"); 


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
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:98:7: ( 'unpack' )
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:98:12: 'unpack'
            {
            	Match("unpack"); 


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
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:99:6: ( 'ref' )
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:99:11: 'ref'
            {
            	Match("ref"); 


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
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:104:6: ( '=' )
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:104:10: '='
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
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:105:7: ( '\\\\' )
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:105:11: '\\\\'
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
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:106:4: ( '>=' )
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:106:8: '>='
            {
            	Match(">="); 


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
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:107:4: ( '<=' )
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:107:8: '<='
            {
            	Match("<="); 


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
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:108:9: ( '~=' )
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:108:12: '~='
            {
            	Match("~="); 


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
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:109:3: ( '?' )
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:109:8: '?'
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
    // $ANTLR end "Or"

    // $ANTLR start "Replicate"
    public void mReplicate() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = Replicate;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:110:10: ( '/' )
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:110:13: '/'
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
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:111:7: ( ':=' )
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:111:11: ':='
            {
            	Match(":="); 


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
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:113:14: ( '+.*' )
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:113:16: '+.*'
            {
            	Match("+.*"); 


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
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:114:9: ( 'max.+' )
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:114:12: 'max.+'
            {
            	Match("max.+"); 


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
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:115:9: ( 'min.+' )
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:115:12: 'min.+'
            {
            	Match("min.+"); 


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
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:116:6: ( '+.' )
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:116:10: '+.'
            {
            	Match("+."); 


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
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:117:9: ( '%.' )
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:117:12: '%.'
            {
            	Match("%."); 


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
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:118:8: ( '=.' )
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:118:11: '=.'
            {
            	Match("=."); 


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
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:119:5: ( '>.' )
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:119:9: '>.'
            {
            	Match(">."); 


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
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:120:6: ( '>=.' )
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:120:10: '>=.'
            {
            	Match(">=."); 


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
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:121:5: ( '<.' )
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:121:9: '<.'
            {
            	Match("<."); 


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
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:122:6: ( '<=.' )
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:122:10: '<=.'
            {
            	Match("<=."); 


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
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:123:6: ( 'max.' )
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:123:10: 'max.'
            {
            	Match("max."); 


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
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:124:6: ( 'min.' )
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:124:10: 'min.'
            {
            	Match("min."); 


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
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:125:11: ( '*.' )
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:125:14: '*.'
            {
            	Match("*."); 


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
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:126:11: ( '~=.' )
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:126:14: '~=.'
            {
            	Match("~=."); 


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
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:127:10: ( '|.' )
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:127:13: '|.'
            {
            	Match("|."); 


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
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:128:12: ( '-.' )
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:128:14: '-.'
            {
            	Match("-."); 


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
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:129:8: ( '^.' )
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:129:11: '^.'
            {
            	Match("^."); 


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
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:132:6: ( 'bwnot' )
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:132:10: 'bwnot'
            {
            	Match("bwnot"); 


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
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:133:6: ( 'bwand' )
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:133:10: 'bwand'
            {
            	Match("bwand"); 


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
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:134:5: ( 'bwor' )
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:134:9: 'bwor'
            {
            	Match("bwor"); 


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
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:135:5: ( 'bwlt' )
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:135:9: 'bwlt'
            {
            	Match("bwlt"); 


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
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:136:6: ( 'bwle' )
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:136:10: 'bwle'
            {
            	Match("bwle"); 


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
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:137:5: ( 'bwgt' )
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:137:9: 'bwgt'
            {
            	Match("bwgt"); 


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
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:138:6: ( 'bwge' )
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:138:10: 'bwge'
            {
            	Match("bwge"); 


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
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:139:8: ( 'bweq' )
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:139:11: 'bweq'
            {
            	Match("bweq"); 


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
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:140:11: ( 'bwne' )
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:140:14: 'bwne'
            {
            	Match("bwne"); 


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
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:143:15: ( '\\u00FE' )
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:143:17: '\\u00FE'
            {
            	Match('\u00FE'); 

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
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:145:3: ( '(' )
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:145:8: '('
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
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:146:3: ( ')' )
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:146:8: ')'
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
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:147:10: ( '[' )
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:147:13: '['
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
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:148:10: ( ']' )
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:148:13: ']'
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
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:149:10: ( ';' )
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:149:13: ';'
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
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:150:6: ( ':' )
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:150:10: ':'
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
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:151:5: ( 'each' )
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:151:9: 'each'
            {
            	Match("each"); 


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
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:152:5: ( '@' )
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:152:9: '@'
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
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:154:6: ( WhiteSpace )
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:154:10: WhiteSpace
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
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:155:4: ( '{' )
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:155:8: '{'
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
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:156:4: ( '}' )
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:156:8: '}'
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
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:157:8: ( '//' (~ '\\n' )* )
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:157:11: '//' (~ '\\n' )*
            {
            	Match("//"); 

            	// Compiler\\Grammar\\Ascii\\AplusLexer.g:157:16: (~ '\\n' )*
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
            			    // Compiler\\Grammar\\Ascii\\AplusLexer.g:157:17: ~ '\\n'
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
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:158:3: ( '\\r' )
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:158:8: '\\r'
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
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:161:2: ({...}? => '\\n' | {...}? => '\\n' )
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
                    // Compiler\\Grammar\\Ascii\\AplusLexer.g:161:6: {...}? => '\\n'
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
                    // Compiler\\Grammar\\Ascii\\AplusLexer.g:162:6: {...}? => '\\n'
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
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:166:2: ( ' ' | '\\t' )
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:
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
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:171:2: ( '0' .. '9' )
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:171:4: '0' .. '9'
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
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:175:2: ( ( Digit )+ )
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:175:4: ( Digit )+
            {
            	// Compiler\\Grammar\\Ascii\\AplusLexer.g:175:4: ( Digit )+
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
            			    // Compiler\\Grammar\\Ascii\\AplusLexer.g:175:4: Digit
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
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:179:2: ( ( '-' )? Number )
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:179:4: ( '-' )? Number
            {
            	// Compiler\\Grammar\\Ascii\\AplusLexer.g:179:4: ( '-' )?
            	int alt4 = 2;
            	int LA4_0 = input.LA(1);

            	if ( (LA4_0 == '-') )
            	{
            	    alt4 = 1;
            	}
            	switch (alt4) 
            	{
            	    case 1 :
            	        // Compiler\\Grammar\\Ascii\\AplusLexer.g:179:4: '-'
            	        {
            	        	Match('-'); 

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
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:183:2: ( ( 'e' | 'E' ) ( '-' | '+' )? Number )
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:183:4: ( 'e' | 'E' ) ( '-' | '+' )? Number
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

            	// Compiler\\Grammar\\Ascii\\AplusLexer.g:183:14: ( '-' | '+' )?
            	int alt5 = 2;
            	int LA5_0 = input.LA(1);

            	if ( (LA5_0 == '+' || LA5_0 == '-') )
            	{
            	    alt5 = 1;
            	}
            	switch (alt5) 
            	{
            	    case 1 :
            	        // Compiler\\Grammar\\Ascii\\AplusLexer.g:
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
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:187:2: ( ( '-' )? Number Exponent | ( '-' )? '.' Number ( Exponent )? | ( '-' )? Number '.' ( Number )? ( Exponent )? )
            int alt12 = 3;
            alt12 = dfa12.Predict(input);
            switch (alt12) 
            {
                case 1 :
                    // Compiler\\Grammar\\Ascii\\AplusLexer.g:187:4: ( '-' )? Number Exponent
                    {
                    	// Compiler\\Grammar\\Ascii\\AplusLexer.g:187:4: ( '-' )?
                    	int alt6 = 2;
                    	int LA6_0 = input.LA(1);

                    	if ( (LA6_0 == '-') )
                    	{
                    	    alt6 = 1;
                    	}
                    	switch (alt6) 
                    	{
                    	    case 1 :
                    	        // Compiler\\Grammar\\Ascii\\AplusLexer.g:187:4: '-'
                    	        {
                    	        	Match('-'); 

                    	        }
                    	        break;

                    	}

                    	mNumber(); 
                    	mExponent(); 

                    }
                    break;
                case 2 :
                    // Compiler\\Grammar\\Ascii\\AplusLexer.g:188:4: ( '-' )? '.' Number ( Exponent )?
                    {
                    	// Compiler\\Grammar\\Ascii\\AplusLexer.g:188:4: ( '-' )?
                    	int alt7 = 2;
                    	int LA7_0 = input.LA(1);

                    	if ( (LA7_0 == '-') )
                    	{
                    	    alt7 = 1;
                    	}
                    	switch (alt7) 
                    	{
                    	    case 1 :
                    	        // Compiler\\Grammar\\Ascii\\AplusLexer.g:188:4: '-'
                    	        {
                    	        	Match('-'); 

                    	        }
                    	        break;

                    	}

                    	Match('.'); 
                    	mNumber(); 
                    	// Compiler\\Grammar\\Ascii\\AplusLexer.g:188:20: ( Exponent )?
                    	int alt8 = 2;
                    	int LA8_0 = input.LA(1);

                    	if ( (LA8_0 == 'E' || LA8_0 == 'e') )
                    	{
                    	    alt8 = 1;
                    	}
                    	switch (alt8) 
                    	{
                    	    case 1 :
                    	        // Compiler\\Grammar\\Ascii\\AplusLexer.g:188:20: Exponent
                    	        {
                    	        	mExponent(); 

                    	        }
                    	        break;

                    	}


                    }
                    break;
                case 3 :
                    // Compiler\\Grammar\\Ascii\\AplusLexer.g:189:4: ( '-' )? Number '.' ( Number )? ( Exponent )?
                    {
                    	// Compiler\\Grammar\\Ascii\\AplusLexer.g:189:4: ( '-' )?
                    	int alt9 = 2;
                    	int LA9_0 = input.LA(1);

                    	if ( (LA9_0 == '-') )
                    	{
                    	    alt9 = 1;
                    	}
                    	switch (alt9) 
                    	{
                    	    case 1 :
                    	        // Compiler\\Grammar\\Ascii\\AplusLexer.g:189:4: '-'
                    	        {
                    	        	Match('-'); 

                    	        }
                    	        break;

                    	}

                    	mNumber(); 
                    	Match('.'); 
                    	// Compiler\\Grammar\\Ascii\\AplusLexer.g:189:20: ( Number )?
                    	int alt10 = 2;
                    	int LA10_0 = input.LA(1);

                    	if ( ((LA10_0 >= '0' && LA10_0 <= '9')) )
                    	{
                    	    alt10 = 1;
                    	}
                    	switch (alt10) 
                    	{
                    	    case 1 :
                    	        // Compiler\\Grammar\\Ascii\\AplusLexer.g:189:20: Number
                    	        {
                    	        	mNumber(); 

                    	        }
                    	        break;

                    	}

                    	// Compiler\\Grammar\\Ascii\\AplusLexer.g:189:28: ( Exponent )?
                    	int alt11 = 2;
                    	int LA11_0 = input.LA(1);

                    	if ( (LA11_0 == 'E' || LA11_0 == 'e') )
                    	{
                    	    alt11 = 1;
                    	}
                    	switch (alt11) 
                    	{
                    	    case 1 :
                    	        // Compiler\\Grammar\\Ascii\\AplusLexer.g:189:28: Exponent
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
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:193:2: ( ( '-' )? 'Inf' )
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:193:4: ( '-' )? 'Inf'
            {
            	// Compiler\\Grammar\\Ascii\\AplusLexer.g:193:4: ( '-' )?
            	int alt13 = 2;
            	int LA13_0 = input.LA(1);

            	if ( (LA13_0 == '-') )
            	{
            	    alt13 = 1;
            	}
            	switch (alt13) 
            	{
            	    case 1 :
            	        // Compiler\\Grammar\\Ascii\\AplusLexer.g:193:4: '-'
            	        {
            	        	Match('-'); 

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
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:196:12: ( '\\'' )
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:196:14: '\\''
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
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:198:12: ( '\"' )
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:198:14: '\"'
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
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:200:19: ( '\\\\' )
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:200:21: '\\\\'
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
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:204:2: ( SQ ( SQ SQ | ( 'R' | ~ SQ ) )* SQ )
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:204:4: SQ ( SQ SQ | ( 'R' | ~ SQ ) )* SQ
            {
            	mSQ(); 
            	// Compiler\\Grammar\\Ascii\\AplusLexer.g:204:7: ( SQ SQ | ( 'R' | ~ SQ ) )*
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
            			    // Compiler\\Grammar\\Ascii\\AplusLexer.g:204:9: SQ SQ
            			    {
            			    	mSQ(); 
            			    	mSQ(); 

            			    }
            			    break;
            			case 2 :
            			    // Compiler\\Grammar\\Ascii\\AplusLexer.g:204:17: ( 'R' | ~ SQ )
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
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:209:2: ( DQ ( 'S' | ~ DQ )* DQ )
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:209:4: DQ ( 'S' | ~ DQ )* DQ
            {
            	mDQ(); 
            	// Compiler\\Grammar\\Ascii\\AplusLexer.g:209:7: ( 'S' | ~ DQ )*
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
            			    // Compiler\\Grammar\\Ascii\\AplusLexer.g:
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
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:213:2: ( ( 'a' .. 'z' | 'A' .. 'Z' ) )
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:213:4: ( 'a' .. 'z' | 'A' .. 'Z' )
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
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:217:2: ( ( Alphabetic | Digit ) )
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:217:4: ( Alphabetic | Digit )
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
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:221:2: ( '`' ( Alphanumeric | '_' | '.' )* )
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:221:4: '`' ( Alphanumeric | '_' | '.' )*
            {
            	Match('`'); 
            	// Compiler\\Grammar\\Ascii\\AplusLexer.g:221:9: ( Alphanumeric | '_' | '.' )*
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
            			    // Compiler\\Grammar\\Ascii\\AplusLexer.g:
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
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:225:2: ( Alphabetic ( Alphanumeric | '_' )* )
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:225:4: Alphabetic ( Alphanumeric | '_' )*
            {
            	mAlphabetic(); 
            	// Compiler\\Grammar\\Ascii\\AplusLexer.g:225:15: ( Alphanumeric | '_' )*
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
            			    // Compiler\\Grammar\\Ascii\\AplusLexer.g:
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
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:230:2: ( ( UnqualifiedName '.' )+ UnqualifiedName | '.' UnqualifiedName | UnqualifiedName )
            int alt19 = 3;
            alt19 = dfa19.Predict(input);
            switch (alt19) 
            {
                case 1 :
                    // Compiler\\Grammar\\Ascii\\AplusLexer.g:230:4: ( UnqualifiedName '.' )+ UnqualifiedName
                    {
                    	// Compiler\\Grammar\\Ascii\\AplusLexer.g:230:4: ( UnqualifiedName '.' )+
                    	int cnt18 = 0;
                    	do 
                    	{
                    	    int alt18 = 2;
                    	    alt18 = dfa18.Predict(input);
                    	    switch (alt18) 
                    		{
                    			case 1 :
                    			    // Compiler\\Grammar\\Ascii\\AplusLexer.g:230:5: UnqualifiedName '.'
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
                    // Compiler\\Grammar\\Ascii\\AplusLexer.g:231:4: '.' UnqualifiedName
                    {
                    	Match('.'); 
                    	mUnqualifiedName(); 

                    }
                    break;
                case 3 :
                    // Compiler\\Grammar\\Ascii\\AplusLexer.g:232:6: UnqualifiedName
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
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:236:2: ( '_' UnqualifiedName )
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:236:4: '_' UnqualifiedName
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
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:241:2: ( '$' (~ ( '\\n' | '\\r' ) )* )
            // Compiler\\Grammar\\Ascii\\AplusLexer.g:241:4: '$' (~ ( '\\n' | '\\r' ) )*
            {
            	Match('$'); 
            	// Compiler\\Grammar\\Ascii\\AplusLexer.g:241:8: (~ ( '\\n' | '\\r' ) )*
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
            			    // Compiler\\Grammar\\Ascii\\AplusLexer.g:241:8: ~ ( '\\n' | '\\r' )
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
        // Compiler\\Grammar\\Ascii\\AplusLexer.g:1:8: ( If | Else | Do | While | Case | RAdd | RAnd | RMax | RMin | RMultiply | ROr | SAdd | SAnd | SMax | SMin | SMultiply | SOr | AbsoluteValue | Ceiling | Count | DefaultFormat | Depth | Disclose | Enclose | Execute | Exponential | Floor | GradeDown | GradeUp | Identity | Interval | ItemRavel | MapIn | MatrixInverse | NaturalLog | Negate | Not | Null | Pack | PartitionCount | PiTimes | Print | Rake | Ravel | Raze | Reciprocal | Reverse | Roll | Right | SeparateSymbols | Shape | Sign | Signal | Stop | Transpose | Unpack | Value | Equal | Expand | GTE | LTE | NotEqual | Or | Replicate | Result | IPAddMultiply | IPMaxAdd | IPMinAdd | OPAdd | OPDivide | OPEqual | OPGT | OPGTE | OPLT | OPLTE | OPMax | OPMin | OPMultiply | OPNotEqual | OPResidue | OPSubstract | OPPower | BWNot | BWAnd | BWOr | BWLT | BWLTE | BWGT | BWGTE | BWEqual | BWNotEqual | StackReference | LP | RP | LSBracket | RSBracket | SemiColon | Colon | Each | Rank | Blank | LSB | RSB | Comment | CR | NewLine | Int | Float | Inf | CharachterConstantSQ | CharachterConstantDQ | SymbolConstant | UnqualifiedName | QualifiedName | SystemName | SystemCommandName )
        int alt21 = 116;
        alt21 = dfa21.Predict(input);
        switch (alt21) 
        {
            case 1 :
                // Compiler\\Grammar\\Ascii\\AplusLexer.g:1:10: If
                {
                	mIf(); 

                }
                break;
            case 2 :
                // Compiler\\Grammar\\Ascii\\AplusLexer.g:1:13: Else
                {
                	mElse(); 

                }
                break;
            case 3 :
                // Compiler\\Grammar\\Ascii\\AplusLexer.g:1:18: Do
                {
                	mDo(); 

                }
                break;
            case 4 :
                // Compiler\\Grammar\\Ascii\\AplusLexer.g:1:21: While
                {
                	mWhile(); 

                }
                break;
            case 5 :
                // Compiler\\Grammar\\Ascii\\AplusLexer.g:1:27: Case
                {
                	mCase(); 

                }
                break;
            case 6 :
                // Compiler\\Grammar\\Ascii\\AplusLexer.g:1:32: RAdd
                {
                	mRAdd(); 

                }
                break;
            case 7 :
                // Compiler\\Grammar\\Ascii\\AplusLexer.g:1:37: RAnd
                {
                	mRAnd(); 

                }
                break;
            case 8 :
                // Compiler\\Grammar\\Ascii\\AplusLexer.g:1:42: RMax
                {
                	mRMax(); 

                }
                break;
            case 9 :
                // Compiler\\Grammar\\Ascii\\AplusLexer.g:1:47: RMin
                {
                	mRMin(); 

                }
                break;
            case 10 :
                // Compiler\\Grammar\\Ascii\\AplusLexer.g:1:52: RMultiply
                {
                	mRMultiply(); 

                }
                break;
            case 11 :
                // Compiler\\Grammar\\Ascii\\AplusLexer.g:1:62: ROr
                {
                	mROr(); 

                }
                break;
            case 12 :
                // Compiler\\Grammar\\Ascii\\AplusLexer.g:1:66: SAdd
                {
                	mSAdd(); 

                }
                break;
            case 13 :
                // Compiler\\Grammar\\Ascii\\AplusLexer.g:1:71: SAnd
                {
                	mSAnd(); 

                }
                break;
            case 14 :
                // Compiler\\Grammar\\Ascii\\AplusLexer.g:1:76: SMax
                {
                	mSMax(); 

                }
                break;
            case 15 :
                // Compiler\\Grammar\\Ascii\\AplusLexer.g:1:81: SMin
                {
                	mSMin(); 

                }
                break;
            case 16 :
                // Compiler\\Grammar\\Ascii\\AplusLexer.g:1:86: SMultiply
                {
                	mSMultiply(); 

                }
                break;
            case 17 :
                // Compiler\\Grammar\\Ascii\\AplusLexer.g:1:96: SOr
                {
                	mSOr(); 

                }
                break;
            case 18 :
                // Compiler\\Grammar\\Ascii\\AplusLexer.g:1:100: AbsoluteValue
                {
                	mAbsoluteValue(); 

                }
                break;
            case 19 :
                // Compiler\\Grammar\\Ascii\\AplusLexer.g:1:114: Ceiling
                {
                	mCeiling(); 

                }
                break;
            case 20 :
                // Compiler\\Grammar\\Ascii\\AplusLexer.g:1:122: Count
                {
                	mCount(); 

                }
                break;
            case 21 :
                // Compiler\\Grammar\\Ascii\\AplusLexer.g:1:128: DefaultFormat
                {
                	mDefaultFormat(); 

                }
                break;
            case 22 :
                // Compiler\\Grammar\\Ascii\\AplusLexer.g:1:142: Depth
                {
                	mDepth(); 

                }
                break;
            case 23 :
                // Compiler\\Grammar\\Ascii\\AplusLexer.g:1:148: Disclose
                {
                	mDisclose(); 

                }
                break;
            case 24 :
                // Compiler\\Grammar\\Ascii\\AplusLexer.g:1:157: Enclose
                {
                	mEnclose(); 

                }
                break;
            case 25 :
                // Compiler\\Grammar\\Ascii\\AplusLexer.g:1:165: Execute
                {
                	mExecute(); 

                }
                break;
            case 26 :
                // Compiler\\Grammar\\Ascii\\AplusLexer.g:1:173: Exponential
                {
                	mExponential(); 

                }
                break;
            case 27 :
                // Compiler\\Grammar\\Ascii\\AplusLexer.g:1:185: Floor
                {
                	mFloor(); 

                }
                break;
            case 28 :
                // Compiler\\Grammar\\Ascii\\AplusLexer.g:1:191: GradeDown
                {
                	mGradeDown(); 

                }
                break;
            case 29 :
                // Compiler\\Grammar\\Ascii\\AplusLexer.g:1:201: GradeUp
                {
                	mGradeUp(); 

                }
                break;
            case 30 :
                // Compiler\\Grammar\\Ascii\\AplusLexer.g:1:209: Identity
                {
                	mIdentity(); 

                }
                break;
            case 31 :
                // Compiler\\Grammar\\Ascii\\AplusLexer.g:1:218: Interval
                {
                	mInterval(); 

                }
                break;
            case 32 :
                // Compiler\\Grammar\\Ascii\\AplusLexer.g:1:227: ItemRavel
                {
                	mItemRavel(); 

                }
                break;
            case 33 :
                // Compiler\\Grammar\\Ascii\\AplusLexer.g:1:237: MapIn
                {
                	mMapIn(); 

                }
                break;
            case 34 :
                // Compiler\\Grammar\\Ascii\\AplusLexer.g:1:243: MatrixInverse
                {
                	mMatrixInverse(); 

                }
                break;
            case 35 :
                // Compiler\\Grammar\\Ascii\\AplusLexer.g:1:257: NaturalLog
                {
                	mNaturalLog(); 

                }
                break;
            case 36 :
                // Compiler\\Grammar\\Ascii\\AplusLexer.g:1:268: Negate
                {
                	mNegate(); 

                }
                break;
            case 37 :
                // Compiler\\Grammar\\Ascii\\AplusLexer.g:1:275: Not
                {
                	mNot(); 

                }
                break;
            case 38 :
                // Compiler\\Grammar\\Ascii\\AplusLexer.g:1:279: Null
                {
                	mNull(); 

                }
                break;
            case 39 :
                // Compiler\\Grammar\\Ascii\\AplusLexer.g:1:284: Pack
                {
                	mPack(); 

                }
                break;
            case 40 :
                // Compiler\\Grammar\\Ascii\\AplusLexer.g:1:289: PartitionCount
                {
                	mPartitionCount(); 

                }
                break;
            case 41 :
                // Compiler\\Grammar\\Ascii\\AplusLexer.g:1:304: PiTimes
                {
                	mPiTimes(); 

                }
                break;
            case 42 :
                // Compiler\\Grammar\\Ascii\\AplusLexer.g:1:312: Print
                {
                	mPrint(); 

                }
                break;
            case 43 :
                // Compiler\\Grammar\\Ascii\\AplusLexer.g:1:318: Rake
                {
                	mRake(); 

                }
                break;
            case 44 :
                // Compiler\\Grammar\\Ascii\\AplusLexer.g:1:323: Ravel
                {
                	mRavel(); 

                }
                break;
            case 45 :
                // Compiler\\Grammar\\Ascii\\AplusLexer.g:1:329: Raze
                {
                	mRaze(); 

                }
                break;
            case 46 :
                // Compiler\\Grammar\\Ascii\\AplusLexer.g:1:334: Reciprocal
                {
                	mReciprocal(); 

                }
                break;
            case 47 :
                // Compiler\\Grammar\\Ascii\\AplusLexer.g:1:345: Reverse
                {
                	mReverse(); 

                }
                break;
            case 48 :
                // Compiler\\Grammar\\Ascii\\AplusLexer.g:1:353: Roll
                {
                	mRoll(); 

                }
                break;
            case 49 :
                // Compiler\\Grammar\\Ascii\\AplusLexer.g:1:358: Right
                {
                	mRight(); 

                }
                break;
            case 50 :
                // Compiler\\Grammar\\Ascii\\AplusLexer.g:1:364: SeparateSymbols
                {
                	mSeparateSymbols(); 

                }
                break;
            case 51 :
                // Compiler\\Grammar\\Ascii\\AplusLexer.g:1:380: Shape
                {
                	mShape(); 

                }
                break;
            case 52 :
                // Compiler\\Grammar\\Ascii\\AplusLexer.g:1:386: Sign
                {
                	mSign(); 

                }
                break;
            case 53 :
                // Compiler\\Grammar\\Ascii\\AplusLexer.g:1:391: Signal
                {
                	mSignal(); 

                }
                break;
            case 54 :
                // Compiler\\Grammar\\Ascii\\AplusLexer.g:1:398: Stop
                {
                	mStop(); 

                }
                break;
            case 55 :
                // Compiler\\Grammar\\Ascii\\AplusLexer.g:1:403: Transpose
                {
                	mTranspose(); 

                }
                break;
            case 56 :
                // Compiler\\Grammar\\Ascii\\AplusLexer.g:1:413: Unpack
                {
                	mUnpack(); 

                }
                break;
            case 57 :
                // Compiler\\Grammar\\Ascii\\AplusLexer.g:1:420: Value
                {
                	mValue(); 

                }
                break;
            case 58 :
                // Compiler\\Grammar\\Ascii\\AplusLexer.g:1:426: Equal
                {
                	mEqual(); 

                }
                break;
            case 59 :
                // Compiler\\Grammar\\Ascii\\AplusLexer.g:1:432: Expand
                {
                	mExpand(); 

                }
                break;
            case 60 :
                // Compiler\\Grammar\\Ascii\\AplusLexer.g:1:439: GTE
                {
                	mGTE(); 

                }
                break;
            case 61 :
                // Compiler\\Grammar\\Ascii\\AplusLexer.g:1:443: LTE
                {
                	mLTE(); 

                }
                break;
            case 62 :
                // Compiler\\Grammar\\Ascii\\AplusLexer.g:1:447: NotEqual
                {
                	mNotEqual(); 

                }
                break;
            case 63 :
                // Compiler\\Grammar\\Ascii\\AplusLexer.g:1:456: Or
                {
                	mOr(); 

                }
                break;
            case 64 :
                // Compiler\\Grammar\\Ascii\\AplusLexer.g:1:459: Replicate
                {
                	mReplicate(); 

                }
                break;
            case 65 :
                // Compiler\\Grammar\\Ascii\\AplusLexer.g:1:469: Result
                {
                	mResult(); 

                }
                break;
            case 66 :
                // Compiler\\Grammar\\Ascii\\AplusLexer.g:1:476: IPAddMultiply
                {
                	mIPAddMultiply(); 

                }
                break;
            case 67 :
                // Compiler\\Grammar\\Ascii\\AplusLexer.g:1:490: IPMaxAdd
                {
                	mIPMaxAdd(); 

                }
                break;
            case 68 :
                // Compiler\\Grammar\\Ascii\\AplusLexer.g:1:499: IPMinAdd
                {
                	mIPMinAdd(); 

                }
                break;
            case 69 :
                // Compiler\\Grammar\\Ascii\\AplusLexer.g:1:508: OPAdd
                {
                	mOPAdd(); 

                }
                break;
            case 70 :
                // Compiler\\Grammar\\Ascii\\AplusLexer.g:1:514: OPDivide
                {
                	mOPDivide(); 

                }
                break;
            case 71 :
                // Compiler\\Grammar\\Ascii\\AplusLexer.g:1:523: OPEqual
                {
                	mOPEqual(); 

                }
                break;
            case 72 :
                // Compiler\\Grammar\\Ascii\\AplusLexer.g:1:531: OPGT
                {
                	mOPGT(); 

                }
                break;
            case 73 :
                // Compiler\\Grammar\\Ascii\\AplusLexer.g:1:536: OPGTE
                {
                	mOPGTE(); 

                }
                break;
            case 74 :
                // Compiler\\Grammar\\Ascii\\AplusLexer.g:1:542: OPLT
                {
                	mOPLT(); 

                }
                break;
            case 75 :
                // Compiler\\Grammar\\Ascii\\AplusLexer.g:1:547: OPLTE
                {
                	mOPLTE(); 

                }
                break;
            case 76 :
                // Compiler\\Grammar\\Ascii\\AplusLexer.g:1:553: OPMax
                {
                	mOPMax(); 

                }
                break;
            case 77 :
                // Compiler\\Grammar\\Ascii\\AplusLexer.g:1:559: OPMin
                {
                	mOPMin(); 

                }
                break;
            case 78 :
                // Compiler\\Grammar\\Ascii\\AplusLexer.g:1:565: OPMultiply
                {
                	mOPMultiply(); 

                }
                break;
            case 79 :
                // Compiler\\Grammar\\Ascii\\AplusLexer.g:1:576: OPNotEqual
                {
                	mOPNotEqual(); 

                }
                break;
            case 80 :
                // Compiler\\Grammar\\Ascii\\AplusLexer.g:1:587: OPResidue
                {
                	mOPResidue(); 

                }
                break;
            case 81 :
                // Compiler\\Grammar\\Ascii\\AplusLexer.g:1:597: OPSubstract
                {
                	mOPSubstract(); 

                }
                break;
            case 82 :
                // Compiler\\Grammar\\Ascii\\AplusLexer.g:1:609: OPPower
                {
                	mOPPower(); 

                }
                break;
            case 83 :
                // Compiler\\Grammar\\Ascii\\AplusLexer.g:1:617: BWNot
                {
                	mBWNot(); 

                }
                break;
            case 84 :
                // Compiler\\Grammar\\Ascii\\AplusLexer.g:1:623: BWAnd
                {
                	mBWAnd(); 

                }
                break;
            case 85 :
                // Compiler\\Grammar\\Ascii\\AplusLexer.g:1:629: BWOr
                {
                	mBWOr(); 

                }
                break;
            case 86 :
                // Compiler\\Grammar\\Ascii\\AplusLexer.g:1:634: BWLT
                {
                	mBWLT(); 

                }
                break;
            case 87 :
                // Compiler\\Grammar\\Ascii\\AplusLexer.g:1:639: BWLTE
                {
                	mBWLTE(); 

                }
                break;
            case 88 :
                // Compiler\\Grammar\\Ascii\\AplusLexer.g:1:645: BWGT
                {
                	mBWGT(); 

                }
                break;
            case 89 :
                // Compiler\\Grammar\\Ascii\\AplusLexer.g:1:650: BWGTE
                {
                	mBWGTE(); 

                }
                break;
            case 90 :
                // Compiler\\Grammar\\Ascii\\AplusLexer.g:1:656: BWEqual
                {
                	mBWEqual(); 

                }
                break;
            case 91 :
                // Compiler\\Grammar\\Ascii\\AplusLexer.g:1:664: BWNotEqual
                {
                	mBWNotEqual(); 

                }
                break;
            case 92 :
                // Compiler\\Grammar\\Ascii\\AplusLexer.g:1:675: StackReference
                {
                	mStackReference(); 

                }
                break;
            case 93 :
                // Compiler\\Grammar\\Ascii\\AplusLexer.g:1:690: LP
                {
                	mLP(); 

                }
                break;
            case 94 :
                // Compiler\\Grammar\\Ascii\\AplusLexer.g:1:693: RP
                {
                	mRP(); 

                }
                break;
            case 95 :
                // Compiler\\Grammar\\Ascii\\AplusLexer.g:1:696: LSBracket
                {
                	mLSBracket(); 

                }
                break;
            case 96 :
                // Compiler\\Grammar\\Ascii\\AplusLexer.g:1:706: RSBracket
                {
                	mRSBracket(); 

                }
                break;
            case 97 :
                // Compiler\\Grammar\\Ascii\\AplusLexer.g:1:716: SemiColon
                {
                	mSemiColon(); 

                }
                break;
            case 98 :
                // Compiler\\Grammar\\Ascii\\AplusLexer.g:1:726: Colon
                {
                	mColon(); 

                }
                break;
            case 99 :
                // Compiler\\Grammar\\Ascii\\AplusLexer.g:1:732: Each
                {
                	mEach(); 

                }
                break;
            case 100 :
                // Compiler\\Grammar\\Ascii\\AplusLexer.g:1:737: Rank
                {
                	mRank(); 

                }
                break;
            case 101 :
                // Compiler\\Grammar\\Ascii\\AplusLexer.g:1:742: Blank
                {
                	mBlank(); 

                }
                break;
            case 102 :
                // Compiler\\Grammar\\Ascii\\AplusLexer.g:1:748: LSB
                {
                	mLSB(); 

                }
                break;
            case 103 :
                // Compiler\\Grammar\\Ascii\\AplusLexer.g:1:752: RSB
                {
                	mRSB(); 

                }
                break;
            case 104 :
                // Compiler\\Grammar\\Ascii\\AplusLexer.g:1:756: Comment
                {
                	mComment(); 

                }
                break;
            case 105 :
                // Compiler\\Grammar\\Ascii\\AplusLexer.g:1:764: CR
                {
                	mCR(); 

                }
                break;
            case 106 :
                // Compiler\\Grammar\\Ascii\\AplusLexer.g:1:767: NewLine
                {
                	mNewLine(); 

                }
                break;
            case 107 :
                // Compiler\\Grammar\\Ascii\\AplusLexer.g:1:775: Int
                {
                	mInt(); 

                }
                break;
            case 108 :
                // Compiler\\Grammar\\Ascii\\AplusLexer.g:1:779: Float
                {
                	mFloat(); 

                }
                break;
            case 109 :
                // Compiler\\Grammar\\Ascii\\AplusLexer.g:1:785: Inf
                {
                	mInf(); 

                }
                break;
            case 110 :
                // Compiler\\Grammar\\Ascii\\AplusLexer.g:1:789: CharachterConstantSQ
                {
                	mCharachterConstantSQ(); 

                }
                break;
            case 111 :
                // Compiler\\Grammar\\Ascii\\AplusLexer.g:1:810: CharachterConstantDQ
                {
                	mCharachterConstantDQ(); 

                }
                break;
            case 112 :
                // Compiler\\Grammar\\Ascii\\AplusLexer.g:1:831: SymbolConstant
                {
                	mSymbolConstant(); 

                }
                break;
            case 113 :
                // Compiler\\Grammar\\Ascii\\AplusLexer.g:1:846: UnqualifiedName
                {
                	mUnqualifiedName(); 

                }
                break;
            case 114 :
                // Compiler\\Grammar\\Ascii\\AplusLexer.g:1:862: QualifiedName
                {
                	mQualifiedName(); 

                }
                break;
            case 115 :
                // Compiler\\Grammar\\Ascii\\AplusLexer.g:1:876: SystemName
                {
                	mSystemName(); 

                }
                break;
            case 116 :
                // Compiler\\Grammar\\Ascii\\AplusLexer.g:1:887: SystemCommandName
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
        "\x01\x2d\x02\x2e\x03\uffff";
    const string DFA12_maxS =
        "\x02\x39\x01\x65\x03\uffff";
    const string DFA12_acceptS =
        "\x03\uffff\x01\x02\x01\x01\x01\x03";
    const string DFA12_specialS =
        "\x06\uffff}>";
    static readonly string[] DFA12_transitionS = {
            "\x01\x01\x01\x03\x01\uffff\x0a\x02",
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
            get { return "186:1: Float : ( ( '-' )? Number Exponent | ( '-' )? '.' Number ( Exponent )? | ( '-' )? Number '.' ( Number )? ( Exponent )? );"; }
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
            get { return "229:1: QualifiedName : ( ( UnqualifiedName '.' )+ UnqualifiedName | '.' UnqualifiedName | UnqualifiedName );"; }
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
            get { return "()+ loopback of 230:4: ( UnqualifiedName '.' )+"; }
        }

    }

    const string DFA21_eotS =
        "\x01\uffff\x05\x38\x01\x46\x01\x49\x01\x38\x01\x50\x01\x53\x01"+
        "\x55\x01\uffff\x01\x38\x01\x5a\x01\x5d\x01\x60\x01\x62\x01\x38\x01"+
        "\uffff\x02\x38\x01\x6a\x01\x6d\x01\x38\x01\uffff\x01\x71\x02\x38"+
        "\x01\uffff\x01\x79\x01\x7b\x0c\uffff\x01\x7c\x01\uffff\x01\x38\x03"+
        "\uffff\x01\x38\x02\uffff\x01\x7f\x01\x38\x01\u0081\x01\uffff\x01"+
        "\x38\x01\uffff\x03\x38\x01\u0086\x04\x38\x02\uffff\x01\u008d\x04"+
        "\uffff\x03\x38\x09\uffff\x02\x38\x03\uffff\x01\u0094\x02\uffff\x01"+
        "\u0096\x04\uffff\x06\x38\x01\u00a2\x02\uffff\x01\u00a4\x01\uffff"+
        "\x01\x38\x01\u00a7\x02\uffff\x06\x38\x06\uffff\x01\x38\x01\uffff"+
        "\x01\x38\x01\uffff\x03\x38\x01\u00b3\x01\uffff\x01\u00b4\x04\x38"+
        "\x02\uffff\x01\u00bc\x01\u00c0\x03\x38\x04\uffff\x01\u00c4\x02\x38"+
        "\x01\u00c7\x06\x38\x01\u00d1\x03\uffff\x02\x38\x01\uffff\x01\u00d4"+
        "\x02\x38\x01\u00d7\x01\u00d8\x01\x38\x01\x6b\x01\u00da\x01\u00db"+
        "\x01\u00dc\x01\u00dd\x02\uffff\x01\u00de\x02\x38\x01\u00e1\x02\uffff"+
        "\x01\u00e3\x03\uffff\x01\u00e5\x01\uffff\x01\u00e6\x01\u00e7\x01"+
        "\u00e8\x01\uffff\x01\x38\x01\u00ea\x01\uffff\x01\x38\x01\u00ec\x01"+
        "\x38\x01\u00ee\x01\u00ef\x01\u00f0\x01\u00f1\x01\u00f2\x01\u00f3"+
        "\x01\uffff\x01\u00f4\x01\u00f5\x01\uffff\x01\u00f6\x01\x38\x02\uffff"+
        "\x01\u00f8\x05\uffff\x01\u00f9\x01\u00fa\x08\uffff\x01\x38\x01\uffff"+
        "\x01\u00fc\x01\uffff\x01\u00fd\x09\uffff\x01\u00fe\x03\uffff\x01"+
        "\u00ff\x04\uffff";
    const string DFA21_eofS =
        "\u0100\uffff";
    const string DFA21_minS =
        "\x01\x09\x06\x2e\x01\x2f\x02\x2e\x01\x2f\x01\x2e\x01\uffff\x06"+
        "\x2e\x01\uffff\x03\x2e\x01\x3d\x01\x2e\x01\uffff\x03\x2e\x01\uffff"+
        "\x01\x2f\x01\x3d\x0c\uffff\x01\x2e\x01\x30\x01\x2e\x03\uffff\x01"+
        "\x2e\x02\uffff\x03\x2e\x01\uffff\x01\x2e\x01\uffff\x08\x2e\x02\uffff"+
        "\x01\x2a\x04\uffff\x03\x2e\x09\uffff\x02\x2e\x03\uffff\x01\x2e\x02"+
        "\uffff\x01\x2e\x04\uffff\x06\x2e\x01\x30\x02\uffff\x01\x2e\x01\uffff"+
        "\x02\x2e\x02\uffff\x06\x2e\x06\uffff\x01\x2e\x01\uffff\x01\x2e\x01"+
        "\uffff\x04\x2e\x01\uffff\x05\x2e\x02\uffff\x05\x2e\x04\uffff\x0b"+
        "\x2e\x03\uffff\x02\x2e\x01\uffff\x0b\x2e\x02\uffff\x04\x2e\x02\uffff"+
        "\x01\x2b\x03\uffff\x01\x2b\x01\uffff\x03\x2e\x01\uffff\x02\x2e\x01"+
        "\uffff\x09\x2e\x01\uffff\x02\x2e\x01\uffff\x02\x2e\x02\uffff\x01"+
        "\x2e\x05\uffff\x02\x2e\x08\uffff\x01\x2e\x01\uffff\x01\x2e\x01\uffff"+
        "\x01\x2e\x09\uffff\x01\x2e\x03\uffff\x01\x2e\x04\uffff";
    const string DFA21_maxS =
        "\x01\u00fe\x05\x7a\x02\x5c\x01\x7a\x02\x5c\x01\x2e\x01\uffff\x01"+
        "\x7a\x03\x3d\x01\x2e\x01\x7a\x01\uffff\x02\x7a\x01\x49\x01\x3d\x01"+
        "\x7a\x01\uffff\x01\x2e\x02\x7a\x01\uffff\x01\x2f\x01\x3d\x0c\uffff"+
        "\x01\x65\x02\x7a\x03\uffff\x01\x7a\x02\uffff\x03\x7a\x01\uffff\x01"+
        "\x7a\x01\uffff\x08\x7a\x02\uffff\x01\x2a\x04\uffff\x03\x7a\x09\uffff"+
        "\x02\x7a\x03\uffff\x01\x2e\x02\uffff\x01\x2e\x04\uffff\x06\x7a\x01"+
        "\x39\x02\uffff\x01\x2e\x01\uffff\x02\x7a\x02\uffff\x06\x7a\x06\uffff"+
        "\x01\x7a\x01\uffff\x01\x7a\x01\uffff\x04\x7a\x01\uffff\x05\x7a\x02"+
        "\uffff\x05\x7a\x04\uffff\x0b\x7a\x03\uffff\x02\x7a\x01\uffff\x0b"+
        "\x7a\x02\uffff\x04\x7a\x02\uffff\x01\x7a\x03\uffff\x01\x7a\x01\uffff"+
        "\x03\x7a\x01\uffff\x02\x7a\x01\uffff\x09\x7a\x01\uffff\x02\x7a\x01"+
        "\uffff\x02\x7a\x02\uffff\x01\x7a\x05\uffff\x02\x7a\x08\uffff\x01"+
        "\x7a\x01\uffff\x01\x7a\x01\uffff\x01\x7a\x09\uffff\x01\x7a\x03\uffff"+
        "\x01\x7a\x04\uffff";
    const string DFA21_acceptS =
        "\x0c\uffff\x01\x14\x06\uffff\x01\x20\x05\uffff\x01\x2c\x03\uffff"+
        "\x01\x3b\x02\uffff\x01\x5c\x01\x5d\x01\x5e\x01\x5f\x01\x60\x01\x61"+
        "\x01\x64\x01\x65\x01\x66\x01\x67\x01\x69\x01\x6a\x03\uffff\x01\x6e"+
        "\x01\x6f\x01\x70\x01\uffff\x01\x73\x01\x74\x03\uffff\x01\x71\x01"+
        "\uffff\x01\x72\x08\uffff\x01\x06\x01\x0c\x01\uffff\x01\x1e\x01\x07"+
        "\x01\x0d\x01\x36\x03\uffff\x01\x0a\x01\x10\x01\x4e\x01\x34\x01\x0b"+
        "\x01\x11\x01\x3f\x01\x50\x01\x12\x02\uffff\x01\x16\x01\x47\x01\x3a"+
        "\x01\uffff\x01\x48\x01\x17\x01\uffff\x01\x4a\x01\x18\x01\x52\x01"+
        "\x1a\x07\uffff\x01\x24\x01\x6d\x01\uffff\x01\x25\x02\uffff\x01\x46"+
        "\x01\x2e\x06\uffff\x01\x68\x01\x40\x01\x41\x01\x62\x01\x6b\x01\x6c"+
        "\x01\uffff\x01\x01\x01\uffff\x01\x2b\x04\uffff\x01\x03\x05\uffff"+
        "\x01\x42\x01\x45\x05\uffff\x01\x49\x01\x3c\x01\x4b\x01\x3d\x0b\uffff"+
        "\x01\x51\x01\x4f\x01\x3e\x02\uffff\x01\x29\x0b\uffff\x01\x32\x01"+
        "\x1c\x04\uffff\x01\x08\x01\x0e\x01\uffff\x01\x13\x01\x09\x01\x0f"+
        "\x01\uffff\x01\x1b\x03\uffff\x01\x1d\x02\uffff\x01\x28\x09\uffff"+
        "\x01\x23\x02\uffff\x01\x2f\x02\uffff\x01\x33\x01\x39\x01\uffff\x01"+
        "\x1f\x01\x02\x01\x19\x01\x63\x01\x2a\x02\uffff\x01\x05\x01\x43\x01"+
        "\x4c\x01\x44\x01\x4d\x01\x22\x01\x15\x01\x37\x01\uffff\x01\x21\x01"+
        "\uffff\x01\x5b\x01\uffff\x01\x55\x01\x56\x01\x57\x01\x58\x01\x59"+
        "\x01\x5a\x01\x27\x01\x2d\x01\x30\x01\uffff\x01\x35\x01\x04\x01\x26"+
        "\x01\uffff\x01\x53\x01\x54\x01\x31\x01\x38";
    const string DFA21_specialS =
        "\x01\x00\u00ff\uffff}>";
    static readonly string[] DFA21_transitionS = {
            "\x01\x27\x01\x2b\x02\uffff\x01\x2a\x12\uffff\x01\x27\x01\x13"+
            "\x01\x30\x01\x0c\x01\x34\x01\x1a\x01\x07\x01\x2f\x01\x21\x01"+
            "\x22\x01\x09\x01\x06\x01\x19\x01\x16\x01\x2d\x01\x1e\x0a\x2c"+
            "\x01\x1f\x01\x25\x01\x10\x01\x0e\x01\x0f\x01\x0a\x01\x26\x08"+
            "\x32\x01\x2e\x11\x32\x01\x23\x01\x1d\x01\x24\x01\x11\x01\x33"+
            "\x01\x31\x01\x32\x01\x14\x01\x05\x01\x03\x01\x02\x01\x0d\x02"+
            "\x32\x01\x01\x02\x32\x01\x15\x01\x08\x02\x32\x01\x18\x01\x32"+
            "\x01\x1b\x01\x32\x01\x1c\x01\x12\x01\x32\x01\x04\x03\x32\x01"+
            "\x28\x01\x0b\x01\x29\x01\x17\x7f\uffff\x01\x20",
            "\x01\x3a\x01\uffff\x0a\x39\x07\uffff\x1a\x39\x04\uffff\x01"+
            "\x39\x01\uffff\x05\x39\x01\x35\x07\x39\x01\x37\x01\x36\x0b\x39",
            "\x01\x3a\x01\uffff\x0a\x39\x07\uffff\x1a\x39\x04\uffff\x01"+
            "\x39\x01\uffff\x01\x3d\x0a\x39\x01\x3b\x09\x39\x01\x3c\x04\x39",
            "\x01\x3a\x01\uffff\x0a\x39\x07\uffff\x1a\x39\x04\uffff\x01"+
            "\x39\x01\uffff\x0d\x39\x01\x3f\x01\x3e\x02\x39\x01\x40\x08\x39",
            "\x01\x3a\x01\uffff\x0a\x39\x07\uffff\x1a\x39\x04\uffff\x01"+
            "\x39\x01\uffff\x07\x39\x01\x41\x12\x39",
            "\x01\x3a\x01\uffff\x0a\x39\x07\uffff\x1a\x39\x04\uffff\x01"+
            "\x39\x01\uffff\x01\x42\x19\x39",
            "\x01\x45\x01\x43\x2c\uffff\x01\x44",
            "\x01\x47\x2c\uffff\x01\x48",
            "\x01\x3a\x01\uffff\x0a\x39\x07\uffff\x1a\x39\x04\uffff\x01"+
            "\x39\x01\uffff\x01\x4a\x02\x39\x01\x4c\x04\x39\x01\x4b\x11\x39",
            "\x01\x4f\x01\x4d\x2c\uffff\x01\x4e",
            "\x01\x51\x2c\uffff\x01\x52",
            "\x01\x54",
            "",
            "\x01\x3a\x01\uffff\x0a\x39\x07\uffff\x1a\x39\x04\uffff\x01"+
            "\x39\x01\uffff\x0b\x39\x01\x57\x02\x39\x01\x56\x0b\x39",
            "\x01\x59\x0e\uffff\x01\x58",
            "\x01\x5c\x0e\uffff\x01\x5b",
            "\x01\x5f\x0e\uffff\x01\x5e",
            "\x01\x61",
            "\x01\x3a\x01\uffff\x0a\x39\x07\uffff\x1a\x39\x04\uffff\x01"+
            "\x39\x01\uffff\x0d\x39\x01\x64\x01\x39\x01\x63\x0a\x39",
            "",
            "\x01\x3a\x01\uffff\x0a\x39\x07\uffff\x1a\x39\x04\uffff\x01"+
            "\x39\x01\uffff\x01\x66\x03\x39\x01\x65\x11\x39\x01\x67\x03\x39",
            "\x01\x3a\x01\uffff\x0a\x39\x07\uffff\x1a\x39\x04\uffff\x01"+
            "\x39\x01\uffff\x0e\x39\x01\x68\x0b\x39",
            "\x01\x69\x01\uffff\x0a\x2c\x0f\uffff\x01\x6b",
            "\x01\x6c",
            "\x01\x3a\x01\uffff\x0a\x39\x07\uffff\x1a\x39\x04\uffff\x01"+
            "\x39\x01\uffff\x01\x6e\x07\x39\x01\x6f\x11\x39",
            "",
            "\x01\x70",
            "\x01\x3a\x01\uffff\x0a\x39\x07\uffff\x1a\x39\x04\uffff\x01"+
            "\x39\x01\uffff\x01\x73\x03\x39\x01\x76\x02\x39\x01\x75\x06\x39"+
            "\x01\x72\x04\x39\x01\x74\x06\x39",
            "\x01\x3a\x01\uffff\x0a\x39\x07\uffff\x1a\x39\x04\uffff\x01"+
            "\x39\x01\uffff\x01\x77\x19\x39",
            "",
            "\x01\x78",
            "\x01\x7a",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "\x01\x7d\x01\uffff\x0a\x2c\x0b\uffff\x01\x7d\x1f\uffff\x01"+
            "\x7d",
            "\x0a\x7d\x07\uffff\x1a\x3a\x06\uffff\x1a\x3a",
            "\x01\x3a\x01\uffff\x0a\x39\x07\uffff\x1a\x39\x04\uffff\x01"+
            "\x39\x01\uffff\x0d\x39\x01\x7e\x0c\x39",
            "",
            "",
            "",
            "\x01\x3a\x01\uffff\x0a\x39\x07\uffff\x1a\x39\x04\uffff\x01"+
            "\x39\x01\uffff\x1a\x39",
            "",
            "",
            "\x01\x3a\x01\uffff\x0a\x39\x07\uffff\x1a\x39\x04\uffff\x01"+
            "\x39\x01\uffff\x1a\x39",
            "\x01\x3a\x01\uffff\x0a\x39\x07\uffff\x1a\x39\x04\uffff\x01"+
            "\x39\x01\uffff\x13\x39\x01\u0080\x06\x39",
            "\x01\x3a\x01\uffff\x0a\x39\x07\uffff\x1a\x39\x04\uffff\x01"+
            "\x39\x01\uffff\x1a\x39",
            "",
            "\x01\x3a\x01\uffff\x0a\x39\x07\uffff\x1a\x39\x04\uffff\x01"+
            "\x39\x01\uffff\x1a\x39",
            "",
            "\x01\x3a\x01\uffff\x0a\x39\x07\uffff\x1a\x39\x04\uffff\x01"+
            "\x39\x01\uffff\x12\x39\x01\u0082\x07\x39",
            "\x01\x3a\x01\uffff\x0a\x39\x07\uffff\x1a\x39\x04\uffff\x01"+
            "\x39\x01\uffff\x01\u0083\x19\x39",
            "\x01\x3a\x01\uffff\x0a\x39\x07\uffff\x1a\x39\x04\uffff\x01"+
            "\x39\x01\uffff\x02\x39\x01\u0084\x17\x39",
            "\x01\x3a\x01\uffff\x0a\x39\x07\uffff\x1a\x39\x04\uffff\x01"+
            "\x39\x01\uffff\x13\x39\x01\u0085\x06\x39",
            "\x01\x3a\x01\uffff\x0a\x39\x07\uffff\x1a\x39\x04\uffff\x01"+
            "\x39\x01\uffff\x06\x39\x01\u0087\x13\x39",
            "\x01\x3a\x01\uffff\x0a\x39\x07\uffff\x1a\x39\x04\uffff\x01"+
            "\x39\x01\uffff\x0e\x39\x01\u0088\x0b\x39",
            "\x01\x3a\x01\uffff\x0a\x39\x07\uffff\x1a\x39\x04\uffff\x01"+
            "\x39\x01\uffff\x04\x39\x01\u008a\x03\x39\x01\u0089\x11\x39",
            "\x01\x3a\x01\uffff\x0a\x39\x07\uffff\x1a\x39\x04\uffff\x01"+
            "\x39\x01\uffff\x12\x39\x01\u008b\x07\x39",
            "",
            "",
            "\x01\u008c",
            "",
            "",
            "",
            "",
            "\x01\x3a\x01\uffff\x0a\x39\x07\uffff\x1a\x39\x04\uffff\x01"+
            "\x39\x01\uffff\x17\x39\x01\u008e\x02\x39",
            "\x01\x3a\x01\uffff\x0a\x39\x07\uffff\x1a\x39\x04\uffff\x01"+
            "\x39\x01\uffff\x0d\x39\x01\u008f\x0c\x39",
            "\x01\x3a\x01\uffff\x0a\x39\x07\uffff\x1a\x39\x04\uffff\x01"+
            "\x39\x01\uffff\x08\x39\x01\u0090\x11\x39",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "\x01\x3a\x01\uffff\x0a\x39\x07\uffff\x1a\x39\x04\uffff\x01"+
            "\x39\x01\uffff\x11\x39\x01\u0091\x08\x39",
            "\x01\x3a\x01\uffff\x0a\x39\x07\uffff\x1a\x39\x04\uffff\x01"+
            "\x39\x01\uffff\x08\x39\x01\u0092\x11\x39",
            "",
            "",
            "",
            "\x01\u0093",
            "",
            "",
            "\x01\u0095",
            "",
            "",
            "",
            "",
            "\x01\x3a\x01\uffff\x0a\x39\x07\uffff\x1a\x39\x04\uffff\x01"+
            "\x39\x01\uffff\x06\x39\x01\u0097\x13\x39",
            "\x01\x3a\x01\uffff\x0a\x39\x07\uffff\x1a\x39\x04\uffff\x01"+
            "\x39\x01\uffff\x0f\x39\x01\u0098\x0a\x39",
            "\x01\x3a\x01\uffff\x0a\x39\x07\uffff\x1a\x39\x04\uffff\x01"+
            "\x39\x01\uffff\x01\u0099\x19\x39",
            "\x01\x3a\x01\uffff\x0a\x39\x07\uffff\x1a\x39\x04\uffff\x01"+
            "\x39\x01\uffff\x06\x39\x01\u009a\x13\x39",
            "\x01\x3a\x01\uffff\x0a\x39\x07\uffff\x1a\x39\x04\uffff\x01"+
            "\x39\x01\uffff\x01\u009c\x03\x39\x01\u00a0\x01\x39\x01\u009f"+
            "\x04\x39\x01\u009e\x01\x39\x01\u009b\x01\u009d\x0b\x39",
            "\x01\x3a\x01\uffff\x0a\x39\x07\uffff\x1a\x39\x04\uffff\x01"+
            "\x39\x01\uffff\x06\x39\x01\u00a1\x13\x39",
            "\x0a\x7d",
            "",
            "",
            "\x01\u00a3",
            "",
            "\x01\x3a\x01\uffff\x0a\x39\x07\uffff\x1a\x39\x04\uffff\x01"+
            "\x39\x01\uffff\x02\x39\x01\u00a5\x17\x39",
            "\x01\x3a\x01\uffff\x0a\x39\x07\uffff\x1a\x39\x04\uffff\x01"+
            "\x39\x01\uffff\x02\x39\x01\u00a6\x17\x39",
            "",
            "",
            "\x01\x3a\x01\uffff\x0a\x39\x07\uffff\x1a\x39\x04\uffff\x01"+
            "\x39\x01\uffff\x13\x39\x01\u00a8\x06\x39",
            "\x01\x3a\x01\uffff\x0a\x39\x07\uffff\x1a\x39\x04\uffff\x01"+
            "\x39\x01\uffff\x0d\x39\x01\u00a9\x0c\x39",
            "\x01\x3a\x01\uffff\x0a\x39\x07\uffff\x1a\x39\x04\uffff\x01"+
            "\x39\x01\uffff\x01\u00aa\x19\x39",
            "\x01\x3a\x01\uffff\x0a\x39\x07\uffff\x1a\x39\x04\uffff\x01"+
            "\x39\x01\uffff\x0e\x39\x01\u00ab\x0b\x39",
            "\x01\x3a\x01\uffff\x0a\x39\x07\uffff\x1a\x39\x04\uffff\x01"+
            "\x39\x01\uffff\x05\x39\x01\u00ac\x14\x39",
            "\x01\x3a\x01\uffff\x0a\x39\x07\uffff\x1a\x39\x04\uffff\x01"+
            "\x39\x01\uffff\x0a\x39\x01\u00ad\x0f\x39",
            "",
            "",
            "",
            "",
            "",
            "",
            "\x01\x3a\x01\uffff\x0a\x39\x07\uffff\x1a\x39\x04\uffff\x01"+
            "\x39\x01\uffff\x05\x39\x01\u00ae\x14\x39",
            "",
            "\x01\x3a\x01\uffff\x0a\x39\x07\uffff\x1a\x39\x04\uffff\x01"+
            "\x39\x01\uffff\x01\u00af\x19\x39",
            "",
            "\x01\x3a\x01\uffff\x0a\x39\x07\uffff\x1a\x39\x04\uffff\x01"+
            "\x39\x01\uffff\x04\x39\x01\u00b0\x15\x39",
            "\x01\x3a\x01\uffff\x0a\x39\x07\uffff\x1a\x39\x04\uffff\x01"+
            "\x39\x01\uffff\x0b\x39\x01\u00b1\x0e\x39",
            "\x01\x3a\x01\uffff\x0a\x39\x07\uffff\x1a\x39\x04\uffff\x01"+
            "\x39\x01\uffff\x07\x39\x01\u00b2\x12\x39",
            "\x01\x3a\x01\uffff\x0a\x39\x07\uffff\x1a\x39\x04\uffff\x01"+
            "\x39\x01\uffff\x1a\x39",
            "",
            "\x01\x3a\x01\uffff\x0a\x39\x07\uffff\x1a\x39\x04\uffff\x01"+
            "\x39\x01\uffff\x1a\x39",
            "\x01\x3a\x01\uffff\x0a\x39\x07\uffff\x1a\x39\x04\uffff\x01"+
            "\x39\x01\uffff\x0f\x39\x01\u00b5\x0a\x39",
            "\x01\x3a\x01\uffff\x0a\x39\x07\uffff\x1a\x39\x04\uffff\x01"+
            "\x39\x01\uffff\x0b\x39\x01\u00b6\x0e\x39",
            "\x01\x3a\x01\uffff\x0a\x39\x07\uffff\x1a\x39\x04\uffff\x01"+
            "\x39\x01\uffff\x11\x39\x01\u00b7\x08\x39",
            "\x01\x3a\x01\uffff\x0a\x39\x07\uffff\x1a\x39\x04\uffff\x01"+
            "\x39\x01\uffff\x04\x39\x01\u00b8\x15\x39",
            "",
            "",
            "\x01\u00bb\x01\u00b9\x0a\x39\x07\uffff\x1a\x39\x01\uffff\x01"+
            "\u00ba\x02\uffff\x01\x39\x01\uffff\x1a\x39",
            "\x01\u00bf\x01\u00bd\x0a\x39\x07\uffff\x1a\x39\x01\uffff\x01"+
            "\u00be\x02\uffff\x01\x39\x01\uffff\x1a\x39",
            "\x01\x3a\x01\uffff\x0a\x39\x07\uffff\x1a\x39\x04\uffff\x01"+
            "\x39\x01\uffff\x15\x39\x01\u00c1\x04\x39",
            "\x01\x3a\x01\uffff\x0a\x39\x07\uffff\x1a\x39\x04\uffff\x01"+
            "\x39\x01\uffff\x0c\x39\x01\u00c2\x0d\x39",
            "\x01\x3a\x01\uffff\x0a\x39\x07\uffff\x1a\x39\x04\uffff\x01"+
            "\x39\x01\uffff\x0f\x39\x01\u00c3\x0a\x39",
            "",
            "",
            "",
            "",
            "\x01\x3a\x01\uffff\x0a\x39\x07\uffff\x1a\x39\x04\uffff\x01"+
            "\x39\x01\uffff\x1a\x39",
            "\x01\x3a\x01\uffff\x0a\x39\x07\uffff\x1a\x39\x04\uffff\x01"+
            "\x39\x01\uffff\x01\u00c5\x19\x39",
            "\x01\x3a\x01\uffff\x0a\x39\x07\uffff\x1a\x39\x04\uffff\x01"+
            "\x39\x01\uffff\x0c\x39\x01\u00c6\x0d\x39",
            "\x01\x3a\x01\uffff\x0a\x39\x07\uffff\x1a\x39\x04\uffff\x01"+
            "\x39\x01\uffff\x1a\x39",
            "\x01\x3a\x01\uffff\x0a\x39\x07\uffff\x1a\x39\x04\uffff\x01"+
            "\x39\x01\uffff\x04\x39\x01\u00c9\x09\x39\x01\u00c8\x0b\x39",
            "\x01\x3a\x01\uffff\x0a\x39\x07\uffff\x1a\x39\x04\uffff\x01"+
            "\x39\x01\uffff\x0d\x39\x01\u00ca\x0c\x39",
            "\x01\x3a\x01\uffff\x0a\x39\x07\uffff\x1a\x39\x04\uffff\x01"+
            "\x39\x01\uffff\x11\x39\x01\u00cb\x08\x39",
            "\x01\x3a\x01\uffff\x0a\x39\x07\uffff\x1a\x39\x04\uffff\x01"+
            "\x39\x01\uffff\x04\x39\x01\u00cd\x0e\x39\x01\u00cc\x06\x39",
            "\x01\x3a\x01\uffff\x0a\x39\x07\uffff\x1a\x39\x04\uffff\x01"+
            "\x39\x01\uffff\x04\x39\x01\u00cf\x0e\x39\x01\u00ce\x06\x39",
            "\x01\x3a\x01\uffff\x0a\x39\x07\uffff\x1a\x39\x04\uffff\x01"+
            "\x39\x01\uffff\x10\x39\x01\u00d0\x09\x39",
            "\x01\x3a\x01\uffff\x0a\x39\x07\uffff\x1a\x39\x04\uffff\x01"+
            "\x39\x01\uffff\x1a\x39",
            "",
            "",
            "",
            "\x01\x3a\x01\uffff\x0a\x39\x07\uffff\x1a\x39\x04\uffff\x01"+
            "\x39\x01\uffff\x0a\x39\x01\u00d2\x0f\x39",
            "\x01\x3a\x01\uffff\x0a\x39\x07\uffff\x1a\x39\x04\uffff\x01"+
            "\x39\x01\uffff\x0a\x39\x01\u00d3\x0f\x39",
            "",
            "\x01\x3a\x01\uffff\x0a\x39\x07\uffff\x1a\x39\x04\uffff\x01"+
            "\x39\x01\uffff\x1a\x39",
            "\x01\x3a\x01\uffff\x0a\x39\x07\uffff\x1a\x39\x04\uffff\x01"+
            "\x39\x01\uffff\x03\x39\x01\u00d5\x16\x39",
            "\x01\x3a\x01\uffff\x0a\x39\x07\uffff\x1a\x39\x04\uffff\x01"+
            "\x39\x01\uffff\x02\x39\x01\u00d6\x17\x39",
            "\x01\x3a\x01\uffff\x0a\x39\x07\uffff\x1a\x39\x04\uffff\x01"+
            "\x39\x01\uffff\x1a\x39",
            "\x01\x3a\x01\uffff\x0a\x39\x07\uffff\x1a\x39\x04\uffff\x01"+
            "\x39\x01\uffff\x1a\x39",
            "\x01\x3a\x01\uffff\x0a\x39\x07\uffff\x1a\x39\x04\uffff\x01"+
            "\x39\x01\uffff\x04\x39\x01\u00d9\x15\x39",
            "\x01\x3a\x01\uffff\x0a\x39\x07\uffff\x1a\x39\x04\uffff\x01"+
            "\x39\x01\uffff\x1a\x39",
            "\x01\x3a\x01\uffff\x0a\x39\x07\uffff\x1a\x39\x04\uffff\x01"+
            "\x39\x01\uffff\x1a\x39",
            "\x01\x3a\x01\uffff\x0a\x39\x07\uffff\x1a\x39\x04\uffff\x01"+
            "\x39\x01\uffff\x1a\x39",
            "\x01\x3a\x01\uffff\x0a\x39\x07\uffff\x1a\x39\x04\uffff\x01"+
            "\x39\x01\uffff\x1a\x39",
            "\x01\x3a\x01\uffff\x0a\x39\x07\uffff\x1a\x39\x04\uffff\x01"+
            "\x39\x01\uffff\x1a\x39",
            "",
            "",
            "\x01\x3a\x01\uffff\x0a\x39\x07\uffff\x1a\x39\x04\uffff\x01"+
            "\x39\x01\uffff\x1a\x39",
            "\x01\x3a\x01\uffff\x0a\x39\x07\uffff\x1a\x39\x04\uffff\x01"+
            "\x39\x01\uffff\x04\x39\x01\u00df\x15\x39",
            "\x01\x3a\x01\uffff\x0a\x39\x07\uffff\x1a\x39\x04\uffff\x01"+
            "\x39\x01\uffff\x04\x39\x01\u00e0\x15\x39",
            "\x01\x3a\x01\uffff\x0a\x39\x07\uffff\x1a\x39\x04\uffff\x01"+
            "\x39\x01\uffff\x1a\x39",
            "",
            "",
            "\x01\u00e2\x15\uffff\x1a\x3a\x06\uffff\x1a\x3a",
            "",
            "",
            "",
            "\x01\u00e4\x15\uffff\x1a\x3a\x06\uffff\x1a\x3a",
            "",
            "\x01\x3a\x01\uffff\x0a\x39\x07\uffff\x1a\x39\x04\uffff\x01"+
            "\x39\x01\uffff\x1a\x39",
            "\x01\x3a\x01\uffff\x0a\x39\x07\uffff\x1a\x39\x04\uffff\x01"+
            "\x39\x01\uffff\x1a\x39",
            "\x01\x3a\x01\uffff\x0a\x39\x07\uffff\x1a\x39\x04\uffff\x01"+
            "\x39\x01\uffff\x1a\x39",
            "",
            "\x01\x3a\x01\uffff\x0a\x39\x07\uffff\x1a\x39\x04\uffff\x01"+
            "\x39\x01\uffff\x02\x39\x01\u00e9\x17\x39",
            "\x01\x3a\x01\uffff\x0a\x39\x07\uffff\x1a\x39\x04\uffff\x01"+
            "\x39\x01\uffff\x1a\x39",
            "",
            "\x01\x3a\x01\uffff\x0a\x39\x07\uffff\x1a\x39\x04\uffff\x01"+
            "\x39\x01\uffff\x13\x39\x01\u00eb\x06\x39",
            "\x01\x3a\x01\uffff\x0a\x39\x07\uffff\x1a\x39\x04\uffff\x01"+
            "\x39\x01\uffff\x1a\x39",
            "\x01\x3a\x01\uffff\x0a\x39\x07\uffff\x1a\x39\x04\uffff\x01"+
            "\x39\x01\uffff\x03\x39\x01\u00ed\x16\x39",
            "\x01\x3a\x01\uffff\x0a\x39\x07\uffff\x1a\x39\x04\uffff\x01"+
            "\x39\x01\uffff\x1a\x39",
            "\x01\x3a\x01\uffff\x0a\x39\x07\uffff\x1a\x39\x04\uffff\x01"+
            "\x39\x01\uffff\x1a\x39",
            "\x01\x3a\x01\uffff\x0a\x39\x07\uffff\x1a\x39\x04\uffff\x01"+
            "\x39\x01\uffff\x1a\x39",
            "\x01\x3a\x01\uffff\x0a\x39\x07\uffff\x1a\x39\x04\uffff\x01"+
            "\x39\x01\uffff\x1a\x39",
            "\x01\x3a\x01\uffff\x0a\x39\x07\uffff\x1a\x39\x04\uffff\x01"+
            "\x39\x01\uffff\x1a\x39",
            "\x01\x3a\x01\uffff\x0a\x39\x07\uffff\x1a\x39\x04\uffff\x01"+
            "\x39\x01\uffff\x1a\x39",
            "",
            "\x01\x3a\x01\uffff\x0a\x39\x07\uffff\x1a\x39\x04\uffff\x01"+
            "\x39\x01\uffff\x1a\x39",
            "\x01\x3a\x01\uffff\x0a\x39\x07\uffff\x1a\x39\x04\uffff\x01"+
            "\x39\x01\uffff\x1a\x39",
            "",
            "\x01\x3a\x01\uffff\x0a\x39\x07\uffff\x1a\x39\x04\uffff\x01"+
            "\x39\x01\uffff\x1a\x39",
            "\x01\x3a\x01\uffff\x0a\x39\x07\uffff\x1a\x39\x04\uffff\x01"+
            "\x39\x01\uffff\x0a\x39\x01\u00f7\x0f\x39",
            "",
            "",
            "\x01\x3a\x01\uffff\x0a\x39\x07\uffff\x1a\x39\x04\uffff\x01"+
            "\x39\x01\uffff\x1a\x39",
            "",
            "",
            "",
            "",
            "",
            "\x01\x3a\x01\uffff\x0a\x39\x07\uffff\x1a\x39\x04\uffff\x01"+
            "\x39\x01\uffff\x1a\x39",
            "\x01\x3a\x01\uffff\x0a\x39\x07\uffff\x1a\x39\x04\uffff\x01"+
            "\x39\x01\uffff\x1a\x39",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "\x01\x3a\x01\uffff\x0a\x39\x07\uffff\x1a\x39\x04\uffff\x01"+
            "\x39\x01\uffff\x0a\x39\x01\u00fb\x0f\x39",
            "",
            "\x01\x3a\x01\uffff\x0a\x39\x07\uffff\x1a\x39\x04\uffff\x01"+
            "\x39\x01\uffff\x1a\x39",
            "",
            "\x01\x3a\x01\uffff\x0a\x39\x07\uffff\x1a\x39\x04\uffff\x01"+
            "\x39\x01\uffff\x1a\x39",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "\x01\x3a\x01\uffff\x0a\x39\x07\uffff\x1a\x39\x04\uffff\x01"+
            "\x39\x01\uffff\x1a\x39",
            "",
            "",
            "",
            "\x01\x3a\x01\uffff\x0a\x39\x07\uffff\x1a\x39\x04\uffff\x01"+
            "\x39\x01\uffff\x1a\x39",
            "",
            "",
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

                   	else if ( (LA21_0 == '&') ) { s = 7; }

                   	else if ( (LA21_0 == 'm') ) { s = 8; }

                   	else if ( (LA21_0 == '*') ) { s = 9; }

                   	else if ( (LA21_0 == '?') ) { s = 10; }

                   	else if ( (LA21_0 == '|') ) { s = 11; }

                   	else if ( (LA21_0 == '#') ) { s = 12; }

                   	else if ( (LA21_0 == 'f') ) { s = 13; }

                   	else if ( (LA21_0 == '=') ) { s = 14; }

                   	else if ( (LA21_0 == '>') ) { s = 15; }

                   	else if ( (LA21_0 == '<') ) { s = 16; }

                   	else if ( (LA21_0 == '^') ) { s = 17; }

                   	else if ( (LA21_0 == 'u') ) { s = 18; }

                   	else if ( (LA21_0 == '!') ) { s = 19; }

                   	else if ( (LA21_0 == 'b') ) { s = 20; }

                   	else if ( (LA21_0 == 'l') ) { s = 21; }

                   	else if ( (LA21_0 == '-') ) { s = 22; }

                   	else if ( (LA21_0 == '~') ) { s = 23; }

                   	else if ( (LA21_0 == 'p') ) { s = 24; }

                   	else if ( (LA21_0 == ',') ) { s = 25; }

                   	else if ( (LA21_0 == '%') ) { s = 26; }

                   	else if ( (LA21_0 == 'r') ) { s = 27; }

                   	else if ( (LA21_0 == 't') ) { s = 28; }

                   	else if ( (LA21_0 == '\\') ) { s = 29; }

                   	else if ( (LA21_0 == '/') ) { s = 30; }

                   	else if ( (LA21_0 == ':') ) { s = 31; }

                   	else if ( (LA21_0 == '\u00FE') ) { s = 32; }

                   	else if ( (LA21_0 == '(') ) { s = 33; }

                   	else if ( (LA21_0 == ')') ) { s = 34; }

                   	else if ( (LA21_0 == '[') ) { s = 35; }

                   	else if ( (LA21_0 == ']') ) { s = 36; }

                   	else if ( (LA21_0 == ';') ) { s = 37; }

                   	else if ( (LA21_0 == '@') ) { s = 38; }

                   	else if ( (LA21_0 == '\t' || LA21_0 == ' ') ) { s = 39; }

                   	else if ( (LA21_0 == '{') ) { s = 40; }

                   	else if ( (LA21_0 == '}') ) { s = 41; }

                   	else if ( (LA21_0 == '\r') ) { s = 42; }

                   	else if ( (LA21_0 == '\n') && (((mode > 0)|| (mode == 0))) ) { s = 43; }

                   	else if ( ((LA21_0 >= '0' && LA21_0 <= '9')) ) { s = 44; }

                   	else if ( (LA21_0 == '.') ) { s = 45; }

                   	else if ( (LA21_0 == 'I') ) { s = 46; }

                   	else if ( (LA21_0 == '\'') ) { s = 47; }

                   	else if ( (LA21_0 == '\"') ) { s = 48; }

                   	else if ( (LA21_0 == '`') ) { s = 49; }

                   	else if ( ((LA21_0 >= 'A' && LA21_0 <= 'H') || (LA21_0 >= 'J' && LA21_0 <= 'Z') || LA21_0 == 'a' || (LA21_0 >= 'g' && LA21_0 <= 'h') || (LA21_0 >= 'j' && LA21_0 <= 'k') || (LA21_0 >= 'n' && LA21_0 <= 'o') || LA21_0 == 'q' || LA21_0 == 's' || LA21_0 == 'v' || (LA21_0 >= 'x' && LA21_0 <= 'z')) ) { s = 50; }

                   	else if ( (LA21_0 == '_') ) { s = 51; }

                   	else if ( (LA21_0 == '$') ) { s = 52; }

                   	 
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