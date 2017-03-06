using PokemonTracker.Models.ViewModels;
using PokemonTracker.Services.Interfaces;
using System;
using System.Web.Mvc;

namespace PokemonTracker.Controllers
{
	public class HomeController : Controller
	{
		private IPokemonService _pokemonService;
		private ITrainerService _trainerService;

		public HomeController(IPokemonService pokemonService, ITrainerService trainerService)
		{
			_pokemonService = pokemonService;
			_trainerService = trainerService;
		}

		// Http GET by default
		// '/' will map to 'Home/Index' : check App_Start/RouteConfig
		// Note how there is a Views/Home/Index.cshtml file -  this is what View() references
		public ActionResult Index()
		{
			var viewModel = new HomeViewModel()
			{
				Pokemons = _pokemonService.GetAllPokemon(),
				Trainers = _trainerService.GetAllTrainers()
			};

			return View(viewModel);
		}

		// again, notice the corresponding Views/Home/Search file
		public ActionResult Search(string param)
		{
			if (String.IsNullOrEmpty(param))
			{
				return RedirectToAction("Index");
			}

			var viewModel = new SearchViewModel()
			{
				Pokemons = _pokemonService.SearchPokemonForKey(param),
				Trainers = _trainerService.SearchTrainersForKey(param),
				SearchParam = param
			};

			return View(viewModel);
		}
	}
}