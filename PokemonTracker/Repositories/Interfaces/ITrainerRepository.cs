using PokemonTracker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonTracker.Repositories.Interfaces
{
	// don't take these return types to be the best way to do things -
	//   maybe you want to return bools or some status..
	// didn't include Update since this is a dummy
	public interface ITrainerRepository
	{
		IEnumerable<Trainer> GetAll();
		IEnumerable<Trainer> SearchByKey(string key);
		Trainer GetById(int id);
		void Insert(Trainer trainer);
		void Delete(int id);
	}
}
