
using System.Linq.Expressions;

namespace CompanyEmployees.Contracts;

public interface IRepositoryBase<T> where T : class
{
    // query the entire table
    IEnumerable<T> GetAll(bool ChangeTracking);
    
    // query the filtered entities only
    IEnumerable<T> GetByCondition(bool ChangeTracking, Expression<Func<T, bool>> ConditionExpression);

    // get an entitiy by its id
    T GetById(Guid id);

    // create an entitiy
    void Create(T entitiy);

    // update an entitiy
    void Update(T entitiy);

    // remove an entitiy
    void Delete(T entitiy);
}
