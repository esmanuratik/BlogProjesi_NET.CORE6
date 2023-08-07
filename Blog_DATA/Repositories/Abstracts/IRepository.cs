using Blog_CORE.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Blog_DATA.Repositories.Abstracts
{
    public interface IRepository<T> where T : class, IEntityBase, new()
    {
        Task AddAsync(T entity);
        Task<List<T>> GetAllAsync(Expression<Func<T, bool>> predicate = null, params Expression<Func<T, object>>[] includeProporties);
        Task<T> GetAsync(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includeProporties);
        Task <T> GetByGuidAsync(Guid id);
        Task <T> UpdateAsync (T entity);
        Task DeleteAsync (T entity);
        Task<bool> AnyAsync(Expression <Func<T,bool>> predicate);//hiç veri var mı kontrolünü sağlamak için.
        Task<int> CountAsync(Expression<Func<T,bool>> predicate=null);// Kaç tane veri girişii var bunu kontrol etmek için.

    }
}
