using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PokemonTracker.Models
{
	public enum PokemonType
	{
		GRASS,
		WATER,
		FIRE,
		FAIRY,
		ELECTRIC,
		FIGHTING,
		DRAGON
	};

	public class Pokemon
	{
		public int Id { get; set; }

		[Required]
		public string Name { get; set; }

		[Required]
		public PokemonType Type { get; set; }
	}
}