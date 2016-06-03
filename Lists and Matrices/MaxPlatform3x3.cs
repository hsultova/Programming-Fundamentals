using System;
using System.Linq;

namespace ProgrammingFundamentals
{
	class MaxPlatform3x3
	{
		static void Main(string[] args)
		{
			var dimensions = Console.ReadLine().Split(' ');
			var rows = int.Parse(dimensions[0]);
			var cols = int.Parse(dimensions[1]);
			var matrix = new int[rows, cols];
			int sum;
			int maxSum = int.MinValue;
			var platform = new int[3, 3];
			var maxPlatform = new int[3, 3];

			for (int row = 0; row < rows; row++)
			{
				var line = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
				for (int col = 0; col < cols; col++)
				{
					matrix[row, col] = line[col];
				}
			}

			for (int row = 0; row < rows - 2; row++)
			{
				sum = 0;
				for (int col = 0; col < cols - 2; col++)
				{
					sum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] + matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2] + matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];
					for (int i = 0; i < 3; i++)
					{
						for (int j = 0; j < 3; j++)
						{
							platform[i, j] = matrix[row + i, col + j];
						}
					}
					if (sum > maxSum)
					{
						maxSum = sum;
						for (int i = 0; i < 3; i++)
						{
							for (int j = 0; j < 3; j++)
							{
								maxPlatform[i, j] = platform[i, j];
							}
						}
					}
				}
			}

			Console.WriteLine(maxSum);
			for (int i = 0; i < 3; i++)
			{
				for (int j = 0; j < 3; j++)
				{
					Console.Write(maxPlatform[i, j] + " ");

				}
				Console.WriteLine();
			}
		}
	}
}