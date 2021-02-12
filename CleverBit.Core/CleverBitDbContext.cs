using Microsoft.EntityFrameworkCore;
namespace CleverBit.Core
{
    public class CleverBitDbContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=CleverBit;Integrated Security=False;Persist Security Info=False;User ID=sa;Password=1");
        }
        public DbSet<Employee> Employees { get; set; }

        public DbSet<Region> Regions { get; set; }
    }
}
