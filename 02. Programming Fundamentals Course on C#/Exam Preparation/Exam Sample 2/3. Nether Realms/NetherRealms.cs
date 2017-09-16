namespace _3.Nether_Realms
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class NetherRealms
    {
        public static void Main()
        {
            List<string> names = Console.ReadLine()
                .Split(new[] { ' ', ',', '\t'},StringSplitOptions.RemoveEmptyEntries)
                .OrderBy(n => n)
                .ToList();

            Regex healthPattern = new Regex(@"[^\d\.\+\-\*\/\s\,]");
            Regex damagePattern = new Regex(@"[\-\+]?[\d]+(?:[\.]*[\d]+|[\d]*)");
            Regex multiplierOrDivider = new Regex(@"\*|\/");

            Dictionary<int, double> demonsProperties = new Dictionary<int, double>();

            for (int i = 0; i < names.Count; i++)
            {
                MatchCollection letterMatches = healthPattern.Matches(names[i]);
                MatchCollection digitMatches = damagePattern.Matches(names[i]);
                MatchCollection finalActionsMatches = multiplierOrDivider.Matches(names[i]);

                int health = 0;
                double damage = 0;

                for (int j = 0; j < letterMatches.Count; j++)
                {
                    int currLet = (int)(letterMatches[j].ToString().ElementAt(0));

                    health += currLet;
                }
                for (int d = 0; d < digitMatches.Count; d++)
                {
                    double currDigit = double.Parse(digitMatches[d].ToString());

                    damage += currDigit;
                }
                for (int g = 0; g < finalActionsMatches.Count; g++)
                {
                    string currSymbol = finalActionsMatches[g].ToString();

                    if (currSymbol == "*")
                    {
                        damage *= 2;
                    }
                    else
                    {
                        damage /= 2;
                    }
                }

                demonsProperties.Add(health, damage);
            }

            int nameCounter = 0;

            foreach (var demon in demonsProperties)
            {
                Console.WriteLine($"{names[nameCounter]} - {demon.Key} health, {demon.Value:f2} damage");
                nameCounter++;
            }
        }
    }
}
