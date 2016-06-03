using System;
using System.Collections.Generic;
using System.Linq;

namespace ProgrammingFundamentals
{
	class SquaresInMatrix
	{
		static void Main(string[] args)
		{
			var dimensions = Console.ReadLine().Split(' ');
			var rows = int.Parse(dimensions[0]);
			var cols = int.Parse(dimensions[1]);
			var matrix = new char[rows, cols];
			int count = 0;

			for (int row = 0; row < rows; row++)
			{
				var line = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
				for (int col = 0; col < cols; col++)
				{
					matrix[row, col] = line[col];
				}
			}

			for (int row = 0; row < rows - 1; row++)
			{
				for (int col = 0; col < cols - 1; col++)
				{
					if (matrix[row, col] == matrix[row, col + 1] && matrix[row, col] == matrix[row + 1, col] && matrix[row, col] == matrix[row + 1, col + 1])
					{
						count++;
					}
				}
			}

			Console.WriteLine(count);
		}
	}
}