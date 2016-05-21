using System;

namespace ProgrammingFundamentals
{
	class PrimeChecker
	{
		static void Main(string[] args)
		{
			var n = long.Parse(Console.ReadLine());

			Console.WriteLine(IsPrime(n));

		}

		static bool IsPrime(long n)
		{
			bool isPrime = true;
			if (n == 1 || n == 0)
			{
				isPrime = false;
			}

			for (int i = 2; i <= (int)Math.Sqrt(n); i++)
			{
				if (n % i == 0 && (i != n && i != 1))
				{
					isPrime = false;
				}
			}

			return isPrime;
		}
	}
}