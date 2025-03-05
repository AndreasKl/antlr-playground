using Antlr4.Runtime.Misc;
using AntlrCSharp.TextEnhancing;

namespace AntlrCSharp;

public interface ITextDescriptor
{
  ITextSpanDescriptor Hyperlink(string text, string link);
  ITextSpanDescriptor Span(string text);
}

public interface ITextSpanDescriptor
{
  void FontColor(string color);
  void Bold();
  void Italic();
  void Underline();
}

public class TextEnhancingListener(ITextDescriptor text) : MarkupBaseListener
{
  private const string DefaultColor = "#000";
  private bool _bold;
  private bool _italic;
  private bool _underline;
  private bool _mail;
  private string _color = DefaultColor;

  public override void ExitText(MarkupParser.TextContext context)
  {
    var textBlockDescriptor = _mail
      ? text.Hyperlink(context.GetText(), "mailto:" + context.GetText())
      : text.Span(context.GetText());
    textBlockDescriptor.FontColor(_color);
    if (_bold)
    {
      textBlockDescriptor.Bold();
    }

    if (_italic)
    {
      textBlockDescriptor.Italic();
    }

    if (_underline)
    {
      textBlockDescriptor.Underline();
    }
  }

  public override void EnterBold(MarkupParser.BoldContext context)
  {
    _bold = true;
  }

  public override void ExitBold([NotNull] MarkupParser.BoldContext context)
  {
    _bold = false;
  }

  public override void EnterUnderline(MarkupParser.UnderlineContext context)
  {
    _underline = true;
  }

  public override void ExitUnderline([NotNull] MarkupParser.UnderlineContext context)
  {
    _underline = false;
  }

  public override void EnterItalic(MarkupParser.ItalicContext context)
  {
    _italic = true;
  }

  public override void ExitItalic([NotNull] MarkupParser.ItalicContext context)
  {
    _italic = false;
  }

  public override void EnterMail(MarkupParser.MailContext context)
  {
    _mail = true;
  }

  public override void ExitMail([NotNull] MarkupParser.MailContext context)
  {
    _mail = false;
  }

  public override void EnterColorcode(MarkupParser.ColorcodeContext context)
  {
    var colorCode = context.Start.Text;
    if (colorCode.Length != 6)
    {
      Console.Error.WriteLine("Invalid color code: " + colorCode);
      return;
    }

    _color = colorCode;
  }

  public override void ExitColor([NotNull] MarkupParser.ColorContext context)
  {
    _color = DefaultColor;
  }
}
