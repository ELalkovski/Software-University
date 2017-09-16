namespace _4.Roli___The_Coder
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class RoliTheCoder
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            Dictionary<int, Event> allEvents = new Dictionary<int, Event>();

            while (input != "Time for Code")
            {
                if (input.Contains("#"))
                {
                    string[] data = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                    int id = int.Parse(data[0]);
                    string eventName = data[1].Replace("#","");

                    Event eachEvent = new Event();
                    HashSet<string> participants = new HashSet<string>();

                    for (int i = 2; i < data.Length; i++)
                    {
                        participants.Add(data[i]);
                    }

                    if (!allEvents.ContainsKey(id))
                    {
                        eachEvent.Name = eventName;
                        eachEvent.Participants = participants;

                        allEvents.Add(id, eachEvent);
                    }

                    else
                    {
                        if (allEvents[id].Name == eventName)
                        {
                            allEvents[id].Participants.UnionWith(participants);
                        }
                    }

                }

                input = Console.ReadLine();
            }

            foreach (var id in allEvents.OrderByDescending(p => p.Value.Participants.Count).ThenBy(n => n.Value.Name))
            {
                Console.WriteLine($"{id.Value.Name} - {id.Value.Participants.Count}");

                foreach (var participant in id.Value.Participants.OrderBy(p => p))
                {
                    Console.WriteLine(participant);
                }
            }
        }
    }
}
