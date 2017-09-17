namespace _02.Wild_Farm
{
    using System;
    using System.Text;

    public class Tiger : Felime
    {
        public Tiger(string type, string name, double weight, string livingRegion)
            : base(type, name, weight, livingRegion)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine("ROAAR!!!");
        }

        public override void Eat(Food food)
        {
            if (food.GetType().Equals("Meat"))
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
            StringBuilder sb = new StringBuilder();
            sb.Append($"{base.Type}[{base.Name}, {base.Weight}, {base.LivingRegion}, {base.FoodEaten}]");

            return sb.ToString();
        }
    }
}
