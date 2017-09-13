using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitOrVegetable
{
    class Program
    {
        static void Main(string[] args)
        {
            var fruitORvegetable = Console.ReadLine();
            

            if (fruitORvegetable == "banana" || fruitORvegetable == "apple" || fruitORvegetable == "kiwi" || fruitORvegetable == "cherry" ||
                fruitORvegetable == "lemon" || fruitORvegetable == "grapes")
            {
                Console.WriteLine("fruit");
            }
            else if (fruitORvegetable == "tomato" || fruitORvegetable == "cucumber" || 
                fruitORvegetable == "pepper" || fruitORvegetable == "carrot")
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
