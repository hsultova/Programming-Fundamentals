using System;
using System.Collections.Generic;
using System.Linq;

namespace ProgrammingFundamentals
{
	class Program
	{
		static void Main(string[] args)
		{
			var key = Console.ReadLine();
			var teamPoints = new Dictionary<string, int>();
			var teamGoals = new Dictionary<string, int>();
			while (true)
			{
				var line = Console.ReadLine();

				if (line == "final")
				{
					break;
				}

				var tokens = line.Split(' ');
				var teamA = DecryptTeam(tokens[0], key);
				var teamB = DecryptTeam(tokens[1], key);
				var score = tokens[2].Split(':').Select(int.Parse).ToArray();
				var scoreA = score[0];
				var scoreB = score[1];

				if (scoreA > scoreB)
				{
					AddPoints(teamPoints, teamA, teamB, 3, 0);
				}
				else if (scoreA < scoreB)
				{
					AddPoints(teamPoints, teamA, teamB, 0, 3);
				}
				else if (scoreA == scoreB)
				{
					AddPoints(teamPoints, teamA, teamB, 1, 1);
				}

				AddPoints(teamGoals, teamA, teamB, scoreA, scoreB);
			}

			Console.WriteLine("League standings:");
			int place = 1;
			foreach (var team in teamPoints.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
			{
				Console.WriteLine($"{place}. {team.Key} {team.Value}");
				place++;
			}

			Console.WriteLine("Top 3 scored goals:");
			foreach (var team in teamGoals.OrderByDescending(x => x.Value).ThenBy(x => x.Key).Take(3))
			{
				Console.WriteLine($"- {team.Key} -> {team.Value}");

			}
		}

		static string DecryptTeam(string team, string key)
		{
			string decryptedTeam = team.Split(new string[] { key }, StringSplitOptions.None)[1].ToUpper();
			decryptedTeam = string.Join("", decryptedTeam.Reverse());
			return decryptedTeam;
		}

		static void AddPoints(Dictionary<string, int> teamPoints, string teamA, string teamB, int pointsTeamA, int pointsTeamB)
		{
			if (teamPoints.ContainsKey(teamA))
			{
				teamPoints[teamA] += pointsTeamA;
			}
			else
			{
				teamPoints.Add(teamA, pointsTeamA);
			}

			if (teamPoints.ContainsKey(teamB))
			{
				teamPoints[teamB] += pointsTeamB;
			}
			else
			{
				teamPoints.Add(teamB, pointsTeamB);
			}
		}
	}
}
