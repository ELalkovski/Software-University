using System;
using System.Collections.Generic;
using System.Linq;

namespace _12.Inferno_III
{
    public class Inferno
    {
        public static void Main()
        {
            var gems = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            var markedGems = new bool[gems.Count];

            var input = Console.ReadLine(); 

            while (input != "Forge")
            {
                var inputTokens = input.Split(';');
                var command = inputTokens[0];
                var criteria = inputTokens[1];
                var boundry = int.Parse(inputTokens[2]);

                ExcludeOrReverse(gems, markedGems, command, criteria, boundry);

                input = Console.ReadLine();
            }

            for (int i = 0; i < gems.Count; i++)
            {
                if (!markedGems[i])
                {
                    Console.Write($"{gems[i]} ");
                }
            }
        }

        private static void MarkAndUnmarkGems(string command, bool[] markedGems, int index)
        {
            if (command == "Exclude")
            {
                markedGems[index] = true;
            }
            else if (command == "Reverse")
            {
                markedGems[index] = false;
            }
        }


        private static void ExcludeOrReverse(List<int> gems, bool[] markedGems, string command, string criteria, int boundry)
        {
            Func<int, int, bool> sumLeftOrRight = (n1, n2) => { return n1 + n2 == boundry; };
            Func<int, int, int, bool> sumLeftAndRight = (n1, n2, n3) => { return n1 + n2 + n3 == boundry; };
            var leftNum = 0;
            var rightNum = 0;

            switch (criteria)
            {
                case "Sum Left":

                    for (int i = 0; i < gems.Count; i++)
                    {
                        var currNum = gems[i];

                        if (i > 0)
                        {
                            leftNum = gems[i - 1];
                        }
                        if (sumLeftOrRight(leftNum, currNum))
                        {
                            MarkAndUnmarkGems(command, markedGems, i);
                        }

                    }
                    break;
                case "Sum Right":

                    for (int i = 0; i < gems.Count; i++)
                    {
                        var currNum = gems[i];

                        if (i < gems.Count - 1)
                        {
                            rightNum = gems[i + 1];
                        }
                        else
                        {
                            rightNum = 0;
                        }
                        if (sumLeftOrRight(currNum, rightNum))
                        {
                            MarkAndUnmarkGems(command, markedGems, i);
                        }
                    }
                    break;
                case "Sum Left Right":
                    for (int i = 0; i < gems.Count; i++)
                    {
                        var currNum = gems[i];

                        if (i > 0)
                        {
                            leftNum = gems[i - 1];
                        }
                        if (i < gems.Count - 1)
                        {
                            rightNum = gems[i + 1];
                        }
                        else
                        {
                            rightNum = 0;
                        }
                        if (sumLeftAndRight(leftNum, currNum, rightNum))
                        {
                            MarkAndUnmarkGems(command, markedGems, i);
                        }
                    }
                    break;
            }
        }
    }
}
