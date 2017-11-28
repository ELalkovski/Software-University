namespace _05.Custom_Enum_Attribute
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            string name = Console.ReadLine();

            if (name.Equals("Rank"))
            {
                Type type = typeof(Rank);
                object[] methods = type.GetCustomAttributes(false);

                foreach (TypeAttribute method in methods)
                {
                    Console.WriteLine($"Type = {method.Type}, Description = {method.Description}");
                }
            }
            else
            {
                Type type = typeof(Suit);
                object[] methods = type.GetCustomAttributes(false);

                foreach (TypeAttribute method in methods)
                {
                    Console.WriteLine($"Type = {method.Type}, Description = {method.Description}");
                }
            }
        }
    }
}
