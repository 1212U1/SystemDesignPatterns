namespace DecoratorPattern
{
    public abstract class CoffeeDecorator : ICoffee
    {
        protected ICoffee _coffee;

        public CoffeeDecorator(ICoffee coffee)
        {
            this._coffee = coffee;
        }
        public virtual Int32 GetCost()
        {
            return _coffee.GetCost();
        }

        public virtual String GetDescription()
        {
            return _coffee.GetDescription();
        }
    }
}
