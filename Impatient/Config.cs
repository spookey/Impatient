using System.ComponentModel;
using System.Configuration;

namespace Impatient
{
    public static class Config
    {
        private static string Get(string key)
        {
            return ConfigurationManager.AppSettings.Get(key);
        }

        private static bool Has(string key)
        {
            return !string.IsNullOrWhiteSpace(Get(key));
        }

        private static T Get<T>(string key, T fallback)
        {
            if (!Has(key)) { return fallback; }
            TypeConverter conv = TypeDescriptor.GetConverter(typeof(T));
            return (T)(conv.ConvertFromInvariantString(Get(key)));
        }

        public static int FstHr
        {
            get { return Get("FstHr", 0); }
        }
        public static int FstMn
        {
            get { return Get("FstMn", 0); }
        }

        public static int ScdHr
        {
            get { return Get("ScdHr", 0); }
        }
        public static int ScdMn
        {
            get { return Get("ScdMn", 0); }
        }

        public static int TrdHr
        {
            get { return Get("TrdHr", 0); }
        }
        public static int TrdMn
        {
            get { return Get("TrdMn", 0); }
        }

    }
}
