using System;
using System.Linq;

namespace ProgrammingFundamentals
{
	class ReverseArray
	{
		static void Main(string[] args)
		{
			double[] numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
			double[] reversedNumbers = new double[numbers.Length];

			int j = numbers.Length - 1;
			for (int i = 0; i < numbers.Length; i++)
			{
				reversedNumbers[i] = numbers[j];
				j--;
			}

			Console.WriteLine(string.Join(" ", reversedNumbers));
		}
	}
}