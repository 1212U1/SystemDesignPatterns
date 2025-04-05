namespace StatePattern
{
    public class Cycling : ITransportationMode
    {
        public void GetDirection()
        {
            Console.WriteLine("Take Left");
        }

        public int GetETA()
        {
            return 10;
        }
    }
}
