//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 3.5
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// $ANTLR 3.5 C:\\Data\\ADNug-Antlr\\Code\\Raw\\Parser\\Dsl.g 2016-01-21 11:47:11

// The variable 'variable' is assigned but its value is never used.
#pragma warning disable 219
// Unreachable code detected.
#pragma warning disable 162
// Missing XML comment for publicly visible type or member 'Type_or_Member'
#pragma warning disable 1591
// CLS compliance checking will not be performed on 'type' because it is not visible from outside this assembly.
#pragma warning disable 3019


using System.Collections.Generic;
using Antlr.Runtime;
using Antlr.Runtime.Misc;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "3.5")]
[System.CLSCompliant(false)]
public partial class DslLexer : Antlr.Runtime.Lexer
{
	public const int EOF=-1;
	public const int APOSTRAPHE=4;
	public const int COMMENT=5;
	public const int DIGIT=6;
	public const int EQUAL=7;
	public const int GREATER=8;
	public const int INT=9;
	public const int IS=10;
	public const int LESS=11;
	public const int LETTER=12;
	public const int LINE_COMMENT_SLASH=13;
	public const int NEWLINE=14;
	public const int NOT=15;
	public const int PLUS=16;
	public const int STAR=17;
	public const int STRING_LITERAL=18;
	public const int THAN=19;
	public const int VARIABLE=20;
	public const int WHEN=21;
	public const int WS=22;

    // delegates
    // delegators

	public DslLexer()
	{
		OnCreated();
	}

	public DslLexer(ICharStream input )
		: this(input, new RecognizerSharedState())
	{
	}

	public DslLexer(ICharStream input, RecognizerSharedState state)
		: base(input, state)
	{

		OnCreated();
	}
	public override string GrammarFileName { get { return "C:\\Data\\ADNug-Antlr\\Code\\Raw\\Parser\\Dsl.g"; } }


	partial void OnCreated();
	partial void EnterRule(string ruleName, int ruleIndex);
	partial void LeaveRule(string ruleName, int ruleIndex);

	partial void EnterRule_APOSTRAPHE();
	partial void LeaveRule_APOSTRAPHE();

