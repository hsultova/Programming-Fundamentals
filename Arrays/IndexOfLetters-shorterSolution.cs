using System;

namespace ProgrammingFundamentals
{
	class  IndexOfLetters
	{
		static void Main(string[] args)
		{
			string word = Console.ReadLine();

			for (int i = 0; i < word.Length; i++)
			{
				int letterIndex = Convert.ToInt32(word[i]) - 97;
				Console.WriteLine("{0} -> {1}", word[i], letterIndex);
			}
		}
	}
}