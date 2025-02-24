//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.13.2
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from Markup.g4 by ANTLR 4.13.2

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

using System;
using System.IO;
using System.Text;
using System.Diagnostics;
using System.Collections.Generic;
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.13.2")]
[System.CLSCompliant(false)]
public partial class MarkupParser : Parser {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		T__0=1, T__1=2, T__2=3, T__3=4, T__4=5, T__5=6, T__6=7, COLORCODE=8, HEX=9, 
		TEXT=10, WS=11;
	public const int
		RULE_markup = 0, RULE_element = 1, RULE_text = 2, RULE_bold = 3, RULE_italic = 4, 
		RULE_color = 5, RULE_colorcode = 6;
	public static readonly string[] ruleNames = {
		"markup", "element", "text", "bold", "italic", "color", "colorcode"
	};

	private static readonly string[] _LiteralNames = {
		null, "'[b]'", "'[/b]'", "'[i]'", "'[/i]'", "'[color='", "']'", "'[/color]'"
	};
	private static readonly string[] _SymbolicNames = {
		null, null, null, null, null, null, null, null, "COLORCODE", "HEX", "TEXT", 
		"WS"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "Markup.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override int[] SerializedAtn { get { return _serializedATN; } }

	static MarkupParser() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}

		public MarkupParser(ITokenStream input) : this(input, Console.Out, Console.Error) { }

