using Microsoft.EntityFrameworkCore;
using ServerSideDev.Web.Data.Entities;

namespace ServerSideDev.Web.Data
{
	public class DataContext : DbContext
	{
		public DataContext(DbContextOptions<DataContext> options) : base(options) 
		{ 
		}

		public DbSet<Country> countries { get; set; }
	}
}
