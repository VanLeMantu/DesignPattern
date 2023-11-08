namespace BuilderPatternForPizzaExample
{
    public class Pizza
    {
        public int Size { get; private set; }
        public bool Cheese { get; private set; }
        public bool Pepperoni { get; private set; }
        public bool Bacon { get; private set; }
        public bool Chilly { get; private set; }
        public Pizza(PizzaBuilder builder)
        {
            Size = builder.Size;
            Cheese = builder.Cheese;
            Pepperoni = builder.Pepperoni;
            Bacon = builder.Bacon;
            Chilly = builder.Chilly;
        }
    }
}
