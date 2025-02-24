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
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.13.2")]
[System.CLSCompliant(false)]
public partial class MarkupLexer : Lexer {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		T__0=1, T__1=2, T__2=3, T__3=4, T__4=5, T__5=6, T__6=7, COLORCODE=8, HEX=9, 
		TEXT=10, WS=11;
	public static string[] channelNames = {
		"DEFAULT_TOKEN_CHANNEL", "HIDDEN"
	};

	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	public static readonly string[] ruleNames = {
		"T__0", "T__1", "T__2", "T__3", "T__4", "T__5", "T__6", "COLORCODE", "HEX", 
		"TEXT", "WS"
	};


	public MarkupLexer(ICharStream input)
	: this(input, Console.Out, Console.Error) { }

	public MarkupLexer(ICharStream input, TextWriter output, TextWriter errorOutput)
	: base(input, output, errorOutput)
	{
		Interpreter = new LexerATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

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

	public override string[] ChannelNames { get { return channelNames; } }

	public override string[] ModeNames { get { return modeNames; } }

	public override int[] SerializedAtn { get { return _serializedATN; } }

	static MarkupLexer() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}
	private static int[] _serializedATN = {
		4,0,11,81,6,-1,2,0,7,0,2,1,7,1,2,2,7,2,2,3,7,3,2,4,7,4,2,5,7,5,2,6,7,6,
		2,7,7,7,2,8,7,8,2,9,7,9,2,10,7,10,1,0,1,0,1,0,1,0,1,1,1,1,1,1,1,1,1,1,
		1,2,1,2,1,2,1,2,1,3,1,3,1,3,1,3,1,3,1,4,1,4,1,4,1,4,1,4,1,4,1,4,1,4,1,
		5,1,5,1,6,1,6,1,6,1,6,1,6,1,6,1,6,1,6,1,6,1,7,1,7,1,7,1,7,1,7,1,7,1,7,
		1,8,1,8,1,9,4,9,71,8,9,11,9,12,9,72,1,10,4,10,76,8,10,11,10,12,10,77,1,
		10,1,10,0,0,11,1,1,3,2,5,3,7,4,9,5,11,6,13,7,15,8,17,9,19,10,21,11,1,0,
		3,3,0,48,57,65,70,97,102,2,0,91,91,93,93,3,0,9,10,13,13,32,32,82,0,1,1,
		0,0,0,0,3,1,0,0,0,0,5,1,0,0,0,0,7,1,0,0,0,0,9,1,0,0,0,0,11,1,0,0,0,0,13,
		1,0,0,0,0,15,1,0,0,0,0,17,1,0,0,0,0,19,1,0,0,0,0,21,1,0,0,0,1,23,1,0,0,
		0,3,27,1,0,0,0,5,32,1,0,0,0,7,36,1,0,0,0,9,41,1,0,0,0,11,49,1,0,0,0,13,
		51,1,0,0,0,15,60,1,0,0,0,17,67,1,0,0,0,19,70,1,0,0,0,21,75,1,0,0,0,23,
		24,5,91,0,0,24,25,5,98,0,0,25,26,5,93,0,0,26,2,1,0,0,0,27,28,5,91,0,0,
		28,29,5,47,0,0,29,30,5,98,0,0,30,31,5,93,0,0,31,4,1,0,0,0,32,33,5,91,0,
		0,33,34,5,105,0,0,34,35,5,93,0,0,35,6,1,0,0,0,36,37,5,91,0,0,37,38,5,47,
		0,0,38,39,5,105,0,0,39,40,5,93,0,0,40,8,1,0,0,0,41,42,5,91,0,0,42,43,5,
		99,0,0,43,44,5,111,0,0,44,45,5,108,0,0,45,46,5,111,0,0,46,47,5,114,0,0,
		47,48,5,61,0,0,48,10,1,0,0,0,49,50,5,93,0,0,50,12,1,0,0,0,51,52,5,91,0,
		0,52,53,5,47,0,0,53,54,5,99,0,0,54,55,5,111,0,0,55,56,5,108,0,0,56,57,
		5,111,0,0,57,58,5,114,0,0,58,59,5,93,0,0,59,14,1,0,0,0,60,61,3,17,8,0,
		61,62,3,17,8,0,62,63,3,17,8,0,63,64,3,17,8,0,64,65,3,17,8,0,65,66,3,17,
		8,0,66,16,1,0,0,0,67,68,7,0,0,0,68,18,1,0,0,0,69,71,8,1,0,0,70,69,1,0,
		0,0,71,72,1,0,0,0,72,70,1,0,0,0,72,73,1,0,0,0,73,20,1,0,0,0,74,76,7,2,
		0,0,75,74,1,0,0,0,76,77,1,0,0,0,77,75,1,0,0,0,77,78,1,0,0,0,78,79,1,0,
		0,0,79,80,6,10,0,0,80,22,1,0,0,0,3,0,72,77,1,6,0,0
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}
