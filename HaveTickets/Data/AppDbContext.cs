
using Microsoft.EntityFrameworkCore;

namespace HaveTickets.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { 
        
        }
    }
}
