using Microsoft.EntityFrameworkCore;
using SIM_SharedLib.Models;

namespace SIM_WebServer
{
	public class ApplicationDbContext : DbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
			: base(options)
		{

		}

		public DbSet<Company> Companies { get; set; }
		public DbSet<Product> Products { get; set; }
		public DbSet<Bin> Bins { get; set; }
		public DbSet<Cart> Carts { get; set; }
		public DbSet<Warehouse> Warehouses { get; set; }
	}
}
