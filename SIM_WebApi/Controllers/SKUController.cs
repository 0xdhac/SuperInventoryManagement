using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SIM_SharedLib.Models;

namespace SIM_WebServer.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class SKUController : ControllerBase
	{
		private readonly ApplicationDbContext _context;

		public SKUController(ApplicationDbContext context)
		{
			_context = context;
		}

		[HttpGet]
		public async Task<ActionResult<IEnumerable<Product>>> GetProducts()
		{
			var products = await _context.Companies.ToListAsync();
			return Ok(products);
		}

		[HttpGet("{id}")]
		public async Task<ActionResult<Product>> GetProduct(int id)
		{
			var product = await _context.Companies.FindAsync(id);
			if (product == null)
			{
				return NotFound();
			}
			return Ok(product);
		}

		[HttpGet("healthcheck")]
		public async Task<ActionResult<string>> HealthCheck()
		{
			try
			{
				// Attempt to query the database
				var anyProduct = await _context.Companies.FirstOrDefaultAsync();
				return Ok("Connected to MySQL database successfully.");
			}
			catch (Exception ex)
			{
				return StatusCode(500, $"Failed to connect to MySQL database: {ex.Message}");
			}
		}
	}
}
