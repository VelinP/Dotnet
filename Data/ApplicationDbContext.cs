using Microsoft.EntityFrameworkCore;
using UserNamespace;

namespace MyApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<User>().HasData(new User { BaseId = 10, BaseUsername = "Admin_Velin", Age = 27 });
            modelBuilder.Entity<User>().HasData(new User { BaseId = 11, BaseUsername = "Velin_backup", Age = 27 });
        }
    }
}
  
