using System;
using System.Linq;

namespace ProgrammingFundamentals
{
	class FoldAndSum
	{
		static void Main(string[] args)
		{
			int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
			int n = numbers.Length;
			int[] upper = new int[n / 2];
			int[] lower = new int[n / 2];

			int index = 0;
			for (int i = n / 4 - 1; i >= 0; i--)
			{
				upper[index] = numbers[i];
				index++;
			}
			for (int i = n - 1; i >= 3 * n / 4; i--)
			{
				upper[index] = numbers[i];
				index++;
			}
			index = 0;
			for (int i = n / 4; i < 3 * n / 4; i++)
			{
				lower[index] = numbers[i];
				index++;
			}
			Console.WriteLine(string.Join(" ", Sum(upper, lower)));
		}

		static int[] Sum(int[] first, int[] second)
		{
			int[] summedNumbers = new int[first.Length];
			int i = 0;
			while (i < first.Length)
			{
				summedNumbers[i] = first[i] + second[i];
				i++;
			}
			return summedNumbers;
		}
	}
}