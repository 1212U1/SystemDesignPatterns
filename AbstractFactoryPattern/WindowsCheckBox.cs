namespace AbstractFactoryPattern
{
    public class WindowsCheckBox : ICheckBox
    {
        public void Render()
        {
            Console.WriteLine("Rendering Windows CheckBox");
        }
    }
}
