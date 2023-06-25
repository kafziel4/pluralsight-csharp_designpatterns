using Visitor;

Console.Title = "Visitor";

// Create container and add concrete elements
var container = new Container();

container.Customers.Add(new Customer("Sophie", 500));
container.Customers.Add(new Customer("Karen", 1000));
container.Customers.Add(new Customer("Sven", 800));
container.Employees.Add(new Employee("Kevin", 18));
container.Employees.Add(new Employee("Tom", 5));

// Create visitor
DiscountVisitor discountVisitor = new();

// Pass it through
container.Accept(discountVisitor);

// Write out gathered amount
Console.WriteLine($"Total discount: {discountVisitor.TotalDiscountGiven}");
