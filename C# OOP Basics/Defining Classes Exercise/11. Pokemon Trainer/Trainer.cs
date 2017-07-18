using System.Collections.Generic;
using System.Linq;

namespace _11.Pokemon_Trainer
{
    public class Trainer
    {
        private string name;
        private int badgesAmount;
        private List<Pokemon> pokemons;

        public Trainer(string name)
        {
            this.name = name;
            this.badgesAmount = 0;
            this.pokemons = new List<Pokemon>();
        }
        public string Name
        {
            get { return this.name; }
        }

        public int Badges
        {
            get { return this.badgesAmount; }
        }

        public List<Pokemon> Pokemons
        {
            get { return this.pokemons; }
        }

        public void AddPokemon(Pokemon pokemon)
        {
            this.pokemons.Add(pokemon);
        }

        public void AddBadge()
        {
            this.badgesAmount++;
        }

        public void PokemonsLooseHealth()
        {
            foreach (var pokemon in this.pokemons)
            {
                pokemon.UpdateHealth();
            }
        }

        public void UpdatePokemons()
        {
            var index = 0;
            var indexesToRemove = new List<int>();

            foreach (var pokemon in this.pokemons)
            {
                if (pokemon.Health <= 0)
                {
                    indexesToRemove.Add(index);
                }
                index++;
            }
            if (indexesToRemove.Count > 0)
            {
                foreach (var position in indexesToRemove.OrderByDescending(i => i))
                {
                    if (this.pokemons.Count > 0)
                    {
                        this.pokemons.RemoveAt(position);
                    } 
                }
            }
            
        }
    }
}
