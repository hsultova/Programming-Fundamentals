using System;
using System.Collections.Generic;
using System.Linq;

namespace ProgrammingFundamentals
{
	class RealNumbersCounter
	{
		static void Main(string[] args)
		{
			var numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
			var sortedNumbers = new SortedDictionary<double, int>();

			foreach (double number in numbers)
			{
				if (!sortedNumbers.ContainsKey(number))
				{
					sortedNumbers.Add(number, 1);
				}
				else
				{
					sortedNumbers[number]++;
				}
			}

			foreach (var item in sortedNumbers)
			{
				Console.WriteLine($"{item.Key} -> {item.Value}");
			}
		}
	}
}