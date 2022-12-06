using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unik_TaskManagement.Application.Contracts.Persistence;

namespace Unik_TaskManagement.Application.Features.Stamdata.Opgaver.Queries.GetAll
{
	public class GetOpgaverListQueryHandler : IRequestHandler<GetOpgaverListQuery, List<OpgaverVM>>
	{
		private readonly IUnitOfWork _unitOfwork;
		private readonly IMapper _mapper;

		public GetOpgaverListQueryHandler ( IUnitOfWork unitOfwork, IMapper mapper )
		{
			this._unitOfwork = unitOfwork;
			this._mapper = mapper;
		}
		public async Task<List<OpgaverVM>> Handle ( GetOpgaverListQuery request, CancellationToken cancellationToken )
		{
			var opgaveList = await _unitOfwork.Opgave.GetAllDataAsync( );
			return _mapper.Map<List<OpgaverVM>>(opgaveList);
		}
	}
}
