using CompanyEmployees.Entities.Models;
using CompanyEmployees.Contracts;

namespace CompanyEmployees.Repository;

internal class EmployeeRepository : RepositoryBase<Employee>, IEmployeeRepository
{
    public EmployeeRepository(RepositoryContext context) : base(context) { }
}
