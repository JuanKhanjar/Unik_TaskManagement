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
		[MinLength(3)]
		public string ProjectTitle { get; set; }

		[Required, MaxLength(100, ErrorMessage = "Project Location Sohuld Be In The Range 3 -100 ")]
		[MinLength(3)]
		public string  Location { get; set; }

        public Guid KundeId { get; set; }
        [ForeignKey("KundeId")]
        public Kunde Kunde { get; set; }

    }
}
