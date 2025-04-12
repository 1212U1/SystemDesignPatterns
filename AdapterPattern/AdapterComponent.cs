namespace AdapterPattern
{
    public class AdapterComponent : INotificationService
    {
        private readonly NewGenNotificationService _notificationService;
        public AdapterComponent(NewGenNotificationService newGenNotificationService)
        {
            _notificationService = newGenNotificationService;
        }
        public void Send(string to, string title, string message)
        {
            _notificationService.SendMailUsingNewGen(to, title, message);
        }
    }
}
