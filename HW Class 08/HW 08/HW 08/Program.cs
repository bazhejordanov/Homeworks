//task 1
Queue<int> numbers = new Queue<int>();

string yesOrNo;
do
{
    Console.WriteLine("Enter a number: ");
    int number = int.Parse(Console.ReadLine());
    numbers.Enqueue(number);

    Console.WriteLine("Will you enter another number? ");
    yesOrNo = Console.ReadLine();
} while (yesOrNo.ToUpper() == "Y" || yesOrNo.ToLower() == "y");

Console.WriteLine("Numbers entered by order: ");
foreach (var num in numbers)
{
    Console.WriteLine(num);
}