using PokemonTracker.Models;
using PokemonTracker.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PokemonTracker.Repositories
{
	public class TrainerRepository : ITrainerRepository
	{
		private PokemonTrackerContext _context;

		public TrainerRepository()
		{
			_context = new PokemonTrackerContext();
		}

		public void Delete(int index)
		{
			var trainer = GetById(index);
			_context.Trainers.Remove(trainer);
			_context.SaveChanges();
		}

		public IEnumerable<Trainer> GetAll()
		{
			return _context.Trainers.AsEnumerable();
		}

		public IEnumerable<Trainer> SearchByKey(string key)
		{
			return _context.Trainers.Where(t => t.Name.Contains(key));
		}

		public Trainer GetById(int id)
		{
			return _context.Trainers.AsQueryable().Where(t => t.Id == id).FirstOrDefault();
		}

		public void Insert(Trainer trainer)
		{
			_context.Trainers.Add(trainer);
			_context.SaveChanges();
		}
	}
}