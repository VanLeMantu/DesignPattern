// Create leaf nodes
using CompositeDesignPattern.Composite;
using CompositeDesignPattern.Leaf;

Employee dev1 = new("John Doe", "Developer");
Employee dev2 = new("Jane Smith", "Developer");
Employee marketer = new("Mike Johnson", "Marketing");

// Initialize managers and add their subordinates
Manager engineeringManager = new("Jennifer Taylor", "Engineering Manager");
engineeringManager.AddSubordinate(dev1);
engineeringManager.AddSubordinate(dev2);

Manager marketingManager = new("James Brown", "Marketing Manager");
marketingManager.AddSubordinate(marketer);

// The general manager who has two managers as subordinates
Manager generalManager = new Manager("Alice King", "General Manager");
generalManager.AddSubordinate(engineeringManager);
generalManager.AddSubordinate(marketingManager);

// Display all employee details in the organization
generalManager.DisplayDetails();