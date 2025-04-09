namespace AbstractFactoryPattern
{
    public class ClientApplication
    {
        /*
         * App holds the reference to button and checkbox. Only the theme of button and checkbox changes.
        We can't have windows button and mac checkbox at the same time. That was blocked with the design.
        Each theme factory is resp for giving their own button and checkbox.
        Abstract factory pattern is something which creates a family of related objects
         */
        public IButton button;
        public ICheckBox checkBox;

        public ClientApplication(IAbstractFactory abstractFactory)
        {
            button = abstractFactory.CreateButton();
            checkBox = abstractFactory.CreateCheckBox();
        }
        public void ChangeFactory(IAbstractFactory abstractFactory)
        {
            button = abstractFactory.CreateButton();
            checkBox = abstractFactory.CreateCheckBox();
        }
        public void RenderUI()
        {
            button.Render();
            checkBox.Render();
        }

    }
}
