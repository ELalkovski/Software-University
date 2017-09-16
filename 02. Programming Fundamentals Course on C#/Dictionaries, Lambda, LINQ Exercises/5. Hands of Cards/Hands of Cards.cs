namespace _5.Hands_of_Cards
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class HandsOfCards
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            Dictionary<string, int> cardStrength = GetCardStrength();
            Dictionary<string, int> cardColor = GetCardColor();
            Dictionary<string, List<int>> handResults = new Dictionary<string, List<int>>();

            while (input != "JOKER")
            {
                string[] pieces = input.Split(':');
                string name = pieces[0];
                string[] playerCards = pieces[1].Split(", ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

                foreach (var card in playerCards)
                {
                    string strength = card.Substring(0, card.Length - 1);
                    string type = card.Substring(card.Length - 1);

                    int sum = cardStrength[strength] * cardColor[type];

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
                string name = item.Key;
                int cardSum = item.Value.Distinct().Sum();

                Console.WriteLine("{0}: {1}",name, cardSum);
            }
        }

        public static Dictionary<string, int> GetCardStrength()
        {
            Dictionary<string, int> cardStrength = new Dictionary<string, int>();

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
            Dictionary<string, int> cardColor = new Dictionary<string, int>();

            cardColor["S"] = 4;
            cardColor["H"] = 3;
            cardColor["D"] = 2;
            cardColor["C"] = 1;

            return cardColor;
        }
    }
}
