using System;

namespace L_home_20200119_inheritance_abstract
{
    class Program
    {
        static void Main(string[] args)
        {
			int a = 20, b = 10;
			MyCalculation demo = new MyCalculation();
			demo.addition(a, b);
			demo.subtraction(a, b);
			demo.multiplication(a, b);


			Console.ReadLine();
		}

		class Calculation
		{
			private int X;
			private int Y;
			protected int Z;
			public Calculation()
			{
				X = 0;
				Y = 0;
				Z = 0;

			}
			int z;
			public void addition(int x, int y)
			{
				z = x + y;
				Console.Out.WriteLine("The sum is: " + z);
			}

			public void subtraction(int x, int y)
			{
				z = x - y;
				Console.Out.WriteLine("The diff is: " + z);
			}
		}

		class MyCalculation : Calculation
		{
			private int z;
			//public MyCalculation(int z) : base(z) { this.z = z; }
			public MyCalculation()
			{ }

			public void multiplication(int x, int y)
			{
				z = x * y;
				Console.Out.WriteLine("The product is: " + z);

			}
		}
	}
}
