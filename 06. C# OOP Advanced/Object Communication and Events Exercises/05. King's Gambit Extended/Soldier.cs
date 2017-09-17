namespace _05.King_s_Gambit_Extended
{
    using System;

    public delegate void SoldierDeathEventHandler(object sender, SoldierDeathEventArgs args);

    public abstract class Soldier : IUnit
    {
        private string name;
        private int health;
        public event SoldierDeathEventHandler SoldierDeath;

        protected Soldier(string name, int health)
        {
            this.name = name;
            this.health = health;
        }

        public int Health
        {
            get { return this.health; }
        }

        public string Name
        {
            get { return this.name; }
        }

        public abstract void KingUnderAttack(object sender, EventArgs args);

        public void RespondToAttack()
        {
            if (this.health == 0)
            {
                OnSoldierDeath(new SoldierDeathEventArgs(this.Name, KingUnderAttack));
            }
        }

        protected void OnSoldierDeath(SoldierDeathEventArgs args)
        {
            if (SoldierDeath != null)
            {
                SoldierDeath(this, args);
            }
        }
    }
}