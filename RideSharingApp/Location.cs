namespace RideSharingApp
{
    public class Location
    {
        private Double latitude;
        private Double longitude;

        public Location(Double latitude, Double longitude)
        {
            this.Latitude = latitude;
            this.Longitude = longitude;
        }

        public Double Latitude { get => latitude; set => latitude = value; }
        public Double Longitude { get => longitude; set => longitude = value; }

        public Double CalculateDistance(Location that)
        {
            return Math.Sqrt(Math.Pow(that.latitude - this.latitude, 2) + Math.Pow(that.longitude - this.longitude, 2));
        }
    }
}
