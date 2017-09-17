namespace _03.Dependency_Inversion
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    using _03.Dependency_Inversion.Contracts;

    public class StrategyManager
    {
        private readonly Dictionary<string, IStrategy> createdStrategies;

        public StrategyManager()
        {
            this.createdStrategies = new Dictionary<string, IStrategy>();
        }

        public IStrategy GetStrategy(char operatorr)
        {
            string strategyName = string.Empty;

            switch (operatorr)
            {
                case '+':
                    strategyName = "AdditionStrategy";
                    break;
                case '-':
                    strategyName = "SubtractionStrategy";
                    break;
                case '*':
                    strategyName = "MultiplicationStrategy";
                    break;
                case '/':
                    strategyName = "DividingStrategy";
                    break;
            }

            if (this.createdStrategies.ContainsKey(strategyName))
            {
                return this.createdStrategies[strategyName];
            }

            Type strategyType = Assembly
                .GetExecutingAssembly()
                .GetTypes()
                .FirstOrDefault(t => t.Name.Equals(strategyName));

            IStrategy strategyInstance = (IStrategy)Activator.CreateInstance(strategyType, new object[] { });
            this.createdStrategies.Add(strategyName, strategyInstance);

            return strategyInstance;
        }
    }
}
