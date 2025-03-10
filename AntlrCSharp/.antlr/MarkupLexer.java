// Generated from /home/andreaskluth/Coding/antlr/antlr-playground/AntlrCSharp/Markup.g4 by ANTLR 4.13.1
import org.antlr.v4.runtime.Lexer;
import org.antlr.v4.runtime.CharStream;
import org.antlr.v4.runtime.Token;
import org.antlr.v4.runtime.TokenStream;
import org.antlr.v4.runtime.*;
import org.antlr.v4.runtime.atn.*;
import org.antlr.v4.runtime.dfa.DFA;
import org.antlr.v4.runtime.misc.*;

@SuppressWarnings({"all", "warnings", "unchecked", "unused", "cast", "CheckReturnValue", "this-escape"})
public class MarkupLexer extends Lexer {
	static { RuntimeMetaData.checkVersion("4.13.1", RuntimeMetaData.VERSION); }

	protected static final DFA[] _decisionToDFA;
	protected static final PredictionContextCache _sharedContextCache =
		new PredictionContextCache();
	public static final int
		T__0=1, T__1=2, T__2=3, T__3=4, T__4=5, T__5=6, T__6=7, COLORCODE=8, HEX=9, 
		TEXT=10, WS=11;
	public static String[] channelNames = {
		"DEFAULT_TOKEN_CHANNEL", "HIDDEN"
	};

	public static String[] modeNames = {
		"DEFAULT_MODE"
	};

	private static String[] makeRuleNames() {
		return new String[] {
			"T__0", "T__1", "T__2", "T__3", "T__4", "T__5", "T__6", "COLORCODE", 
			"HEX", "TEXT", "WS"
		};
	}
	public static final String[] ruleNames = makeRuleNames();

	private static String[] makeLiteralNames() {
		return new String[] {
			null, "'[b]'", "'[/b]'", "'[i]'", "'[/i]'", "'[color='", "']'", "'[/color]'"
		};
	}
	private static final String[] _LITERAL_NAMES = makeLiteralNames();
	private static String[] makeSymbolicNames() {
		return new String[] {
			null, null, null, null, null, null, null, null, "COLORCODE", "HEX", "TEXT", 
			"WS"
		};
	}
	private static final String[] _SYMBOLIC_NAMES = makeSymbolicNames();
	public static final Vocabulary VOCABULARY = new VocabularyImpl(_LITERAL_NAMES, _SYMBOLIC_NAMES);

	/**
	 * @deprecated Use {@link #VOCABULARY} instead.
	 */
	@Deprecated
	public static final String[] tokenNames;
	static {
		tokenNames = new String[_SYMBOLIC_NAMES.length];
		for (int i = 0; i < tokenNames.length; i++) {
			tokenNames[i] = VOCABULARY.getLiteralName(i);
			if (tokenNames[i] == null) {
				tokenNames[i] = VOCABULARY.getSymbolicName(i);
			}

			if (tokenNames[i] == null) {
				tokenNames[i] = "<INVALID>";
			}
		}
	}

	@Override
	@Deprecated
	public String[] getTokenNames() {
		return tokenNames;
	}

	@Override

	public Vocabulary getVocabulary() {
		return VOCABULARY;
	}


	public MarkupLexer(CharStream input) {
		super(input);
		_interp = new LexerATNSimulator(this,_ATN,_decisionToDFA,_sharedContextCache);
	}

	@Override
	public String getGrammarFileName() { return "Markup.g4"; }

	@Override
	public String[] getRuleNames() { return ruleNames; }

	@Override
	public String getSerializedATN() { return _serializedATN; }

	@Override
	public String[] getChannelNames() { return channelNames; }

	@Override
	public String[] getModeNames() { return modeNames; }

	@Override
	public ATN getATN() { return _ATN; }

