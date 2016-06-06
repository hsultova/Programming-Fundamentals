using System;
using System.Collections.Generic;
using System.Linq;

namespace ProgrammingFundamentals
{
	class OddOccurrences
	{
		static void Main(string[] args)
		{
			var words = Console.ReadLine().ToLower().Split(' ');
			var counts = new Dictionary<string, int>();
			var oddOccurrences = new List<string>();

			foreach (string word in words)
			{
				if (!counts.ContainsKey(word))
				{
					counts.Add(word, 1);
				}
				else
				{
					counts[word]++;
				}
			}

			foreach (var item in counts)
			{
				if (item.Value % 2 != 0)
				{
					oddOccurrences.Add(item.Key);
				}
			}
			Console.WriteLine(string.Join(", ", oddOccurrences));
		}
	}
}