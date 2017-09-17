namespace _05.Pizza_Calories
{
    using System;

    public class Dough
    {
        private string flourType;
        private string bakingTechnique;
        private double weightInGrams;

        public Dough(string flourType, string bakingTechnique, double weight)
        {
            this.Flour = flourType;
            this.BakingTechnique = bakingTechnique;
            this.Weight = weight;
        }

        public string Flour
        {
            get
            {
                return this.flourType;
            }
            set
            {
                if (!value.ToLower().Equals("white") 
                    && !value.ToLower().Equals("wholegrain"))
                {
                    throw new ArgumentException("Invalid type of dough.");
                }

                this.flourType = value;
            }
        }

        public string BakingTechnique
        {
            get
            {
                return this.bakingTechnique;
            }
            set
            {
                if (!value.ToLower().Equals("crispy") 
                    && !value.ToLower().Equals("chewy") 
                    && !value.ToLower().Equals("homemade"))
                {
                    throw new ArgumentException("Invalid type of dough.");
                }

                this.bakingTechnique = value;
            }
        }

        public double Weight
        {
            get
            {
                return this.weightInGrams;
            }
            set
            {
                if (value < 1 || value > 200)
                {
                    throw new ArgumentException("Dough weight should be in the range [1..200].");
                }

                this.weightInGrams = value;
            }
        }

        public double CalculateCalories()
        {
            return (2 * this.Weight) * this.GetFlourMod() * this.GetBakingMod();
        }

        private double GetFlourMod()
        {
            switch (this.Flour.ToLower())
            {
                case "white":
                    return 1.5;
                default:
                    return 1;
            }    
        }

        private double GetBakingMod()
        {
            switch (this.BakingTechnique.ToLower())
            {
                case "crispy":
                    return 0.9;
                case "chewy":
                    return 1.1;
                default:
                    return 1;
            }
        }
    }
}
