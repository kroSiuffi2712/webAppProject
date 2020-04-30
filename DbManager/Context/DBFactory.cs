using Common.Setting;

namespace DbManager.Context
{
    public static class DBFactory
    {
        public static Entities Context
        {
            get
            {
                var ctx = new Entities(GlobalSetting.ConnectionString);
                return ctx;
            }

        }
    }
}
