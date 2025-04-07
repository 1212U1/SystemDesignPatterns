using FactoryPattern;

TransportFactory transportFactory = new TransportFactory();
TransportService transportService = transportFactory.CreateTransportation("Bike");
transportService.Deliver();
transportService = transportFactory.CreateTransportation("Car");
transportService.Deliver();