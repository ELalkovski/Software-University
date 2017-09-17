namespace _02.King_s_Gambit
{
    using System;

    public interface IUnit
    {
        string Name { get; }

        void KingUnderAttack(object sender, EventArgs args);
    }
}
