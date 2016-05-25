using System;
using System.Collections.Generic;

namespace ProgrammingFundamentals
{
	class  LastKNumbersSums
	{
		static void Main(string[] args)
		{
			var n = int.Parse(Console.ReadLine());
			var k = int.Parse(Console.ReadLine());

			var sequence = new long[n];
			sequence[0] = 1;

			for (int i = 1; i < n; i++)
			{
				var start = Math.Max(0, i - k);
				var end = i - 1;
				for (int j = start; j <= end; j++)
				{
					sequence[i] += sequence[j];
				}
			}
			Console.WriteLine(string.Join(" ", sequence));
		}
	}
}