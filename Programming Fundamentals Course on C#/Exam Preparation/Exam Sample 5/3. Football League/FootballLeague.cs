namespace _3.Football_League
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class FootballLeague
    {

        public static string GetTeamName(string key, string input)
        {
            var startIndex = input.IndexOf(key) + key.Length;
            var endIndex = input.LastIndexOf(key);
            var length = endIndex - startIndex;
            string name = input.Substring(startIndex, length);
            return string.Join("", name.ToUpper().Reverse());
        }

        public static int GetFirstTeamPoints(string[] score)
        {
            var points = 0;

            if (long.Parse(score[0]) > long.Parse(score[1]))
            {
                return points = 3;
            }
            else if (long.Parse(score[0]) == long.Parse(score[1]))
            {
                return points = 1;
            }
            else
            {
                return points;
            }
        }

        public static int GetSecondTeamPoints(string[] score)
        {
            var points = 0;

            if (long.Parse(score[0]) < long.Parse(score[1]))
            {
                return points = 3;
            }
            else if (long.Parse(score[0]) == long.Parse(score[1]))
            {
                return points = 1;
            }
            else
            {
                return points;
            }
        }

        public static void Main()
        {
            var key = Console.ReadLine();
            var input = Console.ReadLine();

            var teamsGoals = new Dictionary<string, long>();
            var table = new Dictionary<string, int>();

            while (input != "final")
            {
                var data = input.Split();
                var firstName = GetTeamName(key, data[0]);
                var secondName = GetTeamName(key, data[1]);
                var score = data[2].Split(':');

                if (!table.ContainsKey(firstName))
                {
                    teamsGoals.Add(firstName, long.Parse(score[0]));
                    table.Add(firstName, GetFirstTeamPoints(score));
                }
                else
                {
                    teamsGoals[firstName] += long.Parse(score[0]);
                    table[firstName] += GetFirstTeamPoints(score);
                }

                if (!table.ContainsKey(secondName))
                {
                    teamsGoals.Add(secondName, long.Parse(score[1]));
                    table.Add(secondName, GetSecondTeamPoints(score));
                }
                else
                {
                    teamsGoals[secondName] += long.Parse(score[1]);
                    table[secondName] += GetSecondTeamPoints(score);
                }
                input = Console.ReadLine();
            }
            var standingCounter = 1;
            Console.WriteLine("League standings:");
            foreach (var team in table.OrderByDescending(t => t.Value).ThenBy(t => t.Key))
            {
                Console.WriteLine($"{standingCounter}. {team.Key} {team.Value}");
                standingCounter++;
            }

            Console.WriteLine("Top 3 scored goals:");
            foreach (var team in teamsGoals.OrderByDescending(t => t.Value).ThenBy(t => t.Key).Take(3))
            {
                Console.WriteLine($"- {team.Key} -> {team.Value}");
            }
        }
    }
}
