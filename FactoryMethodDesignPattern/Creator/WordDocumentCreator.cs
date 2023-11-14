namespace FactoryMethodDesignPattern
{
    public class WordDocumentCreator : IDocumentCreator
    {
        public IDocument CreateDocument()
        {
            return new WordDocument();
        }
    }
}
