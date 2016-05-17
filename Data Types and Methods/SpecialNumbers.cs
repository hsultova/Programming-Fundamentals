using System;

namespace ProgrammingFundamentals
{
	class SpecialNumbers
	{
		static void Main(string[] args)
		{
			var n = int.Parse(Console.ReadLine());
			for (int number = 1; number <= n; number++)
			{
				Console.WriteLine("{0} -> {1}", number, IsSpecialNumber(number));
			}
		}

		static bool IsSpecialNumber(int number)
		{
			bool isSpecialNumber = false;

			string numberAsText = number.ToString();
			int sum = 0;
			for (int i = 0; i < numberAsText.Length; i++)
			{
				sum += int.Parse(numberAsText[i].ToString());
			}

			switch (sum)
			{
				case 5: isSpecialNumber = true; break;
				case 7: isSpecialNumber = true; break;
				case 11: isSpecialNumber = true; break;
			}

			return isSpecialNumber;
		}
	}
}
