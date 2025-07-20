namespace StatePatternV2
{
    public class GreenState : ISignalState
    {
        public void next(SignalContext context)
        {

            Console.WriteLine("Changing from {0} to Yellow", this.GetColor());

            context.SetState(new YellowState());
        }
        public String GetColor()
        {
            return "Green";
        }
    }
}
