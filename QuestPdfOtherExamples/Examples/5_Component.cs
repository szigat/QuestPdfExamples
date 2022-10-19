using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using System.Globalization;

namespace QuestPdfOtherExamples.Examples
{
    internal class ComponentExample : IQuestPdfExample
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
                            for (int i = 0; i < 12; i++)
                            {
                                column.Item().Component(new MonthComponent(i + 1));
                            }
                        });
                });
            });

            return document;
        }
    }

    internal class MonthComponent : IComponent
    {
        private readonly int _month;

        public MonthComponent(int month)
        {
            _month = month;
        }

        public void Compose(IContainer container)
        {
            string monthName = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(_month);
            container.Text(monthName)
                .FontColor(Colors.DeepPurple.Medium)
                .Bold();
        }
    }
}
