using System;

namespace ProgrammingFundamentals
{
	class RectangleProperties
	{
		static void Main(string[] args)
		{
			var width = double.Parse(Console.ReadLine());
			var height = double.Parse(Console.ReadLine());
			var perimeter = 2 * (width + height);
			var area = width * height;
			var diagonal = Math.Sqrt(width * width + height * height);

			Console.WriteLine("{0}", perimeter);
			Console.WriteLine("{0}", area);
			Console.WriteLine("{0}", diagonal);
		}
	}
}