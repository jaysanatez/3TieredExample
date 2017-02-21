using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PokemonTracker.Models
{
	public class Trainer
	{
		public int Id { get; set; }
		[Required]
		public string Name { get; set; }
		public DateTime DateJoined { get; set; }
	}
}