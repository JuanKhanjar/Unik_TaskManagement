using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unik_TaskManagement.Application.Contracts.Persistence;
using Unik_TaskManagement.Application.Features.Stamdata.Kunder.KundersDtos;

namespace Unik_TaskManagement.Application.Features.Stamdata.Kunder.Queries.GetDetails
{
    public class GetKundeDetailQueryHandler : IRequestHandler<GetKundeDetailQuery, KundeViewModel>
    {
        private readonly IUnitOfWork _unitOfwork;
        private readonly IMapper _mapper;

        public GetKundeDetailQueryHandler ( IUnitOfWork unitOfwork, IMapper mapper )
        {
            this._unitOfwork = unitOfwork;
            this._mapper = mapper;
        }

        public async Task<KundeViewModel> Handle ( GetKundeDetailQuery request, CancellationToken cancellationToken )
        {
            //Get from Db
            var Kunde = await _unitOfwork.Kunde.GetByIdAsync(k=>k.KundeId==request.KundeId);
            //Mapping Properties
            return _mapper.Map<KundeViewModel>(Kunde);
        }
    }
}
