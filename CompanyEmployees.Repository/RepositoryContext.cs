using Microsoft.EntityFrameworkCore;
using CompanyEmployees.Entities.Models;
using CompanyEmployees.Repository.Configurations;

namespace CompanyEmployees.Repository;

public class RepositoryContext : DbContext
{
    public RepositoryContext(DbContextOptions<RepositoryContext> opts)
        : base(opts)
    { }

    protected override void OnModelCreating (ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new CompanyConfiguration());
        modelBuilder.ApplyConfiguration(new EmployeeConfiguration());
    }

    public DbSet<Employee>? Employees { get; set; }
    public DbSet<Company>? Companies { get; set; }
}
