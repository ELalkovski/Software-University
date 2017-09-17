namespace _09.Threeuple
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
                    var town = input[3];

                    var tuple = new Threeuple<string, string, string>(name, adress, town);
                    Console.WriteLine(tuple.ToString());
                }
                else if (i == 1)
                {
                    var name = input[0];
                    var beer = int.Parse(input[1]);
                    var drunkState = input[2];
                    bool isDrunk = drunkState == "drunk";

                    var tuple = new Threeuple<string, int, bool>(name, beer, isDrunk);
                    Console.WriteLine(tuple.ToString());
                }
                else
                {
                    var name = input[0];
                    var floatingNum = double.Parse(input[1]);
                    var bankName = input[2];

                    var tuple = new Threeuple<string, double, string>(name, floatingNum, bankName);
                    Console.WriteLine(tuple.ToString());
                }
            }
        }
    }
}
