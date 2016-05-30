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
			var positiveNumbers = new List<int>();
			for (int i = 0; i < numbers.Length; i++)
			{
				if (numbers[i] >= 0)
				{
					positiveNumbers.Add(numbers[i]);
				}
			}
			positiveNumbers.Reverse();
			if (positiveNumbers.Count != 0)
			{
				Console.WriteLine(string.Join(" ", positiveNumbers));
			}
			else
			{
				Console.WriteLine("empty");
			}
		}
	}
}