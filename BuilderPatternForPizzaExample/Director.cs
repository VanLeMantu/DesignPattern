namespace BuilderPatternForPizzaExample
{
    public static class Director
    {
        public static Pizza CreatePizzaWithChilly()
        {
            return new PizzaBuilder()
                .SetSize(12)
                .SetChilly(true)
                .Build();
        }
    }
}