		public MarkupParser(ITokenStream input, TextWriter output, TextWriter errorOutput)
		: base(input, output, errorOutput)
	{
		Interpreter = new ParserATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

	public partial class MarkupContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ElementContext[] element() {
			return GetRuleContexts<ElementContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public ElementContext element(int i) {
			return GetRuleContext<ElementContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public TextContext[] text() {
			return GetRuleContexts<TextContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public TextContext text(int i) {
			return GetRuleContext<TextContext>(i);
		}
		public MarkupContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_markup; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IMarkupListener typedListener = listener as IMarkupListener;
			if (typedListener != null) typedListener.EnterMarkup(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IMarkupListener typedListener = listener as IMarkupListener;
			if (typedListener != null) typedListener.ExitMarkup(this);
		}
	}

	[RuleVersion(0)]
	public MarkupContext markup() {
		MarkupContext _localctx = new MarkupContext(Context, State);
		EnterRule(_localctx, 0, RULE_markup);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 16;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			do {
				{
				State = 16;
				ErrorHandler.Sync(this);
				switch (TokenStream.LA(1)) {
				case T__0:
				case T__2:
				case T__4:
					{
					State = 14;
					element();
					}
					break;
				case TEXT:
					{
					State = 15;
					text();
					}
					break;
				default:
					throw new NoViableAltException(this);
				}
				}
				State = 18;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			} while ( (((_la) & ~0x3f) == 0 && ((1L << _la) & 1066L) != 0) );
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class ElementContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public BoldContext bold() {
			return GetRuleContext<BoldContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ItalicContext italic() {
			return GetRuleContext<ItalicContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ColorContext color() {
			return GetRuleContext<ColorContext>(0);
		}
		public ElementContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_element; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IMarkupListener typedListener = listener as IMarkupListener;
			if (typedListener != null) typedListener.EnterElement(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IMarkupListener typedListener = listener as IMarkupListener;
			if (typedListener != null) typedListener.ExitElement(this);
		}
	}

	[RuleVersion(0)]
	public ElementContext element() {
		ElementContext _localctx = new ElementContext(Context, State);
		EnterRule(_localctx, 2, RULE_element);
		try {
			State = 23;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case T__0:
				EnterOuterAlt(_localctx, 1);
				{
				State = 20;
				bold();
				}
				break;
			case T__2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 21;
				italic();
				}
				break;
			case T__4:
				EnterOuterAlt(_localctx, 3);
				{
				State = 22;
				color();
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class TextContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode TEXT() { return GetToken(MarkupParser.TEXT, 0); }
		public TextContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_text; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IMarkupListener typedListener = listener as IMarkupListener;
			if (typedListener != null) typedListener.EnterText(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IMarkupListener typedListener = listener as IMarkupListener;
			if (typedListener != null) typedListener.ExitText(this);
		}
	}

	[RuleVersion(0)]
	public TextContext text() {
		TextContext _localctx = new TextContext(Context, State);
		EnterRule(_localctx, 4, RULE_text);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 25;
			Match(TEXT);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class BoldContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public MarkupContext markup() {
			return GetRuleContext<MarkupContext>(0);
		}
		public BoldContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_bold; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IMarkupListener typedListener = listener as IMarkupListener;
			if (typedListener != null) typedListener.EnterBold(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IMarkupListener typedListener = listener as IMarkupListener;
			if (typedListener != null) typedListener.ExitBold(this);
		}
	}

	[RuleVersion(0)]
	public BoldContext bold() {
		BoldContext _localctx = new BoldContext(Context, State);
		EnterRule(_localctx, 6, RULE_bold);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 27;
			Match(T__0);
			State = 28;
			markup();
			State = 29;
			Match(T__1);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class ItalicContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public MarkupContext markup() {
			return GetRuleContext<MarkupContext>(0);
		}
		public ItalicContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_italic; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IMarkupListener typedListener = listener as IMarkupListener;
			if (typedListener != null) typedListener.EnterItalic(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IMarkupListener typedListener = listener as IMarkupListener;
			if (typedListener != null) typedListener.ExitItalic(this);
		}
	}

	[RuleVersion(0)]
	public ItalicContext italic() {
		ItalicContext _localctx = new ItalicContext(Context, State);
		EnterRule(_localctx, 8, RULE_italic);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 31;
			Match(T__2);
			State = 32;
			markup();
			State = 33;
			Match(T__3);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class ColorContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ColorcodeContext colorcode() {
			return GetRuleContext<ColorcodeContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public MarkupContext markup() {
			return GetRuleContext<MarkupContext>(0);
		}
		public ColorContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_color; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IMarkupListener typedListener = listener as IMarkupListener;
			if (typedListener != null) typedListener.EnterColor(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IMarkupListener typedListener = listener as IMarkupListener;
			if (typedListener != null) typedListener.ExitColor(this);
		}
	}

	[RuleVersion(0)]
	public ColorContext color() {
		ColorContext _localctx = new ColorContext(Context, State);
		EnterRule(_localctx, 10, RULE_color);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 35;
			Match(T__4);
			State = 36;
			colorcode();
			State = 37;
			Match(T__5);
			State = 38;
			markup();
			State = 39;
			Match(T__6);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class ColorcodeContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode COLORCODE() { return GetToken(MarkupParser.COLORCODE, 0); }
		public ColorcodeContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_colorcode; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IMarkupListener typedListener = listener as IMarkupListener;
			if (typedListener != null) typedListener.EnterColorcode(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IMarkupListener typedListener = listener as IMarkupListener;
			if (typedListener != null) typedListener.ExitColorcode(this);
		}
	}

	[RuleVersion(0)]
	public ColorcodeContext colorcode() {
		ColorcodeContext _localctx = new ColorcodeContext(Context, State);
		EnterRule(_localctx, 12, RULE_colorcode);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 41;
			Match(COLORCODE);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	private static int[] _serializedATN = {
		4,1,11,44,2,0,7,0,2,1,7,1,2,2,7,2,2,3,7,3,2,4,7,4,2,5,7,5,2,6,7,6,1,0,
		1,0,4,0,17,8,0,11,0,12,0,18,1,1,1,1,1,1,3,1,24,8,1,1,2,1,2,1,3,1,3,1,3,
		1,3,1,4,1,4,1,4,1,4,1,5,1,5,1,5,1,5,1,5,1,5,1,6,1,6,1,6,0,0,7,0,2,4,6,
		8,10,12,0,0,40,0,16,1,0,0,0,2,23,1,0,0,0,4,25,1,0,0,0,6,27,1,0,0,0,8,31,
		1,0,0,0,10,35,1,0,0,0,12,41,1,0,0,0,14,17,3,2,1,0,15,17,3,4,2,0,16,14,
		1,0,0,0,16,15,1,0,0,0,17,18,1,0,0,0,18,16,1,0,0,0,18,19,1,0,0,0,19,1,1,
		0,0,0,20,24,3,6,3,0,21,24,3,8,4,0,22,24,3,10,5,0,23,20,1,0,0,0,23,21,1,
		0,0,0,23,22,1,0,0,0,24,3,1,0,0,0,25,26,5,10,0,0,26,5,1,0,0,0,27,28,5,1,
		0,0,28,29,3,0,0,0,29,30,5,2,0,0,30,7,1,0,0,0,31,32,5,3,0,0,32,33,3,0,0,
		0,33,34,5,4,0,0,34,9,1,0,0,0,35,36,5,5,0,0,36,37,3,12,6,0,37,38,5,6,0,
		0,38,39,3,0,0,0,39,40,5,7,0,0,40,11,1,0,0,0,41,42,5,8,0,0,42,13,1,0,0,
		0,3,16,18,23
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}
