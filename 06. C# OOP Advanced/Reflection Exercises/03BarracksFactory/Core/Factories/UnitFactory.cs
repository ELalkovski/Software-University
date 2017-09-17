namespace _03BarracksFactory.Core.Factories
{
    using System;
    using Contracts;

    public class UnitFactory : IUnitFactory
    {
        private const string Namespace = "_03BarracksFactory.Models.Units.";

        public IUnit CreateUnit(string unitType)
        {
            Type classType = Type.GetType(Namespace + unitType);
            IUnit classInstance = (IUnit)Activator.CreateInstance(classType, new object[] { });

            return classInstance;
        }
    }
}
