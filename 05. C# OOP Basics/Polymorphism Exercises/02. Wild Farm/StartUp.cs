namespace _02.Wild_Farm
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            string animalInfo = Console.ReadLine();

            while (animalInfo != "End")
            {
                string[] foodInfo = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries); 
                string[] infoTokens = animalInfo.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);              

                string type = infoTokens[0];
                string name = infoTokens[1];
                double weight = double.Parse(infoTokens[2]);
                string livingRegion = infoTokens[3];
                string breed = "";\

                try
                {
                    breed = infoTokens[4];
                }
                catch (Exception)
                {
                }

                string foodType = foodInfo[0];
                int quantity = int.Parse(foodInfo[1]);
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
