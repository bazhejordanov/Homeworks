using Task2;

CarCenter carCenter = new CarCenter();

Car car = new Car();
Truck truck = new Truck();

carCenter.WashCar(car);
carCenter.WashTruck(truck);
carCenter.PumpGas(car);
carCenter.CheckVehicle(truck);
carCenter.FixVehicle(car);