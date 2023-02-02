using Microsoft.EntityFrameworkCore;
using WebApplication2.Models;

namespace WebApplication2.DAY
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext>options):base(options)
        {
                
        }
        public DbSet<Service> Services { get; set; }
    }
}
