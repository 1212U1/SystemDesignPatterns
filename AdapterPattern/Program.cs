using AdapterPattern;

//Without modifying the client code much, we could use the adapter to make them work together.
INotificationService notificationService = new LegacyNotificationService();
notificationService.Send("Kantha", "Nothing", "This is kanthakumaran");

INotificationService notificationService2 = new AdapterComponent(new NewGenNotificationService());
notificationService2.Send("Kantha", "Nothing", "This is kanthakumaran");