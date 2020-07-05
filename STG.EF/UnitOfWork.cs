namespace STG.DataAccess
{
	using Microsoft.EntityFrameworkCore;

	public class UnitOfWork : IUnitOfWork
	{
		private readonly STGContext _context;

		public UnitOfWork()
		{
			this._context = new STGContext();
		}

		public DbContext Db
		{
			get { return this._context; }
		}

		public void Dispose()
		{
			this._context.Dispose();
		}
	}
}

