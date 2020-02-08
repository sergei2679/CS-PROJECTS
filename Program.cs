using System;

namespace Lesson_20200205_bus_arrival
{
    class Program
    {
        static void Main()
        {
            Time time = new Time(10, 30, 0);
            Time otherTime = new Time(10, 30, 40);

            // this
            Console.WriteLine("---- THIS BUS ARRIVAL");
            BusArrival bus = new BusArrival(time.GetHour(), time.GetMinute(), time.GetSecond(), 90, 15);
            Console.WriteLine(bus.toString());


            // other
            Console.WriteLine("\n ---- OTHER BUS ARRIVAL");
            BusArrival otherBusArrival = new BusArrival(otherTime.GetHour(), otherTime.GetMinute(), otherTime.GetSecond(), 95, 5);
            Console.WriteLine(otherBusArrival.toString());


            // check passengers
            Console.WriteLine(" \n\n ------------ CHECK IF BUS SENDER AS PARAMETER IS MORE FULLER -------------------");
            Console.WriteLine(bus.Fuller(otherBusArrival));


            // check time arrival
            Console.WriteLine(" \n\n ------------ CHECK IF THIS BUS ARRIVAL TIME BEFORE THAN OTHER -------------------");

            if (bus.Before(otherBusArrival) == true)
                Console.WriteLine("this bus arrival time before than other");
            else
                Console.WriteLine("this bus arrival time not before than other");


            // check earliest arrival time
            Console.WriteLine(" \n\n ------------ CHECK EARLIEST ARRIVAL TIME WITH AT LEAST 10 PASSENGERS -------------------");

            var busArr = new BusArrival[]
            {
                new BusArrival(10, 23, 20, 90, 30),
                new BusArrival(10, 20, 20, 90, 20),
                new BusArrival(08, 23, 20, 90, 15),
                new BusArrival(09, 23, 20, 90, 30)
            };

            Console.WriteLine(bus.printBusWith10Passengers(busArr));



            Console.ReadLine();

        }
    }
}
