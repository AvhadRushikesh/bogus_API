using bogus_API.Models;
using Microsoft.EntityFrameworkCore;

namespace bogus_API.Data
{
    public class MakeCartDbContext : DbContext
    {
        public MakeCartDbContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Order> Orders { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}
