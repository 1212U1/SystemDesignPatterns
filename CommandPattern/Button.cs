namespace CommandPattern
{
    //Invoker
    public class Button
    {
        private ICommand _command;

        public void SetCommand(ICommand command)
        {
            _command = command;
        }
        public void Click()
        {
            _command.Execute();
        }
    }
}
