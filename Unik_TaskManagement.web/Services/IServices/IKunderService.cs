using System.Linq.Expressions;
using Unik_TaskManagement.web.Models.KunderModels;

namespace Unik_TaskManagement.web.Services.IServices
{
    public interface IKunderService
    {
        //GET ALL, GET By ID FIRST OR DEFAULT, ADD, REMOVE, REMOVERANGE
        Task<IEnumerable<KunderDto>> GetAllDataAsync ( Expression<Func<KunderDto, bool>>? filter = null );
        Task<KunderDto> GetByIdAsync (Guid Id, Expression<Func<KunderDto, bool>>? filter = null );
        Task CreateAsync ( CreateKundeDto entity );
        Task UpdateAsync (Guid Id, UpdateKundeDto entity );
        Task Delete ( Guid Id );
    }
}
