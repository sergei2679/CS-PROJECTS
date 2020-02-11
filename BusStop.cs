using System;

namespace Lesson_20200209_bus_stop
{
    class BusStop //: BusArrival  
    {
        private BusArrival[] busArrivals;
        private int countSequentially;
        private int busStopHour;
        private int busStopMinute;
        private int busStopSecond;
        private int timeSpan;
        private const int maxArrival = 86400;    // one day in seconds
                                                 // private int size = maxArrival - (12 * 60 * 60);   //  43200 = 12:00:00

        public BusStop()
        {
            busArrivals = new BusArrival[maxArrival];
            timeSpan = 0;
           // countSequentially = 0;
        }

        public BusStop(int timeSpan) : this()
        {
            this.timeSpan = timeSpan;
            busArrivals = new BusArrival[timeSpan];     // ( 86400 - 43200 ) = 43200 = 12 :00 :00
            SetTimeSpan(timeSpan);
            SetBusStopHour(busStopHour);
            SetBusStopMinute(busStopMinute);
            SetBusStopSecond(busStopSecond);

            //countSequentially = maxArrival - timeSpan;               // range sequentialy
        }

        public int CountSequentially
        {
            get
            {
                return countSequentially;
            }
            set
            {
                if (value > 0 && value <= maxArrival)
                    countSequentially = value;
            }
        }

        public int GetTimeSpan()
        {
            return timeSpan;     // (hour * 3600) +(minute * 60) + second
        }

        public void SetTimeSpan(int timeSpan)
        {
            this.timeSpan = timeSpan;
        }

        public void Add(BusArrival busArrival)
        {
            //timeSpan = (busStopHour * 60 * 60) + (busStopMinute * 60) + busStopSecond;
            timeSpan = (busArrival.TimeArrival.GetHour() * 60 * 60) + (busArrival.TimeArrival.GetMinute() * 60) + busArrival.TimeArrival.GetSecond();
            busArrivals[timeSpan] = busArrival;
        }

        public int GetBusStopHour()
        {
            return busArrivals[timeSpan].TimeArrival.GetHour();
        }

        public int GetBusStopMinute()
        {
            return busArrivals[timeSpan].TimeArrival.GetMinute();
        }

        public int GetBusStopSecond()
        {
            return busArrivals[timeSpan].TimeArrival.GetSecond();
        }

        public void SetBusStopHour(int busStopHour)
        {
            this.busStopHour = busStopHour;
        }

        public void SetBusStopMinute(int busStopMinute)
        {
            this.busStopMinute = busStopMinute;
        }

        public void SetBusStopSecond(int busStopSecond)
        {
            this.busStopSecond = busStopSecond;
        }

    
        #region PROPERTY


        //public int BusStopHour
        //{
        //    get
        //    {
        //        return busStopHour;
        //    }
        //    set
        //    {
        //        if (value >= 0 && value < 24)
        //            busStopHour = value;
        //    }
        //}
        //public int BusStopMinute
        //{
        //    get
        //    {
        //        return busStopMinute;
        //    }
        //    set
        //    {
        //        if (value >= 0 && value < 60)
        //            busStopMinute = value;
        //    }
        //}
        //public int BusStopSecond
        //{
        //    get
        //    {
        //        return busStopSecond;
        //    }
        //    set
        //    {
        //        if (value > 0 && value < 60)
        //            busStopSecond = value;
        //    }
        //}
        #endregion

        // -------------------------------------------------------------------

        public string ToString()
        {
            return
                    "\n Time Arrival     : " + busArrivals[timeSpan].TimeArrival.ToString() +
                    "\n Time span        : " + timeSpan +
                    "\n Line Number      : " + busArrivals[timeSpan].LineNumber +
                    "\n Passengers       : " + busArrivals[timeSpan].Passengers;
        }


        //public string toStringArrayObject()
        //{
        //    string strObj = "";

        //    for (int i = 0; i < busArrivals.Length; i++)
        //    {
        //        strObj += "ROW " + i + " ------------------------------------\n" + busArrivals[i].toString();
                                         
        //    }

        //    return strObj;
        //}

     
    }
}
