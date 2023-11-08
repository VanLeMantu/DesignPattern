namespace BuilderDesignPattern
{
    public class ConcretePDFBuilder : IPDFBuilder
    {
        private readonly PDFDocument pdfDocument = new();

        public void AddText(string text)
        {
            pdfDocument.AddElement($"Text: {text}");
        }

        public void AddImage(string imagePath)
        {
            pdfDocument.AddElement($"Image: {imagePath}");
        }

        public void ApplyFormatting(string formatting)
        {
            pdfDocument.AddElement($"Formatting: {formatting}");
        }

        public PDFDocument Build()
        {
            return pdfDocument;
        }
    }
}
