using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.Mordor_s_Cruelty_Plan
{
    public class StartUp
    {
        public static void Main()
        {
            var allFoodNames = Console.ReadLine()
                .Split(new []{' '}, StringSplitOptions.RemoveEmptyEntries);

            var foodFactory = new FoodFactory();
            var food = new List<Food>();

            for (int i = 0; i < allFoodNames.Length; i++)
            {
                var foodName = allFoodNames[i].ToLower();

                Food currFood = foodFactory.ProduceFood(foodName);
                food.Add(currFood);
            }

            var foodSummedPoints = food.Sum(f => f.PointsOfHappiness);
            var mood = new Mood(foodSummedPoints);
            Console.WriteLine(foodSummedPoints);
            Console.WriteLine(mood.GetMood);
        }
    }
}
