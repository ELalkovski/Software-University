namespace _05.Mordor_s_Cruelty_Plan
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            string[] allFoodNames = Console.ReadLine()
                .Split(new []{' '}, StringSplitOptions.RemoveEmptyEntries);

            FoodFactory foodFactory = new FoodFactory();
            List<Food> food = new List<Food>();

            for (int i = 0; i < allFoodNames.Length; i++)
            {
                string foodName = allFoodNames[i].ToLower();
                Food currFood = foodFactory.ProduceFood(foodName);
                food.Add(currFood);
            }

            int foodSummedPoints = food.Sum(f => f.PointsOfHappiness);
            Mood mood = new Mood(foodSummedPoints);

            Console.WriteLine(foodSummedPoints);
            Console.WriteLine(mood.GetMood);
        }
    }
}
