namespace RideSharingApp
{
    public enum RideStatus
    {
        Scheduled,
        Ongoing,
        Completed
    }
    public class Ride
    {
        private Driver driver;
        private Passenger passenger;
        private RideStatus status;
        private Double distance;
        private IFareStrategy strategy;

        public Ride(Driver driver, Passenger passenger, double distance, IFareStrategy fareStrategy)
        {
            this.passenger = passenger;
            this.distance = distance;
            this.driver = driver;
            this.strategy = fareStrategy;
            this.status = RideStatus.Scheduled;
        }
        public double CalculateFare()
        {
            return this.strategy.CalculateFare(this.driver.GetVehicle(), this.distance);
        }
        public void ChangeStatus(RideStatus rideStatus)
        {
            this.status = rideStatus;
            notify("Ride is " + rideStatus.ToString());
        }
        public void notify(String message)
        {
            driver.Notify(message);
            passenger.Notify(message);
        }
    }
}
