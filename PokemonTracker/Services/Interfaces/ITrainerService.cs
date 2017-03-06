using PokemonTracker.Models;
using System.Collections.Generic;

namespace PokemonTracker.Services.Interfaces
{
	public interface ITrainerService
	{
		IEnumerable<Trainer> GetAllTrainers();
		IEnumerable<Trainer> SearchTrainersForKey(string key);
	}
}
