namespace _01.ParkingLot
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ParkingLot
    {
        public static void Main()
        {
            /*
                This program:
                •	Records car number for every car that entered in a parking lot
                •	Removes car number when the car goes out
                •	Input is string in format [command("IN" or "OUT"), carNumber]
                •	input ends with string "END"
                Finally it prints the output with all car numbers which left in the parking lot.
             */

            string input = Console.ReadLine();
            SortedSet<string> cars = new SortedSet<string>();

            while (input != "END")
            {
                string[] tokens = input
                    .Split(new[] {',', ' '}, StringSplitOptions.RemoveEmptyEntries);

                string command = tokens[0];
                string carNumber = tokens[1];

                if (command == "IN")
                {
                    cars.Add(carNumber);
                }
                else
                {
                    cars.Remove(carNumber);
                }

                input = Console.ReadLine();
            }

            if (cars.Count() != 0)
            {
                foreach (var car in cars)
                {
                    Console.WriteLine(car);
                }
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
        }
    }
}
