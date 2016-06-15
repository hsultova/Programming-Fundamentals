using System;
using System.Collections.Generic;
using System.Linq;

namespace ProgrammingFundamentals
{
	class Program
	{
		static void Main(string[] args)
		{
			var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
			double average = numbers.Average();
			var numbersGreaterThanAverage = numbers.Where(x => x > average);
			numbersGreaterThanAverage = numbersGreaterThanAverage.OrderByDescending(x => x).Take(5);
			if (numbersGreaterThanAverage.Count() == 0)
			{
				Console.WriteLine("No");
			}
			else
			{
				Console.WriteLine(string.Join(" ", numbersGreaterThanAverage));
			}
		}
	}
}
