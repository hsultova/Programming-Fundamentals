using System;
using System.Linq;

namespace ProgrammingFundamentals
{
	class EmailCensored
	{
		static void Main(string[] args)
		{
			var email = Console.ReadLine();
			var text = Console.ReadLine();
			var partToReplace = email.Split('@')[0];
			var domain = email.Split('@')[1];
			var censoredEmail = new string('*', partToReplace.Length) + '@' + domain;

			text = text.Replace(email, censoredEmail);
			Console.WriteLine(text);
		}
	}
}