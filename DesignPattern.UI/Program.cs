//using BuilderPatternForPizzaExample;
//using NonBuilderPatternForPizzaExample;
//using BuilderDesignPatternForHouseExample;

//// builder pattern
//var director = new Director();
//var pizza = director.CreatePizzaWithChilly();
//Console.WriteLine($"Size: {pizza.Size}, Chilli: {pizza.Chilly}");

//// non-builder pattern
//NonBuilderPizza pizzaNonbuilder = new NonBuilderPizza(size: 12, cheese: false, pepperoni: true, bacon: false);
//Console.WriteLine($"Size: {pizzaNonbuilder.Size}, Pepperoni: {pizzaNonbuilder.Pepperoni}");

// builder pattern with house example
//IHouseBuilder stoneHouseBuilder = new StoneHouseBuilder();
//House stoneHouse = HouseDirector.Construct(stoneHouseBuilder);
//Console.WriteLine($"Constructed House: {stoneHouse.Walls}, {stoneHouse.Doors}, {stoneHouse.Windows}");

//IHouseBuilder woodenHouseBuilder = new WoodenHouseBuilder();
//House woodenHouse = HouseDirector.Construct(woodenHouseBuilder);
//Console.WriteLine($"Constructed House: {woodenHouse.Walls}, {woodenHouse.Doors}, {woodenHouse.Windows}");

// factory method pattern
//using FactoryMethodDesignPattern;

//IDocumentCreator pdfCreator = new PDFDocumentCreator();
//IDocument pdfDocument = pdfCreator.CreateDocument();
//pdfDocument.Open();
//pdfDocument.Save();

//IDocumentCreator wordCreator = new WordDocumentCreator();
//IDocument wordDocument = wordCreator.CreateDocument();
//wordDocument.Open();
//wordDocument.Save();

//using BuilderFactoryDesignPattern;

//var catShop = new PetShop(new CatFactory());
//catShop.DescribeProducts();

//var dogShop = new PetShop(new DogFactory());
//dogShop.DescribeProducts();

using PrototypeDesignPattern;

Document doc = new();
doc.Title = "Document Prototype";
Document docCopy = (Document)doc.Clone(doc);
Console.WriteLine($"docCopy's title = {docCopy.Title}");

Image img = new();
img.FileName = "image.png";
Image imgCopy = (Image)img.Clone(img);
Console.WriteLine($"imgCopy's file name = {imgCopy.FileName}");

Car car = new Car();
Car prototypeRedTesla = (Car)car.Clone(new Car { Color = "Red", Model = "Tesla"});
Console.WriteLine($"prototypeRedTesla's color = {prototypeRedTesla.Color}, model = {prototypeRedTesla.Model}");
Car prototypeBlueFord = (Car)car.Clone(new Car { Color = "Blue", Model = "Ford" });
Console.WriteLine($"prototypeRedTesla's color = {prototypeBlueFord.Color}, model = {prototypeBlueFord.Model}");
