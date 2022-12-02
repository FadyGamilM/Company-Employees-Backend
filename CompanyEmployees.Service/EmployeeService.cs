using CompanyEmployees.Contracts;
using CompanyEmployees.Service.Contracts;

namespace CompanyEmployees.Service;

internal class EmployeeService : IEmployeeService
{
    private readonly IRepositoryManager _repositoryManager;

    public EmployeeService(IRepositoryManager repositoryManager) => _repositoryManager = repositoryManager;
}
