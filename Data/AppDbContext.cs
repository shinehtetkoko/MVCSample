using Microsoft.EntityFrameworkCore;
using MVCSample.Data.Entities;

namespace MVCSample.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options){}

        public DbSet<Employee> Employees { get; set; }
    }
}
