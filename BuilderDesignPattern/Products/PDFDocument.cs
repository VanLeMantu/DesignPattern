namespace BuilderDesignPattern
{
    public class PDFDocument
    {
        private readonly List<string> elements = new();

        public void AddElement(string element)
        {
            elements.Add(element);
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
