namespace DisassemblyNumber
{
    class Statistics
    {
        private int number;
        private int otherNumber;
        private int copyNumber;
        private int digitCounter;
        private int digitSum;
        private int maxDigit;
        private int minDigit;
        private int reversedNumber;

        public Statistics(int number = 0)
        {
            this.number = number;
            otherNumber = 0;
            copyNumber = 0;
            digitCounter = 0;
            digitSum = 0;
            maxDigit = 0;
            minDigit = 0;
            reversedNumber = 0;
            SetNumber(number);
            SetDigitCounter(number);
            SetDigitSum(number);
            SetMaxDigit(number);
            SetMinDigit(number);
            SetReversed(number);

        }
        public Statistics(Statistics copyNumber)    // copy constructor (recomendate)
        {
            this.copyNumber = copyNumber.number;
        }

        // ------------------------------ ORIGIN -----------
        public int GetNumber()
        {
            return number;
        }
        public void SetNumber(int number)
        {
            this.number = number;
        }


        public void SetOtherNumber(int otherNumber)
        {
            this.otherNumber = otherNumber;
        }

        public int GetOtherNumber()
        {
            return otherNumber;
        }

        public int ValueDifference(int value1, int value2)
        {
            if (value1 >= value2)
                return value1 - value2;
            else
                return value2 - value1;
        }
        // ------------------------------  COUNT DIGITS  --------------
        public int GetDigitCounter()
        {
            return digitCounter;
        }

        private void SetDigitCounter(int number)
        {
            while (number > 0)
            {
                digitCounter += 1;
                number /= 10;
            }
        }
        // ------------------------------  SUM DIGITS  --------------
        static int DigitSum(int number)
        {
            int sum = 0;
            while (number > 0)
            {
                sum += number % 10;
                number /= 10;
            }
            return sum;
        }

        private void SetDigitSum(int number)
        {
            digitSum = DigitSum(number);
        }

        public int GetDigitSum()
        {
            return digitSum;
        }

        // ------------------------------  MAX DIGIT  --------------
      
        static int MaxDigit(int num)    //  num = 812
        {
            int max = 0;
            while (num > 0)
            {
                if (max < num % 10)
                    max = num % 10;     // max = 2                                  
                num /= 10;              // num = 81 // num = 8
            }
            return max;
        }
        public void SetMaxDigit(int number)    //  num = 812
        {
            maxDigit = MaxDigit(number);
        }

        public int GetMaxDigit()    //  num = 812
        {
            return maxDigit;
        }

        // ------------------------------  MIN DIGIT  --------------
        static int MinDigit(int num)    //  num = 812
        {
            int min = num % 10;
            while (num > 0)
            {
                if (min > num % 10)
                    min = num % 10;                                      
                num /= 10;        
            }
            return min;
        }

        public void SetMinDigit(int num)   
        {
            minDigit = MinDigit(num);
        }

        public int GetMinDigit()    //  num = 812
        {
            return minDigit;
        }


        // ------------------------------  REVERSE DIGITS  --------------
        public int GetReversed()    //  num = 290 
        {
            return reversedNumber;
        }

        private void SetReversed(int number)    //  num = 290 
        {
            int remainder;
            while (number != 0)
            {
                remainder = number % 10;
                reversedNumber = reversedNumber * 10 + remainder;
                number /= 10;
            }
        }

        // ------------------------------  INFO  --------------

        public string toString()
        {
            return
                    "\n    Metod/Value   |     Value" +
                    "\n ---------------- | -----------------" +
                    "\n   Origin Number  | " + number +
                    "\n   Other Number   | " + otherNumber + "\n" +
                    "\n   Reversed       | " + reversedNumber +
                    "\n   Max Digit      | " + maxDigit +
                    "\n   Min Digit      | " + minDigit +
                    "\n   Sum Digits     | " + digitSum +
                    "\n   Count Digits   | " + digitCounter + 
                    "\n ---------------- | -----------------";

        }
    }
}