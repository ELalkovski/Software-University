namespace Greater_of_Two_Values
{
    using System;

    public class GreaterOfTwoValues
    {
        public static void Main()
        {
            string type = Console.ReadLine();

            if (type == "int")
            {
                int firstInput = int.Parse(Console.ReadLine());
                int secondInput = int.Parse(Console.ReadLine());

                Console.WriteLine(GetMax(firstInput,secondInput));
            }
            else if (type == "string")
            {
                string firstInput = Console.ReadLine();
                string secondInput = Console.ReadLine();

                Console.WriteLine(GetMax(firstInput,secondInput));
            }
            else if (type == "char")
            {
                char firstInput = char.Parse(Console.ReadLine());
                char secondInput = char.Parse(Console.ReadLine());

                Console.WriteLine(GetMax(firstInput,secondInput));
            }
        }

        private static int GetMax(int firstInput, int secondInput)
        {
            if (firstInput >= secondInput)
            {
                return firstInput;
            }

            return secondInput;
        }

        private static string GetMax(string firstInput, string secondInput)
        {
            if (firstInput.CompareTo(secondInput) >= 0)
            {
                return firstInput;
            }

            return secondInput;
        }

        private static char GetMax(char firstInput, char secondInput)
        {
            if (firstInput >= secondInput)
            {
                return firstInput;
            }

            return secondInput;
        }
    }
}
