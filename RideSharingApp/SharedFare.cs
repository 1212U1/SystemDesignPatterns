namespace RideSharingApp
{
    public class SharedFare : IFareStrategy
    {
        public double CalculateFare(Vehicle vehicle, double distanceTravelled)
        {
            return vehicle.GetBaseFarePerKm() * distanceTravelled * 0.5;
        }
    }
}
