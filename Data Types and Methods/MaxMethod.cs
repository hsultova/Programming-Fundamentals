using System;

namespace ProgrammingFundamentals
{
	class MaxMethod
	{
		static void Main(string[] args)
		{
			var a = int.Parse(Console.ReadLine());
			var b = int.Parse(Console.ReadLine());
			var c = int.Parse(Console.ReadLine());

			Console.WriteLine(GetMax(GetMax(a, b), c));
		}

		static int GetMax(int a, int b)
		{
			if (a > b)
			{
				return a;
			}
			else
			{
				return b;
			}
		}
	}
}