using System;
using System.Linq;

namespace ProgrammingFundamentals
{
	class MaxSequenceEqualElements
	{
		static void Main(string[] args)
		{
			var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

			int equalElement = 0;
			int countEqualElement = 1;
			int maxCount = 0;

			for (int i = 0; i < numbers.Length - 1; i++)
			{
				if (numbers[i] == numbers[i + 1])
				{
					countEqualElement++;
				}
				else
				{
					countEqualElement = 1;
				}
				if (countEqualElement > maxCount)
				{
					maxCount = countEqualElement;
					equalElement = numbers[i];
				}
			}

			for (int i = 0; i < maxCount; i++)
			{
				if (i != maxCount - 1)
				{
					Console.Write(equalElement + " ");
				}
				else
				{
					Console.Write(equalElement);
				}
			}
		}
	}
}