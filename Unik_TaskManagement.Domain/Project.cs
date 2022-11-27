using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unik_TaskManagement.Domain
{
    public class Project
    {
        [Key]
        public Guid ProjectId { get; set; }

        [Required,MaxLength(100,ErrorMessage ="Project Name Sohuld Be In The Range 3 -100 ")]
        public string ProjectTitle { get; set; }
        public bool IsActive { get; set; } = true;
        public Guid KundeId { get; set; }

        [ForeignKey("KundeId")]
        public Kunde Kunde { get; set; }
        public IReadOnlyCollection<Opgave>? Opgaver { get; set; }

    }
}
