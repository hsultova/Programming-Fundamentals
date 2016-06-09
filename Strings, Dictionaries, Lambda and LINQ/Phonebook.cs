using System;
using System.Collections.Generic;

namespace ProgrammingFundamentals
{
	class Phonebook
	{
		static void Main(string[] args)
		{
			var line = Console.ReadLine();
			var phonebook = new Dictionary<string, string>();
			while (line != "END")
			{
				var tokens = line.Split(' ');
				char command = char.Parse(tokens[0]);
				string name = tokens[1];

				if (command == 'A')
				{
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
				else if (command == 'S')
				{
					if (phonebook.ContainsKey(name))
					{
						Console.WriteLine($"{name} -> {phonebook[name]}");
					}
					else
					{
						Console.WriteLine($"Contact {name} does not exist.");
					}
				}
				line = Console.ReadLine();
			}
		}
	}
}