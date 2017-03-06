using PokemonTracker.Models;
using PokemonTracker.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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

		public void Delete(Trainer obj)
		{
			var trainer = Find(obj.Id);
			_context.Trainers.Remove(trainer);
			_context.SaveChanges();
		}

		public Trainer Find(int id)
		{
			return _context.Trainers.Find(id);
		}

		public IEnumerable<Trainer> GetAll()
		{
			return _context.Trainers.AsEnumerable();
		}

		public void Insert(Trainer obj)
		{
			_context.Trainers.Add(obj);
			_context.SaveChanges();
		}

		public IEnumerable<Trainer> Where(Expression<Func<Trainer, bool>> where)
		{
			return GetAll().AsQueryable().Where(where);
		}
	}
}