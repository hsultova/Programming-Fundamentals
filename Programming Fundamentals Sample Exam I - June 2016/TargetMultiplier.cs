using System;
using System.Linq;

namespace ProgrammingFundamentals
{
	class TargetMultiplier
	{
		static void Main(string[] args)
		{
			int[] dimensions = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
			int rows = dimensions[0];
			int cols = dimensions[1];
			long[,] matrix = new long[rows, cols];
			for (int row = 0; row < rows; row++)
			{
				long[] line = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
				for (int col = 0; col < cols; col++)
				{
					matrix[row, col] = line[col];
				}
			}
			int[] nextLine = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
			int targetedRow = nextLine[0];
			int targetedCol = nextLine[1];

			long targetedCell = matrix[targetedRow, targetedCol];
			long sumOfNeighboringsCells = 0;

			int startRow = Math.Max(0, targetedRow - 1);
			int endRow = Math.Min(rows, targetedRow + 1);
			int startCol = Math.Max(0, targetedCol - 1);
			int endCol = Math.Min(cols, targetedCol + 1);

			for (int row = startRow; row <= endRow; row++)
			{
				for (int col = startCol; col <= endCol; col++)
				{
					sumOfNeighboringsCells += matrix[row, col];
					matrix[row, col] *= targetedCell;
				}
			}
			sumOfNeighboringsCells -= targetedCell;
			matrix[targetedRow, targetedCol] = sumOfNeighboringsCells * targetedCell;


			for (int row = 0; row < rows; row++)
			{
				for (int col = 0; col < cols; col++)
				{
					Console.Write(matrix[row, col] + " ");
				}
				Console.WriteLine();
			}
		}
	}
}
