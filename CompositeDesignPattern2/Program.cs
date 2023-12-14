// Create individual files
var file1 = new CompositeDesignPattern2.Leaf.File(2048); // 2KB
var file2 = new CompositeDesignPattern2.Leaf.File(1024); // 1KB
var file3 = new CompositeDesignPattern2.Leaf.File(2560); // 2.5KB

// Create directories and add files/subdirectories
var subDirectory = new CompositeDesignPattern2.Composite.Directory();
subDirectory.Add(file1);
subDirectory.Add(file2);

var mainDirectory = new CompositeDesignPattern2.Composite.Directory();
mainDirectory.Add(subDirectory);
mainDirectory.Add(file3);

// Print sizes
Console.WriteLine("Size of file1: " + file1.GetSize() + " bytes");
Console.WriteLine("Size of subDirectory: " + subDirectory.GetSize() + " bytes");
Console.WriteLine("Size of mainDirectory: " + mainDirectory.GetSize() + " bytes");