namespace _4.Cubic_Messages
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Text.RegularExpressions;

    public class CubicMessages
    {
        public static void Main()
        {
            string inputMessage = Console.ReadLine();
            Dictionary<string, string> validfMessages = new Dictionary<string, string>();

            while (inputMessage != "Over!")
            {
                int num = int.Parse(Console.ReadLine());
                Regex regex = new Regex(@"^(\d+)([a-zA-Z]{" + num + @"})([^a-zA-Z]*)$");
                StringBuilder message = new StringBuilder();
                StringBuilder indices = new StringBuilder();

                if (regex.IsMatch(inputMessage))
                {
                    Match match = regex.Match(inputMessage);
                    indices.Append(match.Groups[1].Value);
                    message.Append(match.Groups[2].Value);
                    indices.Append(match.Groups[3].Value);
                    validfMessages.Add(message.ToString(), indices.ToString());
                }

                inputMessage = Console.ReadLine();              
            }

            Regex digitReg = new Regex(@"[0-9]");

            foreach (var message in validfMessages)
            {
                int length = message.Key.Length - 1;
                StringBuilder results = new StringBuilder();
               
                Console.Write($"{message.Key} == ");

                for (int i = 0; i < message.Value.Length; i++)
                {
                    if (digitReg.IsMatch(message.Value[i].ToString()))
                    {
                        var currIndex = int.Parse(message.Value[i].ToString());

                        if (currIndex >= 0 && currIndex <= length)
                        {
                            results.Append(message.Key[currIndex]);
                        }
                        else
                        {
                            results.Append(" ");
                        }
                    }
                    else
                    {
                        var currIndex = (int)message.Value[i];

                        if (currIndex >= 0 && currIndex <= length)
                        {
                            results.Append(message.Key[currIndex]);
                        }
                        else
                        {
                            results.Append(" ");
                        }
                    }
                    
                }
                             
                Console.Write(results.ToString());
                Console.WriteLine();
            }
        }
    }
}
