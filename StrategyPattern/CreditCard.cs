namespace StrategyPattern
{
    public class CreditCard : IStrategyPattern
    {
        public void MakePayment()
        {
            Console.WriteLine("Make payment using CreditCard");
        }
    }
}
