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

//using PrototypeDesignPattern;

//Document doc = new();
//doc.Title = "Document ABC";
//Document docCopy = (Document)doc.Clone(doc);
//Console.WriteLine($"docCopy's title = {docCopy.Title}");

//Image img = new()
//{
//    FileName = "image.png"
//};
//Image imgCopy = (Image)img.Clone(img);
//Console.WriteLine($"imgCopy's file name = {imgCopy.FileName}");

//Car car = new();
////Car clone = new Car();
////clone.Color = "Red";
////clone.Model = "Tesla";

//// Car clone = new Car() { Color = "Red", Model = "Tesla" };

//// Car clone = new Car { Color = "Red", Model = "Tesla" };

//Car prototypeRedTesla = (Car)car.Clone(new Car() { Color = "Red", Model = "Tesla"});
//Console.WriteLine($"prototypeRedTesla's color = {prototypeRedTesla.Color}, model = {prototypeRedTesla.Model}");
//Car prototypeBlueFord = (Car)car.Clone(new Car { Color = "Blue", Model = "Ford" });
//Console.WriteLine($"prototypeRedTesla's color = {prototypeBlueFord.Color}, model = {prototypeBlueFord.Model}");


//using AdapterDesignPattern.Adapters;
//using AdapterDesignPattern.Services;

//var iPhone = new IPhone();
//var android = new Android();
//Console.WriteLine("Recharging Android with MicroUsb");
//android.UseMicroUsb();
//android.Recharge();
//Console.WriteLine();

//Console.WriteLine("Recharging iPhone with Lightning");
//iPhone.UseLightning();
//iPhone.Recharge();
//Console.WriteLine();

//Console.WriteLine("Recharging iPhone with MicroUsb");
//var adapter = new LightningToMicroUsbAdapter(iPhone);
//adapter.UseMicroUsb();
//adapter.Recharge();

//using BridgeDesignPattern;

//IDatabaseImplementation dbImplementation = new SQLServerImplementation();
//ReportGenerator reportGenerator = new SalesReportGenerator(dbImplementation);
//reportGenerator.GenerateReport();

//// Nếu chuyển connect sang 1 db instance khác thì dùng bridge như này
//dbImplementation = new OracleImplementation();
//reportGenerator = new SalesReportGenerator(dbImplementation);
//reportGenerator.GenerateReport();

using BridgeDesignPattern2;

IRenderingEngine windowsEngine = new WindowsRenderingEngine();
UIControl button = new Button(windowsEngine, "Click Me");
button.Draw();

// De dang convert sang 1 he dieu hanh khac ma khong can thay doi code
IRenderingEngine linuxEngine = new LinuxRenderingEngine();
UIControl checkbox = new Checkbox(linuxEngine, true);
checkbox.Draw();