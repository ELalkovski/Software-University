﻿namespace _6.Fix_Emails
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.IO;

    public class FixEmails
    {
        public static void Main()
        {
            string[] input = File.ReadAllLines("input.txt");
            List<string> names = new List<string>();
            List<string> emails = new List<string>();
            Dictionary<string, string> results = new Dictionary<string, string>();
            int lineCounter = 0;

            foreach (var item in input)
            {
                if (item == "stop")
                {
                    break;
                }
                if (lineCounter == 0 || lineCounter % 2 == 0)
                {
                    names.Add(item);
                }
                else
                {
                    emails.Add(item);
                }

                lineCounter++;
            }

            for (int i = 0; i < names.Count; i++)
            {
                var domain = emails[i]
                    .ToLower()
                    .Split('.')
                    .ToArray();

                if (domain[1] != "us" && domain[1] != "uk")
                {
                    results.Add(names[i], emails[i]);
                }
            }

            foreach (var name in results)
            {
                Console.WriteLine("{0} -> {1}", name.Key, name.Value);
                File.AppendAllText("output.txt", name.Key + " -> " + name.Value + Environment.NewLine);
            }
        }
    }
}
