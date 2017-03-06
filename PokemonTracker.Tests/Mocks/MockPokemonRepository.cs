using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using PokemonTracker.Models;
using PokemonTracker.Repositories.Interfaces;
using System.Linq;

namespace PokemonTracker.Tests.Mocks
{
	public class MockPokemonRepository : IPokemonRepository
	{
		private List<Pokemon> _allPokemon;
		public MockPokemonRepository(List<Pokemon> allPokemon)
		{
			_allPokemon = allPokemon;
		}

		public void Delete(Pokemon obj)
		{
			var pokemon = Find(obj.Id);
			_allPokemon.Remove(pokemon);
		}

		public Pokemon Find(int id)
		{
			return _allPokemon.Find(p => p.Id == id);
		}

		public IEnumerable<Pokemon> GetAll()
		{
			return _allPokemon;
		}

		public void Insert(Pokemon obj)
		{
			_allPokemon.Add(obj);
		}

		public IEnumerable<Pokemon> Where(Expression<Func<Pokemon, bool>> where)
		{
			return _allPokemon.AsQueryable().Where(where).AsEnumerable();
		}
	}
}
