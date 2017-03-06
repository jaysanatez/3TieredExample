using PokemonTracker.Models;
using System.Collections.Generic;

namespace PokemonTracker.Services.Interfaces
{
	public interface IPokemonService
	{
		IEnumerable<Pokemon> GetAllPokemon();
		IEnumerable<Pokemon> SearchPokemonForKey(string key);
	}
}
