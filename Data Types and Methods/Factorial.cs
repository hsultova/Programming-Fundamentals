using System;
using System.Numerics;

namespace ProgrammingFundamentals
{
	class Factorial
	{
		static void Main(string[] args)
		{
			var n = int.Parse(Console.ReadLine());
			BigInteger factorial = 1;

			for (int i = 1; i <= n; i++)
			{
				factorial *= i;
			}

			Console.WriteLine(factorial);
		}
	}
}