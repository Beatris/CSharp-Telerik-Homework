using System;

class SumOf3Integers
{
	static void Main()
	{
		// Task 1 - Read three integers from
		// the console and print their sum.

		Console.Write("Enter the first integer: ");
		string inputFirstInt = Console.ReadLine();
		int firstInt = int.Parse(inputFirstInt);

		Console.Write("Enter the second integer: ");
		string inputSecondInt = Console.ReadLine();
		int secondInt = int.Parse(inputSecondInt);

		Console.Write("Enter the third integer: ");
		string inputThirdInt = Console.ReadLine();
		int thirdInt = int.Parse(inputThirdInt);

		Console.WriteLine("The sum of the integers is: {0}", 
		                  firstInt + secondInt + thirdInt);
		
	}
}
