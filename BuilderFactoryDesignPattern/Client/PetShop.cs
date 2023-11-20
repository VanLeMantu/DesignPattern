namespace AbstractFactoryDesignPattern
{
    public class PetShop
    {
        private readonly IAnimal _animal;
        private readonly IAnimalFood _animalFood;
        private readonly IAnimalToy _animalToy;

        public PetShop(IAnimalFactory factory)
        {
            _animal = factory.CreateAnimal();
            _animalFood = factory.CreateAnimalFood();
            _animalToy = factory.CreateAnimalToy();
        }

        public void DescribeProducts()
        {
            Console.WriteLine(_animal.Speak());
            Console.WriteLine(_animalFood.Serve());
            Console.WriteLine(_animalToy.Play());
        }
    }
}
