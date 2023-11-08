using BuilderPatternForPizzaExample;
using NonBuilderPatternForPizzaExample;

// builder pattern
var director = new Director();
var pizza = director.CreatePizzaWithChilly();
Console.WriteLine($"Size: {pizza.Size}, Chilli: {pizza.Chilly}");

// non-builder pattern
NonBuilderPizza pizzaNonbuilder = new NonBuilderPizza(size: 12, cheese: false, pepperoni: true, bacon: false);
Console.WriteLine($"Size: {pizzaNonbuilder.Size}, Pepperoni: {pizzaNonbuilder.Pepperoni}");