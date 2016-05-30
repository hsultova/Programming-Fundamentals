using System;
using System.Collections.Generic;
using System.Linq;

namespace ProgrammingFundamentals
{
	class SquareNumbers
	{
		static void Main(string[] args)
		{
			var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
			var squareNumbers = new List<int>();
			for (int i = 0; i < numbers.Count; i++)
			{
				if (numbers[i] % Math.Sqrt(numbers[i]) == 0)
				{
					squareNumbers.Add(numbers[i]);
				}
			}
			squareNumbers.Sort();
			squareNumbers.Reverse();
			Console.WriteLine(string.Join(" ", squareNumbers));
		}
	}
}