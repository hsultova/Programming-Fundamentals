using System;

namespace ProgrammingFundamentals
{
	class SweetDessert
	{
		static void Main(string[] args)
		{
			var money = double.Parse(Console.ReadLine());
			var guests = int.Parse(Console.ReadLine());
			var priceBananas = double.Parse(Console.ReadLine());
			var eggsPrice = double.Parse(Console.ReadLine());
			var berriesPrice = double.Parse(Console.ReadLine());

			var portions = Math.Ceiling(guests / 6.0);
			var neededMoney = portions * (2 * priceBananas + 4 * eggsPrice + 0.2 * berriesPrice);
			if (neededMoney <= money)
			{
				Console.WriteLine("Ivancho has enough money - it would cost {0:f2}lv.", neededMoney);
			}
			else
			{
				Console.WriteLine("Ivancho will have to withdraw money - he will need {0:f2}lv more.", neededMoney - money);
			}
		}
	}
}
