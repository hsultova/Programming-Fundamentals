using System;
using System.Linq;

namespace ProgrammingFundamentals
{
	class EqualSums
	{
		static void Main(string[] args)
		{
			int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
			int leftSum;
			int rightSum;
			int j;
			for (int i = 1; i < numbers.Length - 1; i++)
			{
				leftSum = 0;
				rightSum = 0;
				j = 0;
				while (j < numbers.Length - 1)
				{
					if (j < i)
					{
						leftSum += numbers[i - j - 1];
					}
					if (j >= i)
					{
						rightSum += numbers[i + j - 1];
					}
					j++;
				}
				if (leftSum == rightSum)
				{
					Console.WriteLine(i);
					return;
				}
			}
			if (numbers.Length == 1 || numbers[1] == 0)
			{
				Console.WriteLine("0");
				return;
			}

			Console.WriteLine("no");
		}
	}
}