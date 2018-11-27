using System;

namespace Impatient
{
    public class Logic
    {

        private readonly DateTime FstTm = Make(Config.FstHr, Config.FstMn);
        private readonly DateTime ScdTm = Make(Config.ScdHr, Config.ScdMn);
        private readonly DateTime TrdTm = Make(Config.TrdHr, Config.TrdMn);

        private static DateTime Now
        {
            get { return DateTime.Now; }
        }

        public static string NowStr
        {
            get { return string.Format("{0:HH:MM:SS}", Now); }
        }

        private static DateTime Make(int hr, int mn)
        {
            DateTime now = Now;
            if (hr <= now.Hour) { now = now.AddDays(1); }
            return new DateTime(now.Year, now.Month, now.Day, hr, mn, 0);
        }

        private int Span(DateTime future)
        {
            DateTime now = Now;
            if (future <= now) { return 0; }
            return (int)(future - now).TotalSeconds;
        }

        public bool HardReset
        {
            get {
                return Now.Hour == 0 && Now.Minute == 0 && Now.Second == 0;
            }
        }

        public bool Divider
        {
            get { return Now.Second == 59; }
        }

        public int Fst
        {
            get { return Span(FstTm); }
        }

        public int Scd
        {
            get { return Span(ScdTm); }
        }

        public int Trd
        {
            get { return Span(TrdTm); }
        }
    }
}
