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
            var inputMessage = Console.ReadLine();
            

            var validfMessages = new Dictionary<string, string>();

            while (inputMessage != "Over!")
            {
                var num = int.Parse(Console.ReadLine());
                var regex = new Regex(@"^(\d+)([a-zA-Z]{" + num + @"})([^a-zA-Z]*)$");
                var message = new StringBuilder();
                var indices = new StringBuilder();

                if (regex.IsMatch(inputMessage))
                {
                    var match = regex.Match(inputMessage);
                    indices.Append(match.Groups[1].Value);
                    message.Append(match.Groups[2].Value);
                    indices.Append(match.Groups[3].Value);
                    validfMessages.Add(message.ToString(), indices.ToString());
                }

                inputMessage = Console.ReadLine();              
            }
            var digitReg = new Regex(@"[0-9]");

            foreach (var message in validfMessages)
            {
                var length = message.Key.Length - 1;
                var results = new StringBuilder();
               
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
