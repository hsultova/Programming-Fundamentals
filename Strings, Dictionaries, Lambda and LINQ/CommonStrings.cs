using System;
using System.Collections.Generic;

namespace ProgrammingFundamentals
{
	class CommonStrings
	{
		static void Main(string[] args)
		{
			var A = Console.ReadLine();
			var B = Console.ReadLine();
			var a = "";

			for (int i = 1; i < A.Length; i++)
			{
				a = A.Substring(0, i);
				if (B.Contains(a))
				{
					Console.WriteLine("yes");
					return;
				}
			}

			Console.WriteLine("no");
		}
	}
}