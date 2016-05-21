using System;
using System.Collections.Generic;

namespace ProgrammingFundamentals
{
	class PrimesInGivenRange
	{
		static void Main(string[] args)
		{
			var start = int.Parse(Console.ReadLine());
			var end = int.Parse(Console.ReadLine());
			var primeNumbers = FindPrimesInRange(start, end);

			Console.WriteLine(string.Join(", ", primeNumbers));
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

		static List<int> FindPrimesInRange(int startNumber, int endNumber)
		{
			var primeNumbers = new List<int>();

			for (int i = startNumber; i <= endNumber; i++)
			{
				if (IsPrime(i))
				{
					primeNumbers.Add(i);
				}
			}
			return primeNumbers;
		}
	}
}