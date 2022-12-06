using System.Net.Http;
using Unik_TaskManagement.web.Models.BookingModels;
using Unik_TaskManagement.web.Services.IServices;

namespace Unik_TaskManagement.web.Services
{
	public class BookingService : IBookingService
	{
		private readonly HttpClient _httpClient;
		public BookingService ( HttpClient httpClient )
		{
			_httpClient = httpClient;
		}
		public async Task CreateAsync ( CreateBookingDto CreateBookingDto )
		{
			var response = await _httpClient.PostAsJsonAsync("api/Booking", CreateBookingDto);

			if (response.IsSuccessStatusCode)
				return;

			var message = await response.Content.ReadAsStringAsync( );
			throw new Exception(message);
		}
	}
}
