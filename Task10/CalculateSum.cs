using System;
 
class CalculateSum
{
    static void Main()
    {
		// Task 10 - Write a program to calculate the sum 
		// (with accuracy of 0.001): 1 + 1/2 - 1/3 + 1/4 - 1/5 + ...

        decimal sum = 1;
        for (decimal i = 2; i <= 1000; i++)
        {
            sum = (i % 2 == 0) ? sum + (1 / i) : sum - (1 / i);
        }
        Console.WriteLine(sum);
    }
}
