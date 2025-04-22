namespace RideSharingApp
{
    public class Car : Vehicle
    {
        public Car(String numberPlate) : base(numberPlate) { }
        public override double GetBaseFarePerKm()
        {
            return 10;
        }
    }
}
