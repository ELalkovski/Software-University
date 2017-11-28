namespace _07.Card_Game
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

        public string CardRank { get { return this.cardRank.ToString(); } }

        public string CardSuit { get { return this.cardSuit.ToString(); } }

        public int GetCardPower()
        {
            return (int) this.cardRank + (int) this.cardSuit;
        }

        public int CompareTo(Card other)
        {
            int firstCardPower = (int) this.cardRank + (int) this.cardSuit;
            int secondCardPower = (int) other.cardRank + (int) other.cardSuit;

            return firstCardPower.CompareTo(secondCardPower);
        }

        public override string ToString()
        {
            return
                $"Card name: {this.cardRank} of {this.cardSuit}; Card power: {(int) this.cardRank + (int) this.cardSuit}";
        }
    }
}
