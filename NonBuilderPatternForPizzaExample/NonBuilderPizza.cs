namespace NonBuilderPatternForPizzaExample
{
    public class NonBuilderPizza
    {
        public int Size { get; private set; }
        public bool Cheese { get; private set; }
        public bool Pepperoni { get; private set; }
        public bool Bacon { get; private set; }
        public NonBuilderPizza(int size, bool cheese, bool pepperoni, bool bacon)
        {
            Size = size;
            Cheese = cheese;
            Pepperoni = pepperoni;
            Bacon = bacon;
        }
    }
}
