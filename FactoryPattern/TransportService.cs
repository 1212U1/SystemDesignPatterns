namespace FactoryPattern
{
    public abstract class TransportService
    {
        public virtual void Deliver()
        {
            Console.WriteLine("Normal Drive mode");
        }
    }
}
