using System;
using System.Linq;

namespace ProgrammingFundamentals
{
	class UrlParser
	{
		static void Main(string[] args)
		{
			var url = Console.ReadLine().Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries);
			var protocol = "";
			var server = "";
			var resource = "";
			if (url[0].Contains(":"))
			{
				protocol = url[0].Replace(":", "");
				server = url[1];
			}
			else
			{
				server = url[0];
			}

			for (int i = 2; i < url.Length; i++)
			{
				if (i == url.Length - 1)
				{
					resource += url[i];
				}
				else
				{
					resource += url[i] + "/";
				}
			}
			Console.WriteLine("[protocol] = \"{0}\"", protocol);
			Console.WriteLine("[server] = \"{0}\"", server);
			Console.WriteLine("[resource] = \"{0}\"", resource);
		}
	}
}