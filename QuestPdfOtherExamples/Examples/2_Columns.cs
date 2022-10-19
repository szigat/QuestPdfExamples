using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;

namespace QuestPdfOtherExamples.Examples
{
    public class ColumnsExample : IQuestPdfExample
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
                            //column.Spacing(5);
                            column.Item().Background(Colors.Grey.Medium).Height(50);
                            column.Item().Background(Colors.Grey.Lighten1).Height(100);
                            //column.Item().PageBreak();
                            column.Item().Background(Colors.Grey.Lighten2).Height(150);

                            #region with rows
                            //column.Item().Row(row => {
                            //    row.RelativeItem().Text(Placeholders.DateTime());
                            //    row.RelativeItem().Text(Placeholders.Email());
                            //});

                            //column.Item().Row(row => {
                            //    row.RelativeItem().Background(Colors.Blue.Lighten1).Text(Placeholders.Name()).BackgroundColor(Colors.Lime.Accent4);
                            //    row.RelativeItem().Background(Colors.Grey.Medium).Text(Placeholders.DateTime()).BackgroundColor(Colors.Red.Accent4);
                            //    row.RelativeItem().Background(Colors.Green.Darken1).Text(Placeholders.Email()).BackgroundColor(Colors.Orange.Accent4);
                            //});
                            #endregion
                        });
                });


            });

            return document;
        }
    }
}
