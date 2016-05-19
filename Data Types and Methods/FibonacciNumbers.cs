using System;

namespace ProgrammingFundamentals
{
	class FibonacciNumbers
	{
		static void Main(string[] args)
		{
			var n = int.Parse(Console.ReadLine());
			Console.WriteLine(Fib(n));
		}

		static int Fib(int n)
		{
			if (n <= 1)
			{
				return 1;
			}
			return Fib(n - 1) + Fib(n - 2);
		}
	}
}