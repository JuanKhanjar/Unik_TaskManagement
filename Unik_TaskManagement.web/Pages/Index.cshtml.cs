using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Unik_TaskManagement.web.Models.KunderModels;
using Unik_TaskManagement.web.Services.IServices;

namespace Unik_TaskManagement.web.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IKunderService _baseService;

        public IndexModel ( ILogger<IndexModel> logger ,IKunderService baseKunderService)
        {
            _logger = logger;
            _baseService = baseKunderService;
        }
        [BindProperty]
        public IEnumerable<KunderDto> kunder { get; set; }
        public async Task OnGet ( )
        {
            kunder=await _baseService.GetAllDataAsync();
        }
    }
}