namespace _02.King_s_Gambit
{
    using System;

    public class King
    {
        private string name;
        public event EventHandler UnderAttack;

        public King(string name)
        {
            this.name = name;
        }

        public string Name
        {
            get { return this.name; }
        }

        public void KingUnderAttack()
        {
            Console.WriteLine($"King {this.name} is under attack!");
            this.OnKingsAttack();
        }

        public void OnKingsAttack()
        {
            if (UnderAttack != null)
            {
                UnderAttack(this, new EventArgs());
            }
        }
    }
}
