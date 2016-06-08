using System;
using System.Linq;

namespace ProgrammingFundamentals
{
	class Point
	{

		public int X { get; internal set; }
		public int Y { get; internal set; }
	}

	class Distance
	{
		static void Main(string[] args)
		{
			var point1 = ReadPoint();
			var point2 = ReadPoint();

			Console.WriteLine("{0:f3}", CalcDistance(point1, point2));
		}

		static Point ReadPoint()
		{
			var line = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
			var point = new Point() { X = line[0], Y = line[1] };
			return point;
		}

		static double CalcDistance(Point p1, Point p2)
		{
			var x = Math.Abs(p1.X - p2.X);
			var y = Math.Abs(p1.Y - p2.Y);
			double distance = Math.Sqrt(x * x + y * y);
			return distance;
		}
	}
}