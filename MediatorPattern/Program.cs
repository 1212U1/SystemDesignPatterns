using MediatorPattern;

//Holds the tight coupling between the users.No user needs to know about the other users.
//Delegates the work to the mediator
ChatRoom chatRoom = new ChatRoom();
ChatUser chatUserOne = new ChatUser("Kantha", chatRoom);
ChatUser chatUserTwo = new ChatUser("Challa", chatRoom);
ChatUser chatUserThree = new ChatUser("Abhinav", chatRoom);
chatRoom.AddUser(chatUserOne);
chatRoom.AddUser(chatUserTwo);
chatRoom.AddUser(chatUserThree);

chatUserOne.SendMessage("Hi this is Kantha");