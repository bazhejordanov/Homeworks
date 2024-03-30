namespace Task2
{
    public class CarCenter : ICarWash, IGasPump, IRepairService
    {
        private CarWash carWash = new CarWash();
        private GasPump gasPump = new GasPump();
        private RepairService repairService = new RepairService();

        public void WashCar(Car car)
        {
            carWash.WashCar(car);
        }

        public void WashTruck(Truck truck)
        {
            carWash.WashTruck(truck);
        }

        public void PumpGas(Vehicle vehicle)
        {
            gasPump.PumpGas(vehicle);
        }

        public void CheckVehicle(Vehicle vehicle)
        {
            repairService.CheckVehicle(vehicle);
        }

        public void FixVehicle(Vehicle vehicle)
        {
            repairService.FixVehicle(vehicle);
        }
    }
}
