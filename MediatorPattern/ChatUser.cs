namespace MediatorPattern
{
    public class ChatUser
    {
        private String name;
        private ChatRoom chatRoom;
        public ChatUser(string name, ChatRoom chatRoom)
        {
            this.Name = name;
            this.ChatRoom = chatRoom;
        }

        public string Name { get => name; set => name = value; }
        public ChatRoom ChatRoom { get => chatRoom; set => chatRoom = value; }

        public void ReceiveMessage(String message, ChatUser chatUser)
        {
            if (chatUser != this)
            {
                Console.WriteLine("{0} Received a message {1}", this.Name, message);
            }
        }
        public void SendMessage(String message)
        {
            chatRoom.SendMessage(message, this);
        }
    }
}
