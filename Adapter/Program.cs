Console.Title = "Adapter";

// Object objectAdapter example
Adapter.ICityAdapter objectAdapter = new Adapter.CityAdapter();
var cityFromObjectAdapter = objectAdapter.GetCity();

Console.WriteLine($"{cityFromObjectAdapter.FullName}, {cityFromObjectAdapter.Inhabitants}");

// Class objectAdapter example
ClassAdapter.ICityAdapter classAdapter = new ClassAdapter.CityAdapter();
var cityFromClassAdapter = classAdapter.GetCity();

Console.WriteLine($"{cityFromClassAdapter.FullName}, {cityFromClassAdapter.Inhabitants}");
