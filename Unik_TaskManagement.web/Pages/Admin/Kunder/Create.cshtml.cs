using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Unik_TaskManagement.web.Models.KunderModels;
using Unik_TaskManagement.web.Services.IServices;

namespace Unik_TaskManagement.web.Pages.Admin.Kunder
{
	public class CreateModel : PageModel
	{
		private readonly IKunderService _baseService;
		public CreateModel ( IKunderService baseService )
		{
			this._baseService = baseService;
		}
		[BindProperty]
		public CreateKundeDto Kunde { get; set; }
		public void OnGet ( )
		{
		}


		public async Task OnPost ( )
		{
			if (ModelState.IsValid)
			{
				await _baseService.CreateAsync(Kunde);
				TempData["success"] = "Kunden created successfully";
				//return RedirectToPage("Index");
			}
		}
	}
}
