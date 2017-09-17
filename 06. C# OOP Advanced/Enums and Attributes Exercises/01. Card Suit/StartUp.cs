namespace _01.Card_Suit
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            Console.WriteLine(input + ":");

            foreach (var card in Enum.GetValues(typeof(Suit)))
            {
                Console.WriteLine($"Ordinal value: {(int)card}; Name value: {card}");
            }
        }
    }
}
