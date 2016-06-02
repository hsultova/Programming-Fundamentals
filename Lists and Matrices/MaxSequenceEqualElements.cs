using System;
using System.Collections.Generic;
using System.Linq;

namespace ProgrammingFundamentals
{
	class MaxSequenceEqualElements
	{
		static void Main(string[] args)
		{
			var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
			int start = 0;
			int length = 0;
			int bestStart = 0;
			int bestLength = 0;

			for (int i = 0; i < numbers.Count - 1; i++)
			{
				start = numbers[i];
				if (numbers[i] == numbers[i + 1])
				{
					length++;
				}
				else
				{
					length = 0;
				}
				if (length > bestLength)
				{
					bestLength = length;
					bestStart = start;
				}
			}
			for (int i = 0; i <= bestLength; i++)
			{
				Console.Write(bestStart + " ");
			}
		}
	}
}