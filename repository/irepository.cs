using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;

namespace Repository
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> All();

        Task<IEnumerable<T>> AllSync(CancellationToken cancellationToken = default(CancellationToken));

        IEnumerable<T> Find(Expression<Func<T, bool>> predicate);

        Task<IEnumerable<T>> FindAsync(Expression<Func<T, bool>> predicate, CancellationToken cancellationToken = default(CancellationToken));
        
        T Get(params object[] id);

        Task<T> GetAsync(object[] ids, CancellationToken cancellationToken = default(CancellationToken));
        
        T SingleOrDefault(Expression<Func<T, bool>>predicate);

        Task<T> SingleOrDefaultAsync(Expression<Func<T, bool>> predicate, CancellationToken cancellationToken = default(CancellationToken));

        void Add(T entity);

        Task AddAsync(T entity, CancellationToken cancellationToken = default(CancellationToken));
        
        void AddRange(IEnumerable<T> entities);

        Task AddRangeAsync(IEnumerable<T> entities, CancellationToken cancellationToken = default(CancellationToken));

        void Remove(T entity);
        void RemoveRange(IEnumerable<T> entities);
    }
}
