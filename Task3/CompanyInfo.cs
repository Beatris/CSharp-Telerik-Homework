using System;

class CompanyInfo
{
	static void Main()
	{
		// Task 3 - read the information about a company
		// and its manager and prints them on the console.

		Console.WriteLine("Please enter info about a company " +
		                  "and its manager below.");

		Console.Write("Enter a company's name: ");
		string companyName = Console.ReadLine();

		Console.Write("Enter a company's address: ");
		string companyAdress = Console.ReadLine();

		Console.Write("Enter a company's phone: ");
		string companyPhone = Console.ReadLine();

		Console.Write("Enter a company's fax number: ");
		string companyFaxNumber = Console.ReadLine();

		Console.Write("Enter a company's website: ");
		string companyWebsite = Console.ReadLine();

		Console.Write("Enter a manager's first name: ");
		string managerFirstName = Console.ReadLine();

		Console.Write("Enter a manager's last name: ");
		string managerLastName = Console.ReadLine();

		Console.Write("Enter a manager's age: ");
		byte managerAge = byte.Parse(Console.ReadLine());

		Console.Write("Enter a manager's phone number: ");
		string managerPhone = Console.ReadLine();

		Console.WriteLine("");
		Console.WriteLine("The company's name is: " + companyName);
		Console.WriteLine("The company's adress is: " + companyAdress);
		Console.WriteLine("The company's phone is: " + companyPhone);
		Console.WriteLine("The company's fax number is: " + companyFaxNumber);
		Console.WriteLine("The company's website is: " + companyWebsite);
		Console.WriteLine("The manager's first name is: " + managerFirstName);
		Console.WriteLine("The manager's last name is: " + managerLastName);
		Console.WriteLine("The manager's age is: " + managerAge);
		Console.WriteLine("The manager's phone number is: " + managerPhone);
	}
}
