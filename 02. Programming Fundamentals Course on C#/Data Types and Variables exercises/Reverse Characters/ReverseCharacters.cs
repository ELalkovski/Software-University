namespace reverseCharacters
{
    using System;

    public class ReverseCharacters
    {
        public static void Main()
        {
            char firstLet = char.Parse(Console.ReadLine());
            char secondLet = char.Parse(Console.ReadLine());
            char thirdLet = char.Parse(Console.ReadLine());

            Console.WriteLine("{0}{1}{2}",thirdLet,secondLet,firstLet);  
        }
    }
}
