using Domain.Contracts;
using Persistance.Data.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistance.Repositores
{
    internal class GenericRepository<TEntity, TKey>(StoreDbContext _dbcontext) : IGenericRepository<TEntity, TKey>
        where TEntity : BaseEntity<TKey>
    {
        public void Add(TEntity entity) => _dbcontext.Set<TEntity>().Add(entity);


        public void Delete(TEntity entity) => _dbcontext.Set<TEntity>().Remove(entity);

        public async Task<IEnumerable<TEntity>> GetAllAsync()
        => await _dbcontext.Set<TEntity>().ToListAsync();

        public async Task<TEntity> GetAsync(TKey key)
            => await _dbcontext.Set<TEntity>().FindAsync(key);


        public void Update(TEntity entity) => _dbcontext.Set<TEntity>().Update(entity);

        
    }
}
