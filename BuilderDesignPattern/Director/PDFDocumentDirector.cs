namespace BuilderDesignPattern
{
    public class PDFDocumentDirector
    {
        private readonly IPDFBuilder builder;

        public PDFDocumentDirector(IPDFBuilder builder)
        {
            this.builder = builder;
        }

        public PDFDocument ConstructDocument()
        {
            builder.AddText("Hello, World!");
            builder.AddImage("image.png");
            builder.ApplyFormatting("Arial 12pt");
            return builder.Build();
        }
    }
}
