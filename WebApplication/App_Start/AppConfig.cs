using System;

namespace WebApplication
{
    public static class AppConfig
    {
        public static string ApiUrl { get; set; }

        //Get settings from web.config file
        public static T GetAppSetting<T>(string key)
        {
            return (T)Convert.ChangeType(System.Configuration.ConfigurationManager.AppSettings[key], typeof(T));
        }

        public static void GetWebConfig()
        {
            ApiUrl = GetAppSetting<string>("ApiUrl");
        }
    }
}