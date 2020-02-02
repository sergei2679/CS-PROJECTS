using System;

namespace DisassemblyNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 812;
            int otherNumber = 1012;

            Statistics num = new Statistics(number);
            Statistics copy = num;

            copy.SetOtherNumber(otherNumber);

            int difference = num.GetNumber() - copy.GetOtherNumber();
            Console.WriteLine("\n =====  Disassembly Number  ================== \n\n" + num.toString());

            Console.WriteLine("\n  Difference (Number1 , Number2)  =  " + number + "-" + otherNumber + " | " + difference);


            //string numberStr = string.Format(number.ToString());

            //int maxDigit = num.GetMaxDigit();
            //int countDigits = num.GetDigitCounter(); 
            //int sumDigits = num.GetDigitSum();          
            //int reversedDigits = num.GetReversed();

            //Console.WriteLine("======== Disassembly Number ===================== \n" );
            //Console.WriteLine("  Origin Number   :   " + numberStr);
            //Console.WriteLine("  Digit Counter   :   " + countDigits);
            //Console.WriteLine("  Max Digit       :   " + maxDigit);
            //Console.WriteLine("  Sum Digit       :   " + sumDigits);
            //Console.WriteLine("  Reversed Digits :   " + reversedDigits);


            Console.ReadLine();
        }
    }
}