namespace MediatorPattern
{
    public interface IMediator
    {
        void AddUser(ChatUser chatUser);
        void SendMessage(String message, ChatUser chatUser);

    }
}
