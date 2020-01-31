namespace Lesson29012020_Time
{
    class Time
    {
        private const int tiks = 10000;

        private long millisecond;             //  millisecond = 10,000 tiks
        private int second;                  //  second = 1000 millisecond =  10,000,000 tiks
        private int minute;                 //  minute = 60 second = 60,000 millisecond =  600,000,000 tiks
        private int hour;                  // hour = 60 minute = 3600 second = ‭3,600,000‬ millisecond =  ‭36,000,000,000‬ tiks

        public Time(int hour, int minute, int second, long millisecond)        // own constructor
        {
            this.millisecond = tiks;
            this.second = 0;
            this.minute = 0;
            this.hour = 0;
            SetHour(hour);
            SetMinute(minute);
            SetSecond(second);
            SetMillisecond(millisecond);
        }

        //public Time(Time other) : this(other.hour,other.minute,other.second) { }   // copy constructor

        public Time(Time other)
        {
            hour = other.hour;         // copy constructor (recomendate)
            minute = other.minute;
            second = other.second;
            millisecond = other.millisecond;
        }
        public int GetHour()
        {
            return hour;
        }
        public void SetHour(int hour)
        {
            if (hour < 0 || hour > 23)
                this.hour = 0;
            else
                this.hour = hour;
        }

        public int GetMinute()
        {
            return minute;
        }
        public void SetMinute(int minute)
        {
            if (minute < 0 || minute > 59)
                this.minute = 0;
            else
                this.minute = minute;
        }

        public int GetSecond()
        {
            return second;
        }
        public void SetSecond(int second)
        {
            if (second < 0 || second > 59)
                this.second = 0;
            else
                this.second = second;
        }

        public long GetMillisecond()
        {
            return millisecond;
        }
        private void SetMillisecond(long millisecond)
        {
            if (millisecond < 0)
                this.millisecond = 0;
            else
                this.millisecond = millisecond;
        }

        // 10,000 Ticks is a millisecond  / 10,000,000 ticks per second /  600 000 000 tiks per minute /  36,000,000,000‬ tiks per hour
        public long TiksPerHour()
        {
            return ((((minute * 60) + second) * 60) + millisecond) * 1000;  
        }
       
        static string AddZero(int num)    //  static function = no using any variables of class (hour,minute,second)
        {
            return (num < 10 ? "0" : "") + num;
        }
        static string AddZero(long num)    //  static function = no using any variables of class (hour,minute,second)
        {
            return (num < 10 ? "0" : "") + num;
        }

        public string toString()
        {
            return AddZero(hour) + ":" + AddZero(minute) + ":" + AddZero(second) + ":" + AddZero(millisecond);
        }
        public string toString(long ticks)
        {
            return "ticks per second : " + tiks/millisecond + "\n ticks per minute : " + tiks/second + "\n ticks per hour : " + tiks/minute;
        }
        private int TotalSeconds()
        {
            return ((hour * 60) + minute) * 60 + second;
        }

        public int Difference(Time other)
        {
            return TotalSeconds() - other.TotalSeconds();
        }
        public bool Equals(Time other)
        {
            if (other == null)
                return false;
            if (this == other)
                return true;
            return hour == other.hour && minute == other.minute && second == other.second;
        }
    }
}
