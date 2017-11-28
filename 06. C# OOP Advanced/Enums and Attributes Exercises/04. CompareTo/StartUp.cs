namespace _04.CompareTo
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            string rank = Console.ReadLine();
            string suit = Console.ReadLine();
            Card firstCard = new Card(rank, suit);

            rank = Console.ReadLine();
            suit = Console.ReadLine();

            Card secondCard = new Card(rank, suit);

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
