namespace CommandPattern
{
    public class ChangeColorCommand : ICommand
    {
        private readonly TextEditor textEditor;

        public ChangeColorCommand(TextEditor textEditor)
        {
            this.textEditor = textEditor;
        }

        void ICommand.Execute()
        {
            this.textEditor.ChangeColor();
        }
    }
}
