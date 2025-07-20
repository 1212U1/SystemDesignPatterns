namespace StatePatternV2
{
    public class SignalContext
    {
        private ISignalState signalState;
        public SignalContext()
        {
            this.signalState = new RedState();
        }

        public void SetState(ISignalState signalState)
        {
            this.signalState = signalState;
        }
        public void next()
        {
            signalState.next(this);
        }
    }
}
