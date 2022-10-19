using QuestPDF.Drawing;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;

namespace QuestPdfOtherExamples.Examples
{
    internal class ExampleDocument : IDocument
    {
        public DocumentMetadata GetMetadata()
        {
            return DocumentMetadata.Default;
        }

        public void Compose(IDocumentContainer container)
        {
            container
            .Page(page =>
            {
                page.Size(PageSizes.A4);
                page.Margin(2, Unit.Centimetre);
                page.PageColor(Colors.White);
                page.DefaultTextStyle(x => x.FontSize(20));

                page.Header().Element(ComposeHeader);
                page.Content().Element(ComposeContent);
                page.Footer().Element(ComposeFooter);
            });
        }

        void ComposeHeader(IContainer container)
        {
            container
                .Text("Hello PDF!")
                .SemiBold().FontSize(36).FontColor(Colors.Blue.Medium);
        }

        void ComposeContent(IContainer container)
        {
            container
                .PaddingVertical(1, Unit.Centimetre)
                .Column(x =>
                {
                    x.Spacing(20);

                    x.Item().Text(Placeholders.LoremIpsum());
                    x.Item().Image(Placeholders.Image(200, 100));
                });
        }

        void ComposeFooter(IContainer container)
        {
            container
                .AlignCenter()
                .Text(x =>
                {
                    x.Span("Page ");
                    x.CurrentPageNumber();
                });
        }

    }
}
