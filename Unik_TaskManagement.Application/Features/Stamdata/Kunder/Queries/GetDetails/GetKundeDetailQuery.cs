using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unik_TaskManagement.Application.Features.Stamdata.Kunder.Queries.GetDetails
{
    public class GetKundeDetailQuery: IRequest<GetKundeDetailViewModel>
    {
        public Guid KundeId { get; set; }
    }
}
