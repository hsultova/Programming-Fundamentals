using System;

namespace ProgrammingBasicExam
{
	class  DayOfWeek
	{
		static void Main(string[] args)
		{
			int day = int.Parse(Console.ReadLine());
			string[] daysOfWeeks = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
			if (day >= 1 && day <= 7)
			{
				Console.WriteLine(daysOfWeeks[day - 1]);
			}
			else
			{
				Console.WriteLine("Invalid day!");
			}
		}
	}
}