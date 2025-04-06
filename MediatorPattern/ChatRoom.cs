namespace MediatorPattern
{
    public class ChatRoom : IMediator
    {
        private List<ChatUser> _users;
        public ChatRoom() { _users = new List<ChatUser>(); }

        public void AddUser(ChatUser chatUser)
        {
            _users.Add(chatUser);
        }

        public void SendMessage(String message, ChatUser chatUser)
        {
            Console.WriteLine("{0} sending a message to people across chatroom", chatUser.Name);
            foreach (ChatUser receiver in _users)
            {
                receiver.ReceiveMessage(message, chatUser);
            }
        }
    }
}
