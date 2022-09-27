using Microsoft.EntityFrameworkCore;
using min.api.Models;

namespace min.api.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }

        public DbSet<Command> Commands => Set<Command>();

    }
}