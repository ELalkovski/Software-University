using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace _7.Advertisement_Message
{
    class AdvertisementMessage
    {
        public static void Main()
        {
            var input = File.ReadAllLines("Input.txt");
            var phrases = input[0]
                .Split(',')
                .ToArray();

            var events = input[1]
                .Split(',')
                .ToArray();

            var authors = input[2]
                .Split(',')
                .ToArray();

            var cities = input[3]
                .Split(',')
                .ToArray();

            var random = new Random();

            var messagesNeeded = int.Parse(Console.ReadLine());

            for (int i = 0; i < messagesNeeded; i++)
            {
                var phraseIndex = random.Next(0, phrases.Length);
                var eventIndex = random.Next(0, events.Length);
                var authorIndex = random.Next(0, authors.Length);
                var cityIndex = random.Next(0, cities.Length);

                Console.WriteLine("{0}{1}{2} -{3}"
                    ,phrases[phraseIndex], events[eventIndex], authors[authorIndex], cities[cityIndex]);
                File.AppendAllText("output.txt", phrases[phraseIndex]
                    + " " + events[eventIndex] + " " + authors[authorIndex] + " - " + cities[cityIndex] + Environment.NewLine);
            }

        }
    }
}
