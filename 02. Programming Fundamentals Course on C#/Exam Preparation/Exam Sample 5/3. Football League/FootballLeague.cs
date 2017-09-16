namespace _3.Football_League
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class FootballLeague
    {
        public static void Main()
        {
            string key = Console.ReadLine();
            string input = Console.ReadLine();

            Dictionary<string, long> teamsGoals = new Dictionary<string, long>();
            Dictionary<string, int> table = new Dictionary<string, int>();

            while (input != "final")
            {
                string[] data = input.Split();
                string firstName = GetTeamName(key, data[0]);
                string secondName = GetTeamName(key, data[1]);
                string[] score = data[2].Split(':');

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

            int standingCounter = 1;

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

        private static string GetTeamName(string key, string input)
        {
            int startIndex = input.IndexOf(key) + key.Length;
            int endIndex = input.LastIndexOf(key);
            int length = endIndex - startIndex;
            string name = input.Substring(startIndex, length);

            return string.Join("", name.ToUpper().Reverse());
        }

        private static int GetFirstTeamPoints(string[] score)
        {
            int points = 0;

            if (long.Parse(score[0]) > long.Parse(score[1]))
            {
                points = 3;
            }
            else if (long.Parse(score[0]) == long.Parse(score[1]))
            {
                points = 1;
            }

            return points;
        }

        public static int GetSecondTeamPoints(string[] score)
        {
            int points = 0;

            if (long.Parse(score[0]) < long.Parse(score[1]))
            {
                points = 3;
            }
            else if (long.Parse(score[0]) == long.Parse(score[1]))
            {
                points = 1;
            }

            return points;
        }
    }
}
