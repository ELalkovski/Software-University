namespace _09.Traffic_Lights
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var inputLights = Console.ReadLine()
                .Split(new []{' '}, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            var allTrafficLights = new List<TrafficLight>();

            foreach (var light in inputLights)
            {
                Light currentLight = (Light)Enum.Parse(typeof(Light), light);
                allTrafficLights.Add(new TrafficLight(currentLight));
            }

            var numberOfLines = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfLines; i++)
            {
                foreach (var trafficLight in allTrafficLights)
                {
                    trafficLight.ChangeLight();
                }

                Console.WriteLine(string.Join(" ", allTrafficLights));
            }
        }

    }
}
