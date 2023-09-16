using C2Models;

var animalSorter = new AnimalSorter();
var wagons = animalSorter.SortAnimals(Scenarios.Scenario1());

foreach (var wagon in wagons)
{
    Console.WriteLine($"Wagon Capacity: {wagon.AvailableCapacity}");
    foreach (var animal in wagon.Animals)
    {
        Console.WriteLine($"Size: {animal.Size}, Type: {animal.Type}");
    }
    Console.WriteLine();   
}

Console.WriteLine($"\nExpected amount of wagons: {wagons.Count}");