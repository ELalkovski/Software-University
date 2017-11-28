namespace _11.Inferno_Infinity
{
    using Models;

    public interface IWeapon
    {
        string Name { get; }

        void AddGem(int index, Gem gem);

        void RemoveGem(int index);

        void CalculateMagicalStats();

        void CalculateBaseStats();
    }
}
