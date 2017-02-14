namespace _2.Advertisement_Message
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class AdvMessage
    {
        public static void Main()
        {
            var messageCount = int.Parse(Console.ReadLine());

            string[] phrases = { "Excellent product.", "Such a great product.", "I always use that product."
                    , "Best product of its category.", "Exceptional product.", "I can’t live without this product."};

            string[] events = {"Now I feel good.", "I have succeeded with this product."
                    , "Makes miracles.I am happy of the results!", "I cannot believe but now I feel awesome."
                    , "Try it yourself, I am very satisfied.", "I feel great!"};

            string[] author = { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };

            string[] city = {"Burgas", "Sofia", "Plovdiv", "Varna", "Ruse"};

            var random = new Random();

            for (int i = 0; i < messageCount; i++)
            {
                var phraseIndex = random.Next(0, phrases.Length);
                var eventsIndex = random.Next(0, events.Length);
                var authorIndex = random.Next(0, author.Length);
                var cityIndex = random.Next(0, city.Length);

                Console.WriteLine("{0} {1} {2} - {3}", phrases[phraseIndex], events[eventsIndex]
                    , author[authorIndex], city[cityIndex]);
            }

        }
    }
}
