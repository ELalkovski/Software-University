namespace Triple_of_Latin_Letters
{
    using System;

    public class LatinLetters
    {
        public static void Main()
        {
            int lettersCount = int.Parse(Console.ReadLine());

            for (int first = 0; first < lettersCount; first++)
            {
                for (int second = 0; second < lettersCount; second++)
                {
                    for (int third = 0; third < lettersCount; third++)
                    {
                        char firstLetter = (char)('a' + first);
                        char secondLetter = (char)('a' + second);
                        char thirdLetter = (char)('a' + third);

                        Console.WriteLine("{0}{1}{2}",firstLetter,secondLetter,thirdLetter);
                    }
                }
            }
        }
    }
}
