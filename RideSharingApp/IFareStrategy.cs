namespace RideSharingApp
{
    public interface IFareStrategy
    {
        Double CalculateFare(Vehicle vehicle, Double distanceTravelled);
    }
}
