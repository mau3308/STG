namespace STG.WebApi.Controllers
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Threading.Tasks;
	using Microsoft.AspNetCore.Http;
	using Microsoft.AspNetCore.Mvc;
	using STG.WebApi.Models;

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
