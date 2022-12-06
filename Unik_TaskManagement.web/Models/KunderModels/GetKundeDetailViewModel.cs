namespace Unik_TaskManagement.web.Models.KunderModels
{
    public class GetKundeDetailViewModel
    {
        public Guid KundeId { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public ProjectsDto KundesProject { get; set; }
    }
}
