namespace _05.Pizza_Calories
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            while (input != "END")
            {
                string[] tokens = input.Split(' ');

                try
                {
                    switch (tokens[0])
                    {
                        case "Dough":
                            Dough dough = new Dough(tokens[1], tokens[2], double.Parse(tokens[3]));

                            Console.WriteLine($"{dough.CalculateCalories():f2}");
                            break;
                        case "Topping":
                            Topping topping = new Topping(tokens[1], double.Parse(tokens[2]));

                            Console.WriteLine($"{topping.CalculateCalories():f2}");
                            break;
                        case "Pizza":
                            Pizza pizza = MakePizza(tokens);

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
            int numberOfToppings = int.Parse(tokens[2]);
            Pizza pizza = new Pizza(tokens[1], numberOfToppings);

            string[] doughInfo = Console.ReadLine().Split(' ');

            Dough dough = new Dough(doughInfo[1], doughInfo[2], double.Parse(doughInfo[3]));
            pizza.Dough = dough;

            for (int i = 0; i < numberOfToppings; i++)
            {
                string[] toppingInfo = Console.ReadLine().Split(' ');

                Topping topping = new Topping(toppingInfo[1], double.Parse(toppingInfo[2]));
                pizza.AddTopping(topping);
            }

            return pizza;
        }
    }
}
