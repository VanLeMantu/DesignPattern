namespace BuilderPatternForPizzaExample
{
    public class PizzaBuilder
    {
        public int Size { get; private set; }
        public bool Cheese { get; private set; }
        public bool Pepperoni { get; private set; }
        public bool Bacon { get; private set; }
        public bool Chilly { get; private set; }
        public PizzaBuilder SetSize(int size)
        {
            this.Size = size;
            return this;
        }
        public PizzaBuilder SetCheese(bool cheese)
        {
            Cheese = cheese;
            return this;
        }
        public PizzaBuilder SetPepperoni(bool pepperoni)
        {
            Pepperoni = pepperoni;
            return this;
        }
        public PizzaBuilder SetBacon(bool bacon)
        {
            Bacon = bacon;
            return this;
        }
        public PizzaBuilder SetChilly(bool chilly)
        {
            Chilly = chilly;
            return this;
        }
        public Pizza Build()
        {
            Pizza result = new Pizza(this);
            return result;
        }
    }
}
