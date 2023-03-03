using Microsoft.EntityFrameworkCore;

namespace KickOff.Models
{
    public class KickOffDbContext:DbContext
    {
        public KickOffDbContext(DbContextOptions<KickOffDbContext>options):base(options)
        {
            
        }
    }
}
