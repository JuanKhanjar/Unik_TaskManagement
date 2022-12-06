using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unik_TaskManagement.Application.Features.Stamdata.Kunder.KundersDtos;
using Unik_TaskManagement.Application.Features.Stamdata.Projects.Queries.GetAll;

namespace Unik_TaskManagement.Application.Features.Stamdata.Projects.Queries.GetDetails
{
	public class GetProjectDetailQuery: IRequest<ProjectDetailVieModel>
	{
		public Guid ProjectId { get; set; }
	}
}
