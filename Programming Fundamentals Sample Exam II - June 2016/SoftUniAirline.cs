using System;

namespace ProgrammingFundamentals
{
	class SoftUniAirline
	{
		static void Main(string[] args)
		{
			var n = int.Parse(Console.ReadLine());
			decimal overallProfit = 0;
			decimal averageProfit = 0;

			for (int i = 0; i < n; i++)
			{
				var adultPassengersCount = int.Parse(Console.ReadLine());
				var adultTicketPrice = decimal.Parse(Console.ReadLine());
				var youthPassengersCount = decimal.Parse(Console.ReadLine());
				var youthTicketPrice = decimal.Parse(Console.ReadLine());
				var fuelPricePerHour = decimal.Parse(Console.ReadLine());
				var fuleConsumptionPerHour = decimal.Parse(Console.ReadLine());
				var flightDuration = int.Parse(Console.ReadLine());

				var income = adultPassengersCount * adultTicketPrice + youthPassengersCount * youthTicketPrice;
				var expense = flightDuration * fuleConsumptionPerHour * fuelPricePerHour;
				var profit = income - expense;
				overallProfit += profit;
				if (income > +expense)
				{
					Console.WriteLine("You are ahead with {0:f3}$.", profit);
				}
				else
				{
					Console.WriteLine("We've got to sell more tickets! We've lost {0:f3}$.", profit);
				}
			}

			averageProfit = overallProfit / n;
			Console.WriteLine("Overall profit -> {0:f3}$.", overallProfit);
			Console.WriteLine("Average profit -> {0:f3}$.", averageProfit);
		}
	}
}
