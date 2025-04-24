using RideSharingApp;

Location location1 = new Location(latitude: 37.7749, longitude: -122.4194);
Location location2 = new Location(latitude: 37.8024, longitude: -122.4058);
Location location3 = new Location(latitude: 37.7694, longitude: -122.4862);

//Driver driverOne = new Driver("Kantha", "kantha1212@gmail.com", location1, new Car("TN792056"));
Driver driverTwo = new Driver("Challa", "challa1212@gmail.com", location2, new Bike("TN792057"));
//Driver driverThree = new Driver("Abhi", "abhi1212@gmail.com", location3, new Car("TN792058"));

Passenger passengerOne = new Passenger("Sanjay", "Sanjay@gmail.com", location2);
Passenger passengerTwo = new Passenger("JP", "JP@gmail.com", location1);

RideSharingService rideSharingService = new RideSharingService();
rideSharingService.AddPassengers(passengerOne);
rideSharingService.AddPassengers(passengerTwo);

//rideSharingService.AddDrivers(driverOne);
rideSharingService.AddDrivers(driverTwo);
//rideSharingService.AddDrivers(driverThree);
rideSharingService.BookRide(passengerTwo, 23.34, new SharedFare());

rideSharingService.BookRide(passengerOne, 50.34, new LuxuryFare());
