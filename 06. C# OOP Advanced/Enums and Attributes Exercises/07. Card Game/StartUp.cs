namespace _07.Card_Game
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var firstName = Console.ReadLine();
            var secondName = Console.ReadLine();

            var firstPlayer = new Player(firstName);
            var secondPlayer = new Player(secondName);
            var deck = new List<Card>();

            while (firstPlayer.Cards.Count < 5 || secondPlayer.Cards.Count < 5)
            {
                var cardInfo = Console.ReadLine()
                    .Split(new []{"of", " "}, StringSplitOptions.RemoveEmptyEntries);

                var cardRank = cardInfo[0];
                var cardSuit = cardInfo[1];

                try
                {
                    var card = new Card(cardRank, cardSuit);

                    if (firstPlayer.Cards.Count < 5)
                    {
                        if (!deck.Any(c => c.CardRank.Equals(cardRank) && c.CardSuit.Equals(cardSuit)))
                        {
                            firstPlayer.AddCard(card);
                            deck.Add(card);
                        }
                        else
                        {
                            Console.WriteLine("Card is not in the deck.");
                        }
                    }
                    else
                    {
                        if (!deck.Any(c => c.CardRank.Equals(cardRank) && c.CardSuit.Equals(cardSuit)))
                        {
                            secondPlayer.AddCard(card);
                            deck.Add(card);
                        }
                        else
                        {
                            Console.WriteLine("Card is not in the deck.");
                        }
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("No such card exists.");
                }
            }

            if (firstPlayer.GetHighestCard().GetCardPower() > secondPlayer.GetHighestCard().GetCardPower())
            {
                Console.WriteLine($"{firstPlayer.Name} wins with {firstPlayer.GetHighestCard().CardRank} of {firstPlayer.GetHighestCard().CardSuit}.");
            }
            else
            {
                Console.WriteLine($"{secondPlayer.Name} wins with {secondPlayer.GetHighestCard().CardRank} of {secondPlayer.GetHighestCard().CardSuit}.");
            }
        }
    }
}
