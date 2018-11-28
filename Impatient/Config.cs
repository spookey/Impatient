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
            return (T)conv.ConvertFromInvariantString(Get(key));
        }

        public static int StartHour
        {
            get { return Get("StartHour", 0); }
        }
        public static int StartMinute
        {
            get { return Get("StartMinute", 0); }
        }

        public static int FirstHour
        {
            get { return Get("FirstHour", 0); }
        }
        public static int FirstMinute
        {
            get { return Get("FirstMinute", 0); }
        }

        public static int SecondHour
        {
            get { return Get("SecondHour", 0); }
        }
        public static int SecondMinute
        {
            get { return Get("SecondMinute", 0); }
        }

        public static int ThirdHour
        {
            get { return Get("ThirdHour", 0); }
        }
        public static int ThirdMinute
        {
            get { return Get("ThirdMinute", 0); }
        }

        public static int FourthHour
        {
            get { return Get("FourthHour", 0); }
        }
        public static int FourthMinute
        {
            get { return Get("FourthMinute", 0); }
        }

    }
}
