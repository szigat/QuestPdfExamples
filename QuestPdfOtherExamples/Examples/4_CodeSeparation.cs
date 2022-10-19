using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestPdfOtherExamples.Examples
{
    internal class CodeSeparationExample : IQuestPdfExample
    {
        public IDocument GetDocument()
        {
            IDocument document = new ExampleDocument();
            
            return document;
        }
    }
}
