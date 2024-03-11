Console.WriteLine("Enter number: ");
int number =int.Parse(Console.ReadLine());
int sum = SumOfDigits(number);
Console.WriteLine($"Sum of digits: {sum}");

int SumOfDigits(int number)
{
    if (number != 0)
    {
        return(number%10+SumOfDigits(number/10));
    }
    else
    {
        return(0);
    }
}