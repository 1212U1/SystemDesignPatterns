namespace CommandPattern
{
    public class BoldCommand : ICommand
    {
        private readonly TextEditor textEditor;

        public BoldCommand(TextEditor textEditor)
        {
            this.textEditor = textEditor;
        }

        void ICommand.Execute()
        {
            this.textEditor.BoldText();
        }
    }
}
