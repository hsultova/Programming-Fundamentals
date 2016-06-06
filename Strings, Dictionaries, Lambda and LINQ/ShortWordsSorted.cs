using System;
using System.Linq;

namespace ProgrammingFundamentals
{
	class ShortWordsSorted
	{
		static void Main(string[] args)
		{
			var separators = new char[] { ' ', ',', '.', ';', '(', ')', '[', ']', '\'', '"', '\\', '/', '!', '?' };
			var text = Console.ReadLine().ToLower().Split(separators);

			Console.WriteLine(string.Join(", ", text.Where(x => x.Length < 5 && x.Length > 0).OrderBy(x => x).Distinct()));
		}
	}
}