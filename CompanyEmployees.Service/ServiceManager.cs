

using CompanyEmployees.Contracts;
using CompanyEmployees.Service.Contracts;

namespace CompanyEmployees.Service;

public class ServiceManager : IServiceManager
{
    // private fields
    private readonly Lazy<IEmployeeService> _employeeService;
    private readonly Lazy<ICompanyService> _companyService;
    private readonly IRepositoryManager _repositoryManager;

    // constructor 
    public ServiceManager( IRepositoryManager repositoryManager )
    {
        _repositoryManager = repositoryManager;
        // => initialize the private services
        _employeeService = new Lazy<IEmployeeService>(new EmployeeService(_repositoryManager));
        _companyService = new Lazy<ICompanyService>(new CompanyService(_repositoryManager));
    }

    // their public version after initializing the private ones
    public IEmployeeService EmployeeService => _employeeService.Value;
    public ICompanyService CompanyService => _companyService.Value;
}
