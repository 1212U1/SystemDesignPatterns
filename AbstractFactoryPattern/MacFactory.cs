namespace AbstractFactoryPattern
{
    public class MacFactory : IAbstractFactory
    {
        public IButton CreateButton()
        {
            return new MacButton();
        }

        public ICheckBox CreateCheckBox()
        {
            return new MacCheckBox();
        }
    }
}
