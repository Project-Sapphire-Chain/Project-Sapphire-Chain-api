using Microsoft.AspNetCore.Mvc;
using Sapphire.Chain.Domain.Catalog;
using System.Collections.Generic;

namespace Sapphire.Chain.Api.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class CatalogController : ControllerBase
	{
		[HttpGet]
		public IActionResult GetItems()
	{
		return Ok("hello world.");
	}
	}
}

