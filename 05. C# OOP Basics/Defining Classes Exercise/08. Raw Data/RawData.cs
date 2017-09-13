using System;
using System.Collections.Generic;
using System.Linq;


namespace _08.Raw_Data
{
    public class RawData
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var cars = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                var carsInfo = Console.ReadLine()
                    .Split(new []{' '}, StringSplitOptions.RemoveEmptyEntries);

                var model = carsInfo[0];
                var engineSpeed = int.Parse(carsInfo[1]);
                var enginePower = int.Parse(carsInfo[2]);
                var cargoWeight = int.Parse(carsInfo[3]);
                var cargoType = carsInfo[4];
                var firstTirePressure = double.Parse(carsInfo[5]);
                var firstTireAge = int.Parse(carsInfo[6]);
                var secondTirePressure = double.Parse(carsInfo[7]);
                var secondTireAge = int.Parse(carsInfo[8]);
                var thirdTirePressure = double.Parse(carsInfo[9]);
                var thirdTireAge = int.Parse(carsInfo[10]);
                var fourthTirePressure = double.Parse(carsInfo[11]);
                var fourthTireAge = int.Parse(carsInfo[12]);

                var car = new Car(model, engineSpeed, enginePower, cargoWeight, cargoType,
                    firstTirePressure, firstTireAge, secondTirePressure, secondTireAge, 
                    thirdTirePressure, thirdTireAge, fourthTirePressure, fourthTireAge);

                cars.Add(car);

            }

            var criteria = Console.ReadLine();

            if (criteria == "fragile")
            {
                foreach (var car in cars.Where(c => c.IsCarFragile))
                {
                    Console.WriteLine($"{car.Model}");
                }
            }
            else
            {
                foreach (var car in cars.Where(c => c.IsFlamable))
                {
                    Console.WriteLine($"{car.Model}");
                }
            }
        }
    }
}
