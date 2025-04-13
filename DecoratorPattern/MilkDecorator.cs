namespace DecoratorPattern
{
    public class MilkDecorator : CoffeeDecorator
    {
        public MilkDecorator(ICoffee coffee) : base(coffee)
        {

        }
        public override Int32 GetCost()
        {
            return _coffee.GetCost() + 2;
        }

        public override String GetDescription()
        {
            return _coffee.GetDescription() + " Milk";
        }
    }
}
