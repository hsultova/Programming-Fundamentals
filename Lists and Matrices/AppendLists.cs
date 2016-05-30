using System;
using System.Collections.Generic;

namespace ProgrammingFundamentals
{
	class AppendLists
	{
		static void Main(string[] args)
		{
			var lists = Console.ReadLine().Split('|');

			for (int i = lists.Length-1; i >=0; i--)
			{
				var numbersText = lists[i].Split(' ');
				var numbers = new List<int>();
				for (int j = 0; j < numbersText.Length; j++)
				{
					if (numbersText[j] !="")
					{
						numbers.Add(int.Parse(numbersText[j]));
					}
				
				}
				Console.Write(string.Join(" ", numbers)+ " ");
			}
		}
	}
}