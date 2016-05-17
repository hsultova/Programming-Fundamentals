using System;

namespace ProgrammingFundamentals
{
	class FilledSquare
	{
		static void Main(string[] args)
		{
			var n = int.Parse(Console.ReadLine());

			Console.WriteLine(new string('-', 2 * n));
			for (int i = 0; i < n - 2; i++)
			{
				Console.Write('-');

				int count = 0;
				while (count < n - 1)
				{
					Console.Write("\\/");
					count++;
				}
				Console.WriteLine('-');
			}
			Console.WriteLine(new string('-', 2 * n));
		}
	}
}
