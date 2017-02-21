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
	public interface IPokemonRepository
	{
		IEnumerable<Pokemon> GetAll();
		IEnumerable<Pokemon> SearchByKey(string key);
		Pokemon GetById(int id);
		void Insert(Pokemon pokemon);
		void Delete(int id);
	}
}
