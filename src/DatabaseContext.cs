using Microsoft.EntityFrameworkCore;

namespace ucmdb_mvc.Models
{
				public class DatabaseContext : DbContext
				{
								protected override void OnConfiguring(DbContextOptionsBuilder options)
												=> options.UseSqlite(@"Data Source="+ Environment.CurrentDirectory + @"\ucmdb.db");

								public DbSet<Machine> Machines { get; set; }

								public DbSet<User> Users { get ; set; }
				}
}
