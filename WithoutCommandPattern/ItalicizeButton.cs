namespace WithoutCommandPattern
{
    public class ItalicizeButton
    {
        private readonly TextEditor textEditor;

        public ItalicizeButton(TextEditor textEditor)
        {
            this.textEditor = textEditor;
        }
        public void Execute()
        {
            this.textEditor.ItalicizeText();
        }
    }
}
