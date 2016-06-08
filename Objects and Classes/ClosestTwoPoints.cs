using System;
using System.Linq;

namespace ProgrammingFundamentals
{
	class Point
	{

		public int X { get; set; }
		public int Y { get; set; }
	}

	class ClosestTwoPoints
	{
		static void Main(string[] args)
		{
			var n = int.Parse(Console.ReadLine());
			var points = new Point[n];			
			var closestTwoPoints = new Point[2];
			double distance = 0;
			double minDistance = double.MaxValue;
			
			for (int i = 0; i < n; i++)
			{
				points[i] = ReadPoint();
			}
			
			for (int i = 0; i < n; i++)
			{
				for (int j = i + 1; j < n; j++)
				{
					distance = CalcDistance(points[i], points[j]);

					if (distance < minDistance)
					{
						minDistance = distance;
						closestTwoPoints = new Point[] { points[i], points[j] };
					}
				}
			}

			Console.WriteLine("{0:f3}", minDistance);
			for (int i = 0; i < 2; i++)
			{
				Console.WriteLine("({0}, {1})", closestTwoPoints[i].X, closestTwoPoints[i].Y);
			}
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