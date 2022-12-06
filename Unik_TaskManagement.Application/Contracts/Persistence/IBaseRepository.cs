using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Unik_TaskManagement.Application.Contracts.Persistence
{
    public interface IBaseRepository<T> where T : class
    {
        //GET ALL, GET By ID FIRST OR DEFAULT, ADD, REMOVE, REMOVERANGE
        Task<IEnumerable<T>> GetAllDataAsync ( Expression<Func<T, bool>>? filter = null, string[]? includeProperties = null );
        Task<T> GetByIdAsync ( Expression<Func<T, bool>> filter , string? includeProperties = null );
        Task CreateAsync ( T entity );
        void Delete ( T entity );
    }
}

