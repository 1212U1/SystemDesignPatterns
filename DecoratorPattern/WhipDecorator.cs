namespace DecoratorPattern
{
    public class WhipDecorator : CoffeeDecorator
    {
        public WhipDecorator(ICoffee coffee) : base(coffee)
        {

        }
        public override Int32 GetCost()
        {
            return _coffee.GetCost() + 2;
        }

        public override String GetDescription()
        {
            return _coffee.GetDescription() + " Whip";
        }
    }
}
