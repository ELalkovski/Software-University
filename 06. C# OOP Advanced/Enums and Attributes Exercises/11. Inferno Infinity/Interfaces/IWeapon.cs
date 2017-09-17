namespace _11.Inferno_Infinity
{
    using Models;

    public interface IWeapon
    {
        void AddGem(int index, Gem gem);

        void RemoveGem(int index);

        void CalculateMagicalStats();

        void CalculateBaseStats();
    }
}
