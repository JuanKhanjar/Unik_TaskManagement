using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unik_TaskManagement.Application.Features.Stamdata.Opgaver.Queries.GetAll
{
	public class GetOpgaverListQuery:IRequest<List<OpgaverVM>>
	{
	}
}
