using CompanyEmployees.Contracts;
using CompanyEmployees.Service.Contracts;

namespace CompanyEmployees.Service;

internal sealed class CompanyService : ICompanyService
{
    private readonly IRepositoryManager _repositoryManager;

    public CompanyService(IRepositoryManager repositoryManager) => _repositoryManager = repositoryManager;
}
