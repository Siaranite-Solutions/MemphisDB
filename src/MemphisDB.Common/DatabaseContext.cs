using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Sqlite;
using System.IO;

namespace MemphisDB.Common
{
    public class DatabaseContext : DbContext
    {
        public string DbPath { get; }

        public DatabaseContext() 
        {
            var dir = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(dir);
            DbPath = Path.Join(path, "memphis.db");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source=" + Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + @"\memphis.db");
        }

        public DbSet<Machine> Machines { get; set; }
        public DbSet<User> Users { get; set; }
    }
}