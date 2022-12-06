using System.Linq.Expressions;
using Unik_TaskManagement.web.Models.MedarbejdeModels;

namespace Unik_TaskManagement.web.Services.IServices
{
	public interface IMedarbejderService
	{
		//GET ALL, GET By ID FIRST OR DEFAULT, ADD, REMOVE, REMOVERANGE
		Task<IEnumerable<MedarbejderDto>> GetAllDataAsync ( Expression<Func<MedarbejderDto, bool>>? filter = null );
		//Task<KunderDto> GetByIdAsync ( Guid Id, Expression<Func<KunderDto, bool>>? filter = null );
		//Task CreateAsync ( CreateKundeDto entity );
		//Task UpdateAsync ( Guid Id, UpdateKundeDto entity );
		//Task Delete ( Guid Id );
	}
}
