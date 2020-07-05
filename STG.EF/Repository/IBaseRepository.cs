namespace STG.DataAccess
{
	using System;
	using System.Collections.Generic;
	using System.Linq.Expressions;

	public interface IBaseRepository<T>
	{
		List<T> GetAll();

		T Add(T entity);

		void Update(T entity);

		void Delete(T entity);

		List<T> GetByExpression(Expression<Func<T, bool>> expression);
	}
}
