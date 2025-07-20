namespace StatePatternV2
{
    public class RedState : ISignalState
    {
        public void next(SignalContext context)
        {
            Console.WriteLine("Changing from {0} to Green", this.GetColor());
            context.SetState(new GreenState());
        }
        public String GetColor()
        {
            return "Red";
        }
    }
}
