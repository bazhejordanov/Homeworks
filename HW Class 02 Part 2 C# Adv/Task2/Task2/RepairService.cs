namespace Task2
{
    public class RepairService : IRepairService
    {
        public void CheckVehicle(Vehicle vehicle)
        {
            Console.WriteLine("The vehicle is being repared");
        }
        public void FixVehicle(Vehicle vehicle)
        {
            Console.WriteLine("The vehicle is being fixed");
        }
    }
}
