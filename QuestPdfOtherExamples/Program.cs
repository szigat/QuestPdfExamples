// See https://aka.ms/new-console-template for more information
using QuestPDF.Fluent;
using QuestPDF.Previewer;
using QuestPdfOtherExamples;
using QuestPdfOtherExamples.Examples;
using Spectre.Console;

bool run = true;
while (run)
{
    var example = AnsiConsole.Prompt(
        new SelectionPrompt<IQuestPdfExample>()
        .Title("Choose an example")
        .PageSize(10)
        .UseConverter((exampleClass) => exampleClass.GetType().Name)
        .MoreChoicesText("[grey](Move up and down to reveal more example)[/]")
        .AddChoices(
            new IQuestPdfExample[] {
                new RowsExample(),
                new ColumnsExample(),
                new ALotOfTextExample(),
                new CodeSeparationExample(),
                new ErrorExample()
        }));

    var document = example.GetDocument();
    document.GeneratePdf($"{example.GetType().Name}.pdf");
    try { document.ShowInPreviewer(); }
    catch { }
    finally
    {
        Console.WriteLine("Press ESC to exit!");
        var pressedKey = Console.ReadKey();
        if (pressedKey.Key == ConsoleKey.Escape)
        {
            run = false;
        }
        Console.Clear();
    }
}