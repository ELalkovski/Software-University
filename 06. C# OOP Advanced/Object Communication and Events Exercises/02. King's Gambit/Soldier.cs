namespace _02.King_s_Gambit
{
    using System;

    public abstract class Soldier : IUnit
    {
        private string name;

        protected Soldier(string name)
        {
            this.name = name;
        }

        public string Name
        {
            get { return this.name; }
        }

        public abstract void KingUnderAttack(object sender, EventArgs args);
    }
}