namespace _07.Speed_Racing
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SpeedRacing
    {
        public static void Main()
        {
            int linesCount = int.Parse(Console.ReadLine());

            List<Car> cars = new List<Car>();

            for (int i = 0; i < linesCount; i++)
            {
                string[] carInfo = Console.ReadLine()
                    .Split(' ');

                string model = carInfo[0];
                int fuelAmount = int.Parse(carInfo[1]);
                double fuelConsumption = double.Parse(carInfo[2]);
                Car currCar = new Car(model, fuelAmount, fuelConsumption);

                cars.Add(currCar);
            }

            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] tokens = input
                    .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string model = tokens[1];
                int distanceToTravel = int.Parse(tokens[2]);

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
