namespace _08.Hands_of_cards
{
    using System;
    using System.Collections.Generic;

    public class HandsOfCards
    {
        public static void Main()
        {
            /*
             The input is separate lines in the format:
                {personName}: {PT, PT, PT,… PT}
                Where P (2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K, A) is the power of the card 
                and T (S, H, D, C) is the type. The input ends when a "JOKER" is drawn.
                A single person cannot have more than one card with the same power and type, if he draws such a card he discards it. 
                The people are playing with multiple decks. 
                Each card has a value that is calculated by the power multiplied by the type. 
                Powers 2 to 10 have the same value and J to A are 11 to 14. 
                Types are mapped to multipliers in the following way (S -> 4, H-> 3, D -> 2, C -> 1).
             */

            var input = Console.ReadLine()
                .Split(new char []{':', ','}, StringSplitOptions.RemoveEmptyEntries);

            var playerPoints = new Dictionary<string, HashSet<string>>();

            while (input[0] != "JOKER")
            {
                var name = input[0];
                var currCards = new HashSet<string>();             

                for (int i = 1; i < input.Length; i++)
                {
                    currCards.Add(input[i]);
                }              

                if (!playerPoints.ContainsKey(name))
                {
                    playerPoints.Add(name, currCards);
                }
                else
                {
                    playerPoints[name].UnionWith(currCards);
                }

                input = Console.ReadLine()
                    .Split(new char[] { ':', ',' }, StringSplitOptions.RemoveEmptyEntries);
            }

            foreach (var player in playerPoints)
            {
                var currPlayerPoints = CalculatePoints(player.Value);
                Console.WriteLine($"{player.Key}: {currPlayerPoints}");
            }
        }

        private static int CalculatePoints(HashSet<string> playerCards)
        {
            var summedPoints = 0;

            foreach (var card in playerCards)
            {
                var cardPower = 0;
                var cardType = 0;

                foreach (char symbol in card)
                {
                    switch (symbol)
                    {
                        case '1':
                            cardPower = 10;
                            break;

                        case '2':
                            cardPower = 2;
                            break;

                        case '3':
                            cardPower = 3;
                            break;

                        case '4':
                            cardPower = 4;
                            break;

                        case '5':
                            cardPower = 5;
                            break;

                        case '6':
                            cardPower = 6;
                            break;

                        case '7':
                            cardPower = 7;
                            break;

                        case '8':
                            cardPower = 8;
                            break;

                        case '9':
                            cardPower = 9;
                            break;

                        case 'J':
                            cardPower = 11;
                            break;

                        case 'Q':
                            cardPower = 12;
                            break;

                        case 'K':
                            cardPower = 13;
                            break;

                        case 'A':
                            cardPower = 14;
                            break;

                        case 'S':
                            cardType = 4;
                            break;

                        case 'H':
                            cardType = 3;
                            break;

                        case 'D':
                            cardType = 2;
                            break;

                        case 'C':
                            cardType = 1;
                            break;
                    }
                }
                summedPoints += (cardPower * cardType);
            }
            return summedPoints;
        }
    }
}
