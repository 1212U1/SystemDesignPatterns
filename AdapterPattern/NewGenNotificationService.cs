namespace AdapterPattern
{
    public class NewGenNotificationService
    {
        public void SendMailUsingNewGen(String receipient, String subject, String body)
        {
            Console.WriteLine("Sending message using new gen service to " + receipient);
            Console.WriteLine("Title: " + subject);
            Console.WriteLine(body);
        }
    }
}
