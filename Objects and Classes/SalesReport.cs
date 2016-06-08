using System;
using System.Collections.Generic;
using System.Linq;

namespace ProgrammingFundamentals
{
	class Sale
	{

		public string Town { get; set; }
		public string Product { get; set; }
		public decimal Price { get; set; }
		public decimal Quantity { get; set; }
	}

	class SalesReport
	{
		static void Main(string[] args)
		{
			var n = int.Parse(Console.ReadLine());
			var sales = new List<Sale>();
			var salesByTown = new SortedDictionary<string, decimal>();
			for (int i = 0; i < n; i++)
			{
				sales.Add(ReadSale());
			}
			for (int i = 0; i < sales.Count; i++)
			{
				if (!salesByTown.ContainsKey(sales[i].Town))
				{
					salesByTown.Add(sales[i].Town, sales[i].Price * sales[i].Quantity);
				}
				else
				{
					salesByTown[sales[i].Town] += sales[i].Price * sales[i].Quantity;
				}
			}
			foreach (var sale in salesByTown)
			{
				Console.WriteLine("{0} -> {1:f2}", sale.Key, sale.Value);
			}
		}

		static Sale ReadSale()
		{
			var line = Console.ReadLine().Split(' ');
			var sale = new Sale() { Town = line[0], Product = line[1], Price = decimal.Parse(line[2]), Quantity = decimal.Parse(line[3]) };
			return sale;
		}

	}
}