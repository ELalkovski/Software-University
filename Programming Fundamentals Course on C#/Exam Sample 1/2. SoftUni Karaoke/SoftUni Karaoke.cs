namespace _2.SoftUni_Karaoke
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;

    public class Karaoke
    {
        public static void Main()
        {
            var participants = Console.ReadLine()
                .Split(new[] { ", " },StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            var availableSongs = Console.ReadLine()
                .Split(new[] { ", "},StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            var rewardedParticipants = new Dictionary<string, HashSet<string>>();

            var input = Console.ReadLine();

            while (input != "dawn")
            {
                var performanceData = input.Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                var performer = performanceData[0];
                var song = performanceData[1];
                var reward = performanceData[2];
                var rewardsList = new HashSet<string>();

                if (participants.Contains(performer) && availableSongs.Contains(song))
                {
                    if (!rewardedParticipants.ContainsKey(performer))
                    {
                        rewardsList.Add(reward);
                        rewardedParticipants.Add(performer, rewardsList);
                    }
                    else
                    {
                        rewardedParticipants[performer].Add(reward);
                    }
                }
                input = Console.ReadLine();
            }

            if (rewardedParticipants.Keys.Count <= 0)
            {
                Console.WriteLine("No awards");
            }
            else
            {
                foreach (var participant in rewardedParticipants.OrderByDescending(p => p.Value.Count).ThenBy(p => p.Key))
                {
                    Console.WriteLine($"{participant.Key}: {participant.Value.Count} awards");
                    foreach (var reward in participant.Value.OrderBy(r => r))
                    {
                        Console.WriteLine($"--{reward}");
                    }
                }
            }          
        }
    }
}
