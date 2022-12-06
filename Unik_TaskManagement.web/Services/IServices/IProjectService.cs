using System.Linq.Expressions;
using Unik_TaskManagement.web.Models.ProjectsModels;

namespace Unik_TaskManagement.web.Services.IServices
{
	public interface IProjectService
	{
		//GET ALL, GET By ID FIRST OR DEFAULT, ADD, REMOVE, REMOVERANGE
		Task<IEnumerable<ProjectDto>> GetAllDataAsync ( Expression<Func<ProjectDto, bool>>? filter = null );
		//Task<KunderDto> GetByIdAsync ( Guid Id, Expression<Func<KunderDto, bool>>? filter = null );
		//Task CreateAsync ( CreateKundeDto entity );
		//Task UpdateAsync ( Guid Id, UpdateKundeDto entity );
		//Task Delete ( Guid Id );
	}
}
