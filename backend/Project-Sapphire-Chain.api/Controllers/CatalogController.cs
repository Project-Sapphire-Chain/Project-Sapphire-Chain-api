using Microsoft.ASPNetCore.Mvc
using Sapphire.Chain.Domain.Catalog

namespace Sapphire.Chain.Api.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class CatalogController : ControllerBase
	{

	}
}

[HttpGet]
public IActionResult GetItems()
{
	return Ok("hello world.");
}