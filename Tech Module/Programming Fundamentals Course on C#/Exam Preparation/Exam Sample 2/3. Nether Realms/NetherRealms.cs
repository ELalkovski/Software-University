namespace _3.Nether_Realms
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;

    public class NetherRealms
    {
        public static void Main()
        {
            var names = Console.ReadLine()
                .Split(new[] { ' ', ',', '\t'},StringSplitOptions.RemoveEmptyEntries)
                .OrderBy(n => n)
                .ToList();

            var healthPattern = new Regex(@"[^\d\.\+\-\*\/\s\,]");
            var damagePattern = new Regex(@"[\-\+]?[\d]+(?:[\.]*[\d]+|[\d]*)");
            var multiplierOrDivider = new Regex(@"\*|\/");

            var demonsProperties = new Dictionary<int, double>();

            for (int i = 0; i < names.Count; i++)
            {
                var letterMatches = healthPattern.Matches(names[i]);
                var digitMatches = damagePattern.Matches(names[i]);
                var finalActionsMatches = multiplierOrDivider.Matches(names[i]);
                var health = 0;
                double damage = 0;

                var demonsTemp = new Dictionary<int, double>();

                for (int j = 0; j < letterMatches.Count; j++)
                {
                    var currLet = (int)(letterMatches[j].ToString().ElementAt(0));
                    health += currLet;
                }
                for (int d = 0; d < digitMatches.Count; d++)
                {
                    var currDigit = double.Parse(digitMatches[d].ToString());
                    damage += currDigit;
                }
                for (int g = 0; g < finalActionsMatches.Count; g++)
                {
                    var currSymbol = finalActionsMatches[g].ToString();
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

            var nameCounter = 0;
            foreach (var demon in demonsProperties)
            {
                Console.WriteLine($"{names[nameCounter]} - {demon.Key} health, {demon.Value:f2} damage");
                nameCounter++;
            }
        }
    }
}
