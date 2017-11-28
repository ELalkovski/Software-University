namespace _08.Tuple
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            for (int i = 0; i < 3; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(' ');

                if (i == 0)
                {
                    string name = input[0] + " " + input[1];
                    string adress = input[2];
                    Tuple<string, string> tuple = new Tuple<string, string>(name, adress);

                    Console.WriteLine(tuple.ToString());
                }
                else if (i == 1)
                {
                    string name = input[0];
                    int beer = int.Parse(input[1]);
                    Tuple<string, int> tuple = new Tuple<string, int>(name, beer);

                    Console.WriteLine(tuple.ToString());
                }
                else
                {
                    int integer = int.Parse(input[0]);
                    double floatingNum = double.Parse(input[1]);
                    Tuple<int, double> tuple = new Tuple<int, double>(integer, floatingNum);

                    Console.WriteLine(tuple.ToString());
                }
            }
        }
    }
}
