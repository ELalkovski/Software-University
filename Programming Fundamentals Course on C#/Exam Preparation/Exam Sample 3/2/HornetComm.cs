namespace _2
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Text.RegularExpressions;

    public class HornetComm
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            var patternForPm = @"(\d+) <-> ([\w]+|[A-Za-z]+)$";
            var patternForBroadcast = @"^([^\d]+) <-> ([\w]+|[\d]+)$";

            var privateMessageReg = new Regex(patternForPm);
            var broadcastReg = new Regex(patternForBroadcast);

            var privateMessages = new List<string>();
            var broadcasts = new List<string>();

            while (input != "Hornet is Green")
            {
                if (privateMessageReg.IsMatch(input))
                {
                    var recipement = privateMessageReg.Match(input).Groups[1].ToString();
                    var sb = new StringBuilder();
                    for (int i = recipement.Length - 1; i >= 0; i--)
                    {
                        sb.Append(recipement[i]);
                    }
                    var reversedRecipement = sb.ToString();
                    var message = privateMessageReg.Match(input).Groups[2].ToString();
                    var finalSb = new StringBuilder();
                    finalSb.Append($"{reversedRecipement} -> {message}");
                    privateMessages.Add(finalSb.ToString());

                }
                else if (broadcastReg.IsMatch(input))
                {
                    var frequency = broadcastReg.Match(input).Groups[2].Value;
                    var message = broadcastReg.Match(input).Groups[1].Value.ToString();
                    var sb = new StringBuilder();
                    for (int i = 0; i < frequency.Length; i++)
                    {
                        var currLet = frequency[i].ToString();
                        if (currLet == currLet.ToUpper())
                        {
                            currLet = currLet.ToLower();
                        }
                        else
                        {
                            currLet = currLet.ToUpper();
                        }
                        sb.Append(currLet);
                    }
                    var filteredFrequency = sb.ToString();
                    var result = new StringBuilder();
                    result.Append($"{filteredFrequency} -> {message}");
                    broadcasts.Add(result.ToString());

                }
                input = Console.ReadLine();
            }

            Console.WriteLine("Broadcasts:");
            if (broadcasts.Count <= 0)
            {
                Console.WriteLine("None");
            }
            else
            {
                foreach (var frequency in broadcasts)
                {
                    Console.WriteLine(frequency);                
                }
            }
            Console.WriteLine("Messages:");
            if (privateMessages.Count <= 0)
            {
                Console.WriteLine("None");
            }
            else
            {
                foreach (var message in privateMessages)
                {
                    Console.WriteLine(message);
                }
            }
        }
    }
}
