using System;
using System.Globalization;

class GreaterNum
{
	static void Main()
	{
	    // Get two numbers from the console and
	    // print the greater of them.

		double num1 = 0;
		double num2 = 0;

		System.Threading.Thread.CurrentThread.CurrentUICulture = 
			System.Globalization.CultureInfo.InvariantCulture;

        Console.Write("Enter first number: ");
        bool isDouble1 = Double.TryParse(Console.ReadLine(), out num1);
 
        Console.Write("Enter second number: ");
        bool isDouble2 = Double.TryParse(Console.ReadLine(), out num2);

		if (isDouble1 && isDouble2)
		{
			Console.WriteLine("The greater number is: " + Math.Max(num1, num2));
		}
		else
		{
			Console.WriteLine("Not a valid numbers!");
		}
	}
}
