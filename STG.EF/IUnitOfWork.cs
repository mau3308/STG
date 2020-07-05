namespace STG.DataAccess
{
	using Microsoft.EntityFrameworkCore;

	public interface IUnitOfWork
	{
		DbContext Db { get; }

		void Dispose();
	}
}