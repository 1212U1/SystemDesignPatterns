using AdapterPattern;
//The Adapter Pattern is a structural design pattern that allows
//objects with incompatible interfaces to collaborate. It acts as a bridge between two incompatible
//interfaces by converting the interface of one class into another interface that clients expect.
//Without modifying the client code much, we could use the adapter to make them work together.
INotificationService notificationService = new LegacyNotificationService();
notificationService.Send("Kantha", "Nothing", "This is kanthakumaran");

INotificationService notificationService2 = new AdapterComponent(new NewGenNotificationService());
notificationService2.Send("Kantha", "Nothing", "This is kanthakumaran");