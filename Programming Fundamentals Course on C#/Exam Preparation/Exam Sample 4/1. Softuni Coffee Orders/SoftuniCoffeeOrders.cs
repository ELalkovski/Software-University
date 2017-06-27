namespace _1.Softuni_Coffee_Orders
{
    using System;
    using System.Globalization;

    public class SoftuniCoffeeOrders
    {

        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            decimal currPrice = 0M;
            decimal totalPrice = 0M;

            for (int i = 0; i < n; i++)
            {
                decimal pricePerCapsule = decimal.Parse(Console.ReadLine());
                var orderDate = DateTime.ParseExact(Console.ReadLine(), "d/M/yyyy", CultureInfo.InvariantCulture);
                long capsulesCount = long.Parse(Console.ReadLine());

                var daysInMonth = DateTime.DaysInMonth(
                    orderDate.Year,
                    orderDate.Month);

                currPrice = ((daysInMonth * capsulesCount) * pricePerCapsule);
                totalPrice += currPrice;
                Console.WriteLine($"The price for the coffee is: ${currPrice:f2}");
            }

            Console.WriteLine($"Total: ${totalPrice:f2}");
        }
    }
}