	public static final String _serializedATN =
		"\u0004\u0000\u000bQ\u0006\uffff\uffff\u0002\u0000\u0007\u0000\u0002\u0001"+
		"\u0007\u0001\u0002\u0002\u0007\u0002\u0002\u0003\u0007\u0003\u0002\u0004"+
		"\u0007\u0004\u0002\u0005\u0007\u0005\u0002\u0006\u0007\u0006\u0002\u0007"+
		"\u0007\u0007\u0002\b\u0007\b\u0002\t\u0007\t\u0002\n\u0007\n\u0001\u0000"+
		"\u0001\u0000\u0001\u0000\u0001\u0000\u0001\u0001\u0001\u0001\u0001\u0001"+
		"\u0001\u0001\u0001\u0001\u0001\u0002\u0001\u0002\u0001\u0002\u0001\u0002"+
		"\u0001\u0003\u0001\u0003\u0001\u0003\u0001\u0003\u0001\u0003\u0001\u0004"+
		"\u0001\u0004\u0001\u0004\u0001\u0004\u0001\u0004\u0001\u0004\u0001\u0004"+
		"\u0001\u0004\u0001\u0005\u0001\u0005\u0001\u0006\u0001\u0006\u0001\u0006"+
		"\u0001\u0006\u0001\u0006\u0001\u0006\u0001\u0006\u0001\u0006\u0001\u0006"+
		"\u0001\u0007\u0001\u0007\u0001\u0007\u0001\u0007\u0001\u0007\u0001\u0007"+
		"\u0001\u0007\u0001\b\u0001\b\u0001\t\u0004\tG\b\t\u000b\t\f\tH\u0001\n"+
		"\u0004\nL\b\n\u000b\n\f\nM\u0001\n\u0001\n\u0000\u0000\u000b\u0001\u0001"+
		"\u0003\u0002\u0005\u0003\u0007\u0004\t\u0005\u000b\u0006\r\u0007\u000f"+
		"\b\u0011\t\u0013\n\u0015\u000b\u0001\u0000\u0003\u0003\u000009AFaf\u0002"+
		"\u0000[[]]\u0003\u0000\t\n\r\r  R\u0000\u0001\u0001\u0000\u0000\u0000"+
		"\u0000\u0003\u0001\u0000\u0000\u0000\u0000\u0005\u0001\u0000\u0000\u0000"+
		"\u0000\u0007\u0001\u0000\u0000\u0000\u0000\t\u0001\u0000\u0000\u0000\u0000"+
		"\u000b\u0001\u0000\u0000\u0000\u0000\r\u0001\u0000\u0000\u0000\u0000\u000f"+
		"\u0001\u0000\u0000\u0000\u0000\u0011\u0001\u0000\u0000\u0000\u0000\u0013"+
		"\u0001\u0000\u0000\u0000\u0000\u0015\u0001\u0000\u0000\u0000\u0001\u0017"+
		"\u0001\u0000\u0000\u0000\u0003\u001b\u0001\u0000\u0000\u0000\u0005 \u0001"+
		"\u0000\u0000\u0000\u0007$\u0001\u0000\u0000\u0000\t)\u0001\u0000\u0000"+
		"\u0000\u000b1\u0001\u0000\u0000\u0000\r3\u0001\u0000\u0000\u0000\u000f"+
		"<\u0001\u0000\u0000\u0000\u0011C\u0001\u0000\u0000\u0000\u0013F\u0001"+
		"\u0000\u0000\u0000\u0015K\u0001\u0000\u0000\u0000\u0017\u0018\u0005[\u0000"+
		"\u0000\u0018\u0019\u0005b\u0000\u0000\u0019\u001a\u0005]\u0000\u0000\u001a"+
		"\u0002\u0001\u0000\u0000\u0000\u001b\u001c\u0005[\u0000\u0000\u001c\u001d"+
		"\u0005/\u0000\u0000\u001d\u001e\u0005b\u0000\u0000\u001e\u001f\u0005]"+
		"\u0000\u0000\u001f\u0004\u0001\u0000\u0000\u0000 !\u0005[\u0000\u0000"+
		"!\"\u0005i\u0000\u0000\"#\u0005]\u0000\u0000#\u0006\u0001\u0000\u0000"+
		"\u0000$%\u0005[\u0000\u0000%&\u0005/\u0000\u0000&\'\u0005i\u0000\u0000"+
		"\'(\u0005]\u0000\u0000(\b\u0001\u0000\u0000\u0000)*\u0005[\u0000\u0000"+
		"*+\u0005c\u0000\u0000+,\u0005o\u0000\u0000,-\u0005l\u0000\u0000-.\u0005"+
		"o\u0000\u0000./\u0005r\u0000\u0000/0\u0005=\u0000\u00000\n\u0001\u0000"+
		"\u0000\u000012\u0005]\u0000\u00002\f\u0001\u0000\u0000\u000034\u0005["+
		"\u0000\u000045\u0005/\u0000\u000056\u0005c\u0000\u000067\u0005o\u0000"+
		"\u000078\u0005l\u0000\u000089\u0005o\u0000\u00009:\u0005r\u0000\u0000"+
		":;\u0005]\u0000\u0000;\u000e\u0001\u0000\u0000\u0000<=\u0003\u0011\b\u0000"+
		"=>\u0003\u0011\b\u0000>?\u0003\u0011\b\u0000?@\u0003\u0011\b\u0000@A\u0003"+
		"\u0011\b\u0000AB\u0003\u0011\b\u0000B\u0010\u0001\u0000\u0000\u0000CD"+
		"\u0007\u0000\u0000\u0000D\u0012\u0001\u0000\u0000\u0000EG\b\u0001\u0000"+
		"\u0000FE\u0001\u0000\u0000\u0000GH\u0001\u0000\u0000\u0000HF\u0001\u0000"+
		"\u0000\u0000HI\u0001\u0000\u0000\u0000I\u0014\u0001\u0000\u0000\u0000"+
		"JL\u0007\u0002\u0000\u0000KJ\u0001\u0000\u0000\u0000LM\u0001\u0000\u0000"+
		"\u0000MK\u0001\u0000\u0000\u0000MN\u0001\u0000\u0000\u0000NO\u0001\u0000"+
		"\u0000\u0000OP\u0006\n\u0000\u0000P\u0016\u0001\u0000\u0000\u0000\u0003"+
		"\u0000HM\u0001\u0006\u0000\u0000";
	public static final ATN _ATN =
		new ATNDeserializer().deserialize(_serializedATN.toCharArray());
	static {
		_decisionToDFA = new DFA[_ATN.getNumberOfDecisions()];
		for (int i = 0; i < _ATN.getNumberOfDecisions(); i++) {
			_decisionToDFA[i] = new DFA(_ATN.getDecisionState(i), i);
		}
	}
}