using System;
using System.Collections.Generic;
using System.Linq;

namespace ProgrammingFundamentals
{
	class ArrayManipulator
	{
		static void Main(string[] args)
		{
			var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
			var line = Console.ReadLine();
			while (line != "print")
			{
				var tokens = line.Split(' ');
				var command = tokens[0];
				if (command == "add")
				{
					var index = int.Parse(tokens[1]);
					var element = int.Parse(tokens[2]);
					numbers = Add(numbers, index, element);
				}
				else if (command == "addMany")
				{
					var index = int.Parse(tokens[1]);
					var elements = new int[tokens.Length - 2];
					var j = 0;
					for (int i = 2; i < tokens.Length; i++)
					{
						elements[j] = int.Parse(tokens[i]);
						j++;
					}
					numbers = AddMany(numbers, index, elements);
				}
				else if (command == "contains")
				{
					var element = int.Parse(tokens[1]);
					Console.WriteLine(Contains(numbers, element));
				}
				else if (command == "remove")
				{
					var index = int.Parse(tokens[1]);
					numbers = Remove(numbers, index);
				}
				else if (command == "shift")
				{
					var positions = int.Parse(tokens[1]);
					numbers = Shift(numbers, positions);
				}
				else if (command == "sumPairs")
				{
					numbers = SumPairs(numbers);

				}
				line = Console.ReadLine();
			}
			Console.WriteLine("[" + string.Join(", ", numbers) + "]");
		}

		static int[] Add(int[] array, int index, int element)
		{
			var updatedArray = new int[array.Length + 1];
			var j = 0;
			for (int i = 0; i < updatedArray.Length; i++)
			{
				if (i == index)
				{
					updatedArray[i] = element;
				}
				else
				{
					updatedArray[i] = array[j];
					j++;
				}
			}

			return updatedArray;
		}

		static int[] AddMany(int[] array, int index, int[] elements)
		{
			var updatedArray = new int[array.Length + elements.Length];
			var j = 0;
			for (int i = 0; i < updatedArray.Length; i++)
			{
				if (i == index)
				{
					for (int l = i; l < elements.Length + i; l++)
					{
						updatedArray[l] = elements[l - i];
					}
					i += elements.Length - 1;
				}
				else
				{
					updatedArray[i] = array[j];
					j++;
				}
			}

			return updatedArray;
		}

		static int Contains(int[] array, int element)
		{
			var index = -1;
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i] == element)
				{
					index = i;
				}
			}
			return index;
		}

		static int[] Remove(int[] array, int index)
		{
			var updatedArray = new int[array.Length - 1];

			var j = 0;
			for (int i = 0; i < updatedArray.Length; i++)
			{
				if (i == index)
				{
					j++;
				}
				updatedArray[i] = array[j];
				j++;
			}

			return updatedArray;
		}

		static int[] Shift(int[] array, int positions)
		{
			for (int pos = 0; pos < positions; pos++)
			{
				var first = array[0];
				for (int i = 0; i < array.Length - 1; i++)
				{
					array[i] = array[i + 1];
				}
				array[array.Length - 1] = first;
			}

			return array;
		}

		static int[] SumPairs(int[] array)
		{
			var updatedArray = new int[(int)Math.Ceiling(array.Length / 2.0)];
			var j = 0;
			for (int i = 0; i < array.Length - 1; i += 2)
			{
				updatedArray[j] = array[i] + array[i + 1];
				j++;
			}
			if (array.Length % 2 != 0)
			{
				updatedArray[updatedArray.Length - 1] = array[array.Length - 1];
			}
			return updatedArray;
		}
	}
}