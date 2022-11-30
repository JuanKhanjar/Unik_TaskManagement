using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unik_TaskManagement.Application.Contracts.Persistence;

namespace Unik_TaskManagement.Application.Features.Stamdata.Kunder.Queries.GetAll
{
    public class GetAllKunderQueryHandler : IRequestHandler<GetAllKunderQuery, List<GetKunderListViewModel>>
    {
        private readonly IUnitOfWork _unitOfwork;
        private readonly IMapper _mapper;

        public GetAllKunderQueryHandler ( IUnitOfWork unitOfwork, IMapper mapper )
        {
            this._unitOfwork = unitOfwork;
            this._mapper = mapper;
        }

        public async Task<List<GetKunderListViewModel>> Handle ( GetAllKunderQuery request, CancellationToken cancellationToken )
        {
            var allKunder = await _unitOfwork.Kunde.GetAllDataAsync();
            return _mapper.Map<List<GetKunderListViewModel>>(allKunder);
        }
    }
}
