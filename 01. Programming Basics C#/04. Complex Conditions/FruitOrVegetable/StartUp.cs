namespace FruitOrVegetable
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            string fruitORvegetable = Console.ReadLine();

            if (fruitORvegetable == "banana" || fruitORvegetable == "apple" || fruitORvegetable == "kiwi" || fruitORvegetable == "cherry" || fruitORvegetable == "lemon" || fruitORvegetable == "grapes")
            {
                Console.WriteLine("fruit");
            }
            else if (fruitORvegetable == "tomato" || fruitORvegetable == "cucumber" || fruitORvegetable == "pepper" || fruitORvegetable == "carrot")
            {
                Console.WriteLine("vegetable");
            }
            else
            {
                Console.WriteLine("unknown");
            }
        }
    }
}
