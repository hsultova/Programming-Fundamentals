using System;

namespace ProgrammingFundamentals
{
	class ConvertSpeedUnits
	{
		static void Main(string[] args)
		{
			var distance = float.Parse(Console.ReadLine());
			var hours = int.Parse(Console.ReadLine());
			var minutes = int.Parse(Console.ReadLine());
			var seconds = int.Parse(Console.ReadLine());

			var timeInHours = hours + minutes / 60f + seconds / 3600f;
			var timeInSeconds = hours * 3600f + minutes * 60f + seconds;
			var speedInMetersPerSecond = distance / timeInSeconds;
			var speedInKilometersPerHour = distance / 1000f / timeInHours;
			var speedInMilesPerHour = distance / 1609f / timeInHours;

			Console.WriteLine(speedInMetersPerSecond);
			Console.WriteLine(speedInKilometersPerHour);
			Console.WriteLine(speedInMilesPerHour);
		}
	}
}