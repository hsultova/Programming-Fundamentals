using System;

namespace ProgrammingFundamentals
{
	class EmployeeData
	{
		static void Main(string[] args)
		{
			var firstName = Console.ReadLine();
			var lastName = Console.ReadLine();
			var age = int.Parse(Console.ReadLine());
			var gender = char.Parse(Console.ReadLine());
			var personalID = long.Parse(Console.ReadLine());
			var UniqueNumber = long.Parse(Console.ReadLine());

			PrintInformation("First name", firstName);
			PrintInformation("Last name", lastName);
			PrintInformation("Age", age.ToString());
			PrintInformation("Gender", gender.ToString());
			PrintInformation("Personal ID", personalID.ToString());
			PrintInformation("Unique Employee number", UniqueNumber.ToString());
		}

		static void PrintInformation(string text, string value)
		{
			Console.WriteLine(text + ": " + value);
		}
	}
}
