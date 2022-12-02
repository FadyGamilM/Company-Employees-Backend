using CompanyEmployees.Contracts;
using CompanyEmployees.Repository;


namespace CompanyEmployees.API.Extensions;

public static class ServicesExtension
{
    public static void ConfigureRepositoryManager(this IServiceCollection services)
    {
        services.AddScoped<IRepositoryManager, RepositoryManager>();
    }
}
