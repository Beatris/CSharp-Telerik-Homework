using System;
 
class CalculatingTheSumOfNNumbers
{
    static void Main()
    {
        // Task 8 - Write a program that gets an integer n 
		// and after that prints the numbers from 1 to n.

        Console.Write("Enter n: ");
        int n = int.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine(i);
        }
	}
}
