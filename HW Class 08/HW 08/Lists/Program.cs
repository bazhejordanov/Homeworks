//task2
List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
List<int> squares=numbers.Select(num=>num*num).ToList();

Console.WriteLine("Numbers:");
foreach(var number in numbers)
{
    Console.WriteLine(number);
}

Console.WriteLine("Squares of numbers");
foreach (var square in squares)
{
    Console.WriteLine(square);
}
