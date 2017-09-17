namespace _11.Pokemon_Trainer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            string trainersInput = Console.ReadLine();

            List<Trainer> trainers = new List<Trainer>();

            while (trainersInput != "Tournament")
            {
                string[] trainersInfo = trainersInput.Split(' ');
                string name = trainersInfo[0];
                string pokemonName = trainersInfo[1];
                string element = trainersInfo[2];
                int health = int.Parse(trainersInfo[3]);
                Pokemon pokemon = new Pokemon(pokemonName, element, health);
                Trainer trainer = new Trainer(name);

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

            string elementNeeded = Console.ReadLine();

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
