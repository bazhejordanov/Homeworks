using ClassAnimal;

List<Animal> animals = new List<Animal>
{
    new Animal("Dog","Beige",5,Gender.Male),
    new Animal("Giraffe","Yellow",7,Gender.Female),
    new Animal("Zebra","White",9,Gender.Female),
    new Animal("Lion","Brown",13,Gender.Male),
    new Animal("Jaguar","Black",12,Gender.Male),
    new Animal("Tiger","Orange",6,Gender.Male),
    new Animal("Aligator","Green",8,Gender.Male),
    new Animal("Monkey","Brown",4,Gender.Male),
    new Animal("Horse","Brown",3,Gender.Male),
    new Animal("Bear","Brown",10,Gender.Female),
    new Animal("Dinosaurusi","Green",7,Gender.Male)
};

//older than age 5
Console.WriteLine("Animals older than 5:");
foreach (var animal in animals)
{
    if (animal.Age > 5)
    {
        Console.WriteLine($"{animal.Name}:{animal.Age}");
    }
}

//brown male animals
Console.WriteLine("Brown,male animals:");
foreach (var animal in animals)
{
    if (animal.Gender == Gender.Male && animal.Color.ToLower() == "brown")
    {
        Console.WriteLine(animal.Name);
    }
}
  
//name longer than 10 letters
Console.WriteLine("Animal with a name longer than 10 letters:");
Animal longNameAnimal = animals.Find(animal => animal.Name.Length > 10);
if(longNameAnimal != null)
{
    Console.WriteLine(longNameAnimal.Name);
}

//easier way
foreach (var animal in animals)
{
    if(animal.Name.Length > 10)
    {
        Console.WriteLine(animal.Name);
        break;
    }
}

//starts with "A"
foreach (var animal in animals)
{
    if (animal.Name.StartsWith("A"))
    {
        Console.WriteLine(animal.Name);
    }
}