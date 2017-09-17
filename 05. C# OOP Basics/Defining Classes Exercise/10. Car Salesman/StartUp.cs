namespace _10.Car_Salesman
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            int linesCount = int.Parse(Console.ReadLine());

            List<Engine> engines = new List<Engine>();

            for (int i = 0; i < linesCount; i++)
            {
                string[] engineInfo = Console.ReadLine()
                    .Split(' ');

                string model = engineInfo[0];
                string power = engineInfo[1];
                string displacement = "";
                string efficiency = "";

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


                Engine currEngine = new Engine(model, power);
                currEngine.Displacement = displacement;
                currEngine.Efficiency = efficiency;
                engines.Add(currEngine);
            }

            int carsInputLines = int.Parse(Console.ReadLine());

            List<Car> cars = new List<Car>();

            for (int i = 0; i < carsInputLines; i++)
            {
                string[] carsInfo = Console.ReadLine()
                    .Split(' ');

                string model = carsInfo[0];
                string engine = carsInfo[1];
                string weight = "";
                string color = "";

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

                Car currCar = new Car(model, engines.Find(e => e.Model == engine));
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
