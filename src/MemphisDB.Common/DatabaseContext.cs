using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Sqlite;

namespace MemphisDB.Common
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext() { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source=" + Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + @"\memphis.db");
        }

        public DbSet<Machine> Machines { get; set; }
        public DbSet<User> Users { get; set; }
    }
}