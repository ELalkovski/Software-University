﻿namespace _11.Pokemon_Trainer
{
    public class Pokemon
    {
        private string name;
        private string element;
        private int health;

        public Pokemon(string name, string element, int health)
        {
            this.name = name;
            this.element = element;
            this.health = health;
        }

        public string Name
        {
            get { return this.name; }
        }

        public string Element
        {
            get { return this.element; }
        }

        public int Health
        {
            get { return this.health; }
        }

        public void UpdateHealth()
        {
            this.health -= 10;
        }
    }
}
