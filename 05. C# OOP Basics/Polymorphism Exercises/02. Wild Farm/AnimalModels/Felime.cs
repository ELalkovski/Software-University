using System;

namespace _02.Wild_Farm
{
    public abstract class Felime : Mammal
    {
        public Felime(string type, string name, double weight, string livingRegion)
            : base(type, name, weight, livingRegion)
        {

        }

        //public override void Eat(Food food)
        //{
        //    if (food.GetType().Equals("Meat"))
        //    {
        //        base.FoodEaten += food.Quantity;
        //    }
        //    else
        //    {
        //        Console.WriteLine($"{base.Type}s are not eating that type of food!");
        //    }
        //}
    }
}
