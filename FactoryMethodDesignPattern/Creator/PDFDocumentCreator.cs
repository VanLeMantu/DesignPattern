namespace FactoryMethodDesignPattern
{
    public class PDFDocumentCreator : IDocumentCreator
    {
        public IDocument CreateDocument()
        {
            return new PDFDocument();
        }
    }
}
