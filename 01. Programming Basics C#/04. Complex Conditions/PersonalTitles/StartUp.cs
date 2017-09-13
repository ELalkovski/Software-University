namespace PersonalTitles
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            double age = double.Parse(Console.ReadLine());
            string gender = Console.ReadLine();

            if (age < 16)
            {
                if (gender == "m")
                {
                    Console.WriteLine("Master");
                }
                else if (gender == "f")
                {
                    Console.WriteLine("Miss");
                }
            }
            else
            {
                if (gender == "m")
                {
                    Console.WriteLine("Mr.");
                }
                else if (gender == "f")
                {
                    Console.WriteLine("Ms.");
                }
            }
        }
    }
}
