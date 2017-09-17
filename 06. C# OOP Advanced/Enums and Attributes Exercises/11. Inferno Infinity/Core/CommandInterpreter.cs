namespace _11.Inferno_Infinity.Core
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Models;

    public class CommandInterpreter
    {
        private List<Weapon> weapons;

        public CommandInterpreter()
        {
            this.weapons = new List<Weapon>();
        }

        public void Create(string rarity, string type, string name)
        {
            var weapon = new Weapon(rarity, type, name);
            this.weapons.Add(weapon);
        }

        public void Add(string name, int index, string clarity, string type)
        {
            var gem = new Gem(clarity, type);
            this.weapons.First(w => w.Name.Equals(name)).AddGem(index, gem);
        }

        public void Remove(string name, int index)
        {
            this.weapons.First(w => w.Name.Equals(name)).RemoveGem(index);
        }

        public void Print(string name)
        {
            var weapon = this.weapons.First(w => w.Name.Equals(name));
            weapon.CalculateMagicalStats();
            weapon.CalculateBaseStats();
            Console.WriteLine(weapon.ToString());
        }
    }
}
