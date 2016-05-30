using System;
using System.Linq;

namespace ProgrammingFundamentals
{
	class Pairs
	{
		static void Main(string[] args)
		{
			var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
			var difference = int.Parse(Console.ReadLine());

			int count = 0;
			int j = 0;
			for (int i = 0; i < numbers.Length; i++)
			{
				for (j = 0; j < i; j++)
				{
					if (Math.Abs(numbers[i] - numbers[j]) == difference)
					{
						count++;
					}
				}
			}

			Console.WriteLine(count);
		}
	}
}