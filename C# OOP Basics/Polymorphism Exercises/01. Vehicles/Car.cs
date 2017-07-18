using System;

namespace _01.Vehicles
{
    public class Car : Vehicle
    {
        private const double AcConsumptionMod = 0.9;

        public Car(double fuel, double consumption, double tankCapacity)
            : base(fuel, consumption + AcConsumptionMod, tankCapacity)
        {

        }

        public override void Refuell(double liters)
        {
            if (liters <= 0)
            {
                throw new ArgumentException("Fuel must be a positive number");
            }
            if (liters > base.TankCapacity)
            {
                throw new ArgumentException("Cannot fit fuel in tank");
            }
            this.FuelQuantity += liters;
        }
    }
}
