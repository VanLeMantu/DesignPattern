namespace AbstractFactoryDesignPattern
{
    public interface IAnimalFactory
    {
        IAnimal CreateAnimal();
        IAnimalFood CreateAnimalFood();
        IAnimalToy CreateAnimalToy();
    }
}
