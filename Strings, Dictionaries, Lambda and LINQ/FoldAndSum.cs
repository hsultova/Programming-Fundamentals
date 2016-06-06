using System;
using System.Linq;

namespace ProgrammingFundamentals
{
	class FoldAndSum
	{
		static void Main(string[] args)
		{
			var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

			int k = numbers.Length / 4;
			var row1Left = numbers.Take(k).Reverse();
			var row1Right = numbers.Reverse().Take(k);
			int[] row1 = row1Left.Concat(row1Right).ToArray();
			int[] row2 = numbers.Skip(k).Take(2 * k).ToArray();
			var sum = row1.Select((x, index) => x + row2[index]);

			Console.WriteLine(string.Join(" ", sum));
		}
	}
}