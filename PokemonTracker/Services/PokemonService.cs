using System.Collections.Generic;
using PokemonTracker.Models;
using PokemonTracker.Repositories.Interfaces;
using PokemonTracker.Repositories;

namespace PokemonTracker.Services.Interfaces
{
	public class PokemonService : IPokemonService
	{
		private IPokemonRepository _pokemonRepo;

		public PokemonService()
		{
			_pokemonRepo = new PokemonRepository();
		}

		public IEnumerable<Pokemon> GetAllPokemon()
		{
			return _pokemonRepo.GetAll();
		}

		public IEnumerable<Pokemon> SearchPokemonForKey(string key)
		{
			return _pokemonRepo.Where(p => p.Name.Contains(key));
		}
	}
}