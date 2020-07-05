namespace STG.DataAccess
{
	using STG.Model;

	public class ProductoRepository: BaseRepository<Producto>
	{
		public ProductoRepository(IUnitOfWork unitOfWork) : base(unitOfWork) { }
	}
}
