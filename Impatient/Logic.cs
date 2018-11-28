using System;

namespace Impatient
{
    public class Logic
    {

        private readonly DateTime StartTime = Make(
            Config.StartHour, Config.StartMinute
        );
        private readonly DateTime FirstTime = Make(
            Config.FirstHour, Config.FirstMinute
        );
        private readonly DateTime SecondTime = Make(
            Config.SecondHour, Config.SecondMinute
        );
        private readonly DateTime ThirdTime = Make(
            Config.ThirdHour, Config.ThirdMinute
        );
        private readonly DateTime FourthTime = Make(
            Config.FourthHour, Config.FourthMinute
        );

        public static DateTime Now
        {
            get { return DateTime.Now; }
        }

        private static DateTime Make(int hr, int mn)
        {
            DateTime now = Now;
            return new DateTime(now.Year, now.Month, now.Day, hr, mn, 0);
        }

        private int SpanMax(DateTime some)
        {
            if (some <= StartTime) { return 0; }
            return (int)(some - StartTime).TotalSeconds;
        }

        private int SpanNum(DateTime some)
        {
            DateTime now = Now;
            if (Now <= StartTime) { return 0; }
            if (Now >= some) { return 0; }
            return (int)(some - now).TotalSeconds;
        }

        public int FirstMax
        {
            get { return SpanMax(FirstTime); }
        }
        public int FirstNum
        {
            get { return SpanNum(FirstTime); }
        }

        public int SecondMax
        {
            get { return SpanMax(SecondTime); }
        }
        public int SecondNum
        {
            get { return SpanNum(SecondTime); }
        }

        public int ThirdMax
        {
            get { return SpanMax(ThirdTime); }
        }
        public int ThirdNum
        {
            get { return SpanNum(ThirdTime); }
        }

        public int FourthMax
        {
            get { return SpanMax(FourthTime); }
        }
        public int FourthNum
        {
            get { return SpanNum(FourthTime); }
        }
    }
}
