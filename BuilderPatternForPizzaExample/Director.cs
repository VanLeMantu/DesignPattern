namespace BuilderPatternForPizzaExample
{
    public class Director
    {
        public Pizza CreatePizzaWithChilly()
        {
            return new PizzaBuilder()
                .SetSize(12)
                .SetChilly(true)
                .Build();
        }
    }
}
