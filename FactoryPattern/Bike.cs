namespace FactoryPattern
{
    public class Bike : TransportService
    {
        public Bike() { }
        public override void Deliver()
        {
            Console.WriteLine("Delivering via Bike");
        }
    }
}
