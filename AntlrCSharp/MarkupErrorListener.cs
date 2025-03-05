using Antlr4.Runtime;
using Serilog;

namespace AntlrCSharp;

public class MarkupErrorListener : BaseErrorListener
{
  public override void SyntaxError(
    TextWriter output,
    IRecognizer recognizer,
    IToken offendingSymbol,
    int line,
    int charPositionInLine,
    string msg,
    RecognitionException e
  )
  {
    Log.ForContext<MarkupErrorListener>().Error($"line {line}:{charPositionInLine} {msg}");
  }
}
