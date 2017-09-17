using System.Collections.Generic;

public class Garage
{
    private Dictionary<int, Car> parkedCars;

    public Garage()
    {
        this.parkedCars = new Dictionary<int, Car>();
    }

    public Dictionary<int, Car> ParkedCars
    {
        get { return this.parkedCars; }
    }

    public void ParkCar(int id, Car car)
    {
        this.parkedCars.Add(id, car);
    }

    public void TuneCars(int index, string addOn)
    {
        foreach (var car in this.parkedCars)
        {
            this.parkedCars[car.Key].HorsePower += index;
            this.parkedCars[car.Key].Suspension += ((index * 50) / 100);
            this.parkedCars[car.Key].TuneUp(index, addOn);
        }
    }
}
