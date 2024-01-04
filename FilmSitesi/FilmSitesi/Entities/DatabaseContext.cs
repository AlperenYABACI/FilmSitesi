using Microsoft.EntityFrameworkCore;

namespace FilmSitesi.Entities
{
	public class DatabaseContext : DbContext
	{
		public DatabaseContext(DbContextOptions options) : base(options)
		{
		}

		public DbSet<User> Users { get; set; }

		public DbSet<Yorumlar> Yorumlar { get; set;}
	}
}
