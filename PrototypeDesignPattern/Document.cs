namespace PrototypeDesignPattern
{
    public class Document : IPrototype
    {
        public string Title { get; set; }
        public string Text { get; set; }

        public IPrototype Clone(IPrototype documents)
        {
            Document cloned = new()
            {
                Title = this.Title,
                Text = this.Text
            };

            //Document cloned = (Document)MemberwiseClone();

            return cloned;
        }

        public IPrototype CloneSelf()
        {
            return (Document)MemberwiseClone();
        }
    }
}
