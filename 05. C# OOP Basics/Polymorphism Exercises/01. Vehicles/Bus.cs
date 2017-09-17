namespace _01.Vehicles
{
    using System;

    public class Bus : Vehicle
    {
        public Bus(double fuel, double consumption, double tankCapacity)
            : base(fuel, consumption, tankCapacity)
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
