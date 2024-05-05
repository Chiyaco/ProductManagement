using ProductManagement.Domain.Common;
using System.Linq.Expressions;

namespace ProductManagement.Domain
{
    public interface IRepository<T> where T : BaseEntity
    {
        Task<IEnumerable<T>> GetAll();

        Task<IEnumerable<T>> GetAll(Expression<Func<T, bool>> where);

        Task<T> Get(int id);

        Task Insert(T entity);

        Task Update(T entity);

        Task Delete(T entity);

        Task Commit();
    }
}
