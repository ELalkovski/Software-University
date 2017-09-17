namespace _03.Dependency_Inversion.Strategies
{
    using _03.Dependency_Inversion.Contracts;

    public class MultiplicationStrategy : IStrategy
    {
        public int Calculate(int firstOperand, int secondOperand)
        {
            return firstOperand * secondOperand;
        }
    }
}
