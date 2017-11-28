namespace _09.Threeuple
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
                    string town = input[3];
                    Threeuple<string, string, string> tuple = new Threeuple<string, string, string>(name, adress, town);

                    Console.WriteLine(tuple.ToString());
                }
                else if (i == 1)
                {
                    string name = input[0];
                    int beer = int.Parse(input[1]);
                    string drunkState = input[2];
                    bool isDrunk = drunkState == "drunk";
                    Threeuple<string, int, bool> tuple = new Threeuple<string, int, bool>(name, beer, isDrunk);

                    Console.WriteLine(tuple.ToString());
                }
                else
                {
                    string name = input[0];
                    double floatingNum = double.Parse(input[1]);
                    string bankName = input[2];
                    Threeuple<string, double, string> tuple = new Threeuple<string, double, string>(name, floatingNum, bankName);

                    Console.WriteLine(tuple.ToString());
                }
            }
        }
    }
}
