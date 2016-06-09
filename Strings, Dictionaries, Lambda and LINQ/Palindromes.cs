using System;
using System.Collections.Generic;
using System.Linq;

namespace ProgrammingFundamentals
{
	class Palindromes
	{
		static void Main(string[] args)
		{
			var separators = new char[] { ' ', ',', '.', '?', '!', ':', ';' };
			var words = Console.ReadLine().Split(separators, StringSplitOptions.RemoveEmptyEntries);
			var palindromes = new List<string>();
			foreach (string word in words)
			{
				if (IsPalindrome(word))
				{
					palindromes.Add(word);
				}
			}
			palindromes.Sort();
			Console.WriteLine(string.Join(", ", palindromes));

		}

		static bool IsPalindrome(string word)
		{
			bool isPalindrome = true;
			for (int i = 0; i < word.Length / 2; i++)
			{
				if (word[i] != word[word.Length - 1 - i])
				{
					isPalindrome = false;
				}
			}

			return isPalindrome;
		}
	}
}