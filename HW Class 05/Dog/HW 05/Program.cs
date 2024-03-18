using HW_05;

Console.WriteLine("Enter dog's name:");
string name = Console.ReadLine();

Console.WriteLine("Enter dog's breed:");
string breed = Console.ReadLine();

Console.WriteLine("Enter dog's color:");
string color = Console.ReadLine();

Dog dog=new Dog(name, breed, color);

Console.WriteLine("Choose: ");
Console.WriteLine("1. Eat");
Console.WriteLine("2. Play");
Console.WriteLine("3. Chase Tail");

int choose=int.Parse(Console.ReadLine());

switch (choose)
{
    case 1:
        Console.WriteLine(dog.Eat());
        break;
    case 2:
        Console.WriteLine(dog.Play());
        break;
    case 3:
        Console.WriteLine(dog.ChaseTail());
        break;
    default:
        Console.WriteLine("Error");
        break;
}