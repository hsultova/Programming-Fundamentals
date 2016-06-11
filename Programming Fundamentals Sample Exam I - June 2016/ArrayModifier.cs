using System;
using System.Linq;

namespace ProgrammingFundamentals
{
	class ArrayModifier
	{
		static void Main(string[] args)
		{
			var numbers = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
			var line = Console.ReadLine();
			while (line != "end")
			{
				var tokens = line.Split(' ');
				string command = tokens[0];
				if (command == "swap")
				{
					int index1 = int.Parse(tokens[1]);
					int index2 = int.Parse(tokens[2]);

					numbers = Swap(numbers, index1, index2);
				}
				else if (command == "multiply")
				{
					int index1 = int.Parse(tokens[1]);
					int index2 = int.Parse(tokens[2]);

					numbers = Multiply(numbers, index1, index2);
				}
				else if (command == "decrease")
				{
					numbers = Decrease(numbers);
				}
				line = Console.ReadLine();
			}
			Console.WriteLine(string.Join(", ", numbers));
		}

		static long[] Swap(long[] array, int index1, int index2)
		{
			long toMove = array[index1];
			array[index1] = array[index2];
			array[index2] = toMove;

			return array;
		}

		static long[] Multiply(long[] array, int index1, int index2)
		{
			long product = array[index1] * array[index2];
			array[index1] = product;
			return array;
		}

		static long[] Decrease(long[] array)
		{
			for (int i = 0; i < array.Length; i++)
			{
				array[i]--;
			}
			return array;
		}
	}
}
