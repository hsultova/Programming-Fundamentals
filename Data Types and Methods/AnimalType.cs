using System;

namespace ProgrammingFundamentals
{
	class AnimalType
	{
		static void Main(string[] args)
		{
			string animal = Console.ReadLine();
			string type = "";

			bool isMammal = animal == "dog";
			bool isReptile = animal == "crocodile" || animal == "tortoise" || animal == "snake";

			if (isMammal)
			{
				type = "mammal";
			}
			else if (isReptile)
			{
				type = "reptile";
			}
			else
			{
				type = "unknown";
			}

			Console.WriteLine(type);
		}
	}
}
