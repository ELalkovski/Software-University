namespace _11.Inferno_Infinity.Core
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Models;

    public class CommandInterpreter
    {
        private List<IWeapon> weapons;

        public CommandInterpreter()
        {
            this.weapons = new List<IWeapon>();
        }

        public void Create(string rarity, string type, string name)
        {
            IWeapon weapon = new Weapon(rarity, type, name);
            this.weapons.Add(weapon);
        }

        public void Add(string name, int index, string clarity, string type)
        {
            Gem gem = new Gem(clarity, type);
            this.weapons.First(w => w.Name.Equals(name)).AddGem(index, gem);
        }

        public void Remove(string name, int index)
        {
            this.weapons.First(w => w.Name.Equals(name)).RemoveGem(index);
        }

        public void Print(string name)
        {
            IWeapon weapon = this.weapons.First(w => w.Name.Equals(name));
            weapon.CalculateMagicalStats();
            weapon.CalculateBaseStats();

            Console.WriteLine(weapon.ToString());
        }
    }
}
