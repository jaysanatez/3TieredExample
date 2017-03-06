using PokemonTracker.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PokemonTracker.Models.ViewModels;
using PokemonTracker.Repositories.Interfaces;
using PokemonTracker.Repositories;

namespace PokemonTracker.Services
{
	public class HomeService : IHomeService
	{
		private IPokemonRepository _pokemonRepo;
		private ITrainerRepository _trainerRepo;

		public HomeService()
		{
			_pokemonRepo = new PokemonRepository();
			_trainerRepo = new TrainerRepository();
		}

		public HomeViewModel GetHomeViewModel()
		{
			return new HomeViewModel()
			{
				Pokemons = _pokemonRepo.GetAll(),
				Trainers = _trainerRepo.GetAll()
			};
		}

		public SearchViewModel GetSearchViewModel(string param)
		{
			return new SearchViewModel()
			{
				SearchParam = param,
				Pokemons = _pokemonRepo.Where(p => p.Name.Contains(param)),
				Trainers = _trainerRepo.Where(t => t.Name.Contains(param))
			};
		}
	}
}