using Microsoft.EntityFrameworkCore;

namespace WebAPI.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Documents> Documents { get; set; }
        public DbSet<Document_Files> Document_Files { get; set; }
        public DbSet<Priorities> Priorities { get; set; }
    }
}
