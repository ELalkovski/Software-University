namespace _05.King_s_Gambit_Extended
{
    using System;

    public class Footman : Soldier
    {
        private const int footmanHealth = 2;

        public Footman(string name) 
            : base(name, footmanHealth)
        {
        }

        public override void KingUnderAttack(object sender, EventArgs args)
        {
            Console.WriteLine($"Footman {this.Name} is panicking!");
        }
    }
}