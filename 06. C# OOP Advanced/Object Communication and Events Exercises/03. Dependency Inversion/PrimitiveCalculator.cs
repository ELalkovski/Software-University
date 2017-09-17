namespace _03DependencyInversion
{
    using _03.Dependency_Inversion;
    using _03.Dependency_Inversion.Contracts;

    public class PrimitiveCalculator
    {
        private IStrategy strategy;
        private StrategyManager manager;

        public PrimitiveCalculator(StrategyManager factory)
        {
            this.manager = factory;
            this.strategy = this.manager.GetStrategy('+');
        }

        public void ChangeStrategy(char operatorr)
        {
            this.strategy = this.manager.GetStrategy(operatorr);
        }

        public int PerformCalculation(int firstOperand, int secondOperand)
        {
            return this.strategy.Calculate(firstOperand, secondOperand);
        }
    }
}
