namespace Task2
{
    public class CarWash : ICarWash
    {
        public void WashCar(Car car)
        {
            Console.WriteLine("The car is being washed");
        }
        public void WashTruck(Truck truck)
        {
            Console.WriteLine("Truck is being washed.");
        }
    }
}
