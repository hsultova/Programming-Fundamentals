using System;

namespace ProgrammingFundamentals
{
	class Capitalization
	{
		static void Main(string[] args)
		{
			var separators = new char[] { ' ', ',', '.', '?', '!', ':', ';' };
			var words = Console.ReadLine().Split(separators, StringSplitOptions.RemoveEmptyEntries);

			foreach (string word in words)
			{
				Console.Write(char.ToUpper(word[0]) + word.Substring(1) + " ");
			}
		}
	}
}