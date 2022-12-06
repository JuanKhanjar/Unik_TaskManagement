using System.Linq.Expressions;
using Unik_TaskManagement.web.Models.BookingModels;

namespace Unik_TaskManagement.web.Services.IServices
{
	public interface IBookingService
	{
		//GET ALL, GET By ID FIRST OR DEFAULT, ADD, REMOVE, REMOVERANGE
		//Task<IEnumerable<op>> GetAllDataAsync ( Expression<Func<GetKunderListViewModel, bool>>? filter = null );
		//Task<KunderDto> GetByIdAsync ( Guid Id, Expression<Func<KunderDto, bool>>? filter = null );
		Task CreateAsync ( CreateBookingDto CreateBookingDto );
		//Task UpdateAsync ( Guid Id, UpdateKundeDto entity );
		//Task Delete ( Guid Id );
	}
}
