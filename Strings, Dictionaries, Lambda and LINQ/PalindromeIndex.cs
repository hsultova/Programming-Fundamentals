using System;
using System.Collections.Generic;

namespace ProgrammingFundamentals
{
	class PalindromeIndex
	{
		static void Main(string[] args)
		{
			var word = Console.ReadLine();
			var palindrom = "";
			int index = -1;
			if (IsPalindrome(word))
			{
				index = -1;
			}
			else
			{
				for (int i = 0; i < word.Length; i++)
				{
					palindrom = word.Remove(i, 1);
					if (IsPalindrome(palindrom))
					{
						index = i;
					}
				}
			}
			Console.WriteLine(index);

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