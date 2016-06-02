using System;
using System.Collections.Generic;
using System.Linq;

namespace ProgrammingFundamentals
{
	class DiagonalDifference
	{
		static void Main(string[] args)
		{
			var n = int.Parse(Console.ReadLine());
			var matrix = new int[n, n];
			int sumPrimeryDiagonal = 0;
			int sumSecondaryDiagonal = 0;

			for (int row = 0; row < n; row++)
			{
				var line = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
				for (int col = 0; col < n; col++)
				{
					matrix[row, col] = line[col];
				}
			}
			int column = 0;
			for (int row = 0; row < n; row++)
			{
				sumPrimeryDiagonal += matrix[row, column];
				column++;
			}

			column = n - 1;
			for (int row = 0; row < n; row++)
			{
				sumSecondaryDiagonal += matrix[row, column];
				column--;
			}

			Console.WriteLine(Math.Abs(sumPrimeryDiagonal - sumSecondaryDiagonal));
		}
	}
}