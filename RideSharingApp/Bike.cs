namespace RideSharingApp
{
    public class Bike : Vehicle
    {
        public Bike(String numberPlate) : base(numberPlate) { }
        public override Double GetBaseFarePerKm()
        {
            return 5;
        }
    }
}
