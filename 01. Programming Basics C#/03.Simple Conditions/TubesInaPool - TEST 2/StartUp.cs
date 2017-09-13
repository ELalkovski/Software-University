namespace TubesInaPool___TEST_2
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int poolVolume = int.Parse(Console.ReadLine());
            int firstPipe = int.Parse(Console.ReadLine());
            int secondPipe = int.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
           
            double water = firstPipe * height + secondPipe * height;

            if (water <= poolVolume)
            {
             Console.WriteLine("The pool is {0}% full. Pipe 1: {1}%. Pipe 2: {2}%.",
                 Math.Truncate((water/ poolVolume) *100),
                 Math.Truncate((firstPipe * height/ water) * 100),
                 Math.Truncate((secondPipe * height / water) * 100) );
            }
            else
            {
                Console.WriteLine("For {0} hours the pool overflows with {1} liters.", height, water - poolVolume);
            }
        }
    }
}
