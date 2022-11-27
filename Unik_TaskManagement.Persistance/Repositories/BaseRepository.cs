using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Unik_TaskManagement.Application.Contracts.Persistence;
using Unik_TaskManagement.Persistence.Data;

namespace Unik_TaskManagement.Persistence.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        private readonly ApplicationDbContext _db;
        internal DbSet<T> dbSet;

        public BaseRepository ( ApplicationDbContext db )
        {
            _db = db;
            this.dbSet = db.Set<T>( );
        }

        public async Task CreateAsync ( T entity )
        {
            await dbSet.AddAsync(entity);
        }

        public async Task<List<T>> GetAllDataAsync ( Expression<Func<T, bool>>? filter = null, string? includeProperties = null )
        {
            IQueryable<T> query = dbSet;
            if (filter != null)
            {
                query = query.Where(filter);
            }
            if (includeProperties != null)
            {
                //abc,,xyz -> abc xyz
                foreach (var includeProperty in includeProperties.Split(
                    new char[ ] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(includeProperty);
                }
            }

            return await query.ToListAsync( );
        }

        public async Task<T> GetByIdAsync ( Expression<Func<T, bool>>? filter = null, string? includeProperties = null )
        {
            IQueryable<T> query = dbSet;
            if (filter != null)
            {
                query = query.Where(filter);
            }
            if (includeProperties != null)
            {
                //abc,,xyz -> abc xyz
                foreach (var includeProperty in includeProperties.Split(
                    new char[ ] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(includeProperty);
                }
            }
            return await query.FirstOrDefaultAsync( );
        }

        public void Delete ( T entity )
        {
            dbSet.Remove(entity);
        }
    }
}
