using System;

namespace ProgrammingFundamentals
{
	class PartOfASCIITable
	{
		static void Main(string[] args)
		{
			var start = int.Parse(Console.ReadLine());
			var end = int.Parse(Console.ReadLine());

			for (int i = start; i <= end; i++)
			{
				Console.Write(Convert.ToChar(i) + " ");
			}
		}
	}
}