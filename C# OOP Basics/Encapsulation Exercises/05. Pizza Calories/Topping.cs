using System;
using System.Collections.Generic;

namespace _05.Pizza_Calories
{
    public class Topping
    {
        private string type;
        private double weightInGrams;

        public Topping(string type, double weight)
        {
            SetType(type);
            this.Weight = weight;
        }

        public string Type
        {
            get { return this.type; }
        }

        public void SetType(string type)
        {
            if (!type.ToLower().Equals("meat")
                && !type.ToLower().Equals("veggies")
                && !type.ToLower().Equals("cheese")
                && !type.ToLower().Equals("sauce"))
            {
                throw new ArgumentException($"Cannot place {type} on top of your pizza.");
            }
            this.type = type;
        }

        public double Weight
        {
            get { return this.weightInGrams; }

            set
            {
                if (value < 1 || value > 50)
                {
                    throw new ArgumentException($"{this.Type} weight should be in the range [1..50].");
                }
                this.weightInGrams = value;
            }
        }

        public double CalculateCalories()
        {
            return (2 * this.Weight) * GetMod();
        }

        public double GetMod()
        {
            switch (this.Type.ToLower())
            {
                case "meat":
                    return 1.2;
                case "veggies":
                    return 0.8;
                case "cheese":
                    return 1.1;
                case "sauce":
                    return 0.9;
                default:
                    return 1;
            }
        }
    }
}
