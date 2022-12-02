using CompanyEmployees.Contracts;

namespace CompanyEmployees.Repository;

public class RepositoryManager : IRepositoryManager
{
    // private fields for the repositories "with Lazy initialization feature"
    private readonly Lazy<IEmployeeRepository> _employeeRepository;
    private readonly Lazy<ICompanyRepository> _companyRepository;
    // inject the DB context for the save changes method
    private readonly RepositoryContext _context;

    // Dependency Injection for UOW
    public RepositoryManager(RepositoryContext context)
    {
        _context = context;
        _employeeRepository = new Lazy<IEmployeeRepository>( () =>  new EmployeeRepository(this._context) );
        _companyRepository = new Lazy<ICompanyRepository>(() => new CompanyRepository(this._context) );
    }

    // ==> public fields
    public IEmployeeRepository EmployeeRepo => _employeeRepository.Value;
    public ICompanyRepository CompanyRepo => _companyRepository.Value;

    public void SaveChanges()
    {
        this._context.SaveChanges();
    }
}
