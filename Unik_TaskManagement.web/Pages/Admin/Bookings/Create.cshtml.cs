using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Unik_TaskManagement.web.Models.BookingModels;
using Unik_TaskManagement.web.Models.KunderModels;
using Unik_TaskManagement.web.Models.MedarbejdeModels;
using Unik_TaskManagement.web.Models.OpgaverModels;
using Unik_TaskManagement.web.Models.ProjectsModels;
using Unik_TaskManagement.web.Services.IServices;

namespace Unik_TaskManagement.web.Pages.Admin.Bookings
{
	[BindProperties]
	public class CreateModel : PageModel
	{
		private readonly IBookingService _BookService;
		private readonly IKunderService _KundeService;
		private readonly IProjectService _ProjectService;
		private readonly IMedarbejderService _MarbejdeService;
		private readonly IOpgaverService _OpgaveService;

		public CreateModel ( IBookingService bookService, IKunderService KundeService, IProjectService projectService
			, IMedarbejderService medarbejderService, IOpgaverService opgaverService )
		{
			this._BookService = bookService;
			this._KundeService = KundeService;
			this._ProjectService = projectService;
			this._MarbejdeService = medarbejderService;
			this._OpgaveService = opgaverService;
		}
		public CreateBookingDto Booking { get; set; }
		public IEnumerable<OpgaverDto> OpgaverList { get; set; }
		public IEnumerable<KunderDto> KunderList { get; set; }
		public IEnumerable<ProjectDto> ProjectsList { get; set; }
		public IEnumerable<MedarbejderDto> MedarbejderList { get; set; }
		public async Task OnGet ( )
		{
			OpgaverList = await _OpgaveService.GetAllDataAsync( );
			MedarbejderList = await _MarbejdeService.GetAllDataAsync( );
			ProjectsList = await _ProjectService.GetAllDataAsync(null);
			KunderList = await _KundeService.GetAllDataAsync( );
		}


		public async Task OnPost ( )
		{
			if (ModelState.IsValid)
			{
				await _BookService.CreateAsync(Booking);
				TempData["success"] = "Kunden created successfully";
				//return RedirectToPage("Index");
			}
		}
	}
}
