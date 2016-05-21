using System;

namespace ProgrammingFundamentals
{
	class DifferentIntegersSize
	{
		static void Main(string[] args)
		{
			string input = Console.ReadLine();
			int count = 0;
			try
			{
				var number = long.Parse(input);
				Console.WriteLine($"{number} can fit in:");
				if (number == (sbyte)number)
				{
					Console.WriteLine("* sbyte");
					count++;
				}
				if (number == (byte)number)
				{
					Console.WriteLine("* byte");
					count++;
				}
				if (number == (short)number)
				{
					Console.WriteLine("* short");
					count++;
				}
				if (number == (ushort)number)
				{
					Console.WriteLine("* ushort");
					count++;
				}
				if (number == (int)number)
				{
					Console.WriteLine("* int");
					count++;
				}
				if (number == (uint)number)
				{
					Console.WriteLine("* uint");
					count++;
				}
				Console.WriteLine("* long");
				count++;
			}
			catch
			{
				if (count > 7 || count == 0)
				{
					Console.WriteLine($"{input} can't fit in any type");
				}
			}
		}
	}
}