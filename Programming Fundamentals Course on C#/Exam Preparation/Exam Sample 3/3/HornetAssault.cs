namespace _3
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class HornetAssault
    {
        public static void Main()
        {
            var beehive = Console.ReadLine()
                .Split(' ')
                .Select(long.Parse)
                .ToList();

            var hornets = Console.ReadLine()
                .Split(' ')
                .Select(long.Parse)
                .ToList();


            for (int i = 0; i < beehive.Count; i++)
            {
                var powerHornets = hornets.Sum();

                if (powerHornets > beehive[i])
                {
                    beehive.RemoveAt(i);
                    i -= 1;             
                }
                else
                {
                    var diff = beehive[i] - powerHornets;
                    if (diff > 0)
                    {
                        beehive[i] = diff;
                    }
                    else
                    {
                        beehive.RemoveAt(i);
                        i -= 1;
                    }
                    hornets.RemoveAt(0);
                }
                if (beehive.Count <= 0 || hornets.Count <= 0)
                {
                    break;
                }
            }
            if (beehive.Count > 0)
            {
                Console.WriteLine(string.Join(" ",beehive));
            }
            else
            {
                Console.WriteLine(string.Join(" ",hornets));
            }
        }
    }
}
