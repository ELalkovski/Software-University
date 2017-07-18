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
        var input = Console.ReadLine();

        while (input != "Cops Are Here")
        {
            var data = input.Split(' ');
            var command = data[0];
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
                var brand = data[3];
                var model = data[4];
                var yearOfProduction = int.Parse(data[5]);
                var horsePower = int.Parse(data[6]);
                var acceleration = int.Parse(data[7]);
                var suspension = int.Parse(data[8]);
                var durability = int.Parse(data[9]);
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
                    var length = int.Parse(data[3]);
                    var route = data[4];
                    var prizePool = int.Parse(data[5]);
                    this.carManager.Open(raceId, type, length, route, prizePool);
                }
                else
                {
                    raceId = int.Parse(data[1]);
                    type = data[2];
                    var length = int.Parse(data[3]);
                    var route = data[4];
                    var prizePool = int.Parse(data[5]);
                    var specialParameter = int.Parse(data[6]);
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
                var tuneIndex = int.Parse(data[1]);
                var addOn = data[2];
                this.carManager.Tune(tuneIndex, addOn);
                break;
        }
    }
}
