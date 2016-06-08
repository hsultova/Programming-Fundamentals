using System;
using System.Linq;

namespace ProgrammingFundamentals
{
	class DayOfWeek
	{
		static void Main(string[] args)
		{
			var input = Console.ReadLine().Split(new char[] { ' ', '-', '.', '/', '\\' }).Select(int.Parse).ToArray();
			var day = input[0];
			var month = input[1];
			var year = input[2];
			var date = new DateTime(year, month, day);
			Console.WriteLine(date.DayOfWeek);
		}
	}
}