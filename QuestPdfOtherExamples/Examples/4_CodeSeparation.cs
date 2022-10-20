using QuestPDF.Infrastructure;

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
