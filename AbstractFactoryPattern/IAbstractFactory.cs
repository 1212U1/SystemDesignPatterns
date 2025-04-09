namespace AbstractFactoryPattern
{
    public interface IAbstractFactory
    {
        IButton CreateButton();
        ICheckBox CreateCheckBox();
    }
}
