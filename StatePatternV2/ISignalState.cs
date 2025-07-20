namespace StatePatternV2
{
    public interface ISignalState
    {
        void next(SignalContext context);
        String GetColor();
    }
}
