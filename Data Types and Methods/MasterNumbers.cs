using System;

namespace ProgrammingFundamentals
{
	class MasterNumbers
	{
		static void Main(string[] args)
		{
			var end = int.Parse(Console.ReadLine());

			for (int number = 1; number < end; number++)
			{
				if (IsPalindrome(number) && IsSumOfDigitDivisible(number) && ContainsEvenDigit(number))
				{
					Console.WriteLine(number);
				}
			}
		}

		static bool IsPalindrome(int number)
		{
			string numberText = number.ToString();
			int left = 0;
			int right = numberText.Length - 1;

			while (true)
			{
				if (left > right)
				{
					return true;
				}
				char a = numberText[left];
				char b = numberText[right];
				if (a != b)
				{
					return false;
				}
				left++;
				right--;
			}
		}

		static bool IsSumOfDigitDivisible(int number)
		{
			int sumOfDigits = 0;
			string numberText = number.ToString();

			for (int i = 0; i < numberText.Length; i++)
			{
				sumOfDigits += int.Parse(numberText[i].ToString());
			}

			if (sumOfDigits % 7 == 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		static bool ContainsEvenDigit(int number)
		{
			string numberText = number.ToString();
			bool isContainsEvenDigit = false;

			for (int i = 0; i < numberText.Length; i++)
			{
				if (int.Parse(numberText[i].ToString()) % 2 == 0)
				{
					isContainsEvenDigit = true;
				}
			}

			return isContainsEvenDigit;
		}
	}
}