namespace AdapterPattern
{
    public class LegacyNotificationService : INotificationService
    {
        public void Send(string to, string title, string message)
        {
            Console.WriteLine("Sending message to " + to);
            Console.WriteLine("Title: " + title);
            Console.WriteLine(message);
        }
    }
}
