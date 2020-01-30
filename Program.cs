using System;

namespace Classes_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Time copyTime = new Time(DateTime.Now);
            Console.Write(copyTime.Hour + ":" + copyTime.Minute + ":" + copyTime.Second);

            Console.ReadLine();
        }
    }
}
