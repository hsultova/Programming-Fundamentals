using System;
namespace ProgrammingFundamentals
{
	class ExtractSentences
	{
		static void Main(string[] args)
		{
			var keyword = Console.ReadLine();
			var text = Console.ReadLine();
			var sentences = text.Split(new char[] { '.', '?', '!' });
			for (int i = 0; i < sentences.Length; i++)
			{
				if (sentences[i].Contains(' ' + keyword + ' '))
				{
					Console.WriteLine(sentences[i]);
				}
			}
		}
	}
}