
namespace Lesson_20200205_bus_arrival
{
    class BusArrival
    {
        private const byte maxPassengersNumber = 50;
        private byte lineNumber, passengersNumber;
        private Time time;

        public BusArrival(int hour, int minute, int second, byte lineNumber, byte passengersNumber)
        {
            this.lineNumber = 0;
            this.passengersNumber = 0;
            time = new Time(hour, minute, second);
            SetLineNumber(lineNumber);
            SetPassengersNumber(passengersNumber);
        }

        // copy constructor
        // public BusArrival(BusArrival copy) : this(copy.hour, copy.minute, copy.second, copy.lineNumber, copy.passengersNumber) { } 


        public BusArrival(BusArrival other)       // copy constructor
        {          
            lineNumber = other.lineNumber;
            passengersNumber = other.passengersNumber;
            time = new Time(other.time);
        }

        public byte GetLineNumber()
        {
            return lineNumber;
        }

        public void SetLineNumber(byte lineNumber)
        {
            this.lineNumber = lineNumber;
        }

        public byte GetPassengersNumber()
        {
            return passengersNumber;
        }

        public void SetPassengersNumber(byte passengersNumber)
        {
            this.passengersNumber = passengersNumber;
        }

        static string AddZero(int num)    //  static function = no using any variables of class (hour,minute,second)
        {
            return (num < 10 ? "0" : "") + num;
        }

        private static int comparePassengers(byte passengersNumber,byte otherPassengersNumber)
        {
            if (passengersNumber < otherPassengersNumber)
                return otherPassengersNumber - passengersNumber;
            else
                return passengersNumber - otherPassengersNumber;
        }

        public string Fuller(BusArrival other)
        {
            int result = comparePassengers(passengersNumber, other.passengersNumber);

            if (passengersNumber < other.passengersNumber)
                return "  Sender bus is more fuller than This \n " +
                       "\nsender.passengersNumber : " + other.passengersNumber +
                       "\nthis.passengersNumber   : " + passengersNumber +
                       "\nresult                  : " + result;

            else
                return "  This bus is more fuller than Sender \n " +
                       "\nsender.passengersNumber : " + other.passengersNumber +
                       "\nthis.passengersNumber   : " + passengersNumber +
                       "\nresult                  : " + result;
        }

        public bool Equals(BusArrival other)
        {
            if (other == null)
                return false;
            if (this == other)
                return true;
            return time.GetHour() == other.time.GetHour()
                && time.GetMinute() == other.time.GetMinute()
                && time.GetSecond() == other.time.GetSecond();
        }

        public bool Before(BusArrival other)
        {
            if (time.GetHour() < other.time.GetHour())
                return true;
            else if (time.GetMinute() < other.time.GetMinute())
                return true;
            else if (time.GetSecond() < other.time.GetSecond())
                return true;
            else
                return false;

            //return time.GetHour() == other.time.GetHour() && time.GetMinute() == other.time.GetMinute() && time.GetSecond() == other.time.GetSecond();
        }

        public bool isFull(BusArrival busArr)
        {
            if (busArr.GetPassengersNumber() == maxPassengersNumber)
                return true;
            return false;
        }
        private static BusArrival GetBusWith10Passengers(BusArrival[] busArr)
        {
            int minIndex = 0;

            for (int i = 0; i < busArr.Length; i++)
            {
                if (busArr[i].passengersNumber >= 10 && busArr[i].Before(busArr[minIndex]))
                {
                    minIndex = i;
                }
            }
            return busArr[minIndex];
        }

        public string printBusWith10Passengers(BusArrival[] busArr)
        {
            BusArrival bus = GetBusWith10Passengers(busArr);

            return "\n time arrival      | " + AddZero(bus.time.GetHour()) + " : " + AddZero(bus.time.GetMinute()) + " : " + AddZero(bus.time.GetSecond()) +
                   "\n line number       | " + bus.GetLineNumber() +
                   "\n passengers number | " + bus.GetPassengersNumber();
        }

        public string toString()
        {
            return
                    "\n Hour             : " + AddZero(time.GetHour()) +
                    "\n Minute           : " + AddZero(time.GetMinute()) +
                    "\n Second           : " + AddZero(time.GetSecond()) +
                    "\n Line Number      : " + lineNumber +
                    "\n passengersNumber : " + passengersNumber;
        }
    }
}




// -------------------------------------  bus_arrival with property  ------------- not ended ------------
// -------------------------------------------------------------------------------------------------------------------

namespace Lesson_20200205_bus_arrival_property
{
    class BusArrival
    {
        private byte lineNumber, passengersNumber;
        private Time time;

        public BusArrival(int hour, int minute, int second, byte lineNumber, byte passengersNumber)
        {
            LineNumber = lineNumber;
            PassengersNumber = passengersNumber;
            time = new Time(hour, minute, second);
        }

        // copy constructor
        // public BusArrival(BusArrival copy) : this(copy.hour, copy.minute, copy.second, copy.lineNumber, copy.passengersNumber) { } 

        public BusArrival(BusArrival copy)       // copy constructor
        {
            lineNumber = copy.lineNumber;
            passengersNumber = copy.passengersNumber;
            time = new Time(copy.time);
        }

        public byte LineNumber
        {
            get
            {
                return lineNumber;
            }
            set
            {
                if (value >= 0)
                    lineNumber = value;
            }
        }

        public byte PassengersNumber
        {
            get
            {
                return passengersNumber;
            }
            set
            {
                if (value >= 0)
                    passengersNumber = value;
            }
        }

        static string AddZero(int num)    //  static function = no using any variables of class (hour,minute,second)
        {
            return (num < 10 ? "0" : "") + num;
        }

        public bool Equals(BusArrival other)
        {
            if (other == null)
                return false;
            if (this == other)
                return true;
            return time.GetHour() == other.time.GetHour()
                && time.GetMinute() == other.time.GetMinute()
                && time.GetSecond() == other.time.GetSecond();
        }

        //public bool Before(BusArrival busArrival)
        //{
        //    return hour == busArrival.hour && minute == busArrival.minute && second == busArrival.second;
        //}

        public string toString()
        {
            return
                    "\n Hour             : " + AddZero(time.GetHour()) +
                    "\n Minute           : " + AddZero(time.GetMinute()) +
                    "\n Second           : " + AddZero(time.GetSecond()) +
                    "\n Line Number      : " + lineNumber +
                    "\n passengersNumber : " + passengersNumber;
        }
    }
}