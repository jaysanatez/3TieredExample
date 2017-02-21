using PokemonTracker.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonTracker.Services.Interfaces
{
	public interface IHomeService
	{
		HomeViewModel GetHomeViewModel();
		SearchViewModel GetSearchViewModel(string param);
	}
}
