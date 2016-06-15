using System;
using System.Globalization;

namespace ProgrammingFundamentals
{
	class Program
	{
		static void Main(string[] args)
		{
			var n = int.Parse(Console.ReadLine());
			decimal totalPrice = 0;
			for (int i = 0; i < n; i++)
			{
			
				decimal pricePerCapsule = decimal.Parse(Console.ReadLine());
				DateTime orderDate = DateTime.ParseExact(Console.ReadLine(), "d/M/yyyy", CultureInfo.InvariantCulture);
				long countCapsules = long.Parse(Console.ReadLine());

				decimal price = (DateTime.DaysInMonth(orderDate.Year, orderDate.Month) * countCapsules) * pricePerCapsule;
				totalPrice += price;
				Console.WriteLine("The price for the coffee is: ${0:f2}", price);
			}

			Console.WriteLine("Total: ${0:f2}", totalPrice);
		}
	}
}
