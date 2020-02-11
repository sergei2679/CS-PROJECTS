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
            
            

// ---------------------- BUS STOP -------------------------------------------------------------------
            
            BusArrival busArrival1 = new BusArrival(14, 35, 27, 90, 25);
            BusArrival busArrival2 = new BusArrival(18, 30, 20, 74, 20);
            BusArrival busArrival3 = new BusArrival(19, 10, 7, 74, 15);

            BusStop busStop1 = new BusStop();
            BusStop busStop2 = new BusStop();   //  86400 seconds = 1 day   // 52527 = 14:35:27
            BusStop busStop3 = new BusStop();

            busStop1.Add(busArrival1);
            busStop2.Add(busArrival2);
            busStop3.Add(busArrival3);

            Console.WriteLine(busStop1.ToString());
            Console.WriteLine(busStop2.ToString());
            Console.WriteLine(busStop3.ToString());

            
            
            Console.ReadLine();

        }
    }
}
