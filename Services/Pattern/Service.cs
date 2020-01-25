using Repository.Pattern;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Pattern
{
	public abstract class Service<TEntity> : IService<TEntity> where TEntity : class
	{
		protected IRepository<TEntity> Repository { get; }

		protected Service(IRepository<TEntity> repository)
		{
			Repository = repository;
		}

		public virtual TEntity Find(int id)
		{
			return Repository.Find(id);
		}

		public virtual void Add(TEntity entity)
		{
			Repository.Add(entity);
		}

		public virtual void AddRange(IEnumerable<TEntity> entities)
		{
			Repository.AddRange(entities);
		}

		public virtual void Update(TEntity entity) 
		{ 
			Repository.Update(entity);
		}

		public virtual void Remove(TEntity entity) 
		{
			Repository.Remove(entity);
		}

		public virtual void Remove(int id)
		{
			Repository.Remove(id);
		}
	}
}
