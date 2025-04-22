namespace RideSharingApp
{
    public abstract class Vehicle
    {
        protected String numberPlate;
        public Vehicle(String numberPlate)
        {
            this.numberPlate = numberPlate;
        }

        public String NumberPlate { get => numberPlate; }

        public abstract Double GetBaseFarePerKm();
    }
}
