using CSharpAdvancedProjectDAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace CSharpAdvancedProjectDAL.Context
{
    public class EmployeeContext : DbContext , IEmployeeContext
    {
        public EmployeeContext(DbContextOptions<EmployeeContext> options)
            : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Position>()
                .HasIndex(u => u.Name)
                .IsUnique();

            base.OnModelCreating(builder);
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Position> Positions { get; set; }
    }
}
