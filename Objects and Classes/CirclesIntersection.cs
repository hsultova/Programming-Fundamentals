using System;
using System.Linq;

namespace ProgrammingFundamentals
{
	class Point
	{
		public int X { get; set; }
		public int Y { get; set; }

		public double CalcDistance(Point p)
		{
			var x = Math.Abs(X - p.X);
			var y = Math.Abs(Y - p.Y);
			double distance = Math.Sqrt(x * x + y * y);
			return distance;
		}
	}

	class Circle
	{
		public Point Center { get; set; }
		public int Radius { get; set; }

		public bool Intersect(Circle circle)
		{
			var distance = Center.CalcDistance(circle.Center);
			var sumRadius = Radius + circle.Radius;
			if (distance <= sumRadius)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
	}

	class CirclesIntersection
	{
		static void Main(string[] args)
		{
			var circle1 = ReadCircle();
			var circle2 = ReadCircle();

			if (circle1.Intersect(circle2))
			{
				Console.WriteLine("Yes");
			}
			else
			{
				Console.WriteLine("No");
			}
		}

		static Circle ReadCircle()
		{
			var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
			return new Circle() { Center = new Point() { X = input[0], Y = input[1] }, Radius = input[2] };
		}
	}
}
