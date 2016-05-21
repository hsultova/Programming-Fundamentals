using System;

namespace ProgrammingFundamentals
{
	class  VowelOrDigit
	{
		static void Main(string[] args)
		{
			var symbol = char.Parse(Console.ReadLine());
			bool isVowel = symbol == 'a' || symbol == 'o' || symbol == 'e' || symbol == 'u' || symbol == 'i';
			if (char.IsNumber(symbol))
			{
				Console.WriteLine("digit");
			}
			else if (isVowel)
			{
				Console.WriteLine("vowel");
			}
			else
			{
				Console.WriteLine("other");
			}
		}
	}
}