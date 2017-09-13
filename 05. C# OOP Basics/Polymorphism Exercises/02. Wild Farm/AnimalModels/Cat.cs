using System;
using System.Text;

namespace _02.Wild_Farm
{
    public class Cat : Felime
    {
        private string breed;

        public Cat(string type, string name, double weight, string livingRegion, string breed)
            : base(type, name, weight, livingRegion)
        {
            this.Breed = breed;
        }

        public string Breed
        {
            get { return this.breed; }
            set { this.breed = value; }
        }

        public override void MakeSound()
        {
            Console.WriteLine("Meowwww");
        }

        public override void Eat(Food food)
        {
            base.FoodEaten += food.Quantity;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append($"{base.Type}[{base.Name}, {this.Breed}, {base.Weight}, {base.LivingRegion}, {base.FoodEaten}]");
            return sb.ToString();
        }
    }
}
