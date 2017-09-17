namespace _02.King_s_Gambit
{
    using System;

    public class RoyalGuard : Soldier
    {
        public RoyalGuard(string name) 
            : base(name)
        {
        }

        public override void KingUnderAttack(object sender, EventArgs args)
        {
            Console.WriteLine($"Royal Guard {this.Name} is defending!");
        }
    }
}
