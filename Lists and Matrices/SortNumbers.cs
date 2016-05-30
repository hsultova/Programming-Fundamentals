using System;
using System.Linq;

namespace ProgrammingFundamentals
{
	class NumberSorting
	{
		static void Main(string[] args)
		{
			var numbers = Console.ReadLine().Split(' ').Select(decimal.Parse).ToList();
			numbers.Sort();
			Console.WriteLine(string.Join(" <= ", numbers));
		}
	}
}