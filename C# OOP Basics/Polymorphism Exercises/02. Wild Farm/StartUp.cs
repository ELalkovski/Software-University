using System;

namespace _02.Wild_Farm
{
    public class StartUp
    {
        public static void Main()
        {
            var animalInfo = Console.ReadLine();

            while (animalInfo != "End")
            {
                var foodInfo = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries); 
                var infoTokens = animalInfo.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);              

                var type = infoTokens[0];
                var name = infoTokens[1];
                var weight = double.Parse(infoTokens[2]);
                var livingRegion = infoTokens[3];
                var breed = "";
                try
                {
                    breed = infoTokens[4];
                }
                catch (Exception e)
                {
                }
                var foodType = foodInfo[0];
                var quantity = int.Parse(foodInfo[1]);
                Food currFood;
                Animal currAnimal;
                
                switch (foodType)
                {
                    case "Vegetable":
                        currFood = new Vegetable(quantity);
                        currAnimal = CreateAnimal(type, name, weight, livingRegion, breed);
                        currAnimal.MakeSound();
                        currAnimal.Eat(currFood);
                        Console.WriteLine(currAnimal.ToString());
                        break;
                    case "Meat":
                        currFood = new Meat(quantity);
                        currAnimal = CreateAnimal(type, name, weight, livingRegion, breed);
                        currAnimal.MakeSound();
                        currAnimal.Eat(currFood);
                        Console.WriteLine(currAnimal.ToString());
                        break;
                }

                animalInfo = Console.ReadLine();
            }
        }

        private static Animal CreateAnimal(string type, string name, double weight, string livingRegion, string breed)
        {
            if (type.Equals("Cat"))
            {
                return new Cat(type, name, weight, livingRegion, breed);
            }
            if (type.Equals("Tiger"))
            {
                return new Tiger(type, name, weight, livingRegion);
            }
            if (type.Equals("Mouse"))
            {
                return new Mouse(type, name, weight, livingRegion);
            }

            return new Zebra(type, name, weight, livingRegion);
        }
    }
}