	// $ANTLR start "APOSTRAPHE"
	[GrammarRule("APOSTRAPHE")]
	private void mAPOSTRAPHE()
	{
		EnterRule_APOSTRAPHE();
		EnterRule("APOSTRAPHE", 1);
		TraceIn("APOSTRAPHE", 1);
		try
		{
			int _type = APOSTRAPHE;
			int _channel = DefaultTokenChannel;
			// C:\\Data\\ADNug-Antlr\\Code\\Raw\\Parser\\Dsl.g:39:12: ( '\\'' )
			DebugEnterAlt(1);
			// C:\\Data\\ADNug-Antlr\\Code\\Raw\\Parser\\Dsl.g:39:14: '\\''
			{
			DebugLocation(39, 14);
			Match('\''); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("APOSTRAPHE", 1);
			LeaveRule("APOSTRAPHE", 1);
			LeaveRule_APOSTRAPHE();
		}
	}
	// $ANTLR end "APOSTRAPHE"

	partial void EnterRule_VARIABLE();
	partial void LeaveRule_VARIABLE();

	// $ANTLR start "VARIABLE"
	[GrammarRule("VARIABLE")]
	private void mVARIABLE()
	{
		EnterRule_VARIABLE();
		EnterRule("VARIABLE", 2);
		TraceIn("VARIABLE", 2);
		try
		{
			int _type = VARIABLE;
			int _channel = DefaultTokenChannel;
			// C:\\Data\\ADNug-Antlr\\Code\\Raw\\Parser\\Dsl.g:40:9: ( '[' ( LETTER )+ ']' )
			DebugEnterAlt(1);
			// C:\\Data\\ADNug-Antlr\\Code\\Raw\\Parser\\Dsl.g:40:11: '[' ( LETTER )+ ']'
			{
			DebugLocation(40, 11);
			Match('['); 
			DebugLocation(40, 15);
			// C:\\Data\\ADNug-Antlr\\Code\\Raw\\Parser\\Dsl.g:40:15: ( LETTER )+
			int cnt1=0;
			try { DebugEnterSubRule(1);
			while (true)
			{
				int alt1=2;
				try { DebugEnterDecision(1, false);
				int LA1_1 = input.LA(1);

				if (((LA1_1>='A' && LA1_1<='Z')||(LA1_1>='a' && LA1_1<='z')))
				{
					alt1 = 1;
				}


				} finally { DebugExitDecision(1); }
				switch (alt1)
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\Data\\ADNug-Antlr\\Code\\Raw\\Parser\\Dsl.g:
					{
					DebugLocation(40, 15);
					input.Consume();


					}
					break;

				default:
					if (cnt1 >= 1)
						goto loop1;

					EarlyExitException eee1 = new EarlyExitException( 1, input );
					DebugRecognitionException(eee1);
					throw eee1;
				}
				cnt1++;
			}
			loop1:
				;

			} finally { DebugExitSubRule(1); }

			DebugLocation(40, 23);
			Match(']'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("VARIABLE", 2);
			LeaveRule("VARIABLE", 2);
			LeaveRule_VARIABLE();
		}
	}
	// $ANTLR end "VARIABLE"

	partial void EnterRule_STAR();
	partial void LeaveRule_STAR();

	// $ANTLR start "STAR"
	[GrammarRule("STAR")]
	private void mSTAR()
	{
		EnterRule_STAR();
		EnterRule("STAR", 3);
		TraceIn("STAR", 3);
		try
		{
			int _type = STAR;
			int _channel = DefaultTokenChannel;
			// C:\\Data\\ADNug-Antlr\\Code\\Raw\\Parser\\Dsl.g:41:5: ( '*' )
			DebugEnterAlt(1);
			// C:\\Data\\ADNug-Antlr\\Code\\Raw\\Parser\\Dsl.g:41:7: '*'
			{
			DebugLocation(41, 7);
			Match('*'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("STAR", 3);
			LeaveRule("STAR", 3);
			LeaveRule_STAR();
		}
	}
	// $ANTLR end "STAR"

	partial void EnterRule_PLUS();
	partial void LeaveRule_PLUS();

	// $ANTLR start "PLUS"
	[GrammarRule("PLUS")]
	private void mPLUS()
	{
		EnterRule_PLUS();
		EnterRule("PLUS", 4);
		TraceIn("PLUS", 4);
		try
		{
			int _type = PLUS;
			int _channel = DefaultTokenChannel;
			// C:\\Data\\ADNug-Antlr\\Code\\Raw\\Parser\\Dsl.g:42:5: ( '+' )
			DebugEnterAlt(1);
			// C:\\Data\\ADNug-Antlr\\Code\\Raw\\Parser\\Dsl.g:42:7: '+'
			{
			DebugLocation(42, 7);
			Match('+'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("PLUS", 4);
			LeaveRule("PLUS", 4);
			LeaveRule_PLUS();
		}
	}
	// $ANTLR end "PLUS"

	partial void EnterRule_EQUAL();
	partial void LeaveRule_EQUAL();

	// $ANTLR start "EQUAL"
	[GrammarRule("EQUAL")]
	private void mEQUAL()
	{
		EnterRule_EQUAL();
		EnterRule("EQUAL", 5);
		TraceIn("EQUAL", 5);
		try
		{
			int _type = EQUAL;
			int _channel = DefaultTokenChannel;
			// C:\\Data\\ADNug-Antlr\\Code\\Raw\\Parser\\Dsl.g:43:6: ( 'equal' )
			DebugEnterAlt(1);
			// C:\\Data\\ADNug-Antlr\\Code\\Raw\\Parser\\Dsl.g:43:8: 'equal'
			{
			DebugLocation(43, 8);
			Match("equal"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("EQUAL", 5);
			LeaveRule("EQUAL", 5);
			LeaveRule_EQUAL();
		}
	}
	// $ANTLR end "EQUAL"

	partial void EnterRule_GREATER();
	partial void LeaveRule_GREATER();

	// $ANTLR start "GREATER"
	[GrammarRule("GREATER")]
	private void mGREATER()
	{
		EnterRule_GREATER();
		EnterRule("GREATER", 6);
		TraceIn("GREATER", 6);
		try
		{
			int _type = GREATER;
			int _channel = DefaultTokenChannel;
			// C:\\Data\\ADNug-Antlr\\Code\\Raw\\Parser\\Dsl.g:44:8: ( 'greater' )
			DebugEnterAlt(1);
			// C:\\Data\\ADNug-Antlr\\Code\\Raw\\Parser\\Dsl.g:44:10: 'greater'
			{
			DebugLocation(44, 10);
			Match("greater"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("GREATER", 6);
			LeaveRule("GREATER", 6);
			LeaveRule_GREATER();
		}
	}
	// $ANTLR end "GREATER"

	partial void EnterRule_LESS();
	partial void LeaveRule_LESS();

	// $ANTLR start "LESS"
	[GrammarRule("LESS")]
	private void mLESS()
	{
		EnterRule_LESS();
		EnterRule("LESS", 7);
		TraceIn("LESS", 7);
		try
		{
			int _type = LESS;
			int _channel = DefaultTokenChannel;
			// C:\\Data\\ADNug-Antlr\\Code\\Raw\\Parser\\Dsl.g:45:5: ( 'less' )
			DebugEnterAlt(1);
			// C:\\Data\\ADNug-Antlr\\Code\\Raw\\Parser\\Dsl.g:45:7: 'less'
			{
			DebugLocation(45, 7);
			Match("less"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("LESS", 7);
			LeaveRule("LESS", 7);
			LeaveRule_LESS();
		}
	}
	// $ANTLR end "LESS"

	partial void EnterRule_THAN();
	partial void LeaveRule_THAN();

	// $ANTLR start "THAN"
	[GrammarRule("THAN")]
	private void mTHAN()
	{
		EnterRule_THAN();
		EnterRule("THAN", 8);
		TraceIn("THAN", 8);
		try
		{
			int _type = THAN;
			int _channel = DefaultTokenChannel;
			// C:\\Data\\ADNug-Antlr\\Code\\Raw\\Parser\\Dsl.g:46:5: ( 'than' )
			DebugEnterAlt(1);
			// C:\\Data\\ADNug-Antlr\\Code\\Raw\\Parser\\Dsl.g:46:7: 'than'
			{
			DebugLocation(46, 7);
			Match("than"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("THAN", 8);
			LeaveRule("THAN", 8);
			LeaveRule_THAN();
		}
	}
	// $ANTLR end "THAN"

	partial void EnterRule_NOT();
	partial void LeaveRule_NOT();

	// $ANTLR start "NOT"
	[GrammarRule("NOT")]
	private void mNOT()
	{
		EnterRule_NOT();
		EnterRule("NOT", 9);
		TraceIn("NOT", 9);
		try
		{
			int _type = NOT;
			int _channel = DefaultTokenChannel;
			// C:\\Data\\ADNug-Antlr\\Code\\Raw\\Parser\\Dsl.g:47:4: ( 'not' )
			DebugEnterAlt(1);
			// C:\\Data\\ADNug-Antlr\\Code\\Raw\\Parser\\Dsl.g:47:6: 'not'
			{
			DebugLocation(47, 6);
			Match("not"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("NOT", 9);
			LeaveRule("NOT", 9);
			LeaveRule_NOT();
		}
	}
	// $ANTLR end "NOT"

	partial void EnterRule_IS();
	partial void LeaveRule_IS();

	// $ANTLR start "IS"
	[GrammarRule("IS")]
	private void mIS()
	{
		EnterRule_IS();
		EnterRule("IS", 10);
		TraceIn("IS", 10);
		try
		{
			int _type = IS;
			int _channel = DefaultTokenChannel;
			// C:\\Data\\ADNug-Antlr\\Code\\Raw\\Parser\\Dsl.g:48:3: ( 'is' )
			DebugEnterAlt(1);
			// C:\\Data\\ADNug-Antlr\\Code\\Raw\\Parser\\Dsl.g:48:5: 'is'
			{
			DebugLocation(48, 5);
			Match("is"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("IS", 10);
			LeaveRule("IS", 10);
			LeaveRule_IS();
		}
	}
	// $ANTLR end "IS"

	partial void EnterRule_WHEN();
	partial void LeaveRule_WHEN();

	// $ANTLR start "WHEN"
	[GrammarRule("WHEN")]
	private void mWHEN()
	{
		EnterRule_WHEN();
		EnterRule("WHEN", 11);
		TraceIn("WHEN", 11);
		try
		{
			int _type = WHEN;
			int _channel = DefaultTokenChannel;
			// C:\\Data\\ADNug-Antlr\\Code\\Raw\\Parser\\Dsl.g:49:5: ( 'when' )
			DebugEnterAlt(1);
			// C:\\Data\\ADNug-Antlr\\Code\\Raw\\Parser\\Dsl.g:49:7: 'when'
			{
			DebugLocation(49, 7);
			Match("when"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("WHEN", 11);
			LeaveRule("WHEN", 11);
			LeaveRule_WHEN();
		}
	}
	// $ANTLR end "WHEN"

	partial void EnterRule_NEWLINE();
	partial void LeaveRule_NEWLINE();

	// $ANTLR start "NEWLINE"
	[GrammarRule("NEWLINE")]
	private void mNEWLINE()
	{
		EnterRule_NEWLINE();
		EnterRule("NEWLINE", 12);
		TraceIn("NEWLINE", 12);
		try
		{
			int _type = NEWLINE;
			int _channel = DefaultTokenChannel;
			// C:\\Data\\ADNug-Antlr\\Code\\Raw\\Parser\\Dsl.g:50:8: ( ( '\\n' | '\\r' ) )
			DebugEnterAlt(1);
			// C:\\Data\\ADNug-Antlr\\Code\\Raw\\Parser\\Dsl.g:
			{
			DebugLocation(50, 8);
			if (input.LA(1)=='\n'||input.LA(1)=='\r')
			{
				input.Consume();
			}
			else
			{
				MismatchedSetException mse = new MismatchedSetException(null,input);
				DebugRecognitionException(mse);
				Recover(mse);
				throw mse;
			}


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("NEWLINE", 12);
			LeaveRule("NEWLINE", 12);
			LeaveRule_NEWLINE();
		}
	}
	// $ANTLR end "NEWLINE"

	partial void EnterRule_STRING_LITERAL();
	partial void LeaveRule_STRING_LITERAL();

	// $ANTLR start "STRING_LITERAL"
	[GrammarRule("STRING_LITERAL")]
	private void mSTRING_LITERAL()
	{
		EnterRule_STRING_LITERAL();
		EnterRule("STRING_LITERAL", 13);
		TraceIn("STRING_LITERAL", 13);
		try
		{
			int _type = STRING_LITERAL;
			int _channel = DefaultTokenChannel;
			// C:\\Data\\ADNug-Antlr\\Code\\Raw\\Parser\\Dsl.g:51:15: ( APOSTRAPHE (~ ( APOSTRAPHE ) )* APOSTRAPHE )
			DebugEnterAlt(1);
			// C:\\Data\\ADNug-Antlr\\Code\\Raw\\Parser\\Dsl.g:51:17: APOSTRAPHE (~ ( APOSTRAPHE ) )* APOSTRAPHE
			{
			DebugLocation(51, 17);
			mAPOSTRAPHE(); 
			DebugLocation(51, 28);
			// C:\\Data\\ADNug-Antlr\\Code\\Raw\\Parser\\Dsl.g:51:28: (~ ( APOSTRAPHE ) )*
			try { DebugEnterSubRule(2);
			while (true)
			{
				int alt2=2;
				try { DebugEnterDecision(2, false);
				int LA2_1 = input.LA(1);

				if (((LA2_1>='\u0000' && LA2_1<='&')||(LA2_1>='(' && LA2_1<='\uFFFF')))
				{
					alt2 = 1;
				}


				} finally { DebugExitDecision(2); }
				switch ( alt2 )
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\Data\\ADNug-Antlr\\Code\\Raw\\Parser\\Dsl.g:
					{
					DebugLocation(51, 28);
					input.Consume();


					}
					break;

				default:
					goto loop2;
				}
			}

			loop2:
				;

			} finally { DebugExitSubRule(2); }

			DebugLocation(51, 43);
			mAPOSTRAPHE(); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("STRING_LITERAL", 13);
			LeaveRule("STRING_LITERAL", 13);
			LeaveRule_STRING_LITERAL();
		}
	}
	// $ANTLR end "STRING_LITERAL"

	partial void EnterRule_INT();
	partial void LeaveRule_INT();

	// $ANTLR start "INT"
	[GrammarRule("INT")]
	private void mINT()
	{
		EnterRule_INT();
		EnterRule("INT", 14);
		TraceIn("INT", 14);
		try
		{
			int _type = INT;
			int _channel = DefaultTokenChannel;
			// C:\\Data\\ADNug-Antlr\\Code\\Raw\\Parser\\Dsl.g:52:5: ( ( DIGIT )+ )
			DebugEnterAlt(1);
			// C:\\Data\\ADNug-Antlr\\Code\\Raw\\Parser\\Dsl.g:52:7: ( DIGIT )+
			{
			DebugLocation(52, 7);
			// C:\\Data\\ADNug-Antlr\\Code\\Raw\\Parser\\Dsl.g:52:7: ( DIGIT )+
			int cnt3=0;
			try { DebugEnterSubRule(3);
			while (true)
			{
				int alt3=2;
				try { DebugEnterDecision(3, false);
				int LA3_1 = input.LA(1);

				if (((LA3_1>='0' && LA3_1<='9')))
				{
					alt3 = 1;
				}


				} finally { DebugExitDecision(3); }
				switch (alt3)
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\Data\\ADNug-Antlr\\Code\\Raw\\Parser\\Dsl.g:
					{
					DebugLocation(52, 7);
					input.Consume();


					}
					break;

				default:
					if (cnt3 >= 1)
						goto loop3;

					EarlyExitException eee3 = new EarlyExitException( 3, input );
					DebugRecognitionException(eee3);
					throw eee3;
				}
				cnt3++;
			}
			loop3:
				;

			} finally { DebugExitSubRule(3); }


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("INT", 14);
			LeaveRule("INT", 14);
			LeaveRule_INT();
		}
	}
	// $ANTLR end "INT"

	partial void EnterRule_LETTER();
	partial void LeaveRule_LETTER();

	// $ANTLR start "LETTER"
	[GrammarRule("LETTER")]
	private void mLETTER()
	{
		EnterRule_LETTER();
		EnterRule("LETTER", 15);
		TraceIn("LETTER", 15);
		try
		{
			// C:\\Data\\ADNug-Antlr\\Code\\Raw\\Parser\\Dsl.g:53:17: ( ( 'a' .. 'z' | 'A' .. 'Z' ) )
			DebugEnterAlt(1);
			// C:\\Data\\ADNug-Antlr\\Code\\Raw\\Parser\\Dsl.g:
			{
			DebugLocation(53, 17);
			if ((input.LA(1)>='A' && input.LA(1)<='Z')||(input.LA(1)>='a' && input.LA(1)<='z'))
			{
				input.Consume();
			}
			else
			{
				MismatchedSetException mse = new MismatchedSetException(null,input);
				DebugRecognitionException(mse);
				Recover(mse);
				throw mse;
			}


			}

		}
		finally
		{
			TraceOut("LETTER", 15);
			LeaveRule("LETTER", 15);
			LeaveRule_LETTER();
		}
	}
	// $ANTLR end "LETTER"

	partial void EnterRule_DIGIT();
	partial void LeaveRule_DIGIT();

	// $ANTLR start "DIGIT"
	[GrammarRule("DIGIT")]
	private void mDIGIT()
	{
		EnterRule_DIGIT();
		EnterRule("DIGIT", 16);
		TraceIn("DIGIT", 16);
		try
		{
			// C:\\Data\\ADNug-Antlr\\Code\\Raw\\Parser\\Dsl.g:54:15: ( '0' .. '9' )
			DebugEnterAlt(1);
			// C:\\Data\\ADNug-Antlr\\Code\\Raw\\Parser\\Dsl.g:
			{
			DebugLocation(54, 15);
			if ((input.LA(1)>='0' && input.LA(1)<='9'))
			{
				input.Consume();
			}
			else
			{
				MismatchedSetException mse = new MismatchedSetException(null,input);
				DebugRecognitionException(mse);
				Recover(mse);
				throw mse;
			}


			}

		}
		finally
		{
			TraceOut("DIGIT", 16);
			LeaveRule("DIGIT", 16);
			LeaveRule_DIGIT();
		}
	}
	// $ANTLR end "DIGIT"

	partial void EnterRule_WS();
	partial void LeaveRule_WS();

	// $ANTLR start "WS"
	[GrammarRule("WS")]
	private void mWS()
	{
		EnterRule_WS();
		EnterRule("WS", 17);
		TraceIn("WS", 17);
		try
		{
			int _type = WS;
			int _channel = DefaultTokenChannel;
			// C:\\Data\\ADNug-Antlr\\Code\\Raw\\Parser\\Dsl.g:55:4: ( ( ' ' | '\\t' )+ )
			DebugEnterAlt(1);
			// C:\\Data\\ADNug-Antlr\\Code\\Raw\\Parser\\Dsl.g:55:7: ( ' ' | '\\t' )+
			{
			DebugLocation(55, 7);
			// C:\\Data\\ADNug-Antlr\\Code\\Raw\\Parser\\Dsl.g:55:7: ( ' ' | '\\t' )+
			int cnt4=0;
			try { DebugEnterSubRule(4);
			while (true)
			{
				int alt4=2;
				try { DebugEnterDecision(4, false);
				int LA4_1 = input.LA(1);

				if ((LA4_1=='\t'||LA4_1==' '))
				{
					alt4 = 1;
				}


				} finally { DebugExitDecision(4); }
				switch (alt4)
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\Data\\ADNug-Antlr\\Code\\Raw\\Parser\\Dsl.g:
					{
					DebugLocation(55, 7);
					input.Consume();


					}
					break;

				default:
					if (cnt4 >= 1)
						goto loop4;

					EarlyExitException eee4 = new EarlyExitException( 4, input );
					DebugRecognitionException(eee4);
					throw eee4;
				}
				cnt4++;
			}
			loop4:
				;

			} finally { DebugExitSubRule(4); }

			DebugLocation(55, 19);
			_channel = HIDDEN;

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("WS", 17);
			LeaveRule("WS", 17);
			LeaveRule_WS();
		}
	}
	// $ANTLR end "WS"

	partial void EnterRule_COMMENT();
	partial void LeaveRule_COMMENT();

	// $ANTLR start "COMMENT"
	[GrammarRule("COMMENT")]
	private void mCOMMENT()
	{
		EnterRule_COMMENT();
		EnterRule("COMMENT", 18);
		TraceIn("COMMENT", 18);
		try
		{
			int _type = COMMENT;
			int _channel = DefaultTokenChannel;
			// C:\\Data\\ADNug-Antlr\\Code\\Raw\\Parser\\Dsl.g:56:9: ( '/*' ( . )* '*/' )
			DebugEnterAlt(1);
			// C:\\Data\\ADNug-Antlr\\Code\\Raw\\Parser\\Dsl.g:56:11: '/*' ( . )* '*/'
			{
			DebugLocation(56, 11);
			Match("/*"); 

			DebugLocation(56, 16);
			// C:\\Data\\ADNug-Antlr\\Code\\Raw\\Parser\\Dsl.g:56:16: ( . )*
			try { DebugEnterSubRule(5);
			while (true)
			{
				int alt5=2;
				try { DebugEnterDecision(5, false);
				int LA5_1 = input.LA(1);

				if ((LA5_1=='*'))
				{
					int LA5_2 = input.LA(2);

					if ((LA5_2=='/'))
					{
						alt5 = 2;
					}
					else if (((LA5_2>='\u0000' && LA5_2<='.')||(LA5_2>='0' && LA5_2<='\uFFFF')))
					{
						alt5 = 1;
					}


				}
				else if (((LA5_1>='\u0000' && LA5_1<=')')||(LA5_1>='+' && LA5_1<='\uFFFF')))
				{
					alt5 = 1;
				}


				} finally { DebugExitDecision(5); }
				switch ( alt5 )
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\Data\\ADNug-Antlr\\Code\\Raw\\Parser\\Dsl.g:56:16: .
					{
					DebugLocation(56, 16);
					MatchAny(); 

					}
					break;

				default:
					goto loop5;
				}
			}

			loop5:
				;

			} finally { DebugExitSubRule(5); }

			DebugLocation(56, 19);
			Match("*/"); 

			DebugLocation(56, 24);
			_channel = HIDDEN;

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("COMMENT", 18);
			LeaveRule("COMMENT", 18);
			LeaveRule_COMMENT();
		}
	}
	// $ANTLR end "COMMENT"

	partial void EnterRule_LINE_COMMENT_SLASH();
	partial void LeaveRule_LINE_COMMENT_SLASH();

	// $ANTLR start "LINE_COMMENT_SLASH"
	[GrammarRule("LINE_COMMENT_SLASH")]
	private void mLINE_COMMENT_SLASH()
	{
		EnterRule_LINE_COMMENT_SLASH();
		EnterRule("LINE_COMMENT_SLASH", 19);
		TraceIn("LINE_COMMENT_SLASH", 19);
		try
		{
			int _type = LINE_COMMENT_SLASH;
			int _channel = DefaultTokenChannel;
			// C:\\Data\\ADNug-Antlr\\Code\\Raw\\Parser\\Dsl.g:57:20: ( '//' (~ NEWLINE )* )
			DebugEnterAlt(1);
			// C:\\Data\\ADNug-Antlr\\Code\\Raw\\Parser\\Dsl.g:57:22: '//' (~ NEWLINE )*
			{
			DebugLocation(57, 22);
			Match("//"); 

			DebugLocation(57, 27);
			// C:\\Data\\ADNug-Antlr\\Code\\Raw\\Parser\\Dsl.g:57:27: (~ NEWLINE )*
			try { DebugEnterSubRule(6);
			while (true)
			{
				int alt6=2;
				try { DebugEnterDecision(6, false);
				int LA6_1 = input.LA(1);

				if (((LA6_1>='\u0000' && LA6_1<='\t')||(LA6_1>='\u000B' && LA6_1<='\f')||(LA6_1>='\u000E' && LA6_1<='\uFFFF')))
				{
					alt6 = 1;
				}


				} finally { DebugExitDecision(6); }
				switch ( alt6 )
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\Data\\ADNug-Antlr\\Code\\Raw\\Parser\\Dsl.g:
					{
					DebugLocation(57, 27);
					input.Consume();


					}
					break;

				default:
					goto loop6;
				}
			}

			loop6:
				;

			} finally { DebugExitSubRule(6); }

			DebugLocation(57, 37);
			_channel = HIDDEN;

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("LINE_COMMENT_SLASH", 19);
			LeaveRule("LINE_COMMENT_SLASH", 19);
			LeaveRule_LINE_COMMENT_SLASH();
		}
	}
	// $ANTLR end "LINE_COMMENT_SLASH"

	public override void mTokens()
	{
		// C:\\Data\\ADNug-Antlr\\Code\\Raw\\Parser\\Dsl.g:1:8: ( APOSTRAPHE | VARIABLE | STAR | PLUS | EQUAL | GREATER | LESS | THAN | NOT | IS | WHEN | NEWLINE | STRING_LITERAL | INT | WS | COMMENT | LINE_COMMENT_SLASH )
		int alt7=17;
		try { DebugEnterDecision(7, false);
		switch (input.LA(1))
		{
		case '\'':
			{
			int LA7_2 = input.LA(2);

			if (((LA7_2>='\u0000' && LA7_2<='\uFFFF')))
			{
				alt7 = 13;
			}
			else
			{
				alt7 = 1;
			}
			}
			break;
		case '[':
			{
			alt7 = 2;
			}
			break;
		case '*':
			{
			alt7 = 3;
			}
			break;
		case '+':
			{
			alt7 = 4;
			}
			break;
		case 'e':
			{
			alt7 = 5;
			}
			break;
		case 'g':
			{
			alt7 = 6;
			}
			break;
		case 'l':
			{
			alt7 = 7;
			}
			break;
		case 't':
			{
			alt7 = 8;
			}
			break;
		case 'n':
			{
			alt7 = 9;
			}
			break;
		case 'i':
			{
			alt7 = 10;
			}
			break;
		case 'w':
			{
			alt7 = 11;
			}
			break;
		case '\n':
		case '\r':
			{
			alt7 = 12;
			}
			break;
		case '0':
		case '1':
		case '2':
		case '3':
		case '4':
		case '5':
		case '6':
		case '7':
		case '8':
		case '9':
			{
			alt7 = 14;
			}
			break;
		case '\t':
		case ' ':
			{
			alt7 = 15;
			}
			break;
		case '/':
			{
			int LA7_2 = input.LA(2);

			if ((LA7_2=='*'))
			{
				alt7 = 16;
			}
			else if ((LA7_2=='/'))
			{
				alt7 = 17;
			}
			else
			{
				NoViableAltException nvae = new NoViableAltException("", 7, 15, input, 2);
				DebugRecognitionException(nvae);
				throw nvae;
			}
			}
			break;
		default:
			{
				NoViableAltException nvae = new NoViableAltException("", 7, 0, input, 1);
				DebugRecognitionException(nvae);
				throw nvae;
			}
		}

		} finally { DebugExitDecision(7); }
		switch (alt7)
		{
		case 1:
			DebugEnterAlt(1);
			// C:\\Data\\ADNug-Antlr\\Code\\Raw\\Parser\\Dsl.g:1:10: APOSTRAPHE
			{
			DebugLocation(1, 10);
			mAPOSTRAPHE(); 

			}
			break;
		case 2:
			DebugEnterAlt(2);
			// C:\\Data\\ADNug-Antlr\\Code\\Raw\\Parser\\Dsl.g:1:21: VARIABLE
			{
			DebugLocation(1, 21);
			mVARIABLE(); 

			}
			break;
		case 3:
			DebugEnterAlt(3);
			// C:\\Data\\ADNug-Antlr\\Code\\Raw\\Parser\\Dsl.g:1:30: STAR
			{
			DebugLocation(1, 30);
			mSTAR(); 

			}
			break;
		case 4:
			DebugEnterAlt(4);
			// C:\\Data\\ADNug-Antlr\\Code\\Raw\\Parser\\Dsl.g:1:35: PLUS
			{
			DebugLocation(1, 35);
			mPLUS(); 

			}
			break;
		case 5:
			DebugEnterAlt(5);
			// C:\\Data\\ADNug-Antlr\\Code\\Raw\\Parser\\Dsl.g:1:40: EQUAL
			{
			DebugLocation(1, 40);
			mEQUAL(); 

			}
			break;
		case 6:
			DebugEnterAlt(6);
			// C:\\Data\\ADNug-Antlr\\Code\\Raw\\Parser\\Dsl.g:1:46: GREATER
			{
			DebugLocation(1, 46);
			mGREATER(); 

			}
			break;
		case 7:
			DebugEnterAlt(7);
			// C:\\Data\\ADNug-Antlr\\Code\\Raw\\Parser\\Dsl.g:1:54: LESS
			{
			DebugLocation(1, 54);
			mLESS(); 

			}
			break;
		case 8:
			DebugEnterAlt(8);
			// C:\\Data\\ADNug-Antlr\\Code\\Raw\\Parser\\Dsl.g:1:59: THAN
			{
			DebugLocation(1, 59);
			mTHAN(); 

			}
			break;
		case 9:
			DebugEnterAlt(9);
			// C:\\Data\\ADNug-Antlr\\Code\\Raw\\Parser\\Dsl.g:1:64: NOT
			{
			DebugLocation(1, 64);
			mNOT(); 

			}
			break;
		case 10:
			DebugEnterAlt(10);
			// C:\\Data\\ADNug-Antlr\\Code\\Raw\\Parser\\Dsl.g:1:68: IS
			{
			DebugLocation(1, 68);
			mIS(); 

			}
			break;
		case 11:
			DebugEnterAlt(11);
			// C:\\Data\\ADNug-Antlr\\Code\\Raw\\Parser\\Dsl.g:1:71: WHEN
			{
			DebugLocation(1, 71);
			mWHEN(); 

			}
			break;
		case 12:
			DebugEnterAlt(12);
			// C:\\Data\\ADNug-Antlr\\Code\\Raw\\Parser\\Dsl.g:1:76: NEWLINE
			{
			DebugLocation(1, 76);
			mNEWLINE(); 

			}
			break;
		case 13:
			DebugEnterAlt(13);
			// C:\\Data\\ADNug-Antlr\\Code\\Raw\\Parser\\Dsl.g:1:84: STRING_LITERAL
			{
			DebugLocation(1, 84);
			mSTRING_LITERAL(); 

			}
			break;
		case 14:
			DebugEnterAlt(14);
			// C:\\Data\\ADNug-Antlr\\Code\\Raw\\Parser\\Dsl.g:1:99: INT
			{
			DebugLocation(1, 99);
			mINT(); 

			}
			break;
		case 15:
			DebugEnterAlt(15);
			// C:\\Data\\ADNug-Antlr\\Code\\Raw\\Parser\\Dsl.g:1:103: WS
			{
			DebugLocation(1, 103);
			mWS(); 

			}
			break;
		case 16:
			DebugEnterAlt(16);
			// C:\\Data\\ADNug-Antlr\\Code\\Raw\\Parser\\Dsl.g:1:106: COMMENT
			{
			DebugLocation(1, 106);
			mCOMMENT(); 

			}
			break;
		case 17:
			DebugEnterAlt(17);
			// C:\\Data\\ADNug-Antlr\\Code\\Raw\\Parser\\Dsl.g:1:114: LINE_COMMENT_SLASH
			{
			DebugLocation(1, 114);
			mLINE_COMMENT_SLASH(); 

			}
			break;

		}

	}


	#region DFA

	protected override void InitDFAs()
	{
		base.InitDFAs();
	}

 
	#endregion

}
