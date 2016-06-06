using System;
using System.Linq;

namespace ProgrammingFundamentals
{
	class LettersInString
	{
		static void Main(string[] args)
		{
			var word = Console.ReadLine().ToLower();
			var count = new int[word.Max() + 1];

			foreach (char letter in word)
			{
				count[letter]++;
			}

			for (char letter = (char)0; letter < count.Length; letter++)
			{
				if (count[letter] != 0)
				{
					Console.WriteLine($"{letter} -> {count[letter]}");
				}
			}
		}
	}
}