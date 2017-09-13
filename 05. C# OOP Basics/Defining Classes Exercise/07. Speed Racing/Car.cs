using System;

namespace _07.Speed_Racing
{
    public class Car
    {
        private string model;
        private double fuelAmount;
        private double fuelConsumptionPerKm;
        private int distanceTravelled = 0;

        public Car(string model, int fuelAmount, double fuelConsumption)
        {
            this.model = model;
            this.fuelAmount = fuelAmount;
            this.fuelConsumptionPerKm = fuelConsumption;
        }

        public string Model
        {
            get { return this.model; }
            set { this.model = value; }
        }
        public double FuelAmount
        {
            get { return this.fuelAmount; }
            set { this.fuelAmount = value; }
        }
        public double FuelConsumption
        {
            get { return this.fuelConsumptionPerKm; }
            set { this.fuelConsumptionPerKm = value; }
        }
        public int DistanceTravelled
        {
            get { return this.distanceTravelled; }
            set { this.distanceTravelled = value; }
        }

        public void TravelDistance(int distanceToTravel)
        {
            var fuelNeeded = distanceToTravel * this.fuelConsumptionPerKm;

            if (fuelNeeded <= this.fuelAmount)
            {
                this.distanceTravelled += distanceToTravel;
                this.fuelAmount -= fuelNeeded;
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
        }
    }
}
