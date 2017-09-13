namespace StupidPasswordGenerator
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int letter = int.Parse(Console.ReadLine());

            for (int firstNum = 1; firstNum <= number; firstNum++)
            {
                for (int secondNum = 1; secondNum <= number; secondNum++)
                {
                    for (char firstLet = 'a'; firstLet < 'a' + letter; firstLet++)
                    {
                        for (char secondLet = 'a'; secondLet < 'a' + letter; secondLet++)
                        {
                            for (int lastNum = Math.Max(firstNum,secondNum) + 1; lastNum <= number; lastNum++)
                            {
                                Console.Write("{0}{1}{2}{3}{4} ", firstNum, secondNum, firstLet, secondLet, lastNum);
                            }
                        }
                    }
                    
                }
               
            }

            Console.WriteLine();
        }
    }
}
