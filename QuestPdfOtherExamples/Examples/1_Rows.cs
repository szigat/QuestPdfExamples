using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using QuestPDF.Previewer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestPdfOtherExamples.Examples
{
    public class RowsExample : IQuestPdfExample
    {
        public Document GetDocument()
        {
            var document = Document.Create(container =>
            {
                container.Page(page =>
                {
                    page.Content()
                        .Row(row =>
                        {
                            row.ConstantItem(100)
                               .Background("#DDD")
                               .Padding(10)
                               .ExtendVertical()
                               .Text("This column is 100 points width");

                            row.RelativeItem()
                                .Background("#BBB")
                                .Padding(10)
                                .Text("This column takes 1/3 of the available space");

                            row.RelativeItem(2)
                                .Background("#DDD")
                                .Padding(10)
                                .Text("This column takes 2/3 of the available space");

                        });
                });


            });

            return document;
        }

        public override string ToString()
        {
            return "a";
        }
    }
}
