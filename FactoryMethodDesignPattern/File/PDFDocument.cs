namespace FactoryMethodDesignPattern
{
    public class PDFDocument : IDocument
    {
        public void Open()
        {
            Console.WriteLine("Opening PDF document");
        }

        public void Save()
        {
            Console.WriteLine("Saving PDF document");
        }
    }
}
