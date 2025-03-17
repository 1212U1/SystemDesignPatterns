namespace StrategyPattern
{
    public class PaymentService
    {
        public IStrategyPattern strategyPattern;
        public PaymentService()
        {
            this.strategyPattern = new CreditCard();
        }
        public void SetPaymentMethod(IStrategyPattern strategyPattern)
        {
            this.strategyPattern = strategyPattern;
        }
        public void MakePayment()
        {
            this.strategyPattern.MakePayment();
        }
    }
}
