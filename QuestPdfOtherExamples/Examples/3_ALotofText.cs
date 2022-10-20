using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;

namespace QuestPdfOtherExamples.Examples
{
    internal class ALotOfTextExample : IQuestPdfExample
    {
        public IDocument GetDocument()
        {
            var document = Document.Create(container =>
            {
                container.Page(page =>
                {
                    page.Content()
                        .Column(column =>
                        {
                            column.Spacing(10);
                            for (int i = 0; i < 15; i++)
                            {
                                column.Item().Text(Placeholders.LoremIpsum());
                            }

                            column.Item().PageBreak();

                            for (int i = 0; i < 15; i++)
                            {
                                column.Item().Row(row =>
                                {
                                    row.RelativeItem().ShowEntire().Text(Placeholders.LoremIpsum()).FontColor(Colors.Blue.Medium);
                                });

                            }

                        });
                });


            });

            return document;
        }
    }
}
