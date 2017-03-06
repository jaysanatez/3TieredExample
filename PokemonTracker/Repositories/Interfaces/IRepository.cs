using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace PokemonTracker.Repositories.Interfaces
{
	public interface IRepository<T> where T : class
	{
		IEnumerable<T> GetAll();
		IEnumerable<T> Where(Expression<Func<T, bool>> where);
		T Find(int id);
		void Insert(T obj);
		void Delete(T obj);
	}
}
