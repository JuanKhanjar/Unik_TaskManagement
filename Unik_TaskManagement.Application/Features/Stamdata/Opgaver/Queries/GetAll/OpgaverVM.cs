using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unik_TaskManagement.Application.Features.Stamdata.Opgaver.Queries.GetAll
{
	public class OpgaverVM
	{
		public Guid OpgaveId { get; set; }

		[Required, MaxLength(100, ErrorMessage = "Titellængden bør maksimalt være 100 tegn")]
		[MinLength(10, ErrorMessage = "Titellængden bør mindst være 10 tegn")]
		public string Title { get; set; }

		[Required]
		public string Description { get; set; }
	}
}
