namespace _07.Card_Game
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public class Player : IEnumerable<Card>
    {
        private string name;
        private List<Card> cards;

        public Player(string name)
        {
            this.name = name;
            this.cards = new List<Card>();
        }

        public string Name { get { return this.name; } }

        public IList<Card> Cards
        {
            get { return this.cards.AsReadOnly(); }
        }

        public void AddCard(Card card)
        {
            this.cards.Add(card);
        }

        public Card GetHighestCard()
        {
            var orderedCards = this.cards.OrderByDescending(c => c.GetCardPower());
            return orderedCards.First();
        }

        public IEnumerator<Card> GetEnumerator()
        {
            for (int i = 0; i < this.cards.Count; i++)
            {
                yield return this.cards[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
