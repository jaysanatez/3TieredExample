using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Mvc;
using PokemonTracker.Repositories;
using PokemonTracker.Repositories.Interfaces;
using PokemonTracker.Services;
using PokemonTracker.Services.Interfaces;
using System.Web.Mvc;

namespace PokemonTracker
{
	public class Bootstrapper
	{
		public static void Initialise()
		{
			var container = BuildUnityContainer();
			DependencyResolver.SetResolver(new UnityDependencyResolver(container));
		}

		private static IUnityContainer BuildUnityContainer()
		{
			var container = new UnityContainer();

			container.RegisterType<IPokemonRepository, PokemonRepository>();
			container.RegisterType<ITrainerRepository, TrainerRepository>();

			container.RegisterType<IPokemonService, PokemonService>();
			container.RegisterType<ITrainerService, TrainerService>();

			return container;
		}
	}
}