namespace AbstractFactoryDesignPattern
{
    public class DogFactory : IAnimalFactory
    {
        public IAnimal CreateAnimal() => new Dog();
        public IAnimalFood CreateAnimalFood() => new DogFood();
        public IAnimalToy CreateAnimalToy() => new DogToy();
    }
}
