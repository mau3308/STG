namespace STG.DataAccess
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Linq.Expressions;
	using Microsoft.EntityFrameworkCore;

	public class BaseRepository<T> :IBaseRepository<T> where T : class
	{
		internal DbSet<T> dbSet;
		private readonly IUnitOfWork _unitOfWork;

		public BaseRepository(IUnitOfWork unitOfWork)
		{
			_unitOfWork = unitOfWork;
			this.dbSet = _unitOfWork.Db.Set<T>();	
		}

		public T Add(T entity)
		{
			this.dbSet.Add(entity);
			this._unitOfWork.Db.SaveChanges();
			return entity;
		}

		public void Delete(T entity)
		{
			this.dbSet.Remove(entity);
			this._unitOfWork.Db.SaveChanges();
		}

		public void Update(T entity)
		{
			this.dbSet.Update(entity);
			this._unitOfWork.Db.SaveChanges();
		}

		public List<T> GetAll() 
			=> this.dbSet.ToList();

		public List<T> GetByExpression(Expression<Func<T, bool>> expression)
			=> this.dbSet.Where(expression).ToList();
	}
}
