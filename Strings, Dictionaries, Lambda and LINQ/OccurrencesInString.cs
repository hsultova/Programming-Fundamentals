using System;
namespace ProgrammingFundamentals
{
	class OccurrencesInString
	{
		static void Main(string[] args)
		{
			var text = Console.ReadLine().ToLower();
			var word = Console.ReadLine().ToLower();
			var count = 0;
			var offset = -1;

			while (true)
			{
				offset = text.IndexOf(word, offset + 1);
				if (offset == -1)
				{
					break;
				}
				else
				{
					count++;
				}
			}
			Console.WriteLine(count);
		}
	}
}