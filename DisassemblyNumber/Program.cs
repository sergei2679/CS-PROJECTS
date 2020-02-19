using System;

namespace DisassemblyNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = 290;
            int number2 = 1012;

            Statistics num1 = new Statistics(number1);
            Statistics num2 = new Statistics(number2);
            Statistics num3 = new Statistics(number2);
            Statistics num4 = num3;

            //int distance = num1.GetNumber() - num2.GetNumber();  
            int distance = num1.Distance(number1, number2);
           
            Console.WriteLine("\n =====  Disassembly Number  ================== \n\n" + num1.toString() + "\n " + num2.toString());

            Console.WriteLine($"\n  Distance/Range " + number1 + " - " + number2 + "  =  " + distance);

            Console.WriteLine($"\n  Instance Counter  =  " + num3.InstCounter);
            Console.WriteLine($"\n  Copy Counter  =  " + num1.CopyCounter);


            Console.ReadLine();
        }
    }
}