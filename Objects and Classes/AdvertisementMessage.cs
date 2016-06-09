using System;

namespace ProgrammingFundamentals
{
	class AdvertisementMessage
	{
		static void Main(string[] args)
		{
			var n = int.Parse(Console.ReadLine());

			var phrases = new string[] { "Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can’t live without this product." };
			var events = new string[] { "Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!" };
			var authors = new string[] { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };
			var towns = new string[] { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

			Random random = new Random();
			var phraseIndex = 0;
			var eventIndex = 0;
			var authorIndex = 0;
			var townIndex = 0;

			for (int i = 0; i < n; i++)
			{
				phraseIndex = random.Next(0, phrases.Length);
				eventIndex = random.Next(0, events.Length);
				authorIndex = random.Next(0, authors.Length);
				townIndex = random.Next(0, towns.Length);
				Console.WriteLine($"{phrases[phraseIndex]} {events[eventIndex]} {authors[authorIndex]} - {towns[townIndex]}");
			}
		}
	}
}
