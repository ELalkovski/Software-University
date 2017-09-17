namespace _12.Inferno_III
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Inferno
    {
        public static void Main()
        {
            List<int> gems = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            string input = Console.ReadLine();

            bool[] markedGems = new bool[gems.Count];

            while (input != "Forge")
            {
                string[] inputTokens = input.Split(';');
                string command = inputTokens[0];
                string criteria = inputTokens[1];
                int boundry = int.Parse(inputTokens[2]);

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
            int leftNum = 0;
            int rightNum = 0;

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
