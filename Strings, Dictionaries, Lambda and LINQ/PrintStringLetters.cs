using System;

namespace ProgrammingFundamentals
{
	class StringLetters
	{
		static void Main(string[] args)
		{
			var word = Console.ReadLine();

			for (int i = 0; i < word.Length; i++)
			{
				Console.WriteLine("str[{0}] -> '{1}'", i, word[i]);
			}
		}
	}
}