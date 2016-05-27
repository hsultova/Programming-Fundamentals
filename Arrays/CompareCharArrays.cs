using System;
using System.Linq;

namespace ProgrammingFundamentals
{
	class CompareCharArrays
	{
		static void Main(string[] args)
		{
			char[] text1 = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
			char[] text2 = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();

			string result = "";
			int i = 0;
			int j = 0;
			while (i < text1.Length && j < text2.Length)
			{
				if (text1[i] < text2[j])
				{
					result = "first";
					break;
				}
				else if (text1[i] > text2[j])
				{
					result = "second";
					break;
				}
				i++;
				j++;
			}

			if (result == "first")
			{
				Print(text1);
				Print(text2);
			}
			else if (result == "second")
			{
				Print(text2);
				Print(text1);
			}
			else {
				if (text1.Length < text2.Length)
				{
					Print(text1);
					Print(text2);
				}
				else
				{
					Print(text2);
					Print(text1);
				}
			}
		}

		static void Print(char[] array)
		{
			for (int i = 0; i < array.Length; i++)
			{
				Console.Write(array[i]);
			}
			Console.WriteLine();
		}
	}
}