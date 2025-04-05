using StatePattern;
//context
//context holds reference to state
//Concrete state implement its behaviour
DirectionService directionService = new DirectionService(new Car());
Console.WriteLine("Estimated time is {0}", directionService.GetETA().ToString());
directionService.GetDirection();
directionService.ChangeTransportationMode(new Cycling());
Console.WriteLine("Estimated time is {0}", directionService.GetETA().ToString());
directionService.GetDirection();