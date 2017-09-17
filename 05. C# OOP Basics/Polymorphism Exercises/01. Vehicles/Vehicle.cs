namespace _01.Vehicles
{
    using System;

    public abstract class Vehicle
    {
        private const double BusAirConditioner = 1.4;

        private double fuelQuantity;
        private double consumptionPerKm;
        private double tankCapacity;

        public Vehicle(double fuel, double consumption, double tankCapacity)
        {
            this.FuelQuantity = fuel;
            this.ConsumptionPerKm = consumption;
            this.TankCapacity = tankCapacity;
        }

        public double TankCapacity
        {
            get
            {
                return this.tankCapacity;
            }
            set
            {
                this.tankCapacity = value;
            }
        }

        private double ConsumptionPerKm
        {
            get
            {
                return this.consumptionPerKm;
            }
            set
            {
                this.consumptionPerKm = value;
            }
        }   

        public virtual double FuelQuantity
        {
            get
            {
                return this.fuelQuantity;
            }
            set
            {
                this.fuelQuantity = value;
            }
        }

        private bool TryToRefuel(double givenFuel)
        {
            if (givenFuel > this.tankCapacity)
            {
                return false;
            }

            return true;
        }

        public virtual void Refuell(double liters)
        {
            if (liters <= 0)
            {
                throw new ArgumentException("Fuel must be a positive number");
            }

            this.FuelQuantity += liters;
        }

        private bool TryToDrive(double distance)
        {
            double fuelNeeded = this.consumptionPerKm * distance;

            if (fuelNeeded <= this.fuelQuantity)
            {
                this.FuelQuantity -= fuelNeeded;

                return true;
            }

            return false;
        }

        public string Drive(double distance)
        {
            
            if (this.TryToDrive(distance))
            {
                return $"{GetType().Name} travelled {distance} km";
            }
            else
            {
                return $"{GetType().Name} needs refueling";
            }
        }

        private bool TryToDriveBus(string condition, double distance)
        {
            double fuelNeeded = 0;

            if (condition.Equals("Drive"))
            {
                fuelNeeded = (this.ConsumptionPerKm + 1.4) * distance;
            }
            else
            {
                fuelNeeded = this.ConsumptionPerKm * distance;
            }
            if (fuelNeeded <= this.FuelQuantity)
            {
                this.FuelQuantity -= fuelNeeded;

                return true;
            }

            return false;
        }

        public string DriveBus(string condition, double distance)
        {
            if (this.TryToDriveBus(condition, distance))
            {
                return $"{GetType().Name} travelled {distance} km";
            }
            else
            {
                return $"{GetType().Name} needs refueling";
            }
        }
    }
}
