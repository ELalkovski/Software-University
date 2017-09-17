namespace _02.King_s_Gambit
{
    using System;

    public class Footman : Soldier
    {
        public Footman(string name) 
            : base(name)
        {
        }

        public override void KingUnderAttack(object sender, EventArgs args)
        {
            Console.WriteLine($"Footman {this.Name} is panicking!");
        }
    }
}