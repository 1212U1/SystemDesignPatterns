namespace DecoratorPattern
{
    public class SimpleCoffee : ICoffee
    {
        public Int32 GetCost()
        {
            return 1;
        }

        public String GetDescription()
        {
            return "Simple Coffee";
        }
    }
}
