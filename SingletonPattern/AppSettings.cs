namespace SingletonPattern
{
    public class AppSettings
    {
        private readonly String dbConnectionString;
        private static AppSettings instance;

        public String DbConnectionString => dbConnectionString;

        private AppSettings()
        {
            //read from a file and initialize here
            dbConnectionString = "SomeThing";
        }
        public static AppSettings GetInstance()
        {
            if (instance == null)
            {
                instance = new AppSettings();
            }
            return instance;
        }
    }
}
