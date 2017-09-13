using System;
using System.Collections.Generic;
using System.Linq;

namespace _11.Pokemon_Trainer
{
    public class StartUp
    {
        public static void Main()
        {
            var trainers = new List<Trainer>();

            var trainersInput = Console.ReadLine();

            while (trainersInput != "Tournament")
            {
                var trainersInfo = trainersInput.Split(' ');

                var name = trainersInfo[0];
                var pokemonName = trainersInfo[1];
                var element = trainersInfo[2];
                var health = int.Parse(trainersInfo[3]);

                var pokemon = new Pokemon(pokemonName, element, health);
                var trainer = new Trainer(name);

                if (!trainers.Any(t => t.Name == name))
                {
                    trainer.AddPokemon(pokemon);
                    trainers.Add(trainer);
                }
                else
                {
                    trainers.Find(t => t.Name == name).AddPokemon(pokemon);
                }

                trainersInput = Console.ReadLine();
            }

            var elementNeeded = Console.ReadLine();

            while (elementNeeded != "End")
            {
                foreach (var trainer in trainers)
                {
                    if (trainer.Pokemons.Any(p => p.Element == elementNeeded))
                    {
                        trainer.AddBadge();
                    }
                    else
                    {
                        trainer.PokemonsLooseHealth();
                        trainer.UpdatePokemons();
                    }
                }

                elementNeeded = Console.ReadLine();
            }

            foreach (var trainer in trainers.OrderByDescending(t => t.Badges))
            {
                Console.WriteLine($"{trainer.Name} {trainer.Badges} {trainer.Pokemons.Count}");
            }
        }
    }
}
