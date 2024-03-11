//
string inputName = Console.ReadLine();
if  (inputName.Length >= 5)
{
    string name=inputName.Substring(inputName.Length - 5);
    Console.WriteLine(name);
}
else
{
    Console.WriteLine("Error");
}

//
string surName = "Jordanov";
string surName2 =surName.Substring(3);
Console.WriteLine(surName2);