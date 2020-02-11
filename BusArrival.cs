
namespace Lesson_20200205_bus_arrival
{
     class BusArrival
    {
        public const int maxPassengers = 50;
        private int lineNumber;
        private int passengers;
        private Time timeArrival;

        public BusArrival(Time timeArrival, int lineNumber, int passengers)
        {
            this.lineNumber = 1;
            this.passengers = 0;
            this.timeArrival = null;
            LineNumber = lineNumber;
            TimeArrival = timeArrival;
            Passengers = passengers;
        }

        public BusArrival(int hour, int minute, int second, int lineNumber, int passengers) :
            this(new Time(hour, minute, second),lineNumber, passengers)
        { }

        // copy constructor
        public BusArrival(BusArrival other)
        {
            lineNumber = other.lineNumber;
            passengers = other.passengers;
            timeArrival = new Time(other.timeArrival);
        }

        public int LineNumber
        {
            get
            {
                return lineNumber;
            }
            set
            {
                if (value >= 1 && value <= 99)
                    lineNumber = value;
            }
        }

        public Time TimeArrival
        {
            get
            {
                return new Time(timeArrival);
            }
            set
            {
                timeArrival = new Time(value);
            }
        }

        public int Passengers
        {
            get
            {
                return passengers;
            }
            set
            {
                if (value >= 0 && value <= maxPassengers)
                    passengers = value;
            }
        }
     
        //public int GetTimeSpan()
        //{
        //    return (timeArrival.GetHour() * 60 * 60) + (timeArrival.GetMinute() * 60) + timeArrival.GetSecond();
        //}

        static string AddZero(int num)    //  static function = no using any variables of class
        {
            return (num < 10 ? "0" : "") + num;
        }


        public bool isFuller(BusArrival other)
        {
            if (other == null)
                return true;
            return this.passengers > other.passengers;
        }

        private static int comparePassengers(int passengers, int otherPassengers)
        {
            if (passengers < otherPassengers)
                return otherPassengers - passengers;
            else
                return passengers - otherPassengers;
        }

        public string Fuller(BusArrival other)
        {
            int result = comparePassengers(passengers, other.passengers);

            if (passengers < other.passengers)
                return "  Sender bus is more fuller than This \n " +
                       "\nsender.passengers     : " + other.passengers +
                       "\nthis.passengers       : " + passengers +
                       "\nresult                : " + result;

            else
                return "  This bus is more fuller than Sender \n " +
                       "\nsender.passengersNumber : " + other.passengers +
                       "\nthis.passengersNumber   : " + passengers +
                       "\nresult                  : " + result;
        }

        public bool Equals(BusArrival other)
        {
            if (other == null)
                return false;
            if (this == other)
                return true;
            return lineNumber == other.lineNumber &&
                   passengers == other.passengers &&
                   timeArrival.Equals(other.timeArrival);
        }

        public bool Before(BusArrival other)
        {
            if (other == null)
                throw new Exception("cannot compare to null");
            return TimeArrival.Before(other.timeArrival);
        }

        public bool isFull()
        {
            if (passengers == maxPassengers)
                return true;
            return false;
        }
        public static BusArrival EarliestWithAtLeast10Passengers(BusArrival[] arr)
        {
            if (arr == null)
                throw new Exception("invalid parameter");

            BusArrival result = null;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == null)
                    continue;
                if (arr[i].passengers >= 10)
                {
                    if (result == null)
                        result = arr[i];
                    else if (arr[i].Before(result))
                        result = arr[i];

                }
            }
            return result;
        }

        public string PrintEarliestWithAtLeast10Passengers(BusArrival[] busArr)
        {
            BusArrival bus = EarliestWithAtLeast10Passengers(busArr);

            return "\n time arrival      | " + AddZero(bus.timeArrival.GetHour()) + " : " + AddZero(bus.timeArrival.GetMinute()) + " : " + AddZero(bus.timeArrival.GetSecond()) +
                   "\n line number       | " + bus.LineNumber +
                   "\n passengers number | " + bus.Passengers;
        }

        public string ToString()
        {
            return "passengers: " + passengers + "\n" +
                   "line number: " + lineNumber + "\n" +
                   "time arrival: " + timeArrival.ToString() + "\n";
        }
    }
}
