namespace _02.Wild_Farm
{
    using System;

    public abstract class Animal
    {
        private string name;
        private string type;
        private double weight;
        private int foodEaten;

        public Animal(string type, string name, double weight)
        {
            this.Type = type;
            this.Name = name;
            this.Weight = weight;
        }

        public int FoodEaten
        {
            get { return this.foodEaten; }
            set { this.foodEaten = value; }
        }       

        public double Weight
        {
            get { return this.weight; }
            set { this.weight = value; }
        }      

        public string Type
        {
            get { return this.type; }
            set { this.type = value; }
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public virtual void MakeSound()
        {
            Console.WriteLine("");
        }

        public virtual void Eat(Food food)
        {
            
        }
    }
}
