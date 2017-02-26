using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Roli___The_Coder
{
   
    public class RoliTheCoder
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            var allEvents = new Dictionary<int, Event>();

            while (input != "Time for Code")
            {
                if (input.Contains("#"))
                {
                    var data = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                    var id = int.Parse(data[0]);
                    var eventName = data[1].Replace("#","");

                    var eachEvent = new Event();
                    var participants = new HashSet<string>();

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
