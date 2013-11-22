using System;
using System.Diagnostics;
 
class ReminderOfTheDivisionByFive
{
    static void Main()
    {
        // Task 4 - Write a program that reads two positive integer numbers 
        // and prints how many numbers p exist between them such that the
        // reminder of the division by 5 is 0 (inclusive). Example: p(17,25) = 2.

        UInt32 firstNum = 0, secondNum = 0;
 
        Console.Write("Enter first number: ");
        bool b1 = UInt32.TryParse(Console.ReadLine(), out firstNum);
 
        Console.Write("Enter second number: ");
        bool b2 = UInt32.TryParse(Console.ReadLine(), out secondNum);
 
        if (b1 && b2)
		{
            int resultMax = (int)Math.Max(firstNum, secondNum) / 5;
            int resultMin = (int)(Math.Min(firstNum, secondNum) - 1) / 5;
 
            int result = resultMax - resultMin;

            Console.WriteLine("p({0},{1}) = {2}", firstNum, secondNum, result);
		}
		else
		{
			Console.WriteLine("Not a valid positive integers!");
		}
	}
}
