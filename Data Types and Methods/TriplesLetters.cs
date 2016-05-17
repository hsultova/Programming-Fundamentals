using System;

namespace ProgrammingFundamentals
{
	class TriplesLetters
	{
		static void Main(string[] args)
		{
			var n = int.Parse(Console.ReadLine());

			string letters = "";
			char letter = 'a';
			for (int i = 0; i < n; i++)
			{
				letters += letter;
				letter++;
			}

			for (char first = 'a'; first <= letters[letters.Length - 1]; first++)
			{
				for (char second = 'a'; second <= letters[letters.Length - 1]; second++)
				{
					for (char third = 'a'; third <= letters[letters.Length - 1]; third++)
					{
						Console.WriteLine("" + first + second + third);
					}
				}
			}
		}
	}
}
