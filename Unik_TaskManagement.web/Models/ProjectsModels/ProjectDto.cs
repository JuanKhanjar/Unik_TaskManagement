using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Unik_TaskManagement.web.Models.ProjectsModels
{
	public class ProjectDto
	{

		public Guid ProjectId { get; set; }

		[Required, MaxLength(100, ErrorMessage = "Project Name Sohuld Be In The Range 3 -100 ")]
		[MinLength(3)]
		public string ProjectTitle { get; set; }

		[Required, MaxLength(100, ErrorMessage = "Project Location Sohuld Be In The Range 3 -100 ")]
		[MinLength(3)]
		public string Location { get; set; }

		public Guid KundeId { get; set; }
	}
}
