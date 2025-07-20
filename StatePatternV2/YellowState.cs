namespace StatePatternV2
{
    public class YellowState : ISignalState
    {
        public void next(SignalContext context)
        {
            Console.WriteLine("Changing from {0} to Red", this.GetColor());
            context.SetState(new RedState());
        }
        public String GetColor()
        {
            return "Yellow";
        }
    }
}
