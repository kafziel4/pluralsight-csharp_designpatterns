using BuilderPattern;

Console.Title = "Builder";

var garage = new Garage();
var miniBuilder = new MiniBuilder();
var bmwBuilder = new BMWBuilder();

garage.Construct(miniBuilder);
garage.Show();
//Console.WriteLine(miniBuilder.Car);

garage.Construct(bmwBuilder);
garage.Show();
//Console.WriteLine(bmwBuilder.Car);
