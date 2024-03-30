namespace Task1
{
    class Cat : Animal, ICat
    {
        public Cat(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public override void PrintAnimal()
        {
            Console.WriteLine($"Cat: {Name}, Age: {Age}");
        }

        public void Eat(string food)
        {
            Console.WriteLine($"The cat is eating {food}.");
        }
    }
}