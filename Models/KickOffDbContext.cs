using Microsoft.EntityFrameworkCore;

namespace KickOff.Models
{
    public class KickOffDbContext:DbContext
    {
        public KickOffDbContext(DbContextOptions<KickOffDbContext>options):base(options)
        { 
        }
        public DbSet <Post> Posts { get; set; } 

        public DbSet <Author> Author { get; set; }
    }
}
