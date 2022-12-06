using System.Linq.Expressions;
using Unik_TaskManagement.web.Models.MedarbejdeModels;
using Unik_TaskManagement.web.Services.IServices;

namespace Unik_TaskManagement.web.Services
{
	public class MedarbejderService : IMedarbejderService
	{
		private readonly HttpClient _httpClient;

		public MedarbejderService ( HttpClient httpClient )
		{
			_httpClient = httpClient;
		}
		public async Task<IEnumerable<MedarbejderDto>> GetAllDataAsync ( Expression<Func<MedarbejderDto, bool>>? filter = null )
		{
			return await _httpClient.GetFromJsonAsync<IEnumerable<MedarbejderDto>>($"api/Medarbejder");
		}
	}
}
