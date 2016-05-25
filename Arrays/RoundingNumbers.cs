using System;
using System.Linq;

namespace ProgrammingFundamentals
{
	class RoundingNumbers
	{
		static void Main(string[] args)
		{
			double[] numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
			double[] roundedNumbers = new double[numbers.Length];

			for (int i = 0; i < roundedNumbers.Length; i++)
			{
				roundedNumbers[i] = Math.Round(numbers[i], MidpointRounding.AwayFromZero);
			}
			for (int i = 0; i < numbers.Length; i++)
			{
				Console.WriteLine($"{numbers[i]} -> {roundedNumbers[i]}");
			}
		}
	}
}