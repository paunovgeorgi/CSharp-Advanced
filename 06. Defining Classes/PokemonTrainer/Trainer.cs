

namespace PokemonTrainer;

    public class Trainer
    {
        public Trainer(string name, int numberOfBadges)
        {
            Name = name;
            NumberOfBadges = numberOfBadges;
            Pokemons = new();
        }

        public string Name { get; set; }
        public int NumberOfBadges { get; set; }

        public List<Pokemon> Pokemons { get; set; }
    }

