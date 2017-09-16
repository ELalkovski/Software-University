namespace _1.Sweet_Dessert
{
    using System;

    public class SweetDessert
    {
        public static void Main()
        {
            decimal amountOfCash = decimal.Parse(Console.ReadLine());
            int guestsNumber = int.Parse(Console.ReadLine());
            decimal bananaPrice = decimal.Parse(Console.ReadLine());
            decimal priceOfEggs = decimal.Parse(Console.ReadLine());
            decimal priceOfBerries = decimal.Parse(Console.ReadLine());

            int portionSetsNeeded = (int)Math.Ceiling(guestsNumber / 6.0);
            decimal bananas = 2 * bananaPrice;
            decimal eggs = 4 * priceOfEggs;
            decimal berries = 0.2m * priceOfBerries;

            decimal productsCost = ((portionSetsNeeded * bananas) 
                + (portionSetsNeeded * eggs) 
                + (portionSetsNeeded * berries));

            if (productsCost <= amountOfCash)
            {
                Console.WriteLine($"Ivancho has enough money - it would cost {productsCost:f2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivancho will have to withdraw money - he will need {Math.Abs(productsCost - amountOfCash):f2}lv more.");
            }
        }
    }
}
