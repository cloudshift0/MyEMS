using Microsoft.EntityFrameworkCore;

namespace EMS.DataAccess.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<User> Employees { get; set; }
    }
}