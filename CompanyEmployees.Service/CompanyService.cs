using CompanyEmployees.Contracts;
using CompanyEmployees.Service.Contracts;
using CompanyEmployees.Entities.Models;

namespace CompanyEmployees.Service;

internal sealed class CompanyService : ICompanyService
{
    private readonly IRepositoryManager _repositoryManager;

    public CompanyService(IRepositoryManager repositoryManager) => _repositoryManager = repositoryManager;

    // method to return all companies [utlize the CompanyRepository method]
    public IEnumerable<Company> GetAllCompanies()
    {
        return _repositoryManager.CompanyRepo.GetAllCompanies(false);
    }
}
