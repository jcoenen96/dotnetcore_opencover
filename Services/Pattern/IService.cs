using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Pattern
{
	public interface IService<TEntity> where TEntity : class
	{
		TEntity Find(int id);
		void Add(TEntity entity);
		void AddRange(IEnumerable<TEntity> entities);
		void Update(TEntity entity);
		void Remove(int id);
		void Remove(TEntity entity);
	}
}
