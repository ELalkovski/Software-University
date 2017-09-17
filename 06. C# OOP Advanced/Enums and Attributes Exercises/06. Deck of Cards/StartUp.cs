namespace _06.Deck_of_Cards
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            foreach (var suit in Enum.GetValues(typeof(Suit)))
            {
                foreach (var rank in Enum.GetValues(typeof(Rank)))
                {
                    Console.WriteLine($"{rank} of {suit}");
                }
            }
        }
    }
}
