using System;
using System.Collections.Generic;
using System.Linq;

namespace ProgrammingFundamentals
{
	class SumReversedNumbers
	{
		static void Main(string[] args)
		{
			var input = Console.ReadLine().ToList();
			input.Reverse();
			var numbers = new List<string>();
			var number = "";
			var sum = 0;

			for (int i = 0; i < input.Count; i++)
			{
				if (input[i] != ' ')
				{
					number += input[i];
				}
				else {
					numbers.Add(number);
					number = "";
				}
			}
			numbers.Add(number);

			foreach (string item in numbers)
			{
				sum += int.Parse(item);
			}

			Console.WriteLine(sum);
		}
	}
}