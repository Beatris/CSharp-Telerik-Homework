using System;
using System.Globalization;

class circleArea
{
	static void Main()
	{
		Console.Write("Enter the radius of the circle: ");
		string inputRadius = Console.ReadLine();
		double radius = double.Parse(inputRadius);

		double area = Math.PI * radius * radius;
		double perimeter = 2 * Math.PI * radius;

		Console.WriteLine("The area of the circle is {0} " + 
		                  "and the perimeter is {1}", area, perimeter);
	}
}

