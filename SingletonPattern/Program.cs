using SingletonPattern;
//Private constructor to restrict multiple instantiation
//Access Global resources with single instance throughout

AppSettings appSettings = AppSettings.GetInstance();
AppSettings appSettingsCopy = AppSettings.GetInstance();
Console.WriteLine(appSettings.DbConnectionString);
Console.WriteLine(appSettingsCopy.DbConnectionString);
Console.WriteLine((appSettingsCopy == appSettings).ToString());