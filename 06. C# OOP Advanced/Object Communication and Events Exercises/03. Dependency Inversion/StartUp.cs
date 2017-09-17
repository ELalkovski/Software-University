namespace _03.Dependency_Inversion
{
    using System;
    using _03DependencyInversion;

    public class StartUp
    {
        public static void Main()
        {
            StrategyManager manager = new StrategyManager();
            PrimitiveCalculator calculator = new PrimitiveCalculator(manager);

            var input = Console.ReadLine();

            while (input != "End")
            {
                var tokens = input.Split(' ');

                if (tokens[0] == "mode")
                {
                    var operatorr = char.Parse(tokens[1]);
                    calculator.ChangeStrategy(operatorr);
                }
                else
                {
                    var firstOperand = int.Parse(tokens[0]);
                    var secondOperand = int.Parse(tokens[1]);
                    Console.WriteLine(calculator.PerformCalculation(firstOperand, secondOperand));
                }

                input = Console.ReadLine();
            }
        }
    }
}
