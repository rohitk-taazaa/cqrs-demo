using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Core.Data
{
    public interface IRepository<T> where T : Entity
    {
        Task AddAsync(T entity);
        IQueryable<T> Table { get; }
        Task<T> GetByIdAsync(Guid id);
        Task SaveAsync(T entity);
        Task SaveAllAsync(IEnumerable<T> entities);
        Task DeleteAsync(T entity);
        Task SaveChangesAsync(T entity);

    }
}
