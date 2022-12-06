using AutoMapper.Internal;
using Newtonsoft.Json;
using System.Linq.Expressions;
using System.Net.Http;
using System.Text;
using Unik_TaskManagement.web.Models;
using Unik_TaskManagement.web.Models.KunderModels;
using Unik_TaskManagement.web.Services.IServices;

namespace Unik_TaskManagement.web.Services
{
    public class KunderService : IKunderService
    {
        private readonly HttpClient _httpClient;

        public KunderService ( HttpClient httpClient )
        {
            _httpClient = httpClient;
        }
        public async Task CreateAsync ( CreateKundeDto entity )
        {
			HttpResponseMessage response = await _httpClient.PostAsJsonAsync("api/Kunder", entity);

            if (response.IsSuccessStatusCode)
            {
				string result = await response.Content.ReadAsStringAsync( );
				Console.WriteLine("Result: {0}", result);
            }
            else
            {
				Console.WriteLine(string.Format("The request failed with status code: {0}", response.StatusCode));

				// Print the headers - they include the requert ID and the timestamp, which are useful for debugging the failure
				Console.WriteLine(response.Headers.ToString( ));

				string responseContent = await response.Content.ReadAsStringAsync( );
				Console.WriteLine(responseContent);
			}
               

			//var message = await response.Content.ReadAsStringAsync( );
   //         throw new Exception(message);
        }

        public Task Delete ( Guid Id )
        {
            throw new NotImplementedException( );
        }

        public async Task<IEnumerable<KunderDto>> GetAllDataAsync ( Expression<Func<KunderDto, bool>>? filter = null )
        {
            //if (filter!=null)
            //{
            //    return await _httpClient.GetFromJsonAsync<IEnumerable<KunderDto>>($"api/Kunder/{filter}");
            //}
            return await _httpClient.GetFromJsonAsync<IEnumerable<KunderDto>>($"api/Kunder");
        }

        public Task<KunderDto> GetByIdAsync ( Guid Id, Expression<Func<KunderDto, bool>>? filter = null )
        {
            throw new NotImplementedException( );
        }

        public Task UpdateAsync ( Guid Id, UpdateKundeDto entity )
        {
            throw new NotImplementedException( );
        }
    }
}
