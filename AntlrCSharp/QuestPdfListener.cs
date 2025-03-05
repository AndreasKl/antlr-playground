using Antlr4.Runtime.Misc;
using QuestPDF.Fluent;
using QuestPDF.Infrastructure;

namespace AntlrCSharp;

public class QuestPdfListener(TextDescriptor column) : MarkupBaseListener
{
  private const string DefaultColor = "#000";
  private bool _bold;
  private bool _italic;
  private string _color = DefaultColor;

  public override void ExitText(MarkupParser.TextContext context)
  {
    var textBlockDescriptor = column.Span(context.GetText());
    textBlockDescriptor.FontColor(Color.FromHex(_color));
    if (_bold)
    {
      textBlockDescriptor.Bold();
    }

    if (_italic)
    {
      textBlockDescriptor.Italic();
    }
  }

  public override void EnterBold(MarkupParser.BoldContext context)
  {
    _bold = true;
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

  public override void EnterItalic(MarkupParser.ItalicContext context)
  {
    _italic = true;
  }

  public override void ExitBold([NotNull] MarkupParser.BoldContext context)
  {
    _bold = false;
  }

  public override void ExitItalic([NotNull] MarkupParser.ItalicContext context)
  {
    _italic = false;
  }

  public override void ExitColor([NotNull] MarkupParser.ColorContext context)
  {
    _color = DefaultColor;
  }
}
