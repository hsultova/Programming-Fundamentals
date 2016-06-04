using System;
using System.Collections.Generic;
using System.Linq;

namespace ProgrammingFundamentals
{
	class LargestIncreasingSubsequence
	{
		static void Main(string[] args)
		{
			var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
			var increasingNumbers = new List<int>();
			var lengths = new int[numbers.Length];
			var previous = new int[numbers.Length];
			var lastIndex = -1;
			var maxLength = 0;

			for (int p = 0; p < numbers.Length; p++)
			{
				lengths[p] = 1;
				previous[p] = -1;
				for (int i = 0; i < p; i++)
				{
					if (numbers[i] < numbers[p] && lengths[i] + 1 > lengths[p])
					{
						lengths[p] = lengths[i] + 1;
						previous[p] = i;
					}
				}
				if (lengths[p] > maxLength)
				{
					maxLength = lengths[p];
					lastIndex = p;
				}
			}

			while (lastIndex != -1)
			{
				increasingNumbers.Add(numbers[lastIndex]);
				lastIndex = previous[lastIndex];
			}
			increasingNumbers.Reverse();

			Console.WriteLine(string.Join(" ", increasingNumbers));
		}
	}
}