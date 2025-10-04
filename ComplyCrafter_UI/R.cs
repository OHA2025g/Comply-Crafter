namespace ComplyCrafter_UI
{
    public static class R
    {
        public static IConfiguration AppConfig { get; set; }

        public static string AppName { get => AppSet("AppName") ?? "Comply Crafter"; }
        public static string? AppSet(string key) => AppConfig.GetValue<object>(key)?.ToString();
        public static T AppSet<T>(string key) => AppConfig.GetValue<T>(key);
        public static string GetPath(string filePath) => AppDomain.CurrentDomain.BaseDirectory + Path.DirectorySeparatorChar + filePath.Replace('\\', Path.DirectorySeparatorChar).Replace('/', Path.DirectorySeparatorChar);

        public static string ApiUrl
        {
            get => AppSet("API:URL");
        }
        public static string AppOTPTime
        {
            get => AppSet("OTP:ValidityInMin");
        }
        public static string AppSessionTime
        {
            get => AppSet("SessionTimeout:ValidityInHr");
        }

    }

}
