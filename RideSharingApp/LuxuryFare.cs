namespace RideSharingApp
{
    public class LuxuryFare : IFareStrategy
    {
        public Double CalculateFare(Vehicle vehicle, Double distanceTravelled)
        {
            return vehicle.GetBaseFarePerKm() * distanceTravelled * 1.5;
        }
    }
}
