using NSubstitute;
using Xunit;

namespace AntlrCSharp;

public class TextEnhancerTest
{
  [Fact]
  public void GenerateContent_Renders_Bold_Text()
  {
    var textDescriptor = Substitute.For<ITextDescriptor>();
    var spanDescriptor = Substitute.For<ITextSpanDescriptor>();
    textDescriptor.Span("bold").Returns(spanDescriptor);

    TextEnhancer.GenerateContent(textDescriptor, "write [b]bold[/b] text");

    Received.InOrder(() =>
    {
      textDescriptor.Received().Span("write ");
      textDescriptor.Received().Span("bold");
      spanDescriptor.Received().Bold();
      textDescriptor.Received().Span(" text");
    });
  }

  [Fact]
  public void GenerateContent_Stops_On_Broken_Markup()
  {
    var textDescriptor = Substitute.For<ITextDescriptor>();
    var spanDescriptor = Substitute.For<ITextSpanDescriptor>();
    textDescriptor.Span("bold").Returns(spanDescriptor);

    TextEnhancer.GenerateContent(textDescriptor, "write []bold/b] text");

    Received.InOrder(() =>
    {
      textDescriptor.Received().Span("write ");
    });
  }

  [Fact]
  public void GenerateContent_Renders_MailtoLinks()
  {
    var textDescriptor = Substitute.For<ITextDescriptor>();

    TextEnhancer.GenerateContent(textDescriptor, "write [mailto]mail@example.com[/mailto] text");

    Received.InOrder(() =>
    {
      textDescriptor.Received().Span("write ");
      textDescriptor.Received().Hyperlink("mail@example.com", "mailto:mail@example.com");
      textDescriptor.Received().Span(" text");
    });
  }

  [Fact]
  public void GenerateContent_Renders_Complex_Text()
  {
    var textDescriptor = Substitute.For<ITextDescriptor>();
    var spanDescriptor = Substitute.For<ITextSpanDescriptor>();
    textDescriptor.Span(Arg.Any<string>()).Returns(spanDescriptor);

    TextEnhancer.GenerateContent(textDescriptor, "write [b]bold[color=FFFFFF][i]yo[/i][/color]lo[u]under[/u][/b] text");

    Received.InOrder(() =>
    {
      textDescriptor.Received().Span("write ");
      textDescriptor.Received().Span("bold");
      spanDescriptor.Received().Bold();

      textDescriptor.Received().Span("yo");
      spanDescriptor.Received().FontColor("FFFFFF");
      spanDescriptor.Received().Bold();
      spanDescriptor.Received().Italic();

      textDescriptor.Received().Span("lo");
      spanDescriptor.Received().Bold();

      textDescriptor.Received().Span("under");
      spanDescriptor.Received().Bold();
      spanDescriptor.Received().Underline();

      textDescriptor.Received().Span(" text");
    });
  }
}
