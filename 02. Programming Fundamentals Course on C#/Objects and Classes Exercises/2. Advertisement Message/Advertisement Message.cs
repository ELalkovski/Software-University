namespace _2.Advertisement_Message
{
    using System;

    public class AdvMessage
    {
        public static void Main()
        {
            int messageCount = int.Parse(Console.ReadLine());

            string[] phrases = { "Excellent product.", "Such a great product.", "I always use that product."
                    , "Best product of its category.", "Exceptional product.", "I can’t live without this product."};

            string[] events = {"Now I feel good.", "I have succeeded with this product."
                    , "Makes miracles.I am happy of the results!", "I cannot believe but now I feel awesome."
                    , "Try it yourself, I am very satisfied.", "I feel great!"};

            string[] author = { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };

            string[] city = {"Burgas", "Sofia", "Plovdiv", "Varna", "Ruse"};

            Random random = new Random();

            for (int i = 0; i < messageCount; i++)
            {
                int phraseIndex = random.Next(0, phrases.Length);
                int eventsIndex = random.Next(0, events.Length);
                int authorIndex = random.Next(0, author.Length);
                int cityIndex = random.Next(0, city.Length);

                Console.WriteLine("{0} {1} {2} - {3}", phrases[phraseIndex], events[eventsIndex]
                    , author[authorIndex], city[cityIndex]);
            }
        }
    }
}
