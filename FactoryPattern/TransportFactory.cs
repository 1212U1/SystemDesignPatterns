namespace FactoryPattern
{
    public class TransportFactory
    {
        public TransportService CreateTransportation(String vehicleType)
        {
            switch (vehicleType.ToLower())
            {
                case "bike":
                    return new Bike();
                case "car":
                    return new Car();
                default:
                    throw new Exception("No vehicle type found");
            }
        }
    }
}
