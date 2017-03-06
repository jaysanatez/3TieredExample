using PokemonTracker.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using PokemonTracker.Models;
using System.Linq.Expressions;

namespace PokemonTracker.Repositories
{
	public class PokemonRepository : IPokemonRepository
	{
		private PokemonTrackerContext _context;

		public PokemonRepository()
		{
			_context = new PokemonTrackerContext();
		}

		public void Delete(Pokemon obj)
		{
			var pokemon = Find(obj.Id);
			_context.Pokemons.Remove(pokemon);
			_context.SaveChanges();
		}

		public Pokemon Find(int id)
		{
			return _context.Pokemons.Find(id);
		}

		public IEnumerable<Pokemon> GetAll()
		{
			return _context.Pokemons.AsEnumerable();
		}

		public void Insert(Pokemon obj)
		{
			_context.Pokemons.Add(obj);
			_context.SaveChanges();
		}

		public IEnumerable<Pokemon> Where(Expression<Func<Pokemon, bool>> where)
		{
			return GetAll().AsQueryable().Where(where);
		}
	}
}