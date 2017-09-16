namespace _7.Advertisement_Message
{
    using System;
    using System.Linq;
    using System.IO;

    public class AdvertisementMessage
    {
        public static void Main()
        {
            string[] input = File.ReadAllLines("Input.txt");

            string[] phrases = input[0]
                .Split(',')
                .ToArray();

            string[] events = input[1]
                .Split(',')
                .ToArray();

            string[] authors = input[2]
                .Split(',')
                .ToArray();

            string[] cities = input[3]
                .Split(',')
                .ToArray();

            Random random = new Random();

            int messagesNeeded = int.Parse(Console.ReadLine());

            for (int i = 0; i < messagesNeeded; i++)
            {
                int phraseIndex = random.Next(0, phrases.Length);
                int eventIndex = random.Next(0, events.Length);
                int authorIndex = random.Next(0, authors.Length);
                int cityIndex = random.Next(0, cities.Length);

                Console.WriteLine("{0}{1}{2} -{3}"
                    ,phrases[phraseIndex], events[eventIndex], authors[authorIndex], cities[cityIndex]);
                File.AppendAllText("output.txt", phrases[phraseIndex]
                    + " " + events[eventIndex] + " " + authors[authorIndex] + " - " + cities[cityIndex] + Environment.NewLine);
            }
        }
    }
}
