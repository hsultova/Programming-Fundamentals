using System;
using System.Linq;

namespace ProgrammingFundamentals
{
	class TrippleSum
	{
		static void Main(string[] args)
		{
			int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
			bool hasOutput = false;

			for (int i = 0; i < numbers.Length; i++)
			{
				for (int j = i; j < numbers.Length; j++)
				{
					int sum = numbers[i] + numbers[j];
					if (numbers.Contains(sum) && i != j)
					{
						Console.WriteLine("{0} + {1} == {2}", numbers[i], numbers[j], sum);
						hasOutput = true;
					}
				}
			}
			if (!hasOutput)
			{
				Console.WriteLine("No");
			}
		}
	}
}