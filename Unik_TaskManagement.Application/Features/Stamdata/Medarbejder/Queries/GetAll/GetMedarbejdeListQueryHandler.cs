using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unik_TaskManagement.Application.Contracts.Persistence;

namespace Unik_TaskManagement.Application.Features.Stamdata.Medarbejder.Queries.GetAll
{
	public class GetMedarbejdeListQueryHandler : IRequestHandler<GetMedarbejdeListQuery, List<MedarbejderVM>>
	{
		private readonly IUnitOfWork _unitOfwork;
		private readonly IMapper _mapper;

		public GetMedarbejdeListQueryHandler ( IUnitOfWork unitOfwork, IMapper mapper )
		{
			this._unitOfwork = unitOfwork;
			this._mapper = mapper;
		}
		public async Task<List<MedarbejderVM>> Handle ( GetMedarbejdeListQuery request, CancellationToken cancellationToken )
		{
			var allMedarbejdeFraDb = await _unitOfwork.Medarbejde.GetAllDataAsync( );
			return _mapper.Map<List<MedarbejderVM>>(allMedarbejdeFraDb);
		}
	}
}
