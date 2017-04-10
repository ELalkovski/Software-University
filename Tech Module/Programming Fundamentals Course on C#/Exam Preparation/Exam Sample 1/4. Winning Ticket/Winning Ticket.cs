namespace _4.Winning_Ticket
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;


    public class WinningTicket
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(',');
            var regex = new Regex(@"\${6,10}|@{6,10}|\^{6,10}|#{6,10}");

            foreach (var item in input)
            {
                var currTicket = item.Trim();

                if (currTicket.Length == 20)
                {
                    var leftHalf = currTicket.Substring(0,10);
                    var rightHalf = currTicket.Substring(10, 10);

                    if (regex.IsMatch(leftHalf) && regex.IsMatch(rightHalf))
                    {
                        var minLength = Math.Min(regex.Match(leftHalf).Length, regex.Match(rightHalf).Length);
                        var singleMatch = regex.Match(currTicket);

                        if (minLength >= 6 && minLength <= 9)
                        {
                            var symbol = singleMatch.ToString().Substring(0, 1);
                            Console.WriteLine($"ticket \"{currTicket}\" - {minLength}{symbol}");
                        }
                        else if (minLength == 10)
                        {
                            var symbol = singleMatch.ToString().Substring(0, 1);
                            Console.WriteLine($"ticket \"{currTicket}\" - {minLength}{symbol} Jackpot!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("ticket \"{0}\" - no match", currTicket);
                    }
                }
                else
                {
                    Console.WriteLine("invalid ticket");
                }

            }
        }
    }
}
