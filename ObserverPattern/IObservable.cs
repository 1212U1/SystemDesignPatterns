namespace ObserverPattern
{
    interface IObservable
    {
        void AddObservers(IObserver observer);
        void RemoveObservers(IObserver observer);
        void SetValue(String temperature);

    }
}
