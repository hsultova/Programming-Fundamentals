using System;
using System.Linq;

namespace ProgrammingFundamentals
{
	class Numbers
	{
		static void Main(string[] args)
		{
			var n = int.Parse(Console.ReadLine());
			var numbers = new int[n];
			for (int i = 0; i < n; i++)
			{
				numbers[i] = int.Parse(Console.ReadLine());
			}

			int sum = numbers.Sum();
			int min = numbers.Min();
			int max = numbers.Max();
			int first = numbers[0];
			int last = numbers[numbers.Length - 1];
			double average = numbers.Average();

			Console.WriteLine("Sum = {0}", sum);
			Console.WriteLine("Min = {0}", min);
			Console.WriteLine("Max = {0}", max);
			Console.WriteLine("First = {0}", first);
			Console.WriteLine("Last = {0}", last);
			Console.WriteLine("Average = {0}", average);
		}
	}
}