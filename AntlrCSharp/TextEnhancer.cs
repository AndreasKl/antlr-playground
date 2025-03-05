using Antlr4.Runtime;
using AntlrCSharp.TextEnhancing;
using QuestPDF.Fluent;
using QuestPDF.Infrastructure;

namespace AntlrCSharp;

public class TextDescriptorDecorator(TextDescriptor td) : ITextDescriptor
{
  public ITextSpanDescriptor Hyperlink(string text, string link) =>
    new TextSpanDescriptorDecorator(td.Hyperlink(text, link));

  public ITextSpanDescriptor Span(string text) => new TextSpanDescriptorDecorator(td.Span(text));
}

public class TextSpanDescriptorDecorator(TextSpanDescriptor tsd) : ITextSpanDescriptor
{
  public void FontColor(string color) => tsd.FontColor(Color.FromHex(color));

  public void Bold() => tsd.Bold();

  public void Italic() => tsd.Italic();

  public void Underline() => tsd.Underline();
}

public static class TextEnhancer
{
  public static void GenerateContent(TextDescriptor textDescriptor, string content)
  {
    GenerateContent(new TextDescriptorDecorator(textDescriptor), content);
  }

  public static void GenerateContent(ITextDescriptor textDescriptor, string content)
  {
    var markupParser = Parser(content);
    markupParser.AddErrorListener(new MarkupErrorListener());
    markupParser.AddParseListener(new TextEnhancingListener(textDescriptor));
    markupParser.markup();
    return;

    MarkupParser Parser(string text)
    {
      var antlrInputStream = new AntlrInputStream(text);
      var lexer = new MarkupLexer(antlrInputStream);
      var tokenStream = new CommonTokenStream(lexer);
      return new MarkupParser(tokenStream);
    }
  }
}
