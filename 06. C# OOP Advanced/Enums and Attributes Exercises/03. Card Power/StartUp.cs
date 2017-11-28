namespace _03.Card_Power
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            string rank = Console.ReadLine();
            string suit = Console.ReadLine();
            Card card = new Card(rank, suit);

            Console.WriteLine(card);
        }
    }
}
