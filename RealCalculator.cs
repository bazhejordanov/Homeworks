Console.Write("Enter first number: ");
double firstNumber = double.Parse(Console.ReadLine());


Console.Write("Enter second number: ");
double secondNumber = double.Parse(Console.ReadLine());

Console.Write("Enter operation (+, -, *, /): ");
char operation = char.Parse(Console.ReadLine());

double result = 0.0;

switch (operation)
{
    case '+':
        result = firstNumber + secondNumber;
        break;
    case '-':
        result = firstNumber - secondNumber;
        break;
    case '*':
        result = firstNumber * secondNumber;
        break;
    case '/':
        result = firstNumber / secondNumber;
        break;
    default:
        Console.WriteLine("Error");
        return;
}
Console.WriteLine("Result: " + result);
