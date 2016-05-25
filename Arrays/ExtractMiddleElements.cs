using System;
using System.Linq;

namespace ProgrammingFundamentals
{
	class MiddleElements

	{
		static void Main(string[] args)
		{
			var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
			var n = numbers.Length;

			if (n == 1)
			{
				Console.WriteLine("{ " + numbers[0] + " }");
			}
			else if (n % 2 == 0)
			{
				Console.WriteLine("{ " + numbers[n / 2 - 1] + ", " + numbers[n / 2] + " }");
			}
			else
			{
				Console.WriteLine("{ " + numbers[n / 2 - 1] + ", " + numbers[n / 2] + ", " + numbers[n / 2 + 1] + " }");
			}
		}
	}
}