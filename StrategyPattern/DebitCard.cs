namespace StrategyPattern
{
    public class DebitCard : IStrategyPattern
    {
        public void MakePayment()
        {
            Console.WriteLine("Make payment using DebitCard");
        }
    }
}
