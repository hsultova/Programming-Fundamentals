using System;

namespace ProgrammingFundamentals
{
	class EnglishNameOfTheLastDigit
	{
		static void Main(string[] args)
		{
			var number = decimal.Parse(Console.ReadLine());
			Console.WriteLine(GetNameOfLastDigit(number));
		}

		static string GetNameOfLastDigit(decimal number)
		{
			string digitName = "";
			string numberAsText = number.ToString();
			int lastDigit = int.Parse(numberAsText[numberAsText.Length - 1].ToString());

			switch (lastDigit)
			{
				case 0: digitName = "zero"; break;
				case 1: digitName = "one"; break;
				case 2: digitName = "two"; break;
				case 3: digitName = "three"; break;
				case 4: digitName = "four"; break;
				case 5: digitName = "five"; break;
				case 6: digitName = "six"; break;
				case 7: digitName = "seven"; break;
				case 8: digitName = "eight"; break;
				case 9: digitName = "nine"; break;
			}
			return digitName;
		}
	}
}