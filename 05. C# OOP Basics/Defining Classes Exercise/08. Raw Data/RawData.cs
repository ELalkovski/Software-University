namespace _08.Raw_Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class RawData
    {
        public static void Main()
        {
            int linesCount = int.Parse(Console.ReadLine());

            List<Car> cars = new List<Car>();

            for (int i = 0; i < linesCount; i++)
            {
                string[] carsInfo = Console.ReadLine()
                    .Split(new []{' '}, StringSplitOptions.RemoveEmptyEntries);

                string model = carsInfo[0];
                int engineSpeed = int.Parse(carsInfo[1]);
                int enginePower = int.Parse(carsInfo[2]);
                int cargoWeight = int.Parse(carsInfo[3]);
                string cargoType = carsInfo[4];
                double firstTirePressure = double.Parse(carsInfo[5]);
                int firstTireAge = int.Parse(carsInfo[6]);
                double secondTirePressure = double.Parse(carsInfo[7]);
                int secondTireAge = int.Parse(carsInfo[8]);
                double thirdTirePressure = double.Parse(carsInfo[9]);
                int thirdTireAge = int.Parse(carsInfo[10]);
                double fourthTirePressure = double.Parse(carsInfo[11]);
                int fourthTireAge = int.Parse(carsInfo[12]);

                Car car = new Car(model, engineSpeed, enginePower, cargoWeight, cargoType,
                    firstTirePressure, firstTireAge, secondTirePressure, secondTireAge, 
                    thirdTirePressure, thirdTireAge, fourthTirePressure, fourthTireAge);

                cars.Add(car);
            }

            string criteria = Console.ReadLine();

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
