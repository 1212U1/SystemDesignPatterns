namespace StatePattern
{
    public class Car : ITransportationMode
    {
        public void GetDirection()
        {
            Console.WriteLine("Take Right");
        }

        public int GetETA()
        {
            return 5;
        }
    }
}
