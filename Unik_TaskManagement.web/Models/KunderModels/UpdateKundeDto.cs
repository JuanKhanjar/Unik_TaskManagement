namespace Unik_TaskManagement.web.Models.KunderModels
{
    public class UpdateKundeDto
    {
        public Guid KundeId { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
    }
}
