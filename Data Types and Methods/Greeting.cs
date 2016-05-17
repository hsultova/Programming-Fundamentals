using System;

namespace ProgrammingFundamentals
{
	class Greeting
	{
		static void Main(string[] args)
		{
			var firstName = Console.ReadLine();
			var lastName = Console.ReadLine();
			var years = int.Parse(Console.ReadLine());

			Console.WriteLine("Hello, {0} {1}. You are {2} years old.", firstName, lastName, years);
		}
	}
}
