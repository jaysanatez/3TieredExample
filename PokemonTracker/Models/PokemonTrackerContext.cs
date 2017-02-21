using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PokemonTracker.Models
{
	public class PokemonTrackerContext : DbContext
	{
		public PokemonTrackerContext(): base("name=PokemonTrackerContext")
		{ }

		public DbSet<Pokemon> Pokemons { get; set; }
		public DbSet<Trainer> Trainers { get; set; }
	}
}