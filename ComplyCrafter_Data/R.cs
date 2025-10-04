using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ComplyCrafter_Data
{
    public static class R
    {
#pragma warning disable CS8618
        public static IConfiguration AppConfig { get; set; }
#pragma warning restore CS8618

        public static string AppName { get => AppSet("AppName") ?? "Comply Crafter"; }
        public static string? AppSet(string key) => AppConfig.GetValue<object>(key)?.ToString();
        public static T? AppSet<T>(string key) => AppConfig.GetValue<T>(key);
        public static string GetPath(string filePath) => AppDomain.CurrentDomain.BaseDirectory + Path.DirectorySeparatorChar + filePath.Replace('\\', Path.DirectorySeparatorChar).Replace('/', Path.DirectorySeparatorChar);
        public static bool IsBlank(this string? str) { return string.IsNullOrWhiteSpace(str); }
        public static bool IsNull(this object? obj) { return obj == null; }
        public static string ConnectionString { get => AppConfig.GetConnectionString("DB")!; }

        public static string ApiUrl
        {
            get => AppSet("API:URL");
        }
        public static string ApiUIUrl
        {
            get => AppSet("API:UIURL");
        }
    }
}
