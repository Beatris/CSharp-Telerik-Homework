using System;

class QuadraticEquation
{
	static void Main()
	{
		// Get the coefficients a, b and c of
		// a quadratic equation and solve it.

		Double a = 0, b = 0, c = 0, x1 = 0, x2 = 0;

		Console.Write("Enter coefficient a: ");
		bool isDoubleA = Double.TryParse(Console.ReadLine(), out a);

		Console.Write("Enter coefficient b: ");
		bool isDoubleB = Double.TryParse(Console.ReadLine(), out b);

		Console.Write("Enter coefficient c: ");
		bool isDoubleC = Double.TryParse(Console.ReadLine(), out c);

		if (isDoubleA && isDoubleB && isDoubleC && a != 0)
		{
			double discriminant = b * b - (4 * a * c);
			if (discriminant >= 0)
			{
				x1 = (-b - Math.Sqrt(discriminant)) / (2 * a);
				x2 = (-b + Math.Sqrt(discriminant)) / (2 * a);
				Console.WriteLine(discriminant == 0 ? "The quadratic equation " +
									   "has one real solution: x1 = x2 = " + x1 : 
									   "The quadratic equation has two real solutions:" + 
				                  	   " x1 = {0} and x2 = {1}", x1, x2);
			}
			else
			{
				Console.WriteLine("The quadratic equation has no real solutions.");
			}
		}
		else
		{
			Console.WriteLine("Invalid numbers!");
		}
	}
}
