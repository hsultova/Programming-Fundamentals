﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace ProgrammingFundamentals
{
	class MatrixRotation
	{
		static void Main(string[] args)
		{
			int rows = int.Parse(Console.ReadLine());
			int cols = int.Parse(Console.ReadLine());
			string[,] matrix = new string[rows, cols];

			for (int row = 0; row < rows; row++)
			{
				string[] line = Console.ReadLine().Split(' ');
				for (int col = 0; col < cols; col++)
				{
					matrix[row, col] = line[col];
				}
			}

			for (int col = 0; col < cols; col++)
			{
				for (int row = rows - 1; row >= 0; row--)
				{
					Console.Write(matrix[row, col] + " ");
				}
				Console.WriteLine();
			}
		}
	}
}