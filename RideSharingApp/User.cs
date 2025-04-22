namespace RideSharingApp
{
    public abstract class User
    {
        protected String name;
        protected String email;
        protected Location location;

        public User(String name, String email, Location location)
        {
            this.name = name;
            this.email = email;
            this.location = location;
        }

        public Location GetLocation() { return this.location; }
        public void SetLocation(Location location) { this.location = location; }
        public String getName() { return name; }

        public virtual void Notify(String message)
        {
            Console.WriteLine(message);
        }
    }
}
