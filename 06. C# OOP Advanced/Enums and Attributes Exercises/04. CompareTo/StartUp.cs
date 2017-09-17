namespace _04.CompareTo
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var rank = Console.ReadLine();
            var suit = Console.ReadLine();
            var firstCard = new Card(rank, suit);

            rank = Console.ReadLine();
            suit = Console.ReadLine();
            var secondCard = new Card(rank, suit);

            if (firstCard.CompareTo(secondCard) == 1)
            {
                Console.WriteLine(firstCard.ToString());
            }
            else
            {
                Console.WriteLine(secondCard);
            }
        }
    }
}
