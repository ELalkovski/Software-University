namespace _02.Card_Rank
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            Console.WriteLine(input + ":");

            foreach (var card in Enum.GetValues(typeof(CardRank)))
            {
                Console.WriteLine($"Ordinal value: {(int)card}; Name value: {card}");
            }
        }
    }
}
