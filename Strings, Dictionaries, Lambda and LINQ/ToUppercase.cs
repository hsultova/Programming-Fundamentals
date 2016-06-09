using System;
using System.Linq;

namespace ProgrammingFundamentals
{
	class ToUppercase
	{
		static void Main(string[] args)
		{
			var text = Console.ReadLine();
			int upcaseStart = -1;
			while (true)
			{
				upcaseStart = text.IndexOf("<upcase>", upcaseStart + 1);
				int upcaseEnd = text.IndexOf("</upcase>");
				if (upcaseStart == -1)
				{
					break;
				}
				var textToUpper = text.Substring(upcaseStart + 8, upcaseEnd - upcaseStart - 8);
				text = text.Remove(upcaseStart, upcaseEnd - upcaseStart + 9);
				text = text.Insert(upcaseStart, textToUpper.ToUpper());

			}
			Console.WriteLine(text);
		}
	}
}