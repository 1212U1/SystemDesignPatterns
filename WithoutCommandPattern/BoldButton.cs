namespace WithoutCommandPattern
{
    //Button is tightly coupled with text editor
    public class BoldButton
    {
        private readonly TextEditor textEditor;

        public BoldButton(TextEditor textEditor)
        {
            this.textEditor = textEditor;
        }
        public void Execute()
        {
            this.textEditor.BoldText();
        }
    }
}
