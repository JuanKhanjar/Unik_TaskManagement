using System.Linq.Expressions;
using Unik_TaskManagement.web.Models.OpgaverModels;
using Unik_TaskManagement.web.Models.OpgaverModels;

namespace Unik_TaskManagement.web.Services.IServices
{
	public interface IOpgaverService
	{
		//GET ALL, GET By ID FIRST OR DEFAULT, ADD, REMOVE, REMOVERANGE
		Task<IEnumerable<OpgaverDto>> GetAllDataAsync ( Expression<Func<OpgaverDto, bool>>? filter = null );
		//Task<KunderDto> GetByIdAsync ( Guid Id, Expression<Func<KunderDto, bool>>? filter = null );
		//Task CreateAsync ( CreateKundeDto entity );
		//Task UpdateAsync ( Guid Id, UpdateKundeDto entity );
		//Task Delete ( Guid Id );
	}
}
