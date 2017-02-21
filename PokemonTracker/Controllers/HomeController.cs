using PokemonTracker.Services;
using PokemonTracker.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PokemonTracker.Controllers
{
	public class HomeController : Controller
	{
		private IHomeService _homeService;

		public HomeController()
		{
			_homeService = new HomeService();
		}

		// Http GET by default
		// '/' will map to 'Home/Index' : check App_Start/RouteConfig
		// Note how there is a Views/Home/Index.cshtml file -  this is what View() references
		public ActionResult Index()
		{
			var model = _homeService.GetHomeViewModel();
			return View(model);
		}

		// again, notice the corresponding Views/Home/Search file
		public ActionResult Search(string param)
		{
			if (String.IsNullOrEmpty(param))
			{
				return RedirectToAction("Index");
			}

			var model = _homeService.GetSearchViewModel(param);
			return View(model);
		}
	}
}