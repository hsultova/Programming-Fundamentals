using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

namespace ProgrammingFundamentals
{
	class Program
	{
		static void Main(string[] args)
		{
			var healthPoints = long.Parse(Console.ReadLine());
			var dimensions = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
			var rows = dimensions[0];
			var cols = dimensions[1];
			var map = new char[rows, cols];
			int turns = 0;
			for (int row = 0; row < rows; row++)
			{
				var line = Console.ReadLine();
				for (int col = 0; col < cols; col++)
				{
					map[row, col] = line[col];
				}
			}

			int direction = 1;
			for (int col = 0; col < cols; col++)
			{
				int row = 0;
				char currentCell = map[row, col];

				if (direction == 1)
				{
					row = 0;
					while (row < rows)
					{
						currentCell = map[row, col];
						if (currentCell == 'F')
						{
							healthPoints -= turns / 2;
						}
						else if (currentCell == 'H')
						{
							healthPoints += turns / 3;
						}
						else if (currentCell == 'T')
						{
							turns += 2;
						}

						if (healthPoints <= 0)
						{
							Console.WriteLine("Died at: [{0}, {1}]", row, col);
							return;
						}
						turns++;
						row++;
					}
				}
				else if (direction == -1)
				{
					row = rows - 1;
					while (row >= 0)
					{
						currentCell = map[row, col];
						if (currentCell == 'F')
						{
							healthPoints -= turns / 2;
						}
						else if (currentCell == 'H')
						{
							healthPoints += turns / 3;
						}
						else if (currentCell == 'T')
						{
							turns += 2;
						}

						if (healthPoints <= 0)
						{
							Console.WriteLine("Died at: [{0}, {1}]", row, col);
							return;
						}
						turns++;
						row--;
					}
				}
				direction = -direction;

			}
			Console.WriteLine("Quest completed!");
			Console.WriteLine($"Health: {healthPoints}");
			Console.WriteLine($"Turns: {turns}");
		}
	}
}
