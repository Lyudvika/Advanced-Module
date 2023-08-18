namespace PokemonTrainer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Trainer> trainers = new List<Trainer>();

            string command;
            while ((command = Console.ReadLine()) != "Tournament")
            {
                string[] trainerInfo = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string trainerName = trainerInfo[0];
                string pokemonName = trainerInfo[1];
                string pokemonElement = trainerInfo[2];
                int pokemonHealth = int.Parse(trainerInfo[3]);

                Pokemon pokemon = new Pokemon(pokemonName, pokemonElement, pokemonHealth);
                var trainer = trainers.FirstOrDefault(n => n.Name == trainerName);

                if (trainer == null)
                {
                    trainer = new Trainer(trainerName);
                    trainer.Pokemons.Add(pokemon);

                    trainers.Add(trainer);
                }
                else
                {
                    trainer.Pokemons.Add(pokemon);
                }
            }

            while ((command = Console.ReadLine()) != "End")
            {
                foreach (var trainer in trainers)
                {
                    if (trainer.Pokemons.Any(b => b.Element == command))
                    {
                        trainer.NumberOfBadges++;
                    }
                    else
                    {
                        trainer.Pokemons.ForEach(h => h.Health -= 10);
                    }

                    trainer.Pokemons.RemoveAll(x => x.Health <= 0);
                }
            }

            foreach (var trainer in trainers.OrderByDescending(b => b.NumberOfBadges))
            {
                Console.WriteLine(trainer);
            }
        }
    }
}