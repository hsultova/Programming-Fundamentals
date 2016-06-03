using System;
using System.Linq;

namespace ProgrammingFundamentals
{
	class HourglassSum
	{
		static void Main(string[] args)
		{
			var matrix = new int[6, 6];
			int sum;
			int maxSum = int.MinValue;

			for (int row = 0; row < 6; row++)
			{
				var line = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
				for (int col = 0; col < 6; col++)
				{
					matrix[row, col] = line[col];
				}
			}

			for (int row = 0; row < 4; row++)
			{
				for (int col = 0; col < 4; col++)
				{
					sum = 0;
					sum += matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] + matrix[row + 1, col + 1] + matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];
					if (sum > maxSum)
					{
						maxSum = sum;
					}
				}
			}

			Console.WriteLine(maxSum);
		}
	}
}