namespace PrototypeDesignPattern
{
    public class Image : IPrototype
    {
        public string FileName { get; set; }

        public IPrototype Clone(IPrototype image)
        {
            Image cloned = new();
            //image = (Image)image;

            //cloned.FileName = image.
            return cloned;
        }

        public IPrototype CloneSelf()
        {
            return (Image)MemberwiseClone();
        }
    }
}
