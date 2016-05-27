using System;

namespace ProgrammingFundamentals
{
	class PrimeNumbers
	{
		static void Main(string[] args)
		{
			var n = int.Parse(Console.ReadLine());
			bool[] primes = new bool[n + 1];
			for (int i = 0; i < n; i++)
			{
				primes[i] = true;
			}
			primes[0] = false;
			primes[1] = false;

			//Fill prime numbers
			for (int i = 2; i <= n; i++)
			{
				if (primes[i])
				{
					for (int j = 2 * i; j < primes.Length; j += i)
					{
						primes[j] = false;
					}
				}
			}

			//Print prime numbers
			for (int i = 0; i < primes.Length; i++)
			{
				if (primes[i] == true)
				{
					if (i != primes.Length - 1)
					{
						Console.Write(i + " ");
					}
					else
					{
						Console.Write(i);
					}
				}
			}
		}
	}
}