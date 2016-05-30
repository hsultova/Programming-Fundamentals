using System;
using System.Collections.Generic;
using System.Linq;

namespace ProgrammingFundamentals
{
	class WordCasing
	{
		static void Main(string[] args)
		{
			var separators = new char[] { ',', ';', ':', '.', '!', '(', ')', '\\', '/', ' ', '[', ']', '\'', '\"' };
			var words = Console.ReadLine().Split(separators).ToList();
			var lowerCase = new List<string>();
			var mixedCase = new List<string>();
			var upperCase = new List<string>();

			foreach (string word in words)
			{
				if (word != "")
				{
					if (word.Any(char.IsDigit) || word.Any(char.IsPunctuation) || word.Any(char.IsSymbol) || word.Any(char.IsSeparator))
					{
						mixedCase.Add(word);
					}
					else {
						if (word == word.ToLower())
						{
							lowerCase.Add(word);
						}
						else if (word == word.ToUpper())
						{
							upperCase.Add(word);
						}
						else
						{
							mixedCase.Add(word);
						}
					}
				}
			}
			Console.WriteLine("Lower-case: " + string.Join(", ", lowerCase));
			Console.WriteLine("Mixed-case: " + string.Join(", ", mixedCase));
			Console.WriteLine("Upper-case: " + string.Join(", ", upperCase));
		}
	}
}