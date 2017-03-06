using PokemonTracker.Models;
using PokemonTracker.Repositories.Interfaces;
using PokemonTracker.Services.Interfaces;
using System.Collections.Generic;

namespace PokemonTracker.Services
{
	public class TrainerService : ITrainerService
	{
		private ITrainerRepository _trainerRepo;

		public TrainerService(ITrainerRepository trainerRepo)
		{
			_trainerRepo = trainerRepo;
		}

		public IEnumerable<Trainer> GetAllTrainers()
		{
			return _trainerRepo.GetAll();
		}

		public IEnumerable<Trainer> SearchTrainersForKey(string key)
		{
			return _trainerRepo.Where(t => t.Name.Contains(key));
		}
	}
}