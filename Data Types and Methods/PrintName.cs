using System;

namespace ProgrammingFundamentals
{
	class Name
	{
		static void Main(string[] args)
		{
			var name = Console.ReadLine();

			PrintName(name);
		}

		static void PrintName(string name)
		{
			Console.WriteLine("Hello, {0}!", name);
		}
	}
}