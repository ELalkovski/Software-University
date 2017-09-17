using System;

public class Engine
{
    private CarManager carManager;

    public Engine(CarManager carManager)
    {
        this.carManager = carManager;
    }

    public void Run()
    {
        string input = Console.ReadLine();

        while (input != "Cops Are Here")
        {
            string[] data = input.Split(' ');
            string command = data[0];

            ExecuteCommand(command, data);
            input = Console.ReadLine();
        }
    }

    private void ExecuteCommand(string command, string[] data)
    {
        int carId = 0;
        int raceId = 0;
        string type = string.Empty;

        switch (command)
        {
            case "register":
                carId = int.Parse(data[1]);
                type = data[2];
                string brand = data[3];
                string model = data[4];
                int yearOfProduction = int.Parse(data[5]);
                int horsePower = int.Parse(data[6]);
                int acceleration = int.Parse(data[7]);
                int suspension = int.Parse(data[8]);
                int durability = int.Parse(data[9]);

                this.carManager.Register(carId, type, brand, model, yearOfProduction, horsePower, acceleration, suspension, durability);
                break;
            case "check":
                carId = int.Parse(data[1]);

                Console.WriteLine(this.carManager.Check(carId));
                break;
            case "open":
                if (data.Length == 6)
                {
                    raceId = int.Parse(data[1]);
                    type = data[2];
                    int length = int.Parse(data[3]);
                    string route = data[4];
                    int prizePool = int.Parse(data[5]);

                    this.carManager.Open(raceId, type, length, route, prizePool);
                }
                else
                {
                    raceId = int.Parse(data[1]);
                    type = data[2];
                    int length = int.Parse(data[3]);
                    string route = data[4];
                    int prizePool = int.Parse(data[5]);
                    int specialParameter = int.Parse(data[6]);

                    this.carManager.OpenSpecialRace(raceId, type, length, route, prizePool, specialParameter);
                }
                
                break;
            case "participate":
                carId = int.Parse(data[1]);
                raceId = int.Parse(data[2]);

                this.carManager.Participate(carId, raceId);
                break;
            case "start":
                raceId = int.Parse(data[1]);

                Console.WriteLine(this.carManager.Start(raceId));
                break;
            case "park":
                carId = int.Parse(data[1]);

                this.carManager.Park(carId);
                break;
            case "unpark":
                carId = int.Parse(data[1]);

                this.carManager.Unpark(carId);
                break;
            case "tune":
                int tuneIndex = int.Parse(data[1]);
                string addOn = data[2];

                this.carManager.Tune(tuneIndex, addOn);
                break;
        }
    }
}
