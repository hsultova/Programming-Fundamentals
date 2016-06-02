using System;
using System.Collections.Generic;
using System.Linq;

namespace ProgrammingFundamentals
{
	class MatrixPalindromes
	{
		static void Main(string[] args)
		{
			var dimensions = Console.ReadLine().Split(' ');
			var rows = int.Parse(dimensions[0]);
			var cols = int.Parse(dimensions[1]);
			var rowLetter = 'a';
			var colLetter = 'a';

			for (int row = 0; row < rows; row++)
			{
				for (int col = 0; col < cols; col++)
				{
					Console.Write(rowLetter + "" + colLetter + rowLetter + " ");
					colLetter++;
				}
				rowLetter++;
				for (int i = 0; i < cols - 1; i++)
				{
					colLetter--;
				}
				Console.WriteLine();
			}
		}
	}
}