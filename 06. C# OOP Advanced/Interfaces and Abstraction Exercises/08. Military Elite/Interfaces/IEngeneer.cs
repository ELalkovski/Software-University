namespace _08.Military_Elite.Interfaces
{
    using System.Collections.Generic;

    public interface IEngeneer : ISpecialisedSoldier
    {
        IList<IRepair> Reapirs { get; }
    }
}
