using System;

namespace ProgrammingFundamentals
{
	class BooleanVariable
	{
		static void Main(string[] args)
		{
			var input = Console.ReadLine();
			var toBoolean = Convert.ToBoolean(input);
			if (toBoolean == true)
			{
				Console.WriteLine("Yes");
			}
			else
			{
				Console.WriteLine("No");
			}
		}
	}
}