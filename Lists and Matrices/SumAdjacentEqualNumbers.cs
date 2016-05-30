using System;
using System.Linq;

namespace ProgrammingFundamentals
{
	class SumAdjacentEqualNumbers
	{
		static void Main(string[] args)
		{
			var numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
			int position = 0;
			while (position < numbers.Count - 1)
			{
				if (numbers[position] == numbers[position + 1])
				{
					numbers.RemoveAt(position);
					numbers[position] *= 2;
					position--;
					if (position < 0)
					{
						position = 0;
					}
				}
				else
				{
					position++;
				}
			}
			Console.WriteLine(string.Join(" ", numbers));
		}
	}
}