using Antlr4.Runtime;

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
    Console.Error.WriteLine($"An error I guess: {msg}");
  }
}
