using CompanyEmployees.Contracts;
using CompanyEmployees.Entities.Models;

namespace CompanyEmployees.Repository;

internal class CompanyRepository : RepositoryBase<Company>, ICompanyRepository
{
    public CompanyRepository(RepositoryContext context) : base(context) { }

    public IEnumerable<Company> GetAllCompanies(bool trackChanges)
    {
        var companies = GetAll(trackChanges).OrderBy(c => c.Name).ToList();
        return companies;
    }

}
