using Microsoft.EntityFrameworkCore;

namespace bogus_API.Data
{
    public class MakeCartDbContext : DbContext
    {
        public MakeCartDbContext(DbContextOptions options) : base(options)
        {
            
        }
    }
}
