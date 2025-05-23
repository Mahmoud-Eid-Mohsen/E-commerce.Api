using Domain.Contracts;
using Persistance.Data.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistance.Repositores
{
    public class UintOfWork(StoreDbContext _context) : IUnitofWork
    {
        private readonly Dictionary<string, object> _repositores = [];
        public IGenericRepository<TEntity, TKey> GetRepository<TEntity, TKey>() where TEntity : BaseEntity<TKey>
        {
            var typename= typeof(TEntity).Name;
            if (_repositores.ContainsKey(typename))
                return (IGenericRepository<TEntity, TKey>)_repositores[typename];

            var repo = new GenericRepository<TEntity, TKey>(_context);
            _repositores[typename] = repo;
            return repo;



        }

        public Task<int> SaveChangesAysnc()=>_context.SaveChangesAsync();
      
    }
}
