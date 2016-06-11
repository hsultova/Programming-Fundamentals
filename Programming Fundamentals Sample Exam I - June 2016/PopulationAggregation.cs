using System;
using System.Collections.Generic;
using System.Linq;

namespace ProgrammingFundamentals
{
	class PopulationAggregation
	{
		static void Main(string[] args)
		{
			var line = Console.ReadLine();
			var contries = new SortedDictionary<string, int>();
			var cities = new Dictionary<string, long>();
			int cityCounter = 0;
			while (line != "stop")
			{
				var tokens = line.Split('\\');
				string city = "";
				string country = "";
				long population = 0;
				if (tokens[0] == tokens[0].ToLower())
				{
					city = RemoveSymbols(tokens[0]);
					country = RemoveSymbols(tokens[1]);
					population = long.Parse(tokens[2]);
				}
				else
				{
					city = RemoveSymbols(tokens[1]);
					country = RemoveSymbols(tokens[0]);
					population = long.Parse(tokens[2]);
				}

				if (!contries.ContainsKey(country))
				{
					cityCounter = 1;
					contries.Add(country, cityCounter);
				}
				else
				{
					cityCounter++;
					contries[country] = cityCounter;
				}

				if (!cities.ContainsKey(city))
				{
					cities.Add(city, population);
				}
				else
				{
					cities[city] = population;
				}

				line = Console.ReadLine();
			}

			foreach (var country in contries)
			{
				Console.WriteLine($"{country.Key} -> {country.Value}");
			}

			foreach (var city in cities.OrderByDescending(key => key.Value).Take(3))
			{
				Console.WriteLine($"{city.Key} -> {city.Value}");
			}
		}

		static string RemoveSymbols(string word)
		{
			var symbols = new char[] { '@', '#', '$', '&', '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

			var validChars = word.Split(symbols);

			return string.Join("",validChars);
		}
	}
}
