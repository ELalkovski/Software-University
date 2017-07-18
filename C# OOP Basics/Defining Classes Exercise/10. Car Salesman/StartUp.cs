using System;
using System.Collections.Generic;

namespace _10.Car_Salesman
{
    public class StartUp
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var engines = new List<Engine>();

            for (int i = 0; i < n; i++)
            {
                var engineInfo = Console.ReadLine()
                    .Split(' ');

                var model = engineInfo[0];
                var power = engineInfo[1];
                var displacement = "";
                var efficiency = "";
                if (engineInfo.Length == 3)
                {
                    if (char.IsDigit(engineInfo[2][0]))
                    {
                        displacement = engineInfo[2];
                    }
                    else
                    {
                        efficiency = engineInfo[2];
                    }  
                }
                else if (engineInfo.Length == 4)
                {
                    if (char.IsDigit(engineInfo[2][0]))
                    {
                        displacement = engineInfo[2];
                        efficiency = engineInfo[3];
                    }
                    else
                    {
                        efficiency = engineInfo[2];
                        displacement = engineInfo[3];
                    }
                }


                var currEngine = new Engine(model, power);
                currEngine.Displacement = displacement;
                currEngine.Efficiency = efficiency;
                engines.Add(currEngine);
            }

            var carsInputLines = int.Parse(Console.ReadLine());
            var cars = new List<Car>();

            for (int i = 0; i < carsInputLines; i++)
            {
                var carsInfo = Console.ReadLine()
                    .Split(' ');

                var model = carsInfo[0];
                var engine = carsInfo[1];
                var weight = "";
                var color = "";

                if (carsInfo.Length == 3)
                {
                    if (char.IsDigit(carsInfo[2][0]))
                    {
                        weight = carsInfo[2];
                    }
                    else
                    {
                        color = carsInfo[2];
                    }
                }
                else if (carsInfo.Length == 4)
                {
                    if (char.IsDigit(carsInfo[2][0]))
                    {
                        weight = carsInfo[2];
                        color = carsInfo[3];
                    }
                    else
                    {
                        color = carsInfo[2];
                        weight = carsInfo[3];
                    }
                }

                var currCar = new Car(model, engines.Find(e => e.Model == engine));
                currCar.Weight = weight;
                currCar.Color = color;
                cars.Add(currCar);
            }

            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Model}:");
                Console.WriteLine($"  {car.Engine.Model}:");
                Console.WriteLine($"    Power: {car.Engine.Power}");
                if (!string.IsNullOrEmpty(car.Engine.Displacement))
                {
                    Console.WriteLine($"    Displacement: {car.Engine.Displacement}");
                }
                else
                {
                    Console.WriteLine("    Displacement: n/a");
                }
                if (!string.IsNullOrEmpty(car.Engine.Efficiency))
                {
                    Console.WriteLine($"    Efficiency: {car.Engine.Efficiency}");
                }
                else
                {
                    Console.WriteLine($"    Efficiency: n/a");
                }
                if (!string.IsNullOrEmpty(car.Weight))
                {
                    Console.WriteLine($"    Weight: {car.Weight}");
                }
                else
                {
                    Console.WriteLine($"    Weight: n/a");
                }
                if (!string.IsNullOrEmpty(car.Color))
                {
                    Console.WriteLine($"    Color: {car.Color}");
                }
                else
                {
                    Console.WriteLine($"    Color: n/a");
                }
            }
        }
    }
}
