using MigraDocCore.DocumentObjectModel;
using MigraDocCore.Rendering;
using QuestPDF.Helpers;

Console.WriteLine("Hello, World!");

Document document = new Document();
document.DefaultPageSetup.PageFormat = PageFormat.A4;
document.DefaultPageSetup.BottomMargin = new Unit(2, UnitType.Centimeter);
document.DefaultPageSetup.TopMargin = new Unit(2, UnitType.Centimeter);
document.DefaultPageSetup.RightMargin = new Unit(2, UnitType.Centimeter);
document.DefaultPageSetup.LeftMargin = new Unit(2, UnitType.Centimeter);

Section section = document.AddSection();

var headerparagraph = section.Headers.Primary.AddParagraph("Hello PDF!");
var headerFont = headerparagraph.Format.Font;
headerFont.Bold = true;
headerFont.Size = new Unit(20, UnitType.Point);
headerFont.Color = Color.Parse("blue");

var frame = section.AddTextFrame();
frame.Height = new Unit(1, UnitType.Centimeter);

Paragraph contentParagraph = section.AddParagraph(Placeholders.LoremIpsum());

contentParagraph.Format.SpaceBefore = new Unit(20, UnitType.Point);
contentParagraph.Format.Font.Size = 20;

var image = section.AddTextFrame();
image.Width = 200;
image.Height = 100;

var footerparagraph = section.Footers.Primary.AddParagraph("Page ");
footerparagraph.Format.Alignment = ParagraphAlignment.Center;
footerparagraph.AddPageField();

var footerFont = footerparagraph.Format.Font;
footerFont.Size = 20;

var renderer = new PdfDocumentRenderer(true);
renderer.Document = document;

renderer.RenderDocument();

var filename = "c:\\temp\\HelloMigraDoc.pdf";

renderer.PdfDocument.Save(filename);