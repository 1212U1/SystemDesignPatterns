namespace RideSharingApp
{
    public class Driver : User
    {
        private Vehicle vehicletype;
        public Driver(String name, String email, Location location, Vehicle vehicleType) : base(name, email, location)
        {
            this.vehicletype = vehicleType;
        }

        public Vehicle GetVehicle() { return this.vehicletype; }
    }
}
