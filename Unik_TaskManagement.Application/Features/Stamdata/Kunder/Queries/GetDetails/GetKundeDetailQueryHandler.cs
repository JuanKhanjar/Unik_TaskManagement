using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unik_TaskManagement.Application.Contracts.Persistence;

namespace Unik_TaskManagement.Application.Features.Stamdata.Kunder.Queries.GetDetails
{
    public class GetKundeDetailQueryHandler : IRequestHandler<GetKundeDetailQuery, GetKundeDetailViewModel>
    {
        private readonly IUnitOfWork _unitOfwork;
        private readonly IMapper _mapper;

        public GetKundeDetailQueryHandler ( IUnitOfWork unitOfwork, IMapper mapper )
        {
            this._unitOfwork = unitOfwork;
            this._mapper = mapper;
        }

        public async Task<GetKundeDetailViewModel> Handle ( GetKundeDetailQuery request, CancellationToken cancellationToken )
        {
            var Kunde = await _unitOfwork.Kunde.GetByIdAsync(k=>k.KundeId==request.KundeId);

            return _mapper.Map<GetKundeDetailViewModel>(Kunde);
        }
    }
}
