using System.Security.Cryptography.X509Certificates;

namespace PokemonTrainer;

    public class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Trainer> trainers= new();
            string firstInput;
            while ((firstInput = Console.ReadLine())!= "Tournament")
            {
                string[] trainerData = firstInput.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string trainerName = trainerData[0];
                string pokemonName = trainerData[1];
                string element = trainerData[2];
                int health = int.Parse(trainerData[3]);

                Trainer currentTrainer = new Trainer(trainerName, 0);
                Pokemon currentPokemon = new Pokemon(pokemonName, element, health);
                if (!trainers.ContainsKey(trainerName))
                {
                trainers.Add(trainerName, currentTrainer);
                trainers[trainerName].Pokemons.Add(currentPokemon);
                }
                else
                {
                trainers[trainerName].Pokemons.Add(currentPokemon);
                }

            }

            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                foreach (Trainer trainer in trainers.Values)
                {
            bool hasElement = false;
                    foreach (Pokemon pokemon in trainer.Pokemons)
                    {
                        if (pokemon.Element == command)
                        {
                            hasElement = true;
                        }
                    }

                    if (hasElement)
                    {
                        trainer.NumberOfBadges++;
                    }
                    else
                    {
                        trainer.Pokemons.ConvertAll(x => x.Health -= 10);
                    }

                    while(trainer.Pokemons.Any(x=>x.Health <= 0))
                    {
                        Pokemon current = trainer.Pokemons.FirstOrDefault(x => x.Health <= 0);
                        trainer.Pokemons.Remove(current);
                    }
                }
            }

            foreach (Trainer trainer in trainers.Values.OrderByDescending(t=>t.NumberOfBadges))
            {
                Console.WriteLine($"{trainer.Name} {trainer.NumberOfBadges} {trainer.Pokemons.Count}");
            }
        }
    }
