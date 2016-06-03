using System;

namespace ProgrammingFundamentals
{
	class MatrixGenerator
	{
		static void Main(string[] args)
		{
			var line = Console.ReadLine().Split(' ');
			var type = char.Parse(line[0]);
			var rows = int.Parse(line[1]);
			var cols = int.Parse(line[2]);
			var matrix = new int[rows, cols];
			int cellValue = 1;

			if (type == 'A')
			{
				for (int col = 0; col < cols; col++)
				{
					for (int row = 0; row < rows; row++)
					{
						matrix[row, col] = cellValue;
						cellValue++;
					}
				}
			}
			else if (type == 'B')
			{
				int direction = 1;
				for (int col = 0; col < cols; col++)
				{
					int row;
					if (direction == 1)
					{
						row = 0;
						while (row < rows)
						{
							matrix[row, col] = cellValue;
							cellValue++;
							row++;
						}
					}
					else if (direction == -1)
					{
						row = rows - 1;
						while (row >= 0)
						{
							matrix[row, col] = cellValue;
							cellValue++;
							row--;
						}
					}
					direction = -direction;
				}
			}
			else if (type == 'C')
			{
				int startRow = rows - 1;
				int startCol = 0;
				while (cellValue <= rows * cols)
				{
					int col = 0;
					if (startRow < 0)
					{
						startCol++;
						startRow = 0;
						col = startCol;
					}
					for (int row = startRow; row < rows; row++)
					{
						if (col == cols)
						{
							break;
						}
						matrix[row, col] = cellValue;
						col++;
						cellValue++;
					}
					startRow--;
				}
			}
			else if (type == 'D')
			{
				string direction = "down";
				int row = 0;
				int col = 0;
				for (int i = 1; i <= rows * cols; i++)
				{
					if (direction == "right" && (col > cols - 1 || matrix[row, col] != 0))
					{
						direction = "up";
						col--;
						row--;
					}
					if (direction == "down" && (row > rows - 1 || matrix[row, col] != 0))
					{
						direction = "right";
						row--;
						col++;
					}
					if (direction == "left" && (col < 0 || matrix[row, col] != 0))
					{
						direction = "down";
						col++;
						row++;
					}

					if (direction == "up" && row < 0 || matrix[row, col] != 0)
					{
						direction = "left";
						row++;
						col--;
					}

					matrix[row, col] = i;

					if (direction == "right")
					{
						col++;
					}
					if (direction == "down")
					{
						row++;
					}
					if (direction == "left")
					{
						col--;
					}
					if (direction == "up")
					{
						row--;
					}
				}
			}

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