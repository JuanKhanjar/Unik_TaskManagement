using System.Linq.Expressions;
using Unik_TaskManagement.web.Models.MedarbejdeModels;
using Unik_TaskManagement.web.Models.ProjectsModels;
using Unik_TaskManagement.web.Services.IServices;

namespace Unik_TaskManagement.web.Services
{
	public class ProjectService : IProjectService
	{
		private readonly HttpClient _httpClient;

		public ProjectService ( HttpClient httpClient )
		{
			_httpClient = httpClient;
		}
		public async Task<IEnumerable<ProjectDto>> GetAllDataAsync ( Expression<Func<ProjectDto, bool>>? filter = null )
		{
			return await _httpClient.GetFromJsonAsync<IEnumerable<ProjectDto>>($"api/Project");
		}
	}
}
