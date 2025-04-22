namespace RideSharingApp
{
    public class RideSharingService
    {
        private List<Driver> _drivers;
        private List<Passenger> _passengers;

        public RideSharingService()
        {
            _drivers = new List<Driver>();
            _passengers = new List<Passenger>();
        }
        public void AddDrivers(Driver driver)
        {
            _drivers.Add(driver);
        }

        public void AddPassengers(Passenger passenger)
        {
            _passengers.Add(passenger);
        }

        public void BookRide(Passenger passenger, Double distanceToTravel, IFareStrategy fareStrategy)
        {
            if (_drivers.Count == 0) { passenger.Notify("No drivers found"); return; }
            FindNearestDriver(passenger, out Driver assignedDriver);
            //Fare Calculation
            Double fareCalculated = fareStrategy.CalculateFare(assignedDriver.GetVehicle(), distanceToTravel);
            //Notify Passenger with fare and driver number
            passenger.Notify("Ride booked for the fare of " + fareCalculated.ToString() + " for " + passenger.getName());
        }

        public void FindNearestDriver(Passenger passenger, out Driver assignedDriver)
        {
            assignedDriver = null;
            Double minDistance = Double.MaxValue;
            foreach (Driver driver in _drivers)
            {
                Double distanceBetweenUserAndDriver = passenger.GetLocation().CalculateDistance(driver.GetLocation());
                if (distanceBetweenUserAndDriver < minDistance)
                {
                    assignedDriver = driver;
                    minDistance = distanceBetweenUserAndDriver;
                }
            }
        }
    }
}
