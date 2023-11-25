namespace PrototypeDesignPattern
{
    public class Car : IPrototype
    {
        public string Model { get; set; }
        public string Color { get; set; }
        public IPrototype Clone(IPrototype car)
        {
            Car cloned = new();
            car = (Car)car;
            cloned.Model = ((Car)car).Model;
            cloned.Color = ((Car)car).Color;
            return cloned;
        }

        public IPrototype CloneSelf()
        {
            return (Car)MemberwiseClone();
        }
    }
}
