namespace _05.Custom_Enum_Attribute
{
    using System;
    using System.Reflection;

    public class StartUp
    {
        public static void Main()
        {
            var name = Console.ReadLine();

            if (name.Equals("Rank"))
            {
                var type = typeof(Rank);
                var methods = type.GetCustomAttributes(false);

                foreach (TypeAttribute method in methods)
                {
                    Console.WriteLine($"Type = {method.Type}, Description = {method.Description}");
                }
            }
            else
            {
                var type = typeof(Suit);
                var methods = type.GetCustomAttributes(false);

                foreach (TypeAttribute method in methods)
                {
                    Console.WriteLine($"Type = {method.Type}, Description = {method.Description}");
                }
            }
        }
    }
}
