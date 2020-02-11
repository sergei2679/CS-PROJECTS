
namespace Lesson_20200205_bus_arrival
{
    class Time
    {
        private int hour, minute, second;

        public Time(int hour, int minute, int second)
        {
            this.hour = 0;
            this.minute = 0;
            this.second = 0;
            SetHour(hour);
            SetMinute(minute);
            SetSecond(second);
        }

        //public Time(Time other):this(other.hour, other.minute, other.second) { }

        public Time(Time other)         // copy constructor
        {
            hour = other.hour;
            minute = other.minute;
            second = other.second;
        }

        public int GetHour()
        {
            return hour;
        }
        public void SetHour(int hour)
        {
            if (hour >= 0 && hour <= 23)
                this.hour = hour;
        }

        public int GetMinute()
        {
            return minute;
        }

        public void SetMinute(int minute)
        {
            if (minute >= 0 && minute <= 59)
                this.minute = minute;
        }

        public int GetSecond()
        {
            return second;
        }

        public void SetSecond(int second)
        {
            if (second >= 0 && second <= 59)
                this.second = second;
        }

        private static string AddZero(int num)
        {
            return (num < 10 ? "0" : "") + num;
        }

        public string ToString()
        {
            return AddZero(GetHour()) + ":" + AddZero(GetMinute()) + ":" + AddZero(GetSecond());
        }

        public int TotalSeconds()
        {
            return ((hour * 60) + minute) * 60 + second;
        }

        public int Difference(Time other)
        {
            if (this == other)
                return 0;
            return TotalSeconds() - other.TotalSeconds();
        }


        public bool Equals(Time other)
        {
            if (other == null)
                return false;
            if (this == other)
                return true;
            return hour == other.hour && minute == other.minute
                && second == other.second;
        }

        public bool Before(Time other)
        {
            return Difference(other) < 0;
        }

        public bool After(Time other)
        {
            return other.Before(this);
        }
    }
}
