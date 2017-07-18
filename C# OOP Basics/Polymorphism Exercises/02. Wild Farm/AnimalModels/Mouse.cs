using System;
using System.Text;

namespace _02.Wild_Farm
{
    public class Mouse : Mammal
    {
        public Mouse(string type, string name, double weight, string livingRegion)
            : base(type, name, weight, livingRegion)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine("SQUEEEAAAK!");
        }

        public override void Eat(Food food)
        {
            if (food.GetType().Equals("Vegetable"))
            {
                base.FoodEaten += food.Quantity;
            }
            else
            {
                Console.WriteLine($"{base.Type}s are not eating that type of food!");
            }
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append($"{base.Type}[{base.Name}, {base.Weight}, {base.LivingRegion}, {base.FoodEaten}]");
            return sb.ToString();
        }
    }
}
