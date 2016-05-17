using System;

namespace ProgrammingFundamentals
{
	class CircleArea 
	{
		static void Main(string[] args)
		{
			var r = double.Parse(Console.ReadLine());
			double area = Math.PI * r * r;

			Console.WriteLine("{0:f12}", area);
		}
	}
}