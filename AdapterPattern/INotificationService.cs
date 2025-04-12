namespace AdapterPattern
{
    interface INotificationService
    {
        void Send(String to, String title, String message);
    }
}
