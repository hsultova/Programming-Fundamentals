using System;

namespace ProgrammingFundamentals
{
	class  IndexOfLetters
	{
		static void Main(string[] args)
		{
			string word = Console.ReadLine();
			char[] alphabet = CreateLettersArray();

			for (int i = 0; i < word.Length; i++)
			{
				for (int j = 0; j < alphabet.Length; j++)
				{
					if (word[i] == alphabet[j])
					{
						Console.WriteLine("{0} -> {1}", word[i], j);
					}
				}
			}
		}

		static char[] CreateLettersArray()
		{
			char[] letters = new char[26];
			char letter = 'a';
			for (int i = 0; i < 26; i++)
			{
				letters[i] = letter;
				letter++;
			}
			return letters;
		}
	}
}