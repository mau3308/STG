using STG.Model;

namespace STG.DataAccess
{
	public class SolicitudServicioRepository : BaseRepository<SolicitudServicio>
	{
		private readonly STGContext _context;

		public SolicitudServicioRepository(STGContext context)
		{
			_context = context;
		}
	}
}
