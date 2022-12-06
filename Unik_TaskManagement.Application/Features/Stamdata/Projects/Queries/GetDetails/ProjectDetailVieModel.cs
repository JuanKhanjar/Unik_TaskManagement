using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unik_TaskManagement.Domain;

namespace Unik_TaskManagement.Application.Features.Stamdata.Projects.Queries.GetDetails
{
	public class ProjectDetailVieModel
	{

		public Guid ProjectId { get; set; }

		[Required, MaxLength(100, ErrorMessage = "Project Name Sohuld Be In The Range 3 -100 ")]
		[MinLength(3)]
		public string ProjectTitle { get; set; }

		[Required, MaxLength(100, ErrorMessage = "Project Location Sohuld Be In The Range 3 -100 ")]
		[MinLength(3)]
		public string Location { get; set; }
		public Guid KundeId { get; set; }
		public Kunde Kunde { get; set; }
		
	}
}
