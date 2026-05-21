using BetterQueue.Models;
using Microsoft.EntityFrameworkCore;

namespace BetterQueue.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Line> Lines { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Desk> Desks { get; set; }
        public DbSet<UserLocationAccess> UserLocationAccesses { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>().ToTable("user");
            modelBuilder.Entity<Role>().ToTable("role");
            modelBuilder.Entity<Location>().ToTable("location");
            modelBuilder.Entity<Line>().ToTable("line");
            modelBuilder.Entity<Customer>().ToTable("customer");
            modelBuilder.Entity<Desk>().ToTable("desk");
            modelBuilder.Entity<UserLocationAccess>().ToTable("userlocationaccess");
        }
    }
}
