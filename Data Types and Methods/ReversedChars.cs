using System;

namespace ProgrammingFundamentals
{
	class ReversedChars
	{
		static void Main(string[] args)
		{
			var a = char.Parse(Console.ReadLine());
			var b = char.Parse(Console.ReadLine());
			var c = char.Parse(Console.ReadLine());

			string reversedLetters = "" + c + b + a;
			Console.WriteLine(reversedLetters);
		}
	}
}
