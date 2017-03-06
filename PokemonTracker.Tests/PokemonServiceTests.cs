using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PokemonTracker.Services.Interfaces;
using PokemonTracker.Tests.Mocks;
using PokemonTracker.Models;
using System.Collections.Generic;
using System.Linq;

namespace PokemonTracker.Tests
{
	[TestClass]
	public class PokemonServiceTests
	{
		public static List<Pokemon> pokemonList = new List<Pokemon>
		{
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
		};

		public static List<Pokemon> pokemonWithT = new List<Pokemon>
		{
			new Pokemon { Id = 3, Name = "Squirtle", Type = PokemonType.WATER },
			new Pokemon { Id = 6, Name = "Growlithe", Type = PokemonType.FIRE },
			new Pokemon { Id = 10, Name = "Dragonite", Type = PokemonType.DRAGON }
		};

		private PokemonService GetService()
		{
			var mockRepo = new MockPokemonRepository(pokemonList);
			return new PokemonService(mockRepo);
		}

		[TestMethod]
		public void TestGetAllPokemon()
		{
			var service = GetService();
			var allPokemon = service.GetAllPokemon();
			CompareLists(allPokemon.ToList(), pokemonList);
		}

		[TestMethod]
		public void TestSearchPokemon()
		{
			var service = GetService();
			var pokemonSearchedByT = service.SearchPokemonForKey("t");
			CompareLists(pokemonSearchedByT.ToList(), pokemonWithT);
		}

		private void CompareLists(List<Pokemon> actual, List<Pokemon> expected)
		{
			Assert.AreEqual(actual.Count, expected.Count);

			for (var i = 0; i < actual.Count; i++)
			{
				var a = actual.ElementAt(i);
				var e = expected.ElementAt(i);

				Assert.AreEqual(a.Id, e.Id);
				Assert.AreEqual(a.Name, e.Name);
				Assert.AreEqual(a.Type, e.Type);
			}
		}
	}
}
