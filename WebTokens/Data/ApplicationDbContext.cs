using Microsoft.EntityFrameworkCore;
using WebTokens.Model;

namespace WebTokens.Data
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<User> Users { get; set; }
    }
}