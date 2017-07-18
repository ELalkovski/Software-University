using System.Collections.Generic;

public class CarManager
{
    private Dictionary<int, Car> cars;
    private Dictionary<int, Race> races;
    private Dictionary<int, List<Car>> raceParticipants;
    private List<int> parkedCarsIds;
    private Garage garage;

    public CarManager()
    {
        this.cars = new Dictionary<int, Car>();
        this.races = new Dictionary<int, Race>();
        this.raceParticipants = new Dictionary<int, List<Car>>();
        this.parkedCarsIds = new List<int>();
        this.garage = new Garage();
    }

    public void Register(int id, string type, string brand, string model, int yearOfProduction, int horsepower,
        int acceleration, int suspension, int durability)
    {
        Car car;

        if (type.Equals("Performance"))
        {
            car = new PerformanceCar(brand, model, yearOfProduction, horsepower, acceleration, suspension, durability);
            this.cars.Add(id, car);
        }
        else
        {
            car = new ShowCar(brand, model, yearOfProduction, horsepower, acceleration, suspension, durability);
            this.cars.Add(id, car);
        }
    }

    public string Check(int id)
    {
        var carToPrint = this.cars[id];
        return carToPrint.ToString();
    }

    public void Open(int id, string type, int length, string route, int prizePool)
    {
        Race race;

        if (type.Equals("Casual"))
        {
            race = new CasualRace(length, route, prizePool);
            this.races.Add(id, race);
        }
        else if (type.Equals("Drag"))
        {
            race = new DragRace(length, route, prizePool);
            this.races.Add(id, race);
        }
        else if(type.Equals("Drift"))
        {
            race = new DriftRace(length, route, prizePool);
            this.races.Add(id, race);
        }
    }

    public void OpenSpecialRace(int id, string type, int length, string route, int prizePool, int specialParameter)
    {
        Race race;

        if (type.Equals("TimeLimit"))
        {
            var goldTime = specialParameter;
            race = new TimeLimitRace(length, route, prizePool, goldTime);
            this.races.Add(id, race);
        }
        else
        {
            var laps = specialParameter;
            race = new CircuitRace(length, route, prizePool, laps);
            this.races.Add(id, race);
        }
    }

    public void Participate(int carId, int raceId)
    {
        if (!this.parkedCarsIds.Contains(carId))
        {
            var participant = this.cars[carId];

            if (this.raceParticipants.ContainsKey(raceId))
            {
                this.raceParticipants[raceId].Add(participant);
            }
            else
            {
                this.raceParticipants.Add(raceId, new List<Car>());
                this.raceParticipants[raceId].Add(participant);
            }
            
            this.races[raceId].AddParticipant(participant);
        }   
    }

    public string Start(int id)
    {
        if (this.races[id].Participants.Count == 0)
        {
            return "Cannot start the race with zero participants.";
        }
        var startedRace = this.races[id];
        this.raceParticipants.Remove(id);
        return startedRace.GetWinners();
    }

    public void Park(int id)
    {
        var car = this.cars[id];

        foreach (var participants in this.raceParticipants.Values)
        {
            if (participants.Contains(car))
            {
                return;
            }
        }      
        this.garage.ParkCar(id, car);
        this.parkedCarsIds.Add(id);
    }

    public void Unpark(int id)
    {
        this.garage.ParkedCars.Remove(id);
        this.parkedCarsIds.Remove(id);
    }

    public void Tune(int tuneIndex, string addOn)
    {
        this.garage.TuneCars(tuneIndex, addOn);
    }

}
