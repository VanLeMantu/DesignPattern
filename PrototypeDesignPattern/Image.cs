namespace PrototypeDesignPattern
{
    public class Image : IPrototype
    {
        public string FileName { get; set; }

        public IPrototype Clone(IPrototype image)
        {
            Image cloned = (Image)MemberwiseClone();
            return cloned;
        }
    }
}
