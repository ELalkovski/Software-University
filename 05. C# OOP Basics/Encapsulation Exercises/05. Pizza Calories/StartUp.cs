using System;

namespace _05.Pizza_Calories
{
    public class StartUp
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            while (input != "END")
            {
                var tokens = input.Split(' ');

                try
                {
                    switch (tokens[0])
                    {
                        case "Dough":
                            var dough = new Dough(tokens[1], tokens[2], double.Parse(tokens[3]));
                            Console.WriteLine($"{dough.CalculateCalories():f2}");
                            break;
                        case "Topping":
                            var topping = new Topping(tokens[1], double.Parse(tokens[2]));
                            Console.WriteLine($"{topping.CalculateCalories():f2}");
                            break;
                        case "Pizza":
                            var pizza = MakePizza(tokens);
                            Console.WriteLine($"{pizza.Name} - {pizza.CalculateAllCalories():f2} Calories.");
                            break;
                    }

                }
                catch (ArgumentException e)
                {
                    Console.WriteLine(e.Message);
                    return;
                }
                input = Console.ReadLine();
            }           
        }

        private static Pizza MakePizza(string[] tokens)
        {
            var numberOfToppings = int.Parse(tokens[2]);
            var pizza = new Pizza(tokens[1], numberOfToppings);
            var doughInfo = Console.ReadLine().Split(' ');
            var dough = new Dough(doughInfo[1], doughInfo[2], double.Parse(doughInfo[3]));
            pizza.Dough = dough;

            for (int i = 0; i < numberOfToppings; i++)
            {
                var toppingInfo = Console.ReadLine().Split(' ');
                var topping = new Topping(toppingInfo[1], double.Parse(toppingInfo[2]));
                pizza.AddTopping(topping);
            }
            return pizza;
        }
    }
}
