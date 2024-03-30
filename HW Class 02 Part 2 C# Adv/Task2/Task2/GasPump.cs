namespace Task2
{
    public class GasPump : IGasPump
    {
        public void PumpGas(Vehicle vehicle)
        {
            Console.WriteLine("Gas is being pumped in the vehicle");
        }
    }
}
