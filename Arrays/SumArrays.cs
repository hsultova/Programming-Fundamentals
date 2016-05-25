using System;
using System.Linq;

namespace ProgrammingBasicExam
{
	class SumArrays
	{
		static void Main(string[] args)
		{
			int[] numbers1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
			int[] numbers2 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
			int[] sum = new int[Math.Max(numbers1.Length, numbers2.Length)];

			for (int i = 0; i < Math.Max(numbers1.Length, numbers2.Length); i++)
			{
				sum[i] = numbers1[i % numbers1.Length] + numbers2[i % numbers2.Length];

			}

			Console.WriteLine(string.Join(" ", sum));
		}
	}
}