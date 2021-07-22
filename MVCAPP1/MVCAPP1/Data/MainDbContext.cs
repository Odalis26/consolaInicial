using Microsoft.EntityFrameworkCore;
using MVCAPP1.Entities;

namespace MVCAPP1.Data
{
    public class MainDbContext : DbContext
    {
        public DbSet<Mountain> Mountains { get; set; }
        public MainDbContext(DbContextOptions<MainDbContext> dbContextOptions) : base(dbContextOptions)
        {

        }

        
    }
}
