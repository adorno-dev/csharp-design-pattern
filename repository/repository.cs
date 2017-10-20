using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly DbContext _context;

        public Repository(DbContext context) => _context = context;

        public void Add(T entity) => _context.Set<T>().Add(entity);

        public async Task AddAsync(T entity, CancellationToken cancellationToken = default(CancellationToken))
        => await _context.AddAsync(entity, cancellationToken);

        public void AddRange(IEnumerable<T> entities) => _context.Set<T>().AddRange(entities);

        public async Task AddRangeAsync(IEnumerable<T> entities, CancellationToken cancellationToken = default(CancellationToken)) 
        => await _context.AddRangeAsync(entities, cancellationToken);

        public IEnumerable<T> All() => _context.Set<T>().ToList();

        public async Task<IEnumerable<T>> AllSync(CancellationToken cancellationToken = default(CancellationToken))
        => await _context.Set<T>().ToListAsync(cancellationToken);

        public IEnumerable<T> Find(Expression<Func<T, bool>> predicate) => _context.Set<T>().Where(predicate);

        public async Task<IEnumerable<T>> FindAsync(Expression<Func<T, bool>> predicate, CancellationToken cancellationToken = default(CancellationToken))
        => await _context.Set<T>().Where(predicate).ToListAsync(cancellationToken);

        public T Get(params object[] ids) => _context.Set<T>().Find(ids);

        public async Task<T> GetAsync(object[] ids, CancellationToken cancellationToken = default(CancellationToken))
        => await _context.Set<T>().FindAsync(ids, cancellationToken);

        public void Remove(T entity) => _context.Set<T>().Remove(entity);

        public void RemoveRange(IEnumerable<T> entities) => _context.Set<T>().RemoveRange(entities);

        public T SingleOrDefault(Expression<Func<T, bool>> predicate) => _context.Set<T>().SingleOrDefault(predicate);

        public async Task<T> SingleOrDefaultAsync(Expression<Func<T, bool>> predicate, CancellationToken cancellationToken = default(CancellationToken))
        => await _context.Set<T>().SingleOrDefaultAsync(predicate, cancellationToken);
    }
}
