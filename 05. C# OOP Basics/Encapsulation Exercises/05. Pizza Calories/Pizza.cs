namespace _05.Pizza_Calories
{
    using System;
    using System.Collections.Generic;

    public class Pizza
    {
        private string name;
        private Dough dough;
        private int numberOfToppings;
        private List<Topping> toppings;

        public Pizza(string name, int numberOfToppings)
        {
            this.Name = name;
            this.NumberOfToppings = numberOfToppings; 
            this.toppings = new List<Topping>();
        }

        public Dough Dough
        {
            set { this.dough = value; }
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (value.Length < 1 || value.Length > 15)
                {
                    throw new ArgumentException("Pizza name should be between 1 and 15 symbols.");
                }

                this.name = value;
            }
        }

        public int NumberOfToppings
        {
            get
            {
                return this.numberOfToppings;
            }
            set
            {
                if (value < 0 || value > 10)
                {
                    throw new ArgumentException("Number of toppings should be in range [0..10].");
                }

                this.numberOfToppings = value;
            }
        }

        public void AddTopping(Topping topping)
        {
            this.toppings.Add(topping);
        }

        public double CalculateDoughCalories()
        {
            return this.dough.CalculateCalories();
        }

        public double CalculateToppingsCalories()
        {
            double calories = 0;

            foreach (var topping in this.toppings)
            {
                calories += topping.CalculateCalories();
            }

            return calories;
        }

        public double CalculateAllCalories()
        {
            return this.CalculateDoughCalories() + this.CalculateToppingsCalories();
        }
    }
}
