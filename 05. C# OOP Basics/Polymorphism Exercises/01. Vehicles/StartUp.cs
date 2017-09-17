namespace _01.Vehicles
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            string[] carInfo = Console.ReadLine()
                .Split(new []{' '}, StringSplitOptions.RemoveEmptyEntries);
            string[] truckInfo = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string[] busInfo = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            Vehicle car = new Car(double.Parse(carInfo[1]), double.Parse(carInfo[2]), double.Parse(carInfo[3]));
            Vehicle truck = new Truck(double.Parse(truckInfo[1]), double.Parse(truckInfo[2]), double.Parse(truckInfo[3]));
            Vehicle bus = new Bus(double.Parse(busInfo[1]), double.Parse(busInfo[2]), double.Parse(busInfo[3]));

            int commandCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < commandCount; i++)
            {
                try
                {
                    string[] commandTokens = Console.ReadLine()
                        .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    string action = commandTokens[0];
                    string vehicle = commandTokens[1];
                    double distanceOrLitersQuantity = double.Parse(commandTokens[2]);

                    if (action.Equals("Drive") || action.Equals("DriveEmpty"))
                    {
                        
                        ExecuteDrive(vehicle, distanceOrLitersQuantity, action, car, truck, bus);
                    }
                    else if (action.Equals("Refuel"))
                    {
                        ExecuteRefuel(vehicle, distanceOrLitersQuantity, car, truck, bus);
                    }        
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            Console.WriteLine($"Car: {car.FuelQuantity:f2}");
            Console.WriteLine($"Truck: {truck.FuelQuantity:f2}");
            Console.WriteLine($"Bus: {bus.FuelQuantity:f2}");
        }

        private static void ExecuteRefuel(string vehicle, double distanceOrLitersQuantity, Vehicle car, Vehicle truck, Vehicle bus)
        {
            switch (vehicle)
            {
                case "Car":
                    car.Refuell(distanceOrLitersQuantity);
                    break;
                case "Bus":
                    bus.Refuell(distanceOrLitersQuantity);
                    break;
                case "Truck":
                    truck.Refuell(distanceOrLitersQuantity);
                    break;
            }
        }

        private static void ExecuteDrive(string vehicle, double distance, string condition, Vehicle car, Vehicle truck, Vehicle bus)
        {
            switch (vehicle)
            {
                case "Car":
                    Console.WriteLine(car.Drive(distance));
                    break;
                case "Bus":
                    Console.WriteLine(bus.DriveBus(condition, distance));
                    break;
                case "Truck":
                    Console.WriteLine(truck.Drive(distance));
                    break;
                    
            }
        }
    }
}
