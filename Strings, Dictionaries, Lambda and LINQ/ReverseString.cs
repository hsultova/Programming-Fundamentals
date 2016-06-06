using System;
using System.Linq;

namespace ProgrammingFundamentals
{
	class ReverseString
	{
		static void Main(string[] args)
		{
			var word = Console.ReadLine();
			var reversed = word.Reverse();
			foreach (char letter in reversed)
			{
				Console.Write(letter);
			}
		}
	}
}