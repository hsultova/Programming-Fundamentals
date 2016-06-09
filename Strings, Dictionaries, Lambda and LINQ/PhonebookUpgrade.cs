using System;
using System.Collections.Generic;

namespace ProgrammingFundamentals
{
	class PhonebookUpgrade
	{
		static void Main(string[] args)
		{
			var line = Console.ReadLine();
			var phonebook = new SortedDictionary<string, string>();
			while (line != "END")
			{
				var tokens = line.Split(' ');
				string command = tokens[0];


				if (command == "A")
				{
					string name = tokens[1];
					string phone = tokens[2];
					if (!phonebook.ContainsKey(name))
					{
						phonebook.Add(name, phone);
					}
					else
					{
						phonebook[name] = phone;
					}
				}
				else if (command == "S")
				{
					string name = tokens[1];
					if (phonebook.ContainsKey(name))
					{
						Console.WriteLine($"{name} -> {phonebook[name]}");
					}
					else
					{
						Console.WriteLine($"Contact {name} does not exist.");
					}
				}
				else if (command == "ListAll")
				{
					foreach (var record in phonebook)
					{
						Console.WriteLine($"{record.Key} -> {record.Value}");
					}
				}
				line = Console.ReadLine();
			}
		}
	}
}