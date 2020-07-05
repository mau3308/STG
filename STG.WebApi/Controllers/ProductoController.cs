namespace STG.WebApi.Controllers
{
	using System.Collections.Generic;
	using System.Linq;
	using Microsoft.AspNetCore.Mvc;

	[Route("api/[controller]")]
	[ApiController]
	public class ProductoController : ControllerBase
	{
		private readonly STGContext context;

		public ProductoController(STGContext context)
		{
			this.context = context;
		}

		[HttpGet]
		public IEnumerable<Producto> Get()
		{
			return context.Producto.ToList();
		}

	}
}
