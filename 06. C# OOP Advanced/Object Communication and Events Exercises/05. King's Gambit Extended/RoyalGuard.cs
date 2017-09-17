namespace _05.King_s_Gambit_Extended
{
    using System;

    public class RoyalGuard : Soldier
    {
        private const int guardHealth = 3;

        public RoyalGuard(string name) 
            : base(name, guardHealth)
        {
        }

        public override void KingUnderAttack(object sender, EventArgs args)
        {
            Console.WriteLine($"Royal Guard {this.Name} is defending!");
        }
    }
}
