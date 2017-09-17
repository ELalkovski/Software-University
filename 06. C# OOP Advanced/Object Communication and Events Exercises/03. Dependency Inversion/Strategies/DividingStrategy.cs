namespace _03.Dependency_Inversion.Strategies
{
    using _03.Dependency_Inversion.Contracts;

    public class DividingStrategy : IStrategy
    {
        public int Calculate(int firstOperand, int secondOperand)
        {
            return firstOperand / secondOperand;
        }
    }
}
