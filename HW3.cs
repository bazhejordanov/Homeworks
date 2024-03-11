//task 2
string[] studentsG1 = { "Zdravko", "Petko", "Stanko", "Branko", "Trajko" };
string[] studentsG2 = { "Nikola", "Marija", "Jovana", "Martina", "Bazhe" };

int groupNumber;

while (true)
    if (int.TryParse(Console.ReadLine(), out groupNumber) && groupNumber >= 1 && groupNumber <= 2)
    {
        break;
    }
    else
    {
        Console.WriteLine("Error.Enter 1 or 2");
    }

if (groupNumber == 1)
{
    Console.WriteLine("G1 Students:");
    foreach (string student in studentsG1)
    {
        Console.WriteLine(student);
    }
}
else
{
    Console.WriteLine("G2 Students:");
    foreach (string student in studentsG2)
    {
        Console.WriteLine(student);
    }
}

//task 1
int[] numbers = new int[6];
for (int i = 0; i < 6; i++)
{
    Console.Write($"Enter integer: ");
    if (int.TryParse(Console.ReadLine(), out int inputNumber))
    {
        numbers[i] = inputNumber;
    }
    else
    {
        Console.WriteLine("Error");
    }
}

int sumOfEven = 0;
foreach (int number in numbers)
{
    if (number % 2 == 0)
    {
        sumOfEven += number;
    }
}
Console.WriteLine($"Result:{sumOfEven}");
 