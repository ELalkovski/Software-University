namespace _4.Winning_Ticket
{
    using System;
    using System.Text.RegularExpressions;

    public class WinningTicket
    {
        public static void Main()
        {
            string[] input = Console.ReadLine().Split(',');
            Regex regex = new Regex(@"\${6,10}|@{6,10}|\^{6,10}|#{6,10}");

            foreach (var item in input)
            {
                string currTicket = item.Trim();

                if (currTicket.Length == 20)
                {
                    string leftHalf = currTicket.Substring(0,10);
                    string rightHalf = currTicket.Substring(10, 10);

                    if (regex.IsMatch(leftHalf) && regex.IsMatch(rightHalf))
                    {
                        int minLength = Math.Min(regex.Match(leftHalf).Length, regex.Match(rightHalf).Length);
                        Match singleMatch = regex.Match(currTicket);

                        if (minLength >= 6 && minLength <= 9)
                        {
                            string symbol = singleMatch.ToString().Substring(0, 1);
                            Console.WriteLine($"ticket \"{currTicket}\" - {minLength}{symbol}");
                        }
                        else if (minLength == 10)
                        {
                            string symbol = singleMatch.ToString().Substring(0, 1);
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
