namespace _5.Bomb_Numbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class BombNumbers
    {
        public static void Main()
        {
            List<int> inputNums = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            int[] bombNumAndDamage = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            Console.WriteLine(GetBombedSequence(inputNums, bombNumAndDamage).Sum());
        }

        private static List<int> GetBombedSequence(List<int> inputNums, int[] bombNumAndDamage)
        {
            int bombNum = bombNumAndDamage[0];
            int damage = bombNumAndDamage[1];

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
    }
}
