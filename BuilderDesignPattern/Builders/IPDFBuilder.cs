namespace BuilderDesignPattern
{
    public interface IPDFBuilder
    {
        void AddText(string text);
        void AddImage(string imagePath);
        void ApplyFormatting(string formatting);
        PDFDocument Build();
    }
}
