using System;
using System.Linq;

namespace ProgrammingFundamentals
{
	class LargestThreeNumbers
	{
		static void Main(string[] args)
		{
			var numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
			Console.WriteLine(string.Join(" ",numbers.OrderByDescending(x => x).Take(3)));
		}
	}
}