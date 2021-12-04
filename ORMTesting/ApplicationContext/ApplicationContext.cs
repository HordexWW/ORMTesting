using Microsoft.EntityFrameworkCore;
using ORMTesting.model;

namespace ORMTesting
{
    public class ApplicationContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public ApplicationContext()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=ormtesting;Username=postgres;Password=1234");
        }
    }
}