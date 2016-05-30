using System;
using System.Collections.Generic;
using System.Linq;

namespace ProgrammingFundamentals
{
	class NumbersCounter
	{
		static void Main(string[] args)
		{
			var numbers = Console.ReadLine().Split(' ').Select(decimal.Parse).ToList();
			numbers.Sort();
			var occurrences = new List<int>();
			int count = 0;
			for (int i = 0; i < numbers.Count - 1; i++)
			{
				if (numbers[i] == numbers[i + 1])
				{
					count++;
				}
				else
				{
					occurrences.Add(count + 1);
					count = 0;
				}
				if (i == numbers.Count - 2)
				{
					occurrences.Add(count + 1);
				}
			}
			var distinctNumbers = numbers.Distinct();
			int index = 0;
			foreach (int number in distinctNumbers)
			{
				Console.WriteLine("{0} -> {1}", number, occurrences[index]);
				index++;
			}
		}
	}
}