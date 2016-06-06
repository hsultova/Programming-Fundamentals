using System;

namespace ProgrammingFundamentals
{
	class ForbiddenSubstrings
	{
		static void Main(string[] args)
		{
			var text = Console.ReadLine();
			var words = Console.ReadLine().Split(' ');

			for (int i = 0; i < words.Length; i++)
			{
				text = text.Replace(words[i], new string('*', words[i].Length));
			}

			Console.WriteLine(text);
		}
	}
}