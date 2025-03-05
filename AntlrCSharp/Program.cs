using System.Diagnostics;
using AntlrCSharp;
using QuestPDF;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using Serilog;

Log.Logger = new LoggerConfiguration().WriteTo.Console().CreateLogger();

const string input = """
                     This is a [b]bold[/b] and an [i]italic[/i] word.
                     This is [color=FF5733]colored[/color] text.
                     You can also [i]nest [color=FF5733][b]formatting[/b][/color][/i].
                     """;

Settings.License = LicenseType.Community;

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
                TextEnhancer.GenerateContent(t, input);
              });
          });
      })
  )
  .GeneratePdfAndShow();
