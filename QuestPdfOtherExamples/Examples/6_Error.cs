using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;

namespace QuestPdfOtherExamples.Examples
{
    internal class ErrorExample : IQuestPdfExample
    {
        public IDocument GetDocument()
        {
            var document = Document.Create(container =>
            {
                container.Page(page =>
                {
                    page.Size(PageSizes.A4);
                    page.Margin(2, Unit.Centimetre);
                    page.PageColor(Colors.White);
                    page.DefaultTextStyle(x => x.FontSize(20));

                    page.Header()
                        .Text("Hello PDF!")
                        .SemiBold().FontSize(36).FontColor(Colors.Blue.Medium);

                    page.Content()
                        .PaddingVertical(1, Unit.Centimetre)
                        .Column(column =>
                        {
                            column.Spacing(20);

                            column.Item().Text(Placeholders.LoremIpsum());
                            column.Item().Image(Placeholders.Image(200, 100));

                            column.Item().Column(col =>
                            {
                                col.Item().Width(30).Height(20).Column(innerColumn =>
                                {
                                    innerColumn
                                        .Item()
                                        .Text("This will be a suspiciously long text, but we'll see if it fits here.");
                                });
                            });

                        });

                    page.Footer()
                        .AlignCenter()
                        .Text(x =>
                        {
                            x.Span("Page ");
                            x.CurrentPageNumber();
                        });
                });
            });

            return document;
        }
    }
}
