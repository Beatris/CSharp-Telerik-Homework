using System;
 
class CalculatingTheSumOfNNumbers
{
    static void Main()
    {
        // Task 7 - Write a program that gets a number n 
		// and after that gets more n numbers and calculates 
		// and prints their sum.

        Console.Write("Enter n: ");
        double n = double.Parse(Console.ReadLine());
        double sum = 0;
        for (uint i = 1; i <= n; i++)
        {
            Console.Write("Enter number {0}: ", i);
            double number = double.Parse(Console.ReadLine());
            sum += number;
        }
        Console.WriteLine("The sum of all the numbers you entered is: {0}.", sum);
    }
}
