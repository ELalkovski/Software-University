namespace _05.King_s_Gambit_Extended
{
    using System;

    public class SoldierDeathEventArgs : EventArgs
    {
        public SoldierDeathEventArgs(int health)
        {
            this.Health = health;
        }

        public int Health { get; set; }
    }
}
