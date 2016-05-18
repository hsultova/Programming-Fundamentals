using System;

namespace ProgrammingFundamentals
{
	class IntegerToHexAndBinary
	{
		static void Main(string[] args)
		{
			var number = int.Parse(Console.ReadLine());
			var hexadecimalNumber = Convert.ToString(number, 16).ToUpper();
			var binaryNumber = Convert.ToString(number, 2);

			Console.WriteLine(hexadecimalNumber);
			Console.WriteLine(binaryNumber);
		}
	}
}