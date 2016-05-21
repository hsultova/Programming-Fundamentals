using System;

namespace ProgrammingFundamentals
{
	class ComparingFloats
	{
		static void Main(string[] args)
		{
			var a = decimal.Parse(Console.ReadLine());
			var b = decimal.Parse(Console.ReadLine());
			var eps = 0.000001m;

			if (Math.Abs(a - b) < eps)
			{
				Console.WriteLine("True");
			}
			else
			{
				Console.WriteLine("False");
			}
		}
	}
}