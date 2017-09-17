namespace _03.Card_Power
{
    using System;

    public class Card
    {
        private Rank cardRank;
        private Suit cardSuit;

        public Card(string cardRank, string cardSuit)
        {
            this.cardRank = (Rank) Enum.Parse(typeof(Rank), cardRank);
            this.cardSuit = (Suit) Enum.Parse(typeof(Suit), cardSuit);
        }

        public override string ToString()
        {
            return
                $"Card name: {this.cardRank} of {this.cardSuit}; Card power: {(int) this.cardRank + (int) this.cardSuit}";
        }
    }
}
