namespace ObserverPattern
{
    public class WeatherStation : IObservable
    {
        private List<IObserver> observerList = new List<IObserver>();
        private String temperature;
        public WeatherStation()
        {
            temperature = "0";
        }
        public void AddObservers(IObserver observer)
        {
            this.observerList.Add(observer);
        }

        public void RemoveObservers(IObserver observer)
        {
            this.observerList.Remove(observer);
        }

        public void SetValue(String temperature)
        {
            this.temperature = temperature;
            Update();
        }

        private void Update()
        {
            foreach (IObserver observer in observerList)
            {
                observer.PushNotification("Weather has been changed to " + this.temperature);
            }
        }
    }
}
