namespace _08.Tuple
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            for (int i = 0; i < 3; i++)
            {
                var input = Console.ReadLine()
                    .Split(' ');

                if (i == 0)
                {
                    var name = input[0] + " " + input[1];
                    var adress = input[2];

                    var tuple = new Tuple<string, string>(name, adress);
                    Console.WriteLine(tuple.ToString());
                }
                else if (i == 1)
                {
                    var name = input[0];
                    var beer = int.Parse(input[1]);

                    var tuple = new Tuple<string, int>(name, beer);
                    Console.WriteLine(tuple.ToString());
                }
                else
                {
                    var integer = int.Parse(input[0]);
                    var floatingNum = double.Parse(input[1]);

                    var tuple = new Tuple<int, double>(integer, floatingNum);
                    Console.WriteLine(tuple.ToString());
                }
            }
        }
    }
}
