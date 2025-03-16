namespace ObserverPattern
{
    public class Observer : IObserver
    {
        private String name;
        public Observer(String name)
        {
            this.name = name;
        }
        public void PushNotification(string message)
        {
            Console.WriteLine($"Hi {name} {message}");
        }
    }
}
