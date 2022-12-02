using CompanyEmployees.Contracts;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace CompanyEmployees.Repository;
public class RepositoryBase<T> : IRepositoryBase<T> where T : class
{
    // we need to utilize the DbContext using the DI pattern to access the DB
    private readonly RepositoryContext _context;
    public RepositoryBase(RepositoryContext context) => this._context = context;

    public void Create(T entitiy) =>  _context.Set<T>().Add(entitiy);

    public void Delete(T entitiy) =>  _context.Set<T>().Remove(entitiy);

    public IEnumerable<T> GetAll(bool ChangeTracking) =>
        // if we sent the change tracking = True, ==> we set the tracker of Ef Core
        ChangeTracking ?  
            _context.Set<T>().AsTracking().ToList()
            :  
            _context.Set<T>().AsNoTracking().ToList();

    public IEnumerable<T> GetByCondition(bool ChangeTracking, Expression<Func<T, bool>> ConditionExpression) =>
        ChangeTracking ?
            _context.Set<T>()
                         .Where(ConditionExpression)
                         .AsTracking()
            :
            _context.Set<T>()
                         .Where(ConditionExpression)
                         .AsNoTracking();

    public T GetById(Guid id) => _context.Set<T>().Find(id);

    public void Update(T entitiy) => _context.Set<T>().Update(entitiy);
}
