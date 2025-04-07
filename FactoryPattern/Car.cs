namespace FactoryPattern
{
    internal class Car : TransportService
    {
        public Car() { }
        public override void Deliver()
        {
            Console.WriteLine("Delivering via Car");
        }
    }
}
