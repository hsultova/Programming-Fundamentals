using System;
using System.Linq;

namespace ProgrammingFundamentals
{
	class Rectangle
	{

		public int Top { get; set; }
		public int Left { get; set; }
		public int Width { get; set; }
		public int Height { get; set; }

		public int Bottom
		{
			get
			{
				return Top + Height;
			}
		}

		public int Right
		{
			get
			{
				return Left + Width;
			}
		}

		public bool IsInside(Rectangle r)
		{
			return (r.Left <= Left && r.Right >= Right && r.Top <= Top && r.Bottom >= Bottom);
		}
	}

	class RectanglePosition
	{
		static void Main(string[] args)
		{
			var rectangle1 = ReadRectangle();
			var rectangle2 = ReadRectangle();

			Console.WriteLine(rectangle1.IsInside(rectangle2) ? "Inside" : "Not inside");
		}

		static Rectangle ReadRectangle()
		{
			var line = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
			var rectangle = new Rectangle() { Top = line[0], Left = line[1], Width = line[2], Height = line[3] };
			return rectangle;
		}

	}
}