using PokemonTracker.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PokemonTracker.Models;

namespace PokemonTracker.Repositories
{
	public class PokemonRepository : IPokemonRepository
	{
		private PokemonTrackerContext _context;

		public PokemonRepository()
		{
			_context = new PokemonTrackerContext();
		}

		public void Delete(int id)
		{
			var pokemon = GetById(id);
			_context.Pokemons.Remove(pokemon);
			_context.SaveChanges();
		}

		public IEnumerable<Pokemon> GetAll()
		{
			return _context.Pokemons.AsEnumerable();
		}

		public IEnumerable<Pokemon> SearchByKey(string key)
		{
			return _context.Pokemons.Where(t => t.Name.Contains(key));
		}

		public Pokemon GetById(int id)
		{
			return _context.Pokemons.AsQueryable().Where(p => p.Id == id).FirstOrDefault();
		}

		public void Insert(Pokemon pokemon)
		{
			_context.Pokemons.Add(pokemon);
			_context.SaveChanges();
		}
	}
}