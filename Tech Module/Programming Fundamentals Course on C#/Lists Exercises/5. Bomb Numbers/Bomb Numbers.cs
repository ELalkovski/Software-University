


namespace _5.Bomb_Numbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class BombNumbers
    {
        public static List<int> GetBombedSequence (List<int> inputNums, int [] bombNumAndDamage)
        {
            var bombNum = bombNumAndDamage[0];
            var damage = bombNumAndDamage[1];


            for (int i = 0; i < inputNums.Count; i++)
            {
                if (inputNums[i] == bombNum)
                {
                    int left = Math.Max(i - damage, 0);
                    int right = Math.Min(i + damage, inputNums.Count - 1);

                    int length = right - left + 1;
                    inputNums.RemoveRange(left, length);
                    i = 0;
                }
            }

            return inputNums;
        }

        public static void Main()
        {
            var inputNums = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            var bombNumAndDamage = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            Console.WriteLine(GetBombedSequence(inputNums, bombNumAndDamage).Sum());
        }
    }
}
