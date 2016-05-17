using System;

namespace ProgrammingFundamentals
{
	class ExchangeVariableValues
	{
		static void Main(string[] args)
		{
			var a = int.Parse(Console.ReadLine());
			var b = int.Parse(Console.ReadLine());

			Console.WriteLine("Before:");
			Console.WriteLine("a = {0}", a);
			Console.WriteLine("b = {0}", b);

			//Exchange values
			int valueToMove = a;
			a = b;
			b = valueToMove;

			Console.WriteLine("After:");
			Console.WriteLine("a = {0}", a);
			Console.WriteLine("b = {0}", b);
		}
	}
}
