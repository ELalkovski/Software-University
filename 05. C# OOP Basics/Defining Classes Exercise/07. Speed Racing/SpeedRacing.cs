using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.Speed_Racing
{
    public class SpeedRacing
    {
        public static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var cars = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                var carInfo = Console.ReadLine()
                    .Split(' ');

                var model = carInfo[0];
                var fuelAmount = int.Parse(carInfo[1]);
                var fuelConsumption = double.Parse(carInfo[2]);
                var currCar = new Car(model, fuelAmount, fuelConsumption);
                cars.Add(currCar);
            }

            var input = Console.ReadLine();

            while (input != "End")
            {
                var tokens = input
                    .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                var model = tokens[1];
                var distanceToTravel = int.Parse(tokens[2]);

                cars.Find(c => c.Model == model).TravelDistance(distanceToTravel);
                input = Console.ReadLine();
            }

            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.DistanceTravelled}");
            }
        }
    }
}
