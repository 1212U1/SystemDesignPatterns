using FacadePattern;
/*The Facade Pattern is a structural design pattern that provides 
 * a simplified interface to a complex subsystem of classes, libraries, or frameworks. It's 
 * particularly useful when you want to hide implementation details and reduce dependencies between 
 * client code and subsystems.*/
APIGateway aPIGateway = new APIGateway();
Console.WriteLine(aPIGateway.GetFullOrderDetails("123", "343", "324"));