using CompanyEmployees.Contracts;
using CompanyEmployees.Repository;
using CompanyEmployees.Service;
using CompanyEmployees.Service.Contracts;
using Microsoft.EntityFrameworkCore;

namespace CompanyEmployees.Main.Extensions;

public static class ServicesExtension
{
    public static void ConfigureRepositoryManager(this IServiceCollection services)
    {
        services.AddScoped<IRepositoryManager, RepositoryManager>();
    }

    public static void ConfigureServiceManager (this IServiceCollection services)
    {
        services.AddScoped<IServiceManager, ServiceManager>();
    }

    public static void ConfigureDbContextCreation(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<RepositoryContext>(opts => opts.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
    }
}
