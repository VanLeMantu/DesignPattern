namespace NonBuilderDesignPattern
{
    public interface IPDFDocumentNonBuilder
    {
        void AddText(string text);
        void AddImage(string imagePath);
        void ApplyFormatting(string formatting);
        void Print();
    }
}
