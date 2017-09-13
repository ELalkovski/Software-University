using System;

namespace _01.Vehicles
{
    public class Truck : Vehicle
    {
        private const double AcConsumptionMod = 1.6;
        private const double FuelLossFactor = 0.95;

        public Truck(double fuel, double consumption, double tankCapacity)
            : base(fuel, consumption + AcConsumptionMod, tankCapacity)
        {
            
        }

        public override void Refuell(double liters)
        {
            if (liters <= 0)
            {
                throw new ArgumentException("Fuel must be a positive number");
            }
            var litersToRefill = FuelLossFactor * liters;
            base.FuelQuantity += litersToRefill;
        }
    }
}
