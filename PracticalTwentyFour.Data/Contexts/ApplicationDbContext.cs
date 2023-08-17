using Microsoft.EntityFrameworkCore;
using PracticalTwentyFour.Data.Entities;

namespace PracticalTwentyFour.Data.Contexts
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.SeedEmployees();
            modelBuilder.SeedDepartments();
        }
    }
}
