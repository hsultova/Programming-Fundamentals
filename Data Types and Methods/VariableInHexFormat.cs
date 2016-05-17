using System;

namespace ProgrammingFundamentals
{
	class VariableInHexFormat
	{
		static void Main(string[] args)
		{
			var hexadecimalNumber = Console.ReadLine();
			var numberToDecimal = Convert.ToInt32(hexadecimalNumber, 16);
			Console.WriteLine(numberToDecimal);
		}
	}
}
