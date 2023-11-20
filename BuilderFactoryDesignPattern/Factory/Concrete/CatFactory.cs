namespace AbstractFactoryDesignPattern
{
    public class CatFactory : IAnimalFactory
    {
        public IAnimal CreateAnimal() => new Cat();
        public IAnimalFood CreateAnimalFood() => new CatFood();
        public IAnimalToy CreateAnimalToy() => new CatToy();
    }
}
