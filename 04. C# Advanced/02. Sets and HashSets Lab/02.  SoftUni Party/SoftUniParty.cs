namespace _02.SoftUni_Party
{
    using System;
    using System.Collections.Generic;

    public class SoftUniParty
    {
        public static void Main()
        {
            /*             
             There will be 2 command lines. First is "PARTY" - party is on and guests start coming. Second is "END" – then party is over and no more guest will come
             Output have to all guests, who didn't come to the party (VIP must be first)
             */

            string input = Console.ReadLine();
            SortedSet<string> reservations = new SortedSet<string>();

            while (input != "END")
            {
                if (input != "PARTY")
                {
                    reservations.Add(input.Trim());    
                }

                input = Console.ReadLine();

                if (input == "PARTY")
                {
                    while (input != "END")
                    {
                        if (reservations.Contains(input))
                        {
                            reservations.Remove(input);
                        }

                        input = Console.ReadLine();
                    }
                }
            }

            Console.WriteLine(reservations.Count);

            foreach (var reservation in reservations)
            {
                Console.WriteLine(reservation);
            }
        }
    }
}
