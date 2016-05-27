using System;
using System.Linq;

namespace ProgrammingFundamentals
{
	class MostFrequentNumber
	{
		static void Main(string[] args)
		{
			var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

			int count = 0;
			int maxCount = 0;
			int mostFrequentNumber = 0;

			for (int i = 0; i < numbers.Length; i++)
			{
				for (int j = 0; j < numbers.Length; j++)
				{
					if (numbers[j] == numbers[i])
					{
						count++;
					}
				}

				if (count > maxCount)
				{
					maxCount = count;
					mostFrequentNumber = numbers[i];
				}
				count = 0;
			}
			Console.WriteLine(mostFrequentNumber);
		}
	}
}