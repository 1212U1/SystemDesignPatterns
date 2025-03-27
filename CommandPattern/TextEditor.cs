namespace CommandPattern
{
    //Receiver
    public class TextEditor
    {
        public TextEditor()
        {

        }
        public void BoldText()
        {
            Console.WriteLine("Bold");
        }
        public void UnderLineText()
        {
            Console.WriteLine("UnderLine");
        }
        public void ChangeColor()
        {
            Console.WriteLine("Color Changed");
        }
    }
}
