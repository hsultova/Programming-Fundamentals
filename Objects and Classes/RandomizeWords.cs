using System;
using System.Linq;

namespace ProgrammingFundamentals
{
	class RandomizeWords
	{
		static void Main(string[] args)
		{
			var words = Console.ReadLine().Split(' ');
			var random = new Random();
			for (int i = 0; i < words.Length; i++)
			{
				var randomNumber = random.Next(words.Length);
				var numberToMove = words[randomNumber];
				words[randomNumber] = words[i];
				words[i] = numberToMove;
			}
			Console.WriteLine(string.Join("\n", words));
		}
	}
}