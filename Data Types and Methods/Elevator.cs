using System;

namespace ProgrammingFundamentals
{
	class Elevator
	{
		static void Main(string[] args)
		{
			var persons = int.Parse(Console.ReadLine());
			var capacity = int.Parse(Console.ReadLine());
			var courses = Math.Ceiling(persons / (double)capacity);

			Console.WriteLine(courses);
		}
	}
}
