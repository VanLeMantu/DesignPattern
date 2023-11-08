namespace NonBuilderDesignPattern
{
    public class PDFDocumentNonBuilder : IPDFDocumentNonBuilder
    {
        private readonly List<string> elements = new();
        public void AddText(string text)
        {
            elements.Add($"Text: {text}");
        }

        public void AddImage(string imagePath)
        {
            elements.Add($"Image: {imagePath}");
        }

        public void ApplyFormatting(string formatting)
        {
            elements.Add($"Formatting: {formatting}");
        }

        public void Print()
        {
            Console.WriteLine("PDF Document Content:");
            foreach (var element in elements)
            {
                Console.WriteLine(element);
            }
        }
    }
}
