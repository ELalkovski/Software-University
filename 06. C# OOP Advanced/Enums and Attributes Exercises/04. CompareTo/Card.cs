namespace _04.CompareTo
{
    using System;

    public class Card : IComparable<Card>
    {
        private Rank cardRank;
        private Suit cardSuit;

        public Card(string cardRank, string cardSuit)
        {
            this.cardRank = (Rank) Enum.Parse(typeof(Rank), cardRank);
            this.cardSuit = (Suit) Enum.Parse(typeof(Suit), cardSuit);
        }

        public int CompareTo(Card other)
        {
            var firstCardPower = (int) this.cardRank + (int) this.cardSuit;
            var secondCardPower = (int) other.cardRank + (int) other.cardSuit;

            return firstCardPower.CompareTo(secondCardPower);
        }

        public override string ToString()
        {
            return
                $"Card name: {this.cardRank} of {this.cardSuit}; Card power: {(int) this.cardRank + (int) this.cardSuit}";
        }
    }
}
