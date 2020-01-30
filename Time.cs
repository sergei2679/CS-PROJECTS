namespace Classes_3
{
    class Time
    {
        public int Hour { get; private set; }
        public int Minute { get; private set; }
        public int Second { get; private set; }

        public Time(int hour, int minute, int second)
        {
            if (hour < 0 || hour > 23)
                Hour = 0;
            else
                Hour = hour;

            if (minute < 0 || minute > 59)
                Minute = 0;
            else
                Minute = minute;

            if (second < 0 || second > 59)
                Second = 0;
            else
                Second = second;
        }

        public Time(System.DateTime existingTimeObject)    // copy constructor
        {
            Hour = existingTimeObject.Hour;
            Minute = existingTimeObject.Minute;
            Second = existingTimeObject.Second;
        }

        public int GetHour()
        {
            return Hour;
        }
        public void SetHour(int hour)
        {
            Hour = hour;
        }

        public int GetMinute()
        {
            return Minute;
        }
        public void SetMinute(int minute)
        {
            Minute = minute;
        }

        public int GetSecond()
        {
            return Hour;
        }
        public void SetSecond(int second)
        {
            Second = second;
        }

        public string toString(int hour, int minute, int second)
        {
            return "Current Time : " +
                    hour + ":" + minute + ":" + second;

        }
    }

}
