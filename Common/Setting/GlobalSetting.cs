using System.Configuration;

namespace Common.Setting
{
    public static class GlobalSetting
    {
        public static string ConnectionStringName { get; set; } = "Entities";

        public static string ConnectionString
        {
            get { return ConfigurationManager.ConnectionStrings[ConnectionStringName].ConnectionString; }
        }
    }
}
