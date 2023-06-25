using Iterator;

Console.Title = "Iterator";

// Create the collection
PeopleCollection people = new()
{
    new Person("Kevin Dockx", "Belgium"),
    new Person("Gill Cleeren", "Belgium"),
    new Person("Roland Guijt", "The Netherlands"),
    new Person("Thomas Claudius Huber", "Germany")
};

// Create the iterator
var peopleIterator = people.CreateIterator();

// Use the iterator to run through the people in the collection
// They should come out in alphabetical order
for (Person person = peopleIterator.First();
    !peopleIterator.IsDone;
    person = peopleIterator.Next()!)
{
    Console.WriteLine(person.Name);
}
