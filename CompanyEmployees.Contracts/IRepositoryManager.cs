namespace CompanyEmployees.Contracts;

public interface IRepositoryManager
{
    // all the repositories in our system as read-only methods
    public IEmployeeRepository EmployeeRepo { get; }
    public ICompanyRepository CompanyRepo { get; }

    // the save changes method
    void SaveChanges();
}
