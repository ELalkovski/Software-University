namespace _11.Inferno_Infinity.Models
{
    using System;
    using Enums;

    public class Weapon : IWeapon
    {
        private string name;
        private int minDmg;
        private int maxDmg;
        private int strength;
        private int agility;
        private int vitality;
        private WeaponType weaponType;
        private WeaponRarity weaponRarity;
        private Gem[] sockets;

        public Weapon(string rarity, string type, string name)
        {
            Enum.TryParse(rarity, out weaponRarity);
            Enum.TryParse(type, out weaponType);
            this.name = name;
            this.minDmg = 0;
            this.maxDmg = 0;
            this.strength = 0;
            this.agility = 0;
            this.vitality = 0;
            this.CreateBaseStats();
        }

        public string Name { get { return this.name; } }

        private void CreateBaseStats()
        {
            if ((int)this.weaponType == 0)
            {
                this.sockets = new Gem[4];
                this.minDmg = 5;
                this.maxDmg = 10;
            }
            else if ((int)this.weaponType == 1)
            {
                this.sockets = new Gem[3];
                this.minDmg = 4;
                this.maxDmg = 6;
            }
            else
            {
                this.sockets = new Gem[2];
                this.minDmg = 3;
                this.maxDmg = 4;
            }
        }

        public void AddGem(int index, Gem gem)
        {
            if (index >= 0 && index < this.sockets.Length)
            {
                this.sockets[index] = gem;
            }
        }

        public void RemoveGem(int index)
        {
            if (index >= 0 && index < this.sockets.Length)
            {
                this.sockets[index] = null;
            }
        }

        public void CalculateBaseStats()
        {
            this.minDmg *= (int) this.weaponRarity;
            this.minDmg += 2 * this.strength;
            this.minDmg += this.agility;
            this.maxDmg *= (int) this.weaponRarity;
            this.maxDmg += 3 * this.strength;
            this.maxDmg += 4 * this.agility;
        }

        public void CalculateMagicalStats()
        {
            foreach (var gem in this.sockets)
            {
                if (gem != null)
                {
                    this.strength += gem.StrengthBonus;
                    this.agility += gem.AgilityBonus;
                    this.vitality += gem.VitalityBonus;
                }
            }
        }

        public override string ToString()
        {
            return
                $"{this.name}: {this.minDmg}-{this.maxDmg} Damage, +{this.strength} Strength, +{this.agility} Agility, +{this.vitality} Vitality";
        }
    }
}
