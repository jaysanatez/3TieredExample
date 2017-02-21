using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PokemonTracker.Models.ViewModels
{
	public class SearchViewModel
	{
		public string SearchParam { get; set; }
		public IEnumerable<Pokemon> Pokemons { get; set; }
		public IEnumerable<Trainer> Trainers { get; set; }
	}
}