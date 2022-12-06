using System.Linq.Expressions;
using Unik_TaskManagement.web.Models.OpgaverModels;
using Unik_TaskManagement.web.Services.IServices;

namespace Unik_TaskManagement.web.Services
{
	public class OpgaverService : IOpgaverService
	{
		private readonly HttpClient _httpClient;

		public OpgaverService ( HttpClient httpClient )
		{
			_httpClient = httpClient;
		}
		public async Task<IEnumerable<OpgaverDto>> GetAllDataAsync ( Expression<Func<OpgaverDto, bool>>? filter = null )
		{
			return await _httpClient.GetFromJsonAsync<IEnumerable<OpgaverDto>>("api/Opgaver");
		}
	}
}
