namespace HW_05
{
    internal class Dog
    {
        public string Name { get; set; }
        public string Breed { get; set; }
        public string Color { get; set; }

        public Dog(string name, string breed, string color)
        {
            Name = name;
            Breed = breed;
            Color = color;
        }

        public string Eat()
        {
            return "The dog is now eating";
        }
        public string Play()
        {
            return "The dog is now playing";
        }
        public string ChaseTail()
        {
            return "The dog is now chasing it's tail";
        }
    }
}
