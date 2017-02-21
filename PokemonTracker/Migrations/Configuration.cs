namespace PokemonTracker.Migrations
{
	using Models;
	using System;
	using System.Data.Entity;
	using System.Data.Entity.Migrations;
	using System.Linq;

	internal sealed class Configuration : DbMigrationsConfiguration<PokemonTracker.Models.PokemonTrackerContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(PokemonTrackerContext context)
        {
			context.Pokemons.AddOrUpdate(p => p.Id,
				new Pokemon { Id = 1, Name = "Bulbasaur", Type = PokemonType.GRASS },
				new Pokemon { Id = 2, Name = "Charmander", Type = PokemonType.FIRE },
				new Pokemon { Id = 3, Name = "Squirtle", Type = PokemonType.WATER },
				new Pokemon { Id = 4, Name = "Pikachu", Type = PokemonType.ELECTRIC },
				new Pokemon { Id = 5, Name = "Jigglypuff", Type = PokemonType.FAIRY },
				new Pokemon { Id = 6, Name = "Growlithe", Type = PokemonType.FIRE },
				new Pokemon { Id = 7, Name = "Machamp", Type = PokemonType.FIGHTING },
				new Pokemon { Id = 8, Name = "Magikarp", Type = PokemonType.WATER },
				new Pokemon { Id = 9, Name = "Gyarados", Type = PokemonType.WATER },
				new Pokemon { Id = 10, Name = "Dragonite", Type = PokemonType.DRAGON }
				);

			context.Trainers.AddOrUpdate(t => t.Id,
				new Trainer { Id = 1, Name = "Jake", DateJoined = new DateTime(2017, 8, 8) },
				new Trainer { Id = 2, Name = "Tobin", DateJoined = new DateTime(2017, 7, 5) },
				new Trainer { Id = 3, Name = "Trevor", DateJoined = new DateTime(2017, 7, 12) }
				);
        }
    }
}
