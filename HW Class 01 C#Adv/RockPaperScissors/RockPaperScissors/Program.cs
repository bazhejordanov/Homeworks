Console.WriteLine("Enter your choice (rock, paper, or scissors):");
string user = Console.ReadLine().ToLower();

Random random = new Random();
int cpu = random.Next(3);

if (cpu == 0)
{
    if (user == "rock")
    {
        Console.WriteLine("The computer chose rock");
        Console.WriteLine("It's a tie ");
    }
    else if (user == "paper")
    {
        Console.WriteLine("The computer chose paper");
        Console.WriteLine("It's a tie ");
    }
    else if (user == "scissors")
    {
        Console.WriteLine("The computer chose scissors");
        Console.WriteLine("It's a tie ");
    }
    else
    {
        Console.WriteLine("Error");
    }
}

else if (cpu == 1)
{
    if (user == "rock")
    {
        Console.WriteLine("The computer chose paper");
        Console.WriteLine("You lose, paper beats rock");
    }
    else if (user == "paper")
    {
        Console.WriteLine("The computer chose scissors");
        Console.WriteLine("You lose, scissors beats paper");
    }
    else if (user == "scissors")
    {
        Console.WriteLine("The computer chose rock");
        Console.WriteLine("You lose, rock beats scissors");
    }
    else
    {
        Console.WriteLine("Error");
    }
}

else if (cpu == 2)
{
    if (user == "rock")
    {
        Console.WriteLine("The computer chose scissors");
        Console.WriteLine("You win, rock beats scissors");
    }
    else if (user == "paper")
    {
        Console.WriteLine("The computer chose rock");
        Console.WriteLine("You win, paper beats rock");
    }
    else if (user == "scissors")
    {
        Console.WriteLine("The computer chose paper");
        Console.WriteLine("You win, scissors beats paper");
    }
    else
    {
        Console.WriteLine("Error");
    }
}

Console.ReadLine();