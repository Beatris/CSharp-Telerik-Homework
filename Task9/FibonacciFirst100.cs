using System;
using System.Numerics;

class CalculatingTheSumOfNNumbers
{
    static void Main()
    {
        // Task 9 - Write a program that prints the first
		// 100 members of the sequence of Fibonacci.
		

		BigInteger firstMember = 0;
        BigInteger secondMember = 1;
        BigInteger nthMember;
        Console.WriteLine(firstMember);
        Console.WriteLine(secondMember);
        for (int i = 1; i <= 100; i++)
        {
            nthMember = firstMember + secondMember;
            firstMember = secondMember;
            secondMember = nthMember;
            Console.WriteLine(nthMember);
		}
	}
}
