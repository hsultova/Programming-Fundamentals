using System;

namespace ProgrammingFundamentals
{
	class BooleanVariable
	{
		static void Main(string[] args)
		{
			var input = Console.ReadLine();
			var toBoolean = Convert.ToBoolean(input);
			Console.WriteLine(toBoolean);
		}
	}
}
