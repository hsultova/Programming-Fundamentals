using System;

namespace ProgrammingFundamentals
{
	class CenturiesToMinutes
	{
		static void Main(string[] args)
		{
			var centuries = ulong.Parse(Console.ReadLine());

			ulong years = centuries * 100;
			ulong days = (ulong)Math.Round(years * 365.242);
			ulong hours = days * 24;
			ulong minutes = hours * 60;

			Console.WriteLine(centuries);
			Console.WriteLine(years);
			Console.WriteLine(days);
			Console.WriteLine(hours);
			Console.WriteLine(minutes);
		}
	}
}