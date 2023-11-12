using BuilderPatternForPizzaExample;
using NonBuilderPatternForPizzaExample;
using BuilderDesignPatternForHouseExample;

//// builder pattern
//var director = new Director();
//var pizza = director.CreatePizzaWithChilly();
//Console.WriteLine($"Size: {pizza.Size}, Chilli: {pizza.Chilly}");

//// non-builder pattern
//NonBuilderPizza pizzaNonbuilder = new NonBuilderPizza(size: 12, cheese: false, pepperoni: true, bacon: false);
//Console.WriteLine($"Size: {pizzaNonbuilder.Size}, Pepperoni: {pizzaNonbuilder.Pepperoni}");

// builder pattern with house example
IHouseBuilder stoneHouseBuilder = new StoneHouseBuilder();
House stoneHouse = HouseDirector.Construct(stoneHouseBuilder);
Console.WriteLine($"Constructed House: {stoneHouse.Walls}, {stoneHouse.Doors}, {stoneHouse.Windows}");

IHouseBuilder woodenHouseBuilder = new WoodenHouseBuilder();
House woodenHouse = HouseDirector.Construct(woodenHouseBuilder);
Console.WriteLine($"Constructed House: {woodenHouse.Walls}, {woodenHouse.Doors}, {woodenHouse.Windows}");