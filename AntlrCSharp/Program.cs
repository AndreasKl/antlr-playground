using Antlr4.Runtime;
using AntlrCSharp;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;

const string input = """
                     This is a [b]bold[/b] and an [i]italic[/i] word.
                     This is [color=FF5733]colored[/color] text.
                     You can also [i]nest [color=FF5733][b]formatting[/b][/color][/i].
                     """;

QuestPDF.Settings.License = LicenseType.Community;

Document
    .Create(
        doc =>
            doc.Page(p =>
            {
                p.Size(PageSizes.A4);
                p.Margin(10, Unit.Millimetre);
                p.Content()
                    .Column(c =>
                    {
                        c.Item()
                            .Text(t =>
                            {
                                GenerateContent(t, input);
                            });
                    });
            })
    )
    .GeneratePdfAndShow();
return;

void GenerateContent(TextDescriptor textDescriptor, string content)
{
    var markupParser = Parser(content);
    markupParser.AddErrorListener(new MarkupErrorListener());
    markupParser.AddParseListener(new QuestPdfListener(textDescriptor));
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
