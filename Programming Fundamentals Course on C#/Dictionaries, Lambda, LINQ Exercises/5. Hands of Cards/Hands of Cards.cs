namespace _5.Hands_of_Cards
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class HandsOfCards
    {
        public static Dictionary<string, int> GetCardStrength()
        {
            var cardStrength = new Dictionary<string, int>();

            for (int i = 2; i <= 10; i++)
            {
                cardStrength[i.ToString()] = i;
            }

            cardStrength["J"] = 11;
            cardStrength["Q"] = 12;
            cardStrength["K"] = 13;
            cardStrength["A"] = 14;

            return cardStrength;
        }

        public static Dictionary<string, int> GetCardColor()
        {
            var cardColor = new Dictionary<string, int>();

            cardColor["S"] = 4;
            cardColor["H"] = 3;
            cardColor["D"] = 2;
            cardColor["C"] = 1;

            return cardColor;
        }

        public static void Main()
        {
            var input = Console.ReadLine();

            var cardStrength = GetCardStrength();
            var cardColor = GetCardColor();
            var handResults = new Dictionary<string, List<int>>();


            while (input != "JOKER")
            {
                var pieces = input.Split(':');
                var name = pieces[0];
                var playerCards = pieces[1].Split(", ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

                foreach (var card in playerCards)
                {
                    var strength = card.Substring(0, card.Length - 1);
                    var type = card.Substring(card.Length - 1);

                    var sum = cardStrength[strength] * cardColor[type];

                    if (!handResults.ContainsKey(name))
                    {
                        handResults[name] = new List<int>();
                    }

                    handResults[name].Add(sum); 
                }

                input = Console.ReadLine();
            }

            foreach (var item in handResults)
            {
                var name = item.Key;
                var cardSum = item.Value.Distinct().Sum();

                Console.WriteLine("{0}: {1}",name, cardSum);
            }

        }
    }
}
