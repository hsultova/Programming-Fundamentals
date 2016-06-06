using System;
using System.Linq;

namespace ProgrammingFundamentals
{
	class Receipt
	{
		static void Main(string[] args)
		{
			var numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
			double sum = 0;

			for (int i = 0; i < numbers.Length; i++)
			{
				sum += numbers[i];
			}

			Console.WriteLine("/{0}\\", new string('-', 22));
			for (int i = 0; i < numbers.Length; i++)
			{
				Console.WriteLine("| {0,20:f2} |", numbers[i]);
			}
			Console.WriteLine("|{0}|", new string('-', 22));
			Console.WriteLine("| Total: {0,13:f2} |", sum);
			Console.WriteLine("\\{0}/", new string('-', 22));
		}
	}
}