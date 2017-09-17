namespace _05.King_s_Gambit_Extended
{
    using System;

    public interface IUnit
    {
        string Name { get; }

        void KingUnderAttack(object sender, EventArgs args);
    }
}
