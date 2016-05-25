using System;
using System.Linq;

namespace ProgrammingFundamentals
{
	class ArrayToNumber
	{
		static void Main(string[] args)
		{
			var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
			int[] result = AddNumbers(numbers);

			while (result.Length > 1)
			{
				result = AddNumbers(result);
			}

			Console.WriteLine(result[0]);
		}

		static int[] AddNumbers(int[] numbers)
		{
			int[] condensed = new int[numbers.Length - 1];
			for (int i = 0; i < numbers.Length - 1; i++)
			{
				condensed[i] = numbers[i] + numbers[i + 1];
			}
			return condensed;
		}
	}
}