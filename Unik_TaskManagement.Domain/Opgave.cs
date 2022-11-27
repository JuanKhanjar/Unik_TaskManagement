using System.ComponentModel.DataAnnotations;

namespace Unik_TaskManagement.Domain
{
    public class Opgave
    {
        [Key]
        public Guid OpgaveId { get; set; }

        [Required, MaxLength(100, ErrorMessage = "Titellængden bør maksimalt være 100 tegn")]
        [MinLength(10, ErrorMessage = "Titellængden bør mindst være 10 tegn")]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }

    }
}
