namespace Task1
{
    class Dog : Animal, IDog
    {
        public Dog(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public override void PrintAnimal()
        {
            Console.WriteLine($"Dog: {Name}, Age: {Age}");
        }

        public void Bark()
        {
            Console.WriteLine("Af Af");
        }
    }
}
